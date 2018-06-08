using System;
using System.Drawing;
using System.Windows.Forms;

namespace fodraszat
{
    public partial class tipus_kezeles : Form
    {
        public tipus_kezeles()
        {
            InitializeComponent();
        }
        int id = default(int);
        string felhnev = default(string);
        string jelszo = default(string);
        string alapertelmezett = default(string);

        bool teszt = default(bool);

        int szamlalo = default(int);
        bool hiba = default(bool);
        string uz = default(string);

        adatkezeles be;
        fuggvenyek f = new fuggvenyek();
        ToolTip tip = new ToolTip();
        design_beallitasok de = new design_beallitasok();
       
        public tipus_kezeles(int _id,string _felhnev,string _jelszo,string _alapertelmezett, adatkezeles _be)
        {
            InitializeComponent();
            id = _id;
            felhnev = _felhnev;
            jelszo = _jelszo;
            alapertelmezett = _alapertelmezett;
            be = _be;
        }

        private void tipus_hozzáadás_Load(object sender, EventArgs e)
        {            
            LB_üdvözlet.Text = felhnev + " a tevékenységek típusa kezelő oldalon vagy!";
            LB_ora.Text = DateTime.Now.ToString("yyyy.MM.dd.  HH:mm:ss");

            if (f.vanewamp())
            {
                megjelenites();
                formazasok_betoltese();
            }
            else
            {
                LB_hiba_uzenet.Text = "A wampserver nem online!";
                szamlalo = 0;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
            }


        }

        //_____________________________________________________________________________________Főbb események

        private void megjelenites()
        {
            string lekerdezes = "Select tipus_ar.id,tipus_ar.tipus AS 'Hajvágás típusa',tipus_ar.ar AS 'Hajvágás ára',Date_Format (tipus_ar.idotartam,'%H:%i') AS 'Időtartam' FROM tipus_ar WHERE tipus_ar.fodrasz_az = '" + id +"'";
            f.megjelen(lekerdezes, DGV_adatok);
            tisztít();            
        }

        private void feltoltes()
        {
            
            LB_hiba_uzenet.Visible = false;
            T_idozito2.Enabled = true;         
            if (adat_seged())
            {
                string idopont_seged = TB_ora.Text + ":" + TB_perc.Text;
                string feltoltes = @"INSERT INTO tipus_ar(`tipus`,`ar`,`idotartam`,`fodrasz_az`) VALUES( '" + TB_tipus.Text + "', '" + TB_ar.Text + "','" + TB_ora.Text + ":" + TB_perc.Text + "','" + id + "')";
                f.adat_kezeles(feltoltes);
                megjelenites();
            }  
        }

