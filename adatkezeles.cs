using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;


namespace fodraszat
{
    public partial class adatkezeles : Form
    {

        string felhnev = default(string);
        string jelszo = default(string);
        int id = default(int);
        string alapertelmezett = default(string);

        string datum_seged = default(string);
        string helyes_formatumu_datum = default(string);
        int szamlalo = default(int);

        ToolTip tip = new ToolTip();

        string[] seged;

        bool hiba = default(bool);
        bool teszt = default(bool);
        string uz = default(string);

        bool modositom_e = false;
        bool torlom_e = false;
        bool multbeli_idopont_e = false;
        bool atnyulik_e_a_masik_napba = default(bool);

        int valto = 0;
        int dat_valto = 0;
        int ido_valto = 0;
        int ido_vege_valto = 0;
        int bejel_valto = 0;
        int tipus_valto = 0;
        int megjegy_valto = 0;
        int aktualis = 0;

        string date;
        string ido1;
        string ido2;
        string nev;
        string tipus;
        string megjegy;

        string aktualis_idopontok;

        int modositas_index;

        //LAPOZÁS________________________________________________________________________________________

        double oldal = 1; // adattördelésnél, oldal számláló változó
        double lapozo = 0; // segéd adat megjelenítéshez -> lekérdezésnél, lapozo * offset
        double offset = 0; // adat tördelésnél számít, lekérdezésben, egy változó, hogy, hanyadik rekordtól jelenítsen meg
        double megjelenitett_adatszamlalo = 0; // lekérdezi a DGV aktuális megjelenített sorainak számát
        double osszes_adat = 0; // a lekérdezett adatok számát mutatja (az adatbázisból)
        double oldalak_szama;
        

        List<int> tipus_az = new List<int>();
        //_______________________________________________Ellenőrzés
        string datum = default(string);
        string idopont = default(string);
        string fodrasz_az = default(string);
        string idopont_vege = default(string);

        //________________________________________________--
        public adatkezeles()
        {
            InitializeComponent();
        }

        csatlakoz cs = new csatlakoz();
        bejelentkezes be = new bejelentkezes();
        felhasznalo_adat_modositas _fa;
        tipus_kezeles _at;
        fuggvenyek f = new fuggvenyek();
        design_beallitasok de =new design_beallitasok();

        // System.Windows.Forms.Clipboard.SetDataObject(cs.parancs.CommandText, true);

        public adatkezeles(int _id, string _felhnev, string _jelszo,string _alapertelmezett, felhasznalo_adat_modositas fa)
        {
            InitializeComponent();
            felhnev = _felhnev;
            jelszo = _jelszo;
            id = _id;
            alapertelmezett = _alapertelmezett;
            _fa = fa;
        }

        public adatkezeles(int _id, string _felhnev_, string _jelszo_,string _alapertelmezett, bejelentkezes _be_)
        {
            InitializeComponent();
            felhnev = _felhnev_;
            jelszo = _jelszo_;
            id = _id;
            alapertelmezett = _alapertelmezett;
            be = _be_;
        }

        public adatkezeles(int _id, string _felhnev_, string _jelszo_,string _alapertelmezett, tipus_kezeles at)
        {
            InitializeComponent();
            felhnev = _felhnev_;
            jelszo = _jelszo_;
            id = _id;
            alapertelmezett = _alapertelmezett;
            _at = at;
        }

        public adatkezeles(int _id, string _felhnev_, string _jelszo_, string _alapertelmezett)
        {
            InitializeComponent();
            felhnev = _felhnev_;
            jelszo = _jelszo_;
            id = _id;
            alapertelmezett = _alapertelmezett;
        } //személyreszabás

        //_____________________________________________________________________________FŐ form események

        private void adatkezeles_Load(object sender, EventArgs e)
        {
            be.kozep();
            dTP_1.Format = DateTimePickerFormat.Custom;
            dTP_1.CustomFormat = "yy. MM. dd.";
            dTP_1.Value = DateTime.Today;
            LB_üdvözlet.Text =felhnev + " az időpont menedzsment oldalon vagy!";
            LB_ora.Text = DateTime.Now.ToString("yyyy.MM.dd.\nHH:mm:ss");
            dTP_1.SendToBack();

            //____________________________________________________________________________________________________________________________________________________
            teszt = f.vanewamp();
            if (teszt == true)
            {
                string lekerdezes1 = "SELECT tipus_ar.tipus FROM tipus_ar WHERE tipus_ar.fodrasz_az = '" + id + "'";
                f.combobox_feltoltes(lekerdezes1, CB_tipus);
                string lista_feltolt = "Select tipus_ar.id From tipus_ar WHERE tipus_ar.fodrasz_az = '" + id + "'";
                f.lista_feltoltes(lista_feltolt, tipus_az);
                megjelenites();
                de.formazas_beallitasok_beolvasasa(id);
                formazasok_betoltese();

            }
            else
            {
                hiba = true;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
                LB_hiba_uzenet.Text = "A Wampserver nem online!";
            }
            
        }

        private void formazasok_betoltese()
        {
            de.Form_formazasok(alapertelmezett, id,this); //háttér

            de.Button_formazasok(alapertelmezett, id, BT_felhasznalo_modositas, BT_feltoltes, BT_kijelentkezes, BT_kilepes, BT_modositas, BT_szemelyre_szabas, BT_talca, BT_tipus, BT_torles,BT_statisztika); //gombok

            de.Label_formazasok(alapertelmezett, id, LB_aktualis, LB_bejelentkezo, LB_datum, LB_frissítes, LB_hiba_uzenet, LB_idopont, LB_idopont_vege, LB_kereses, LB_kettospont, LB_kettospont2, LB_kovetkezo, LB_megjegyzes, LB_megjelenitett_adatok, LB_oldalszam, LB_ora, LB_osszes_adat, LB_tipus, LB_tisztit, LB_vissza, LB_üdvözlet,LB_datum_kiiras,LB_date,LB_kotojel); //label

            de.Panel_formazasok1(alapertelmezett, id, PANEL_feher); //panel

          //  de.rTextbox_formazasok(alapertelmezett, id,rTB_megjegyzes); // RichTextbox

            de.TextBox_formazasok(alapertelmezett, id, TB_bejelentkezo, TB_id, TB_ora1, TB_ora2, TB_perc1, TB_perc2,TB_megjegyzes); //Textbox

            de.Combobox_Formazasok(alapertelmezett, id, CB_tipus); // combobox

            de.DateTimePicker_formazasok(alapertelmezett, id, dTP_1); //datetimepicker

            de.Datagrid_formazasok(alapertelmezett, id,DGV_adatok); //datagridview

            de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_datum_kiiras,LB_date);