        private void modositas()
        {
            if (adat_seged())
            {
                try
                {
                    string tipus = "[" + DGV_adatok.CurrentRow.Cells[1].Value.ToString() + "] típust?";
                    string modositas = @"UPDATE `tipus_ar` SET `tipus`= '" + TB_tipus.Text + "', `ar`= '" + TB_ar.Text + "', `idotartam`= '" + TB_ora.Text + ":" + TB_perc.Text + ":00' WHERE `id`=" + TB_id.Text + ";";
                    //System.Windows.Forms.Clipboard.SetDataObject(modositas, true);

                    DialogResult dialogResult = MessageBox.Show(felhnev + " biztosan módosítani akarod a(z) " + tipus, "Módosítás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        f.adat_kezeles(modositas);
                        megjelenites();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                    LB_hiba_uzenet.Visible = false;
                }
                catch { MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet
            }
        }

        private void torles()
        {
            uz = default(string);
           
            if (TB_id.Text =="")
            {
                hiba = true;
                uz = "Nincs kijelölve adat!";
                T_idozito.Start();
                T_idozito2.Start();
            }
            else
            {   
            if (torolheto_e())
            {
                try
                {
                    string tipus = "["+DGV_adatok.CurrentRow.Cells[1].Value.ToString() + "] típust?";
                    string feltoltes = @"DELETE FROM  `tipus_ar` Where `id` ='" + TB_id.Text + "'";
                    DialogResult dialogResult = MessageBox.Show(felhnev + " biztosan törölni akarod a(z) " + tipus, "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        

                        f.adat_kezeles(feltoltes);
                        megjelenites();
                        uz = "törlés!";
                        hiba = false;
                        T_idozito.Start();
                        T_idozito2.Start();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                    LB_hiba_uzenet.Visible = false;
                }
                catch { MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet
            }
            else
            {
                try
                {
                    string tipus = "["+DGV_adatok.CurrentRow.Cells[1].Value.ToString() + "] típus";
                    string feltoltes = @"DELETE FROM  `tipus_ar` Where `id` ='" + TB_id.Text + "'";
                    string feltoltes2 = @"DELETE FROM `foglalas` WHERE `tipus_az` ='" + TB_id.Text + "'";
                    DialogResult dialogResult = MessageBox.Show(felhnev + " a(z) " + tipus+ " használatban van az adatbázisban, ha törlöd, az összes hozzá kapcsolódó adatod elveszik!\nBiztosan törölni akarod?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        f.adat_kezeles(feltoltes);
                        f.adat_kezeles(feltoltes2);                         
                        megjelenites();
                        uz = "törlés!";
                        hiba = false;
                        T_idozito.Start();
                        T_idozito2.Start();
                        }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                    LB_hiba_uzenet.Visible = false;
                }
                catch { MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet
            }
            }
        }

        private bool torolheto_e()
        {
            string feltoltes = @"SELECT * FROM  `foglalas` Where `tipus_az` ='" + TB_id.Text + "'";
           // System.Windows.Forms.Clipboard.SetDataObject(feltoltes, true);

            if (f.van_e_ilyen_adat(feltoltes))
            {
                return false;
                
            }
            else
            {
                return true;
                
            }
            
        }

        private void tisztít()
        {

            TB_ora.Text = "";
            TB_perc.Text = "";
            TB_tipus.Text = "";
            TB_ar.Text = "";
            TB_id.Text = "";
            hiba = false;
            uz = "";
            T_idozito2.Start();
        }

        private void formazasok_betoltese()
        {
            de.Form_formazasok(alapertelmezett, id,this); //háttér

            de.Button_formazasok(alapertelmezett, id, BT_feltoltes, BT_kilepes, BT_modositas, BT_talca, BT_torles, BT_vissza);

            de.Label_formazasok(alapertelmezett, id, LB_ar, LB_felirat, LB_hiba_uzenet, LB_idotartam, LB_ora, LB_oraa, LB_perc, LB_tipus, LB_üdvözlet); // Label

            de.Panel_formazasok(alapertelmezett, id, P_1); //panel

            de.TextBox_formazasok(alapertelmezett, id, TB_ar, TB_id, TB_ora, TB_perc, TB_tipus);//textbox

            de.Datagrid_formazasok(alapertelmezett, id, DGV_adatok);
            LB_oraa.Size = new Size(LB_oraa.Width, TB_ora.Height);
            LB_perc.Size = new Size(LB_perc.Width, TB_ora.Height);
        }

        //________________________________________________________________________________Datagridview események

        private void DGV_adatok_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.DGV_adatok.Columns[0].Visible = false;
        }

        private void DGV_adatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string seged = DGV_adatok.CurrentRow.Cells[3].Value.ToString();

                string[] seged2 = seged.Split(':');
                TB_id.Text = DGV_adatok.CurrentRow.Cells[0].Value.ToString(); 
                TB_tipus.Text = DGV_adatok.CurrentRow.Cells[1].Value.ToString();
                TB_ar.Text = DGV_adatok.CurrentRow.Cells[2].Value.ToString();
                TB_ora.Text = seged2[0];
                TB_perc.Text = seged2[1];
            }
            catch { }
        }

        private void DGV_adatok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BT_torles.PerformClick();
            }
        }

        //_________________________________________________________________________________________Gombok
        private void BT_kilepes_Click(object sender, EventArgs e)
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

        private void BT_talca_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BT_vissza_Click(object sender, EventArgs e)
        {
            adatkezeles at = new adatkezeles(id, felhnev, jelszo,alapertelmezett,this);
            at.Show();
            this.Close();

        }

        private void BT_feltoltes_Click(object sender, EventArgs e)
        {
            uz = default(string);
            hiba = false;
            string lekerdezes = "SELECT tipus_ar.tipus FROM tipus_ar WHERE tipus_ar.tipus = '"+ TB_tipus.Text+"' AND tipus_ar.fodrasz_az ='"+id+"'";
            if (!f.van_e_ilyen_adat(lekerdezes))
            {
                feltoltes();
                uz = "feltöltés!";
                T_idozito.Start();
                T_idozito2.Start();
            }
            else
            {
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
                LB_hiba_uzenet.Text = "Ez a típus név már foglalt!";
                hiba = true;
            }
            
        }

        private void BT_modositas_Click(object sender, EventArgs e)
        {
            uz = default(string);
            hiba = false;
            string lekerdezes = "SELECT tipus_ar.tipus FROM tipus_ar WHERE not (tipus_ar.id = '" + TB_id.Text + "') AND tipus_ar.tipus = '" + TB_tipus.Text + "' AND tipus_ar.fodrasz_az='"+id+"'";
            // System.Windows.Forms.Clipboard.SetDataObject(lekerdezes, true);

            if (!f.van_e_ilyen_adat(lekerdezes))
            {
                modositas();
                uz = "módosítás!";
                T_idozito.Start();
                T_idozito2.Start();
            }
            else
            {
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
                LB_hiba_uzenet.Text = "Ez a típus név már foglalt!";
                hiba = true;
            }
        }

        private void BT_torles_Click(object sender, EventArgs e)
        {
            torles();
        }
        //____________________________________________________________________________________________________

        //_______________________________________________________________________________________Egyéb

        private bool adat_seged()
        {

        
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
                T_idozito2.Enabled = true;
                return false;
            }
            else
            {
                if (TB_tipus.Text != "" && TB_ar.Text != "" && TB_perc.Text != "")
                {
                    if(TB_perc.Text.Length==1)
                    {
                        TB_perc.Text = "0" + TB_perc.Text;
                    }
                    if(TB_ora.Text =="")
                    {
                        TB_ora.Text = "00";                       
                    }
                    return true;
                }
                else if (TB_tipus.Text != "" && TB_ar.Text != "" && TB_ora.Text != "")
                {
                    if (TB_ora.Text.Length ==1)
                    {
                        TB_ora.Text = "0"+TB_ora.Text;
                    }
                    if (TB_perc.Text == "")
                    {
                        TB_perc.Text = "00";                        
                    }
                    return true;
                }
                else
                {
                    hiba = true;
                    T_idozito.Enabled = true;
                    T_idozito2.Enabled = true;
                    LB_hiba_uzenet.Text = "Töltsd ki a hiányzó mezőket!";
                    return false;
                }
            }
        }

        //__________________________________________________________________________________Időzítők

        private void T_ora_Tick(object sender, EventArgs e)
        {
            LB_ora.Text = DateTime.Now.ToString("yyyy.MM.dd.  HH:mm:ss");
        }

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
             if (uz =="Nincs kijelölve adat!" && hiba == true)
            {
                LB_hiba_uzenet.Text = uz;
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
                this.Size = new Size(800, 650);
            }
            else
            {
                this.Size = new Size(800, 565);
            }
            T_idozito2.Enabled = false;
        }
        //____________________________________________________________________________________textchanged

        private void TB_ora_TextChanged(object sender, EventArgs e)
        {
            f.ora(TB_ora);
            f.szam_tb(TB_ora);
            if (TB_ora.TextLength == 2 && TB_ora.Focused)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TB_perc_TextChanged(object sender, EventArgs e)
        {
            f.perc(TB_perc);
            f.szam_tb(TB_perc);
            if (TB_perc.TextLength == 2 && TB_perc.Focused)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TB_tipus_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_tipus);
            f.TB_elso_betu_mindig_nagybetu(TB_tipus);
        }

        private void TB_ar_TextChanged(object sender, EventArgs e)
        {
            f.szam_tb(TB_ar);
        }

        //_______________________________________________________________________________Egér esemény
        private void BT_torles_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(BT_torles, "Delete");
        }

        //________________________________________________________________________________Label click
        private void LB_tisztit_Click(object sender, EventArgs e)
        {
            tisztít();
        }
    }
}