            LB_datum_kiiras.Font = new Font(LB_datum_kiiras.Font.FontFamily, this.Font.Size - 2, LB_datum_kiiras.Font.Style);
            LB_datum_kiiras.Size = new Size(TB_bejelentkezo.Width,TB_bejelentkezo.Height+1);
            LB_date.Size = new Size(30, TB_bejelentkezo.Height+1);
            dTP_1.Size = new Size(TB_bejelentkezo.Width, TB_bejelentkezo.Height);
            LB_kettospont.Size = new Size(25, TB_bejelentkezo.Height);
            LB_kettospont2.Size = new Size(25, TB_bejelentkezo.Height);
            LB_kotojel.Size = new Size(25, TB_bejelentkezo.Height);
        }      
        //_________________________________________________________________________ Speciális Függvények erre a formra

        private void adat_feltoltes(string feltoltes)
        {
            uz = default(string);
            hiba = false;

            if (karakter_ellenorzes())
            {

            }
            else
            {
                if (torlom_e == true || szabad_idopont())
                {

                    if (((datum == default(string) && idopont == default(string) && fodrasz_az == default(string)) || szabad_idopont()) || torlom_e == true)
                    {
                        try
                        {
                            cs.kapcs.Open(); //csatlakozás az adatbázishoz
                            cs.ds = new DataSet();
                            cs.da = new MySqlDataAdapter(feltoltes, cs.kapcs); // parancs futtatása
                            cs.da.Fill(cs.ds, "Feltoltes");

                            if (modositom_e)
                            {
                                uz = "módosítás!";
                                if(LB_datum_kiiras.Text =="")
                                {
                                    LB_datum_kiiras.Text = dTP_1.Text;
                                }
                            }
                            else
                            {
                                if (torlom_e)
                                {
                                    uz = "törlés!";
                                }
                                else
                                {
                                    uz = "feltöltés!";
                                    if (LB_datum_kiiras.Text == "")
                                    {
                                        LB_datum_kiiras.Text = dTP_1.Text;
                                    }
                                }
                            }

                            T_idozito.Start();
                            T_idozito2.Start();
                            if (hiba != true)
                            {
                                megjelenites();
                            }

                        }
                        catch { MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet
                        finally { cs.kapcs.Close(); } //kapcsolat lezárása
                    }
                    else
                    {

                        hiba = true;
                        T_idozito.Enabled = true;
                        T_idozito2.Enabled = true;

                        if (multbeli_idopont_e)
                        {
                            LB_hiba_uzenet.Text = "Múltbéli időpontot szeretnél megadni " + felhnev + "!";
                        }
                        else
                        {
                            LB_hiba_uzenet.Text = "Ez az időpont már le van foglalva nálad " + felhnev + "!";
                        }
                    }
                }
                else
                {
                    hiba = true;
                    T_idozito.Enabled = true;
                    T_idozito2.Enabled = true;

                    if (multbeli_idopont_e)
                    {
                        LB_hiba_uzenet.Text = "Múltbéli időpontot szeretnél megadni " + felhnev + "!";
                    }
                    else
                    {
                        LB_hiba_uzenet.Text = "Ez az időpont már le van foglalva nálad " + felhnev + "!";
                    }
                }
            }          
        }

        //______________________________________________________________________________________________Speciális
        private bool adat_seged()
        {
            if (TB_ora1.TextLength < 2)
            {
                if (TB_ora1.TextLength < 1)
                {
                    TB_ora1.Text = "00" + TB_ora1.Text;
                }
                else
                {
                    TB_ora1.Text = "0" + TB_ora1.Text;
                }

            }
            if (TB_perc1.TextLength < 2)
            {
                if (TB_perc1.TextLength < 1)
                {
                    TB_perc1.Text = "00" + TB_perc1.Text;
                }
                else
                {
                    TB_perc1.Text = "0" + TB_perc1.Text;
                }
            }

            if (modositom_e)
            {

            }

            datum_seged = "";
            string[] seged;

            seged = dTP_1.Text.Split(' ');

            for (int i = 0; i < seged.Length; i++)
            {
                datum_seged = datum_seged + seged[i];
            }

            if (T_idozito.Enabled == true)
            {
                T_idozito.Enabled = false;
                LB_hiba_uzenet.Visible = false;
                szamlalo = 0;
            }
            teszt = f.vanewamp();
            if (teszt == false)
            {
                LB_hiba_uzenet.Text = "A Wampserver nem online!";
                hiba = true;
                T_idozito.Enabled = true;
                return false;
            }
            else
            {
                fuggveny_seged();
                //  if (datum_seged != "" && TB_bejelentkezo.Text != "" && CB_tipus.Text != "" && TB_ora1.Text != "" && TB_ora2.Text != "" && TB_perc1.Text != "" && TB_perc2.Text != "")
                 if (datum_seged != "" && TB_bejelentkezo.Text != "" && CB_tipus.Text != "")
                {
                    return true;
                }
                else
                {
                    hiba = true;
                    T_idozito.Enabled = true;
                    T_idozito2.Enabled = true;
                    LB_hiba_uzenet.Text = "Töltsd ki a hiányzó mezőket (megyjegyzést nem kötelező)!";
                    return false;
                }
            }
        }

        private bool szabad_idopont()
        {
            multbeli_idopont_e = false;
            string ido = DateTime.Now.ToString("yy. MM. dd. %H:%m:%s");

            DateTime valos_ido = DateTime.ParseExact(ido, "yy. MM. dd. %H:%m:%s", null);
            DateTime felvett_ido = DateTime.ParseExact(dTP_1.Text + " " + TB_ora1.Text + ":" + TB_perc1.Text + ":00", "yy. MM. dd. HH:mm:ss", null);

            if (valos_ido > felvett_ido)
            {
                multbeli_idopont_e = true;
                return false;
            }
            else
            {
                string mo;
                if (modositom_e)
                {
                    mo = "not (foglalas.id = '" + TB_id.Text + "') AND";
                }
                else
                {
                    mo = "";
                }
                idopont = default(string);
                fodrasz_az = default(string);
                idopont_vege = default(string);
                bool mukodik_e = false;
                int i = 0;
                try
                {
                    List<string> idopont_tomb = new List<string>();
                    List<string> idopont_vege_tomb = new List<string>();


                    helyes_formatumu_datum = datum_seged.Split('.')[0] + "-" + datum_seged.Split('.')[1] + "-" + datum_seged.Split('.')[2];
                    cs.kapcs.Open();
                    cs.parancs.Connection = cs.kapcs;

                    cs.parancs.CommandText = "SELECT foglalas.idopont,fodrasz_az,idopont_vege FROM foglalas WHERE " + mo + " (foglalas.idopont >= '" + helyes_formatumu_datum + "%' OR foglalas.idopont_vege  >= '" + helyes_formatumu_datum + "%') AND foglalas.fodrasz_az = '" + id + "';";
                    //  System.Windows.Forms.Clipboard.SetDataObject(cs.parancs.CommandText, true);

                    MySqlDataReader olvas = cs.parancs.ExecuteReader();
                    while (olvas.Read())    //beolvas amíg     
                    {
                        i++;
                        idopont = olvas.GetString(0);
                        fodrasz_az = olvas.GetString(1);
                        idopont_vege = olvas.GetString(2);
                        idopont_tomb.Add(olvas.GetString(0).Substring(2));
                        idopont_vege_tomb.Add(olvas.GetString(2).Substring(2));
                    }
                    olvas.Close();
                    string beviteli_ido = dTP_1.Text + " " + TB_ora1.Text + ":" + TB_perc1.Text + ":00";
                    string beviteli_ido_vege = dTP_1.Text + " " + TB_ora2.Text + ":" + TB_perc2.Text + ":00";

                    if (atnyulik_e_a_masik_napba)
                    {
                        string instant_seged = datum_seged.Substring(0, 3) + " " + datum_seged.Substring(3, 3) + " " + datum_seged.Substring(6, 3);

                        DateTime beviteli_ido_vege2 = DateTime.ParseExact(instant_seged + " " + TB_ora2.Text + ":" + TB_perc2.Text + ":00", "yy. MM. dd. HH:mm:ss", null).AddDays(1);
                        beviteli_ido_vege2 = DateTime.ParseExact(beviteli_ido_vege2.ToString().Substring(2), "yy. MM. dd. %H:%m:%s", null);
                        beviteli_ido_vege = beviteli_ido_vege2.ToString();
                    }

                    for (int j = 0; j < i; j++)
                    {
                        DateTime adatbazis_idopont = DateTime.ParseExact(idopont_tomb[j], "%y. %M. %d. %H:%m:%s", null);
                        DateTime adatbazis_idopont_vege = DateTime.ParseExact(idopont_vege_tomb[j], "%y. %M. %d. %H:%m:%s", null);
                        DateTime beviteli_idopont = DateTime.ParseExact(beviteli_ido, "%y. %M. %d. %H:%m:%s", null);
                        DateTime beviteli_idopont_vege = DateTime.ParseExact(beviteli_ido_vege.ToString(), "yy. MM. dd. %H:%m:%s", null);



                        //        06:00:00     <     08:00:00                06:45:00      <      08:00:00                 06:00:00      >     05:00:00              06:45:00        >    05:00:00                   06:00:00      <        08:45:00              06:45:00         <      08:45:00                  06:00:00        >     05:45:00                 06:45:00           >          05:45:00
                        if (((adatbazis_idopont < beviteli_idopont && adatbazis_idopont_vege < beviteli_idopont) || (adatbazis_idopont > beviteli_idopont && adatbazis_idopont_vege > beviteli_idopont)) && ((adatbazis_idopont < beviteli_idopont_vege && adatbazis_idopont_vege < beviteli_idopont_vege) || (adatbazis_idopont > beviteli_idopont_vege && adatbazis_idopont_vege > beviteli_idopont_vege)))

                        {
                            mukodik_e = true; //

                        }
                        else
                        {
                            mukodik_e = false;
                            break;
                        }
                    }
                }
                catch  {MessageBox.Show("Hiba van az adatbázissal!", "Szabad-e az időpont", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                cs.kapcs.Close();

                if (mukodik_e || i == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //______________________________________________________________________________________________Főbb eljárások

        private void megjelenites()
        {
            teszt = f.vanewamp();
            if (teszt == true)
            {
                if (oldal < 1)
                {
                    oldal = 1;
                }
                if (osszes_adat < 10)
                {
                    oldal = 1;
                    lapozo = 0;
                    offset = 0;
                }
                offset = lapozo * 10;
                string lekerdezes = "SELECT foglalas.id AS 'ID',Date_Format (foglalas.idopont,'%y. %m. %d. %H:%i') as 'Időpont',Date_Format(idopont_vege,'%y. %m. %d. %H:%i') as 'Időpont vége',foglalas.nev AS 'Ügyfél neve',tipus_ar.tipus AS 'Típus',tipus_ar.ar AS 'Ár (Ft)',foglalas.megjegyzes AS 'Megjegyzés' FROM foglalas INNER JOIN tipus_ar ON foglalas.tipus_az=tipus_ar.id INNER JOIN belepesi_adatok ON belepesi_adatok.id=foglalas.fodrasz_az WHERE belepesi_adatok.id ='" + id + "'" + aktualis_idopontok + " Order By foglalas.idopont Limit 10 Offset " + offset+ "; ";
                osszes_adat = _osszes_adat();;
                f.megjelen(lekerdezes, DGV_adatok);
                megjelenes_ellenorzes();
                tisztít();
                DGV_adatok.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGV_adatok.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;               

                //  System.Windows.Forms.Clipboard.SetDataObject(lekerdezes, true);
            }
            else
            {
                hiba = true;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
                LB_hiba_uzenet.Text = "A Wampserver nem online!";
            }
            oszlop_elrendezes_datagridviewban(DGV_adatok);
        }

        private void kereses()
        {
            hiba_reset();
            teszt = f.vanewamp();
            if (teszt == true)
            {
                if (oldal < 1)
                {
                    oldal = 1;
                }
                           
                            
                offset = lapozo * 10;
                osszes_adat = _osszes_adat();
                string lekerdezes = "SELECT foglalas.id AS 'ID',Date_Format (foglalas.idopont,'%y. %m. %d. %H:%i') as 'Időpont',Date_Format(idopont_vege,'%y. %m. %d. %H:%i') as 'Időpont vége',foglalas.nev AS 'Ügyfél neve',tipus_ar.tipus AS 'Típus',tipus_ar.ar AS 'Ár (Ft)',foglalas.megjegyzes AS 'Megjegyzés' FROM foglalas INNER JOIN tipus_ar ON foglalas.tipus_az=tipus_ar.id INNER JOIN belepesi_adatok ON belepesi_adatok.id=foglalas.fodrasz_az WHERE belepesi_adatok.id ='" + id + "' && Date_Format (foglalas.idopont,'%y. %m. %d. %H:%i') Like '%" + date + "%" + ido1 + "%' && foglalas.nev Like '%" + nev + "%' && tipus_ar.tipus Like '%" + tipus + "%' && foglalas.megjegyzes Like '%" + megjegy + "%' && Date_Format(idopont_vege,'%y. %m. %d. %H:%i') Like '%" + date + "%" + ido2 + "%'" + aktualis_idopontok + " Order By foglalas.idopont Limit 10 Offset " + offset + " ;";
               // System.Windows.Forms.Clipboard.SetDataObject(lekerdezes, true);
                f.megjelen(lekerdezes, DGV_adatok);
                megjelenes_ellenorzes();
                DGV_adatok.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGV_adatok.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                if (osszes_adat < 10)
                {
                    oldal = 1;
                    lapozo = 0;
                    offset = 0;
                    oldalak_szama = osszes_adat / 10;
                }
            }
            else
            {
                hiba = true;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
                LB_hiba_uzenet.Text = "A Wampserver nem online!";
            }
            
        }

        private void modositas()
        {

            if (adat_seged())
            {
                try
                {
                            
                    DateTime kezdo_idopont = DateTime.ParseExact(datum_seged + " " + TB_ora1.Text + ":" + TB_perc1.Text + ":00", "yy.MM.dd. %H:%m:%s", null);
                    DateTime veg_idopont = DateTime.ParseExact(datum_seged + " " + TB_ora2.Text + ":" + TB_perc2.Text + ":00", "yy.MM.dd. %H:%m:%s", null);

                    if (atnyulik_e_a_masik_napba)
                    {
                        veg_idopont = veg_idopont.AddDays(1);
                    }
                    string kezdo_seged = datum_seged + " " + TB_ora1.Text + ":" + TB_perc1.Text + ":00";
                    string veg_seged = veg_idopont.ToString().Split(' ')[0] + veg_idopont.ToString().Split(' ')[1] + veg_idopont.ToString().Split(' ')[2] + " " + veg_idopont.ToString().Split(' ')[3];
                    string foglalas;
                    try
                    {
                        foglalas = "[" + DGV_adatok.CurrentRow.Cells[3].Value.ToString() + " " + DGV_adatok.CurrentRow.Cells[1].Value.ToString() + "]-i időpontját?";
                    }
                    catch { foglalas = ""; }


                    string feltoltes = @"UPDATE `foglalas` SET `idopont`= '" + kezdo_seged + "', `idopont_vege`= '" + veg_seged + "', `nev` = '" + TB_bejelentkezo.Text + "',`tipus_az`= '" + tipus_az[CB_tipus.SelectedIndex - 1] + "',`megjegyzes`= '" + TB_megjegyzes.Text + "' WHERE `id`=" + TB_id.Text + ";";
                      //System.Windows.Forms.Clipboard.SetDataObject(feltoltes, true);

                    if (foglalas == "")
                    {
                        LB_hiba_uzenet.Visible = true;
                        hiba = true;
                        T_idozito.Enabled = true;
                        T_idozito2.Enabled = true;
                        LB_hiba_uzenet.Text = "Nincs kijelölve a módosítandó rekord!";
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show(felhnev + " biztosan módosítani akarod " + foglalas, "Módosítás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            adat_feltoltes(feltoltes);                           
                            
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                        LB_hiba_uzenet.Visible = false;
                    }
                }
                catch { MessageBox.Show("Hiba a módosítás során!", "Módosítási hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet
            }

        }

        private void torles()
        {
                try
                {
                    string foglalas;
                    try
                    {
                        foglalas = "[" + DGV_adatok.CurrentRow.Cells[3].Value.ToString() + " " + DGV_adatok.CurrentRow.Cells[1].Value.ToString() + "]-i időpontját?";
                    }
                    catch { foglalas = ""; }

                    string feltoltes = @"DELETE FROM  `foglalas` Where `id` ='" + TB_id.Text + "'";


                    if (foglalas == "" || TB_id.Text == "")
                    {
                        LB_hiba_uzenet.Visible = true;
                        hiba = true;
                        T_idozito.Enabled = true;
                        T_idozito2.Enabled = true;
                        LB_hiba_uzenet.Text = "Nincs kijelölve a törlendő rekord!";
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show(felhnev + " biztosan törölni akarod " + foglalas, "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            adat_feltoltes(feltoltes);
                            megjelenites();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                        LB_hiba_uzenet.Visible = false;
                    }
                }
                catch { MessageBox.Show("Hiba a törlés során!", "Törlési hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet          
        }

        private void feltoltes()
        {
            if (adat_seged())
            {
                try
                {                  
                    DateTime kezdo_idopont = DateTime.ParseExact(datum_seged + " " + TB_ora1.Text + ":" + TB_perc1.Text + ":00", "yy.MM.dd. %H:%m:%s", null);
                    DateTime veg_idopont = DateTime.ParseExact(datum_seged + " " + TB_ora2.Text + ":" + TB_perc2.Text + ":00", "yy.MM.dd. %H:%m:%s", null);

                    if (atnyulik_e_a_masik_napba)
                    {
                        veg_idopont = veg_idopont.AddDays(1);
                    }
                    string kezdo_seged = datum_seged + " " + TB_ora1.Text + ":" + TB_perc1.Text + ":00";
                    string veg_seged = veg_idopont.ToString().Split(' ')[0] + veg_idopont.ToString().Split(' ')[1] + veg_idopont.ToString().Split(' ')[2] + " " + veg_idopont.ToString().Split(' ')[3];

                    string idopont_seged = TB_ora1.Text + ":" + TB_perc1.Text;
                    string feltoltes = @"INSERT INTO foglalas(`idopont`,`idopont_vege`,`nev`, `tipus_az`,`fodrasz_az`, `megjegyzes`) VALUES( '" + kezdo_seged + "', '" + veg_seged + "','" + TB_bejelentkezo.Text + "', '" + tipus_az[CB_tipus.SelectedIndex - 1] + "', '" + id + "', '" + TB_megjegyzes.Text + "')";
                    //System.Windows.Forms.Clipboard.SetDataObject(feltoltes, true);
                    adat_feltoltes(feltoltes);
                    megjelenes_ellenorzes();
                    LB_hiba_uzenet.Visible = false;
                }
                catch { MessageBox.Show("Hiba a feltöltés során!", "Feltöltési hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void tisztít()
        {
            hiba_reset();
            dTP_1.Value = DateTime.Today;
            TB_ora1.Text = "";
            TB_perc1.Text = "";
            TB_ora2.Text = "";
            TB_perc2.Text = "";
            TB_bejelentkezo.Text = "";
            CB_tipus.Text = "";
            TB_megjegyzes.Text = "";
            TB_id.Text = "";
            LB_datum_kiiras.Text = "";
        }

        private void megjelenes_ellenorzes()
        {
            _osszes_adat();
            oldalak_szama = osszes_adat / 10;
            if (oldalak_szama > oldal)
            {
                LB_kovetkezo.Enabled = true;
            }
            else
            {                
                LB_kovetkezo.Enabled = false;
            }
            if ((oldalak_szama+0.9) < oldal)
            {
                oldal_vissza();
            }
        }

        private void oszlop_elrendezes_datagridviewban(DataGridView dgv)
        {
            try
            {
                dgv.Columns[1].Width = 220;
                dgv.Columns[2].Width = 220;
                dgv.Columns[3].Width = 200;
                dgv.Columns[4].Width = 160;
                dgv.Columns[5].Width = 100;
            }
            catch { }            
        }

        private void hiba_reset()
        {
            LB_hiba_uzenet.Visible = false;
            this.Size = new Size(1200, 750);
        }

        //______________________________________________________________________________________________Datagridview ESEMÉNYEK

        private void DGV_adatok_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.DGV_adatok.Columns[0].Visible = false;
        }

        private void DGV_adatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (valto == 0)
            {
                try
                {
                    string seged = DGV_adatok.CurrentRow.Cells[1].Value.ToString();
                    string[] seged5 = seged.Split(' ');
                    string ido_seged = seged5[3];
                    string[] seged2 = ido_seged.Split(':');

                    string seged3 = DGV_adatok.CurrentRow.Cells[2].Value.ToString();
                    string[] seged6 = seged3.Split(' ');
                    string ido_seged2 = seged6[3];
                    string[] seged4 = ido_seged2.Split(':');

                    TB_id.Text = DGV_adatok.CurrentRow.Cells[0].Value.ToString();
                    dTP_1.Value = DateTime.ParseExact(seged5[0] + " " + seged5[1] + " " + seged5[2], "yy. MM. dd.", CultureInfo.InvariantCulture);
                    TB_bejelentkezo.Text = DGV_adatok.CurrentRow.Cells[3].Value.ToString();
                    TB_ora1.Text = seged2[0];
                    TB_perc1.Text = seged2[1];
                    TB_ora2.Text = seged4[0];
                    TB_perc2.Text = seged4[1];
                    CB_tipus.Text = DGV_adatok.CurrentRow.Cells[4].Value.ToString();
                    TB_megjegyzes.Text = DGV_adatok.CurrentRow.Cells[6].Value.ToString();
                    modositas_index = DGV_adatok.CurrentCell.RowIndex;

                }
                catch { }
            }
        }

        private void DGV_adatok_CurrentCellChanged(object sender, EventArgs e)
        {
            if (valto == 0)
            {
                try
                {
                    string seged = DGV_adatok.CurrentRow.Cells[1].Value.ToString();
                    string[] seged5 = seged.Split(' ');
                    string ido_seged = seged5[3];
                    string[] seged2 = ido_seged.Split(':');

                    string seged3 = DGV_adatok.CurrentRow.Cells[2].Value.ToString();
                    string[] seged6 = seged3.Split(' ');
                    string ido_seged2 = seged6[3];
                    string[] seged4 = ido_seged2.Split(':');

                    TB_id.Text = DGV_adatok.CurrentRow.Cells[0].Value.ToString();
                    dTP_1.Value = DateTime.ParseExact(seged5[0] + " " + seged5[1] + " " + seged5[2], "yy. MM. dd.", CultureInfo.InvariantCulture);
                    TB_bejelentkezo.Text = DGV_adatok.CurrentRow.Cells[3].Value.ToString();
                    TB_ora1.Text = seged2[0];
                    TB_perc1.Text = seged2[1];
                    TB_ora2.Text = seged4[0];
                    TB_perc2.Text = seged4[1];
                    CB_tipus.Text = DGV_adatok.CurrentRow.Cells[4].Value.ToString();
                    TB_megjegyzes.Text = DGV_adatok.CurrentRow.Cells[6].Value.ToString();
                    modositas_index = DGV_adatok.CurrentCell.RowIndex;

                }
                catch { }
            }
        }

        private void DGV_adatok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Right)
            {
                oldal_kovetkezo();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Left)
            {
                oldal_vissza();
            }
            if (e.KeyCode == Keys.Delete)
            {
                BT_torles.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                frissites();
            }
            if (e.KeyCode == Keys.Escape)
            {
                tisztít();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode== Keys.K)
            {
                kereses_click();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                aktualis_megjelenitese();
            }
        }

        //_______________________________________________________________________TÁLCA&Kilépés__
        private void BT_talca_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BT_kilepes_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan ki akarsz lépni a programból?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        //___________________________________________________________________Fő_gombok______________

        private void BT_kijelentkezes_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Biztosan ki akarsz jelentkezni " + felhnev + "?", "Kijelentkezés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // az esemény lefutásakor feldob 1 interaktív üzenet dobozt 1. "figyelmeztetés...stb" 2. "dialógus neve "
            if (dialogResult == DialogResult.Yes) // ha a felajánlott "igen" lehetőségre klikkelünk
            {
                bejelentkezes be = new bejelentkezes();
                be.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No) // ha a felajánlott "nem" lehetőségre klikkelünk
            {

            }

        }

        private void BT_tipus_Click(object sender, EventArgs e)
        {
            tipus_kezeles at = new tipus_kezeles(id, felhnev, jelszo,alapertelmezett, this);
            at.Show();
            this.Close();
        }

        private void BT_felhasznalo_modositas_Click(object sender, EventArgs e)
        {
            felhasznalo_adat_modositas at = new felhasznalo_adat_modositas(id, felhnev, jelszo,alapertelmezett, this);
            at.Show();
            this.Close();
        }

        private void BT_szemelyre_szabas_Click(object sender, EventArgs e)
        {
            szemelyre_szabas at = new szemelyre_szabas(felhnev, jelszo,id, alapertelmezett);
            at.Show();
            this.Close();
        }

        private void BT_statisztika_Click(object sender, EventArgs e)
        {
            statisztika at = new statisztika(felhnev, jelszo, id, alapertelmezett);
            at.Show();
            this.Close();
        }

        private void BT_feltoltes_Click(object sender, EventArgs e)
        {
            torlom_e = false;
            modositom_e = false;
            feltoltes();
        }

        private void BT_modositas_Click(object sender, EventArgs e)
        {
            torlom_e = false;
            modositom_e = true;
            modositas();
        }

        private void BT_torles_Click(object sender, EventArgs e)
        {
            modositom_e = false;
            torlom_e = true;
            torles();
        }

        //____________________________________________________________________Időzítő____________
        private void T_idozito_Tick(object sender, EventArgs e)
        {
            szamlalo++;
            if (hiba == true)
            {
                if (szamlalo % 2 == 0)
                {
                    LB_hiba_uzenet.Visible = true;
                }
                else
                {
                    LB_hiba_uzenet.Visible = false;
                }
            }
            else if (uz == "feltöltés!" || uz == "törlés!" || uz == "módosítás!")
            {
                LB_hiba_uzenet.Text = "Sikeres " + uz;
                if (szamlalo % 2 == 0)
                {
                    LB_hiba_uzenet.Visible = true;
                }
                else
                {
                    LB_hiba_uzenet.Visible = false;
                }
            }

            if (szamlalo == 10)
            {
                T_idozito.Enabled = false;
                szamlalo = 0;
            }
        }

        private void T_idozito2_Tick(object sender, EventArgs e)
        {
            if (hiba == true || (uz == "feltöltés!" || uz == "törlés!" || uz == "módosítás!"))
            {
                this.Size = new Size(1200, 800);
                DGV_adatok.Size = new Size(1100, 344);
            }
            else
            {
                this.Size = new Size(1200, 750);
            }
            T_idozito2.Enabled = false;
        }

        private void T_ora_Tick(object sender, EventArgs e)
        {
            LB_ora.Text = DateTime.Now.ToString("yyyy.MM.dd.\nHH:mm:ss");
        }

        private void T_idozito_3_Tick(object sender, EventArgs e)
        {
            if (oldal <= 1)
            {
                LB_vissza.Enabled = false;
            }
            else
            {
                LB_vissza.Enabled = true;
            }
         // osszes_adat = _osszes_adat();
            LB_oldalszam.Text = oldal + ". oldal"; //frissiti a kiírást
            LB_osszes_adat.Text = "Összes adat: " + osszes_adat; //frissiti a kiírást
            megjelenitett_adatszamlalo = DGV_adatok.RowCount; //megszámolja, hogy hány sor van megjelenítve a daragriedviewban

            if (megjelenitett_adatszamlalo >= 0)
            {
                LB_megjelenitett_adatok.Text = "Megjelenített adatok száma: " + megjelenitett_adatszamlalo; //mindig mutat egy + üres sort, azt vonjuk ki
            }
        }

        //_________________________________________________________________________________________

        //ora és perc ellenorzes && függvénye________________________________________________________________-

        private void ora_mutato(string _ora, string _perc)
        {
            int ora = Convert.ToInt32(_ora);
            int perc = Convert.ToInt32(_perc);

            if (perc - 60 >= 0)
            {
                ora += 1;
                if ((perc - 60).ToString().Length == 1)
                {
                    TB_perc2.Text = "0" + (perc - 60).ToString();
                }
                else
                {
                    TB_perc2.Text = (perc - 60).ToString();
                }
            }
            else
            {
                if (perc.ToString().Length == 1)
                {
                    TB_perc2.Text = "0" + perc.ToString();
                }
                else
                {
                    TB_perc2.Text = perc.ToString();
                }
            }

            if (ora - 24 >= 0)
            {
                atnyulik_e_a_masik_napba = true;
                ora = ora - 24;
                if (ora.ToString().Length == 1)
                {
                    TB_ora2.Text = "0" + ora.ToString();
                }
                else
                {
                    TB_ora2.Text = ora.ToString();
                }
            }
            else
            {
                atnyulik_e_a_masik_napba = false;
                if (ora.ToString().Length == 1)
                {
                    TB_ora2.Text = "0" + ora.ToString();
                }
                else
                {
                    TB_ora2.Text = ora.ToString();
                }
            }
        }

        //_________________________________________________________Textbox események

        private void TB_bejelentkezo_TextChanged(object sender, EventArgs e)
        {
            int jelenlegi = (sender as TextBox).SelectionStart;
            TB_bejelentkezo.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(TB_bejelentkezo.Text);
            (sender as TextBox).SelectionStart = jelenlegi;
            (sender as TextBox).SelectionLength = 0;

            if (valto == 1 && bejel_valto == 1)
            {
                nev = TB_bejelentkezo.Text;
                kereses();
            }
            f.betu_tb(TB_bejelentkezo);
        }

        private void TB_ora1_TextChanged(object sender, EventArgs e)
        {
            f.ora(TB_ora1);
            f.szam_tb(TB_ora1);
            if (TB_ora1.TextLength == 2 && TB_ora1.Focused)
            {
                SendKeys.Send("{TAB}");
            }

            if (valto == 1 && ido_valto == 1)
            {
                ido1 = TB_ora1.Text + "%:%" + TB_perc1.Text;
                kereses();
            }
            else
            {
                if (CB_tipus.Text != "" &&TB_ora1.Text !="" && TB_perc1.Text != "")
                {
                    fuggveny_seged();
                }
                else
                {
                    TB_ora2.Text = "";
                    TB_perc2.Text = "";
                }
            }


        }

        private void TB_perc1_TextChanged(object sender, EventArgs e)
        {
            f.perc(TB_perc1);
            f.szam_tb(TB_perc1);
            if (TB_perc1.TextLength == 2 && TB_perc1.Focused)
            {
                SendKeys.Send("{TAB}");
            }
            if (valto == 1 && ido_valto == 1)
            {
                ido1 = TB_ora1.Text + "%:%" + TB_perc1.Text;
                kereses();
            }
            else
            {
                if (CB_tipus.Text != "" && TB_ora1.Text != "" && TB_perc1.Text != "")
                {
                    fuggveny_seged();
                }
                else
                {
                    TB_ora2.Text = "";
                    TB_perc2.Text = "";
                }
            }


        }

        private void TB_ora2_TextChanged(object sender, EventArgs e)
        {
            f.ora(TB_ora2);
            f.szam_tb(TB_ora2);
            if (TB_ora2.TextLength == 2 && TB_ora2.Focused)
            {
                SendKeys.Send("{TAB}");
            }
            if (valto == 1 && ido_vege_valto == 1)
            {
                ido2 = TB_ora2.Text + "%:%" + TB_perc2.Text;
                kereses();
            }
        }

        private void TB_perc2_TextChanged(object sender, EventArgs e)
        {
            f.perc(TB_perc2);
            f.szam_tb(TB_perc2);
            if (TB_perc2.TextLength == 2 && TB_perc2.Focused)
            {
                SendKeys.Send("{TAB}");
            }
            if (valto == 1 && ido_vege_valto == 1)
            {
                ido2 = TB_ora2.Text + "%:%" + TB_perc2.Text;
                kereses();
            }
        }

        private void TB_megjegyzes_TextChanged(object sender, EventArgs e)
        {
            f.TB_elso_betu_mindig_nagybetu(TB_megjegyzes);
            f.betu_es_szam_TB(TB_megjegyzes);
            if (valto == 1 && megjegy_valto == 1)
            {
                megjegy = TB_megjegyzes.Text;
                kereses();
            }
        }

        private void dTP_1_ValueChanged(object sender, EventArgs e)
        {
            LB_datum_kiiras.Text = Convert.ToString(dTP_1.Value).Substring(2, 11);
            if (valto == 1 && dat_valto == 1)
            {
                date = LB_datum_kiiras.Text;
                kereses();
            }
            else if(valto ==1 && dat_valto==0)
            {
                date = "";
                kereses();
            }                               
        }

        private void CB_tipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_tipus.Focused && TB_ora1.Text != "" && TB_perc1.Text != "" && valto != 1)
            {
                SendKeys.Send("{TAB}");
                fuggveny_seged();
            }

            if (valto == 1 && tipus_valto == 1)
            {
                tipus = CB_tipus.Text;
                kereses();
            }


        }

        //__________________________________________________________________________________________________________________________

        //___________________________________________________________________________________________________egyéb események

        private void fuggveny_seged()
        {
            try
            {
                if (cs.kapcs.State != ConnectionState.Open)
                {
                    cs.kapcs.Open(); //meghívjuk a kapcsolódó parancsot, így ténylegesen is kapcsolódunk az adatbázishoz
                }

                cs.parancs.Connection = cs.kapcs;
                cs.parancs.CommandText = "SELECT tipus_ar.idotartam FROM tipus_ar WHERE tipus_ar.fodrasz_az = '" + id + "' AND tipus_ar.tipus = '" + CB_tipus.Text + "';";
                MySqlDataReader olvas = cs.parancs.ExecuteReader();
                while (olvas.Read())    //beolvas amíg     
                {
                    seged = olvas.GetString(0).Split(':'); //lekérdezésben lévő első elem felh, a (0) jelenti az első elemet
                    int ora = (Convert.ToInt32(TB_ora1.Text) + Convert.ToInt32(seged[0]));
                    int perc = (Convert.ToInt32(TB_perc1.Text) + Convert.ToInt32(seged[1]));

                    ora_mutato(Convert.ToString(ora), Convert.ToString(perc));
                }
                olvas.Close();
            }
            catch { MessageBox.Show("Hiba van az adatbázissal!", "Adatbázis", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            cs.kapcs.Close();
        }

        private double _osszes_adat()
        {
            string lekerdezes;
            if (valto == 1)
            {
                 lekerdezes = "SELECT COUNT(*) FROM foglalas INNER JOIN tipus_ar ON foglalas.tipus_az=tipus_ar.id INNER JOIN belepesi_adatok ON belepesi_adatok.id=foglalas.fodrasz_az WHERE belepesi_adatok.id ='" + id + "' && Date_Format (foglalas.idopont,'%y. %m. %d. %H:%i') Like '%" + date + "%" + ido1 + "%' && foglalas.nev Like '%" + nev + "%' && tipus_ar.tipus Like '%" + tipus + "%' && foglalas.megjegyzes Like '%" + megjegy + "%' && Date_Format(idopont_vege,'%y. %m. %d. %H:%i') Like '%" + date + "%" + ido2 + "%'" + aktualis_idopontok + ";";
            }
            else
            {
                lekerdezes = "SELECT COUNT(*) FROM foglalas INNER JOIN tipus_ar ON foglalas.tipus_az=tipus_ar.id INNER JOIN belepesi_adatok ON belepesi_adatok.id=foglalas.fodrasz_az WHERE belepesi_adatok.id ='" + id + "'" + aktualis_idopontok+";";
            }
            try
            {

                cs.kapcs.Open();
                cs.parancs.Connection = cs.kapcs;
                cs.parancs.CommandText = lekerdezes;         // SQL lekérdezéssel megnézzük az adatbázisban a megadott értékeket (felhasználó név, jelszó)          
                MySqlDataReader olvas2 = cs.parancs.ExecuteReader();               
                while (olvas2.Read())    //beolvas amíg     
                {
                    osszes_adat = olvas2.GetInt32(0);
                    break;
                }
                cs.kapcs.Close();
            }
            catch { }

            return osszes_adat;            
        }

        private bool karakter_ellenorzes()
        {
            if (TB_bejelentkezo.Text.Contains("(") || TB_bejelentkezo.Text.Contains(")") || TB_bejelentkezo.Text.Contains("'"))
            {
                LB_hiba_uzenet.Visible = true;
                hiba = true;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;

                TB_bejelentkezo.Text = default(string);
                LB_hiba_uzenet.Text = "A 'Bejelentkező neve' mező! Nem megengedett karakter(ek)!";
                TB_bejelentkezo.Select();
                TB_bejelentkezo.Select(TB_bejelentkezo.Text.Length, 0);
                return true;
            }
            else
            {
                if (TB_megjegyzes.Text.Contains("(") || TB_megjegyzes.Text.Contains(")") || TB_megjegyzes.Text.Contains("'"))
                {
                    LB_hiba_uzenet.Visible = true;
                    hiba = true;
                    T_idozito.Enabled = true;
                    T_idozito2.Enabled = true;

                    TB_megjegyzes.Text = default(string);
                    LB_hiba_uzenet.Text = "A 'Megjegyzés' mező! Nem megengedett karakterek(ek)!";
                    TB_megjegyzes.Select();
                    TB_megjegyzes.Select(TB_megjegyzes.Text.Length, 0);
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        private void oldal_vissza()
        {
            if(LB_vissza.Enabled==true)
            {
                if (oldal > 1)
                {
                    oldal--;
                    lapozo--;
                    if (valto == 0)
                    {
                        megjelenites();
                        if (DGV_adatok.Rows.Count != 0)
                        {
                            LB_kovetkezo.Enabled = true;
                        }
                        else
                        {
                            LB_kovetkezo.Enabled = false;
                        }
                    }
                    else
                    {
                        kereses();
                        if (DGV_adatok.Rows.Count != 0)
                        {
                            LB_kovetkezo.Enabled = true;
                        }
                        else
                        {
                            LB_kovetkezo.Enabled = false;
                        }
                    }
                }
            }           
        }

        private void oldal_kovetkezo()
        {
            if (LB_kovetkezo.Enabled==true)
            {
                lapozo++;
                oldal++;
                if (valto == 0)
                {                   
                    megjelenites();
                }
                else
                {
                    kereses();
                }
            }
          
        }

        private void aktualis_megjelenitese()
        {
            oldal_beallito();
            hiba_reset();

            if (aktualis == 1)
            {
                aktualis = 0;
                LB_aktualis.BackColor = Color.Transparent;
                aktualis_idopontok = default(string);

                if (valto == 1)
                {
                    kereses();
                }
                else
                {
                    megjelenites();
                }
            }
            else
            {
                aktualis = 1;
                de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_aktualis);
                aktualis_idopontok = " AND foglalas.idopont >= '" + DateTime.Now.ToString("yyyy.MM.dd HH:ii") + "'";
                if (valto == 1)
                {
                    kereses();
                }
                else
                {
                    megjelenites();
                }
            }
        }

        private void frissites()
        {
            hiba_reset();
            if (T_idozito.Enabled == true)
            {
                T_idozito.Enabled = false;
                LB_hiba_uzenet.Visible = false;
                szamlalo = 0;
            }

            if (valto == 1)
            {
                kereses();
            }
            else
            {
                megjelenites();
                tisztít();
            }


        }
        
        private void kereses_click()
        {
            oldal_beallito();
            if (valto == 0)
            {
                valto = 1;
                date = "";
                LB_datum.Cursor = Cursors.Hand;

                ido_valto = 1;
                LB_idopont.Cursor = Cursors.Hand;

                ido_vege_valto = 1;
                LB_idopont_vege.Cursor = Cursors.Hand;
                TB_ora2.TabStop = true;
                TB_perc2.TabStop = true;

                bejel_valto = 1;
                LB_bejelentkezo.Cursor = Cursors.Hand;

                tipus_valto = 1;
                LB_tipus.Cursor = Cursors.Hand;

                megjegy_valto = 1;
                LB_megjegyzes.Cursor = Cursors.Hand;

                de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_kereses, LB_idopont, LB_idopont_vege, LB_bejelentkezo, LB_tipus, LB_megjegyzes); //szines labelek

                //date = dTP_1.Text;
                ido1 = TB_ora1.Text + "%:%" + TB_perc1.Text;
                ido2 = TB_ora2.Text + "%:%" + TB_perc2.Text;
                nev = TB_bejelentkezo.Text;
                tipus = CB_tipus.Text;
                megjegy = TB_megjegyzes.Text;
                dTP_1.Value = DateTime.Today;
                TB_ora2.ReadOnly = false;
                TB_perc2.ReadOnly = false;
                TB_ora1.Text = default(string);
                TB_ora2.Text = default(string);
                TB_perc1.Text = default(string);
                TB_perc2.Text = default(string);
                TB_bejelentkezo.Text = default(string);
                TB_megjegyzes.Text = default(string);
                CB_tipus.SelectedItem = default(string);
                TB_ora2.Enabled = true;
                TB_perc2.Enabled = true;
            }
            else
            {
                valto = 0;
                LB_kereses.BackColor = Color.Transparent;

                dat_valto = 0;
                LB_datum.BackColor = Color.Transparent;
                LB_datum.Cursor = Cursors.Default;

                ido_valto = 0;
                LB_idopont.BackColor = Color.Transparent;
                LB_idopont.Cursor = Cursors.Default;

                ido_vege_valto = 0;
                LB_idopont_vege.BackColor = Color.Transparent;
                LB_idopont_vege.Cursor = Cursors.Default;
                TB_ora2.TabStop = false;
                TB_perc2.TabStop = false;

                bejel_valto = 0;
                LB_bejelentkezo.BackColor = Color.Transparent;
                LB_bejelentkezo.Cursor = Cursors.Default;

                tipus_valto = 0;
                LB_tipus.BackColor = Color.Transparent;
                LB_tipus.Cursor = Cursors.Default;

                megjegy_valto = 0;
                LB_megjegyzes.BackColor = Color.Transparent;
                LB_megjegyzes.Cursor = Cursors.Default;

                date = "";
                ido1 = "";
                ido2 = "";
                nev = "";
                tipus = "";
                megjegy = "";

                TB_ora2.ReadOnly = true;
                TB_perc2.ReadOnly = true;
                TB_ora2.Enabled = false;
                TB_perc2.Enabled = false;
                megjelenites();
            }
        }

        //_________________________________________________________________________________________________Klikk eventek

        private void LB_aktualis_Click(object sender, EventArgs e)
        {
            aktualis_megjelenitese();
        }

        private void LB_kereses_Click(object sender, EventArgs e)
        {
            kereses_click();
        }

        private void LB_datum_Click(object sender, EventArgs e)
        {
            oldal_beallito();

                if (dat_valto == 1 && valto ==1)
                {
                    dat_valto = 0;
                    date = "";               
                    de.Label_formazasok(alapertelmezett, id, LB_datum);
                    kereses();                   
                }
                else if (valto ==1 & dat_valto ==0)
                {
                    dat_valto = 1;
                    date = LB_datum_kiiras.Text;
                    de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_datum);                   
                    kereses();                    
                }                       
        }

        private void LB_idopont_Click(object sender, EventArgs e)
        {
            oldal_beallito();
            if (valto == 1)
            {
                if (ido_valto == 1)
                {
                    ido_valto = 0;
                    LB_idopont.BackColor = Color.Transparent;
                    ido1 = "";
                    kereses();

                }
                else
                {
                    ido_valto = 1;
                    de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_idopont);
                    ido1 = TB_ora1.Text + "%:%" + TB_perc1.Text;
                    kereses();

                }
            }
        }

        private void LB_idopont_vege_Click(object sender, EventArgs e)
        {
            oldal_beallito();
            if (valto == 1)
            {
                if (ido_vege_valto == 1)
                {
                    ido_vege_valto = 0;
                    LB_idopont_vege.BackColor = Color.Transparent;
                    ido2 = "";
                    kereses();
                }
                else
                {
                    ido_vege_valto = 1;

                    de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_idopont_vege);
                    ido2 = TB_ora2.Text + "%:%" + TB_perc2.Text;
                    kereses();
                }
            }
        }

        private void LB_bejelentkezo_Click(object sender, EventArgs e)
        {
            oldal_beallito();
            if (valto == 1)
            {
                if (bejel_valto == 1)
                {
                    bejel_valto = 0;
                    LB_bejelentkezo.BackColor = Color.Transparent;
                    nev = "";
                    kereses();
                }
                else
                {
                    bejel_valto = 1;
                    de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_bejelentkezo);
                    nev = TB_bejelentkezo.Text;
                    kereses();
                }
            }
        }

        private void LB_tipus_Click(object sender, EventArgs e)
        {
            oldal_beallito();
            if (valto == 1)
            {
                if (tipus_valto == 1)
                {
                    tipus_valto = 0;
                    LB_tipus.BackColor = Color.Transparent;
                    tipus = "";
                    kereses();
                }
                else
                {
                    tipus_valto = 1;
                    de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_tipus);
                    tipus = CB_tipus.Text;
                    kereses();
                }
            }
        }

        private void LB_megjegyzes_Click(object sender, EventArgs e)
        {
            oldal_beallito();
            if (valto == 1)
            {
                if (megjegy_valto == 1)
                {
                    megjegy_valto = 0;
                    LB_megjegyzes.BackColor = Color.Transparent;
                    megjegy = "";
                    kereses();
                }
                else
                {
                    megjegy_valto = 1;
                    de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_megjegyzes);
                    megjegy = TB_megjegyzes.Text;
                    kereses();
                }
            }
        }

        private void LB_tisztit_Click(object sender, EventArgs e)
        {
            tisztít();
        }

        private void LB_frissítes_Click(object sender, EventArgs e)
        {
            frissites();
        }

        private void LB_kovetkezo_Click(object sender, EventArgs e)
        {
            oldal_kovetkezo();
        }

        private void LB_vissza_Click(object sender, EventArgs e)
        {
            oldal_vissza();
        }

        private void LB_datum_kiiras_Click(object sender, EventArgs e)
        {
            dTP_1.Focus();
            SendKeys.SendWait("%{DOWN}");
        }

        private void oldal_beallito()
        {
            oldal = 1;
            lapozo = 0;
            offset = 0;
            oldalak_szama = osszes_adat / 10;
        }

        //_________________________________________________________________________Egér rajta tartás esemény

        private void LB_kovetkezo_MouseHover(object sender, EventArgs e)
        {
            LB_kovetkezo.Font = new Font(LB_kovetkezo.Font.Name, LB_kovetkezo.Font.SizeInPoints, FontStyle.Underline);
            tip.SetToolTip(LB_kovetkezo, "Ctrl + ->");
            LB_kovetkezo.Cursor = Cursors.Hand;
        }

        private void LB_kovetkezo_MouseLeave(object sender, EventArgs e)
        {
            LB_kovetkezo.Font = new Font(LB_kovetkezo.Font.Name, LB_kovetkezo.Font.SizeInPoints, FontStyle.Bold);
        }

        private void LB_vissza_MouseHover(object sender, EventArgs e)
        {
            LB_vissza.Font = new Font(LB_vissza.Font.Name, LB_vissza.Font.SizeInPoints, FontStyle.Underline);
            tip.SetToolTip(LB_vissza, "Ctrl + <-");
            LB_vissza.Cursor = Cursors.Hand;
        }

        private void LB_vissza_MouseLeave(object sender, EventArgs e)
        {
            LB_vissza.Font = new Font(LB_vissza.Font.Name, LB_vissza.Font.SizeInPoints, FontStyle.Bold);
        }

        private void BT_torles_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(BT_torles, "Delete");
        }

        private void LB_frissítes_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(LB_frissítes, "Frissítés\n    'F5'   ");
        }

        private void LB_kereses_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(LB_kereses, "Keresés\n'Ctrl+K'");
        }

        private void LB_aktualis_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(LB_aktualis, "Aktuális időpontok\n        'Ctrl + N'     ");
        }

        private void LB_tisztit_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(LB_tisztit, "Paraméterek törlése\n          'Escape'      ");
        }
    }    
}
