using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fodraszat
{
    public partial class szemelyre_szabas : Form
    {
        string felhnev = default(string);
        string jelszo = default(string);
        int id = default(int);

        design_beallitasok de = new design_beallitasok();
        bejelentkezes be = new bejelentkezes();
        fuggvenyek f = new fuggvenyek();
        csatlakoz cs = new csatlakoz();

        string _rgb_szoveg_alap = "0;0;0";
        string _rgb_hatter_alap = "255;175;175";
        string _rgb_datagrid_hatter_alap = "255;140;140";
        string _rgb_datagrid_paros_hatter_alap = "255;200;200";
        string _rgb_datagrid_gridcolor_alap = "255;140;140";
        string _rgb_datagrid_forecolor_alap = "255;255;255";
        string _rgb_datagrid_kivalasztott_hatter_alap = "255;255;255";
        string _rgb_datagrid_kijelolt_betuszin_alap = "0;0;0;";
        string _betu_stilus_alap = "Century Gothic;15,75;Bold";
        string _jelszo_elrejtesi_karakter_alap = "♥";
        string _fo_hatter = "255;128;128";
        string _alapertelmezett = "1";

        string rgb_szoveg_alap = default(string);
        string rgb_hatter_alap = default(string);
        string rgb_datagrid_hatter_alap = default(string);
        string rgb_datagrid_paros_hatter_alap = default(string);
        string rgb_datagrid_gridcolor_alap = default(string);
        string rgb_datagrid_forecolor_alap = default(string);
        string rgb_datagrid_kivalasztott_hatter_alap = default(string);
        string rgb_datagrid_kijelolt_betuszin_alap = default(string);
        string betu_stilus_alap = default(string);
        string jelszo_elrejtesi_karakter_alap = default(string);
        string fo_hatter = default(string);
        string alapertelmezett = default(string);

        int[] darabolo = new int[3];

        string[] ddarabolo = new string[3];

        public szemelyre_szabas()
        {
            InitializeComponent();
        }

        public szemelyre_szabas(string _felhnev, string _jelszo, int _id, string _alapertelmezett)
        {
            InitializeComponent();
            felhnev = _felhnev;
            jelszo = _jelszo;
            id = _id;
            alapertelmezett = _alapertelmezett;
        }

        private void szemelyre_szabas_Load(object sender, EventArgs e)
        {
            be.kozep();
            LB_üdvözlet.Text = felhnev + " a személyre szabás oldalon vagy!";
            LB_ora.Text = DateTime.Now.ToString("yyyy.MM.dd.\nHH:mm:ss");

            formazasok_betoltese(); //aktuális lekérdezése
            
            string megjelenites = "SELECT id,vendegneve AS 'Vendég neve',Date_Format (proba.idopont,'%y. %m. %d. %H:%i') AS 'Időpontja' FROM proba";
            f.megjelen(megjelenites, DGV_adatok);
        }

        //__________________________________________________________________________________Események

        private void formazasok_betoltese()
        {
            aktualis_lekerdezese();
            
            de.Form_formazasok(alapertelmezett, id,this); //háttér

            de.Label_formazasok(alapertelmezett, id, LB_adatmegjelenito, LB_betustilus, LB_dgv_forecolor, LB_dgv_grid_color, LB_dgv_hatter, LB_dgv_kijelolt_hatter, LB_dgv_kitolto_hatterszin, LB_elemek_szemelyre_szabasa, LB_elrejtesi_karakter, LB_felh, LB_form_hatter, LB_hatter, LB_jelszo, LB_kijelolt_betu, LB_kinezet, LB_kinezet2, LB_ora, LB_szoveg, LB_üdvözlet); //Label

            de.Datagrid_formazasok(alapertelmezett, id, DGV_adatok); //datagridview

            de.Button_formazasok(alapertelmezett, id, BT_alapertelmezett, BT_belepes, BT_kilepes, BT_mentes, BT_regisztracio, BT_talca, BT_vissza); //gombok

            de.Panel_formazasok1(alapertelmezett, id, Panel_platform, P_rejtek); //panel főháttér szín
            de.Panel_formazasok(alapertelmezett, id, Panel_csik); // panel gomb szím

            de.TextBox_formazasok(alapertelmezett, id, TB_felh, TB_jelszo, TB_jelszo_elrejt_kar); // textbox

            de.Jelszo_TextBox_beallitas(alapertelmezett, id, TB_jelszo);

            de.CheckBox_formazasok(alapertelmezett, id, CB_felhasznalonev);

            P_1.BackColor = Color.FromArgb(szin_darabolo(fo_hatter)[0], szin_darabolo(fo_hatter)[1], szin_darabolo(fo_hatter)[2]);
            P_2.BackColor = Color.FromArgb(szin_darabolo(rgb_szoveg_alap)[0], szin_darabolo(rgb_szoveg_alap)[1], szin_darabolo(rgb_szoveg_alap)[2]); 
            P_3.BackColor = Color.FromArgb(szin_darabolo(rgb_hatter_alap)[0], szin_darabolo(rgb_hatter_alap)[1], szin_darabolo(rgb_hatter_alap)[2]);
            TB_jelszo_elrejt_kar.Text = jelszo_elrejtesi_karakter_alap;
            P_4.BackColor = Color.FromArgb(szin_darabolo(rgb_datagrid_hatter_alap)[0], szin_darabolo(rgb_datagrid_hatter_alap)[1], szin_darabolo(rgb_datagrid_hatter_alap)[2]);
            P_5.BackColor = Color.FromArgb(szin_darabolo(rgb_datagrid_paros_hatter_alap)[0], szin_darabolo(rgb_datagrid_paros_hatter_alap)[1], szin_darabolo(rgb_datagrid_paros_hatter_alap)[2]);
            P_6.BackColor = Color.FromArgb(szin_darabolo(rgb_datagrid_forecolor_alap)[0], szin_darabolo(rgb_datagrid_forecolor_alap)[1], szin_darabolo(rgb_datagrid_forecolor_alap)[2]);
            P_7.BackColor = Color.FromArgb(szin_darabolo(rgb_datagrid_gridcolor_alap)[0], szin_darabolo(rgb_datagrid_gridcolor_alap)[1], szin_darabolo(rgb_datagrid_gridcolor_alap)[2]);
            P_8.BackColor = Color.FromArgb(szin_darabolo(rgb_datagrid_kivalasztott_hatter_alap)[0], szin_darabolo(rgb_datagrid_kivalasztott_hatter_alap)[1], szin_darabolo(rgb_datagrid_kivalasztott_hatter_alap)[2]);
            P_9.BackColor = Color.FromArgb(szin_darabolo(rgb_datagrid_kijelolt_betuszin_alap)[0], szin_darabolo(rgb_datagrid_kijelolt_betuszin_alap)[1], szin_darabolo(rgb_datagrid_kijelolt_betuszin_alap)[2]);
            System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
            float size = float.Parse(betu_stilus_alap.Split(';')[1]);
            System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true); 
            Font_D.Font = new Font(fa,size,f);
        }

        private int[] szin_darabolo(string szin)
        {
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = szin.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            return darabolo;
        }

        private void aktualis_lekerdezese()
        {
            string lekerdezes = "SELECT `form_hatter`, `rgb_szoveg`, `rgb_hatter`, `rgb_datagrid_hatter`, `rgb_datagrid_gridcolor`, `rgb_datagrid_forecolor`, `rgb_datagrid_kivalasztott_hatter`, `rgb_datagrid_kijelolt_betuszin`, `rgb_datagrid_paros_sorok_szin`, `betu_stilus`, `jelszo_elrejtesi_karakter`, `fodrasz_az`, `alapertelmezett` FROM `beallitasok` WHERE fodrasz_az ='" + id + "'";

            try
            {
                cs.kapcs.Open();
                cs.parancs.Connection = cs.kapcs;
                cs.parancs.CommandText = lekerdezes;
                MySqlDataReader olvas = cs.parancs.ExecuteReader();

                while (olvas.Read())    //beolvas amíg     
                {
                    fo_hatter = olvas.GetString(0);
                    rgb_szoveg_alap = olvas.GetString(1);
                    rgb_hatter_alap = olvas.GetString(2);
                    rgb_datagrid_hatter_alap = olvas.GetString(3);
                    rgb_datagrid_gridcolor_alap = olvas.GetString(4);
                    rgb_datagrid_forecolor_alap = olvas.GetString(5);
                    rgb_datagrid_kivalasztott_hatter_alap = olvas.GetString(6);
                    rgb_datagrid_kijelolt_betuszin_alap = olvas.GetString(7);
                    rgb_datagrid_paros_hatter_alap = olvas.GetString(8);
                    betu_stilus_alap = olvas.GetString(9);
                    jelszo_elrejtesi_karakter_alap = olvas.GetString(10);
                    alapertelmezett = olvas.GetString(12);
                }
                olvas.Close();
                cs.kapcs.Close();
            }
            catch { System.Windows.Forms.MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba,személyre szabásnál!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); } //hibaüzenet
            finally { cs.kapcs.Close(); } //kapcsolat lezárása

            if (fo_hatter == default(string))
            {
                fo_hatter = _fo_hatter;
                rgb_szoveg_alap = _rgb_szoveg_alap;
                rgb_hatter_alap = _rgb_hatter_alap;
                rgb_datagrid_hatter_alap = _rgb_datagrid_hatter_alap;
                rgb_datagrid_gridcolor_alap = _rgb_datagrid_gridcolor_alap;
                rgb_datagrid_forecolor_alap = _rgb_datagrid_forecolor_alap;
                rgb_datagrid_kivalasztott_hatter_alap = _rgb_datagrid_kivalasztott_hatter_alap;
                rgb_datagrid_kijelolt_betuszin_alap = _rgb_datagrid_kijelolt_betuszin_alap;
                rgb_datagrid_paros_hatter_alap = _rgb_datagrid_paros_hatter_alap;
                betu_stilus_alap = _betu_stilus_alap;
                jelszo_elrejtesi_karakter_alap = _jelszo_elrejtesi_karakter_alap;
                alapertelmezett = _alapertelmezett;
            }
            TB_jelszo_elrejt_kar.Text = jelszo_elrejtesi_karakter_alap;
        }

        private void DGV_adatok_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.DGV_adatok.Columns[0].Visible = false;
        }
        //_________________________________________________________________________________GOMBOK
        private void BT_talca_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

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

        private void BT_vissza_Click(object sender, EventArgs e)
        {
            adatkezeles at = new adatkezeles(id, felhnev, jelszo, alapertelmezett);
            at.Show();
            this.Close();
        }

        private void BT_mentes_Click(object sender, EventArgs e)
        {          
            if(rgb_szoveg_alap ==default(string))
            {
                rgb_szoveg_alap = _rgb_szoveg_alap;
            }
            if (rgb_hatter_alap == default(string))
            {
                rgb_hatter_alap = _rgb_hatter_alap;
            }
            if (rgb_datagrid_hatter_alap == default(string))
            {
                rgb_datagrid_hatter_alap = _rgb_datagrid_hatter_alap;
            }

            if (rgb_datagrid_paros_hatter_alap == default(string))
            {
                rgb_datagrid_paros_hatter_alap = _rgb_datagrid_paros_hatter_alap;
            }

            if (rgb_datagrid_gridcolor_alap == default(string))
            {
                rgb_datagrid_gridcolor_alap = _rgb_datagrid_gridcolor_alap;
            }

            if (rgb_datagrid_forecolor_alap == default(string))
            {
                rgb_datagrid_forecolor_alap = _rgb_datagrid_forecolor_alap;
            }

            if (rgb_datagrid_kivalasztott_hatter_alap == default(string))
            {
                rgb_datagrid_kivalasztott_hatter_alap = _rgb_datagrid_kivalasztott_hatter_alap;
            }

            if (rgb_datagrid_kijelolt_betuszin_alap == default(string))
            {
                rgb_datagrid_kijelolt_betuszin_alap = _rgb_datagrid_kijelolt_betuszin_alap;
            }
            if (betu_stilus_alap == default(string))
            {
                betu_stilus_alap = _betu_stilus_alap;
            }

            if (jelszo_elrejtesi_karakter_alap == default(string) || jelszo_elrejtesi_karakter_alap =="")
            {
                jelszo_elrejtesi_karakter_alap = _jelszo_elrejtesi_karakter_alap;
            }
            if (fo_hatter == default(string))
            {
                fo_hatter = _fo_hatter;
            }

            string feltoltes = @"Select * FROM beallitasok WHERE fodrasz_az = '" + id + "'";
            string uzenet;
            string uzenet2;
            if (!f.van_e_ilyen_adat(feltoltes))
            {
                 feltoltes = @"INSERT INTO `beallitasok`(`form_hatter`, `rgb_szoveg`, `rgb_hatter`, `rgb_datagrid_hatter`, `rgb_datagrid_gridcolor`, `rgb_datagrid_forecolor`, `rgb_datagrid_kivalasztott_hatter`, `rgb_datagrid_kijelolt_betuszin`, `rgb_datagrid_paros_sorok_szin`, `betu_stilus`, `jelszo_elrejtesi_karakter`, `fodrasz_az`, `alapertelmezett`) VALUES( '" + fo_hatter + "', '" + rgb_szoveg_alap + "','" + rgb_hatter_alap + "', '" + rgb_datagrid_hatter_alap + "', '" + rgb_datagrid_gridcolor_alap + "', '" +rgb_datagrid_forecolor_alap + "', '" + rgb_datagrid_kivalasztott_hatter_alap + "', '" + rgb_datagrid_kijelolt_betuszin_alap + "', '" + rgb_datagrid_paros_hatter_alap + "', '" + betu_stilus_alap + "', '" + jelszo_elrejtesi_karakter_alap + "', '" + id+ "', '0')";
                uzenet = "Sikeres feltöltés!";
                uzenet2 = "Feltöltés";
            }
            else
            {
                // feltoltes = @"UPDATE `beallitasok` SET `form_hatter`= '" + fo_hatter + "', `rgb_szoveg`= '" + rgb_szoveg_alap + "', `rgb_hatter` = '" + rgb_hatter_alap + "',`rgb_datagrid_hatter`= '" + rgb_datagrid_hatter_alap + "',`rgb_datagrid_forecolor`= '" + rgb_datagrid_forecolor_alap+ "',`rgb_datagrid_kivalasztott_hatter`= '" + rgb_datagrid_kivalasztott_hatter_alap + "',`rgb_datagrid_kijelolt_betuszin`= '" + rgb_datagrid_kijelolt_betuszin_alap + "',`rgb_daragrid_paros_sorok_szin`= '" + rgb_datagrid_paros_hatter_alap + "',`betu_stilus`= '" + betu_stilus_alap + "',`jelszo_elrejtesi_karakter`= '" + jelszo_elrejtesi_karakter_alap + "',`fodrasz_az`= '" + id + "',`alapertelmezett`= '0' WHERE `fodrasz_az`=" + id+ ";";
                 feltoltes = @"UPDATE `beallitasok` SET `form_hatter`='" + fo_hatter + "', `rgb_szoveg`='" + rgb_szoveg_alap + "',`rgb_hatter`='" + rgb_hatter_alap + "',`rgb_datagrid_hatter`='" + rgb_datagrid_hatter_alap + "',`rgb_datagrid_gridcolor`='" + rgb_datagrid_gridcolor_alap + "',`rgb_datagrid_forecolor`='" + rgb_datagrid_forecolor_alap + "',`rgb_datagrid_kivalasztott_hatter`='" + rgb_datagrid_kivalasztott_hatter_alap + "',`rgb_datagrid_kijelolt_betuszin`='" + rgb_datagrid_kijelolt_betuszin_alap + "',`rgb_datagrid_paros_sorok_szin`='" + rgb_datagrid_paros_hatter_alap + "',`betu_stilus`='" + betu_stilus_alap + "',`jelszo_elrejtesi_karakter`='" + jelszo_elrejtesi_karakter_alap + "',`fodrasz_az`='" + id + "',`alapertelmezett`= '0' WHERE `fodrasz_az`=" + id + ";";
                uzenet = "Sikeres módosítás!";
                uzenet2 = "Módosítás";
            }
           // System.Windows.Forms.Clipboard.SetDataObject(feltoltes, true);

            f.adat_kezeles(feltoltes);
            formazasok_betoltese();
            MessageBox.Show(uzenet, uzenet2, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BT_alapertelmezett_Click(object sender, EventArgs e)
        {
            aktualis_lekerdezese();
            string feltoltes = @"UPDATE `beallitasok` SET `form_hatter`='" + fo_hatter + "', `rgb_szoveg`='" + rgb_szoveg_alap + "',`rgb_hatter`='" + rgb_hatter_alap + "',`rgb_datagrid_hatter`='" + rgb_datagrid_hatter_alap + "',`rgb_datagrid_gridcolor`='" + rgb_datagrid_gridcolor_alap + "',`rgb_datagrid_forecolor`='" + rgb_datagrid_forecolor_alap + "',`rgb_datagrid_kivalasztott_hatter`='" + rgb_datagrid_kivalasztott_hatter_alap + "',`rgb_datagrid_kijelolt_betuszin`='" + rgb_datagrid_kijelolt_betuszin_alap + "',`rgb_datagrid_paros_sorok_szin`='" + rgb_datagrid_paros_hatter_alap + "',`betu_stilus`='" + betu_stilus_alap + "',`jelszo_elrejtesi_karakter`='" + jelszo_elrejtesi_karakter_alap + "',`fodrasz_az`='" + id + "',`alapertelmezett`= '1' WHERE `fodrasz_az`=" + id + ";";
            string uzenet = "Sikeres alapértelmezett helyzetbe állítás!";
            string uzenet2 = "Alapértelmezett helyzet";
            f.adat_kezeles(feltoltes);            
            formazasok_betoltese();
            MessageBox.Show(uzenet, uzenet2, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //__________________________________________________________________________________Időzítők

        private void T_ora_Tick(object sender, EventArgs e)
        {
            LB_ora.Text = DateTime.Now.ToString("yyyy.MM.dd.\nHH:mm:ss");
        }

        //__________________________________________________________________________________Textbox események

        private void TB_jelszo_elrejt_kar_TextChanged(object sender, EventArgs e)
        {
            string seged = TB_jelszo_elrejt_kar.Text;
            if (seged != "")
            {

                TB_jelszo.PasswordChar = Convert.ToChar(seged);
                jelszo_elrejtesi_karakter_alap = TB_jelszo_elrejt_kar.Text;
            }
            else
            {
                TB_jelszo.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id, TB_jelszo));
                jelszo_elrejtesi_karakter_alap = TB_jelszo_elrejt_kar.Text;
            }

        }

        private void TB_jelszo_MouseHover(object sender, EventArgs e)
        {
            TB_jelszo.PasswordChar = '\0';
        }

        private void TB_jelszo_MouseLeave(object sender, EventArgs e)
        {
            if (TB_jelszo_elrejt_kar.TextLength == 0)
            {
                TB_jelszo.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id, TB_jelszo));
            }
            else
            {
                string seged = TB_jelszo_elrejt_kar.Text;
                if (seged != "")
                {
                    TB_jelszo.PasswordChar = Convert.ToChar(seged);
                }
            }
        }

        private Color Color_D_szine(Color szin, ColorDialog col)
        {
            col.Color = szin;
            return szin;
        }
        //__________________________________________________________________________________Label események

        private void LB_form_hatter_Click(object sender, EventArgs e)
        {
            Color_D_szine(P_1.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                Panel_hatter.BackColor = Color_D.Color;
                P_1.BackColor = Color_D.Color;
                fo_hatter = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }
        }

        private void LB_szoveg_Click(object sender, EventArgs e)
        {
            Color_D_szine(P_2.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                P_2.BackColor = Color_D.Color;
                LB_felh.ForeColor = Color_D.Color;
                LB_jelszo.ForeColor = Color_D.Color;
                TB_felh.ForeColor = Color_D.Color;
                TB_jelszo.ForeColor = Color_D.Color;
                CB_felhasznalonev.ForeColor = Color_D.Color;
                BT_belepes.ForeColor = Color_D.Color;
                BT_regisztracio.ForeColor = Color_D.Color;
                rgb_szoveg_alap = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }
        }

        private void LB_hatter_Click(object sender, EventArgs e)
        {
            Color_D_szine(P_3.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                P_3.BackColor = Color_D.Color;
                TB_felh.BackColor = Color_D.Color;
                TB_jelszo.BackColor = Color_D.Color;
                BT_belepes.BackColor = Color_D.Color;
                BT_regisztracio.BackColor = Color_D.Color;
                rgb_hatter_alap = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }
        }

        private void LB_betustilus_Click(object sender, EventArgs e)
        {
            if (Font_D.ShowDialog() == DialogResult.OK)
            {
                LB_felh.Font = Font_D.Font;
                LB_jelszo.Font = Font_D.Font;
                TB_felh.Font = Font_D.Font;
                TB_jelszo.Font = Font_D.Font;
                CB_felhasznalonev.Font = Font_D.Font;
                BT_belepes.Font = Font_D.Font;
                BT_regisztracio.Font = Font_D.Font;
                betu_stilus_alap = Convert.ToString(Font_D.Font.Name) + ";" + Convert.ToString(Font_D.Font.Size) + ";" + Convert.ToString(Font_D.Font.Style);
                DGV_adatok.AlternatingRowsDefaultCellStyle.Font = Font_D.Font;
                DGV_adatok.ColumnHeadersDefaultCellStyle.Font = Font_D.Font;
                DGV_adatok.DefaultCellStyle.Font = Font_D.Font;
                DGV_adatok.RowHeadersDefaultCellStyle.Font = Font_D.Font;
                DGV_adatok.Font = Font_D.Font;
            }
        }

        private void LB_dgv_kitolto_hatterszin_Click(object sender, EventArgs e)
        {
            Color_D_szine(P_4.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                P_4.BackColor = Color_D.Color;
                DGV_adatok.BackgroundColor = Color_D.Color;
                DGV_adatok.AlternatingRowsDefaultCellStyle.BackColor = Color_D.Color;
                DGV_adatok.ColumnHeadersDefaultCellStyle.BackColor = Color_D.Color;
                DGV_adatok.RowHeadersDefaultCellStyle.BackColor = Color_D.Color;
                rgb_datagrid_hatter_alap = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }

        }

        private void LB_dgv_hatter_Click(object sender, EventArgs e)
        {
            //PÁros sorok
            Color_D_szine(P_5.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                P_5.BackColor = Color_D.Color;
                DGV_adatok.DefaultCellStyle.BackColor = Color_D.Color;
                rgb_datagrid_paros_hatter_alap = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }
        }

        private void LB_dgv_forecolor_Click(object sender, EventArgs e)
        {
            Color_D_szine(P_6.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                P_6.BackColor = Color_D.Color;
                DGV_adatok.ForeColor = Color_D.Color;
                DGV_adatok.AlternatingRowsDefaultCellStyle.ForeColor = Color_D.Color;
                DGV_adatok.ColumnHeadersDefaultCellStyle.ForeColor = Color_D.Color;
                DGV_adatok.DefaultCellStyle.ForeColor = Color_D.Color;
                DGV_adatok.RowHeadersDefaultCellStyle.ForeColor = Color_D.Color;
                rgb_datagrid_forecolor_alap = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }
        }

        private void LB_dgv_grid_color_Click(object sender, EventArgs e)
        {
            Color_D_szine(P_7.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                P_7.BackColor = Color_D.Color;
                DGV_adatok.GridColor = Color_D.Color;
                rgb_datagrid_gridcolor_alap = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }
        }

        private void LB_dgv_kijelolt_hatter_Click(object sender, EventArgs e)
        {
            Color_D_szine(P_8.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                P_8.BackColor = Color_D.Color;
                DGV_adatok.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color_D.Color;
                DGV_adatok.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color_D.Color;
                DGV_adatok.DefaultCellStyle.SelectionBackColor = Color_D.Color;
                DGV_adatok.RowHeadersDefaultCellStyle.SelectionBackColor = Color_D.Color;
                rgb_datagrid_kivalasztott_hatter_alap = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }
         }

        private void LB_kijelolt_betu_Click(object sender, EventArgs e)
        {
            Color_D_szine(P_9.BackColor, Color_D);
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                P_9.BackColor = Color_D.Color;
                DGV_adatok.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color_D.Color;
                DGV_adatok.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color_D.Color;
                DGV_adatok.DefaultCellStyle.SelectionForeColor = Color_D.Color;
                DGV_adatok.RowHeadersDefaultCellStyle.SelectionForeColor = Color_D.Color;
                rgb_datagrid_kijelolt_betuszin_alap = Convert.ToString(Color_D.Color.R) + ";" + Convert.ToString(Color_D.Color.G) + ";" + Convert.ToString(Color_D.Color.B);
            }
            }

        //___________________________________________________________________________________Mouse hover/leave
        private void LB_form_hatter_MouseHover(object sender, EventArgs e)
        {
           LB_form_hatter.Font = new Font(LB_form_hatter.Font.Name, LB_form_hatter.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_form_hatter_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_form_hatter);
        }

        private void LB_szoveg_MouseHover(object sender, EventArgs e)
        {
            LB_szoveg.Font = new Font(LB_szoveg.Font.Name, LB_szoveg.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_szoveg_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_szoveg);
        }

        private void LB_hatter_MouseHover(object sender, EventArgs e)
        {
            LB_hatter.Font = new Font(LB_hatter.Font.Name, LB_hatter.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_hatter_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_hatter);
        }

        private void LB_betustilus_MouseHover(object sender, EventArgs e)
        {
            LB_betustilus.Font = new Font(LB_betustilus.Font.Name, LB_betustilus.Font.SizeInPoints, FontStyle.Underline);

        }

        private void LB_betustilus_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_betustilus);
        }

        private void LB_elrejtesi_karakter_MouseHover(object sender, EventArgs e)
        {
            LB_elrejtesi_karakter.Font = new Font(LB_elrejtesi_karakter.Font.Name, LB_elrejtesi_karakter.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_elrejtesi_karakter_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_elrejtesi_karakter);
        }

        private void LB_dgv_kitolto_hatterszin_MouseHover(object sender, EventArgs e)
        {
            LB_dgv_kitolto_hatterszin.Font = new Font(LB_dgv_kitolto_hatterszin.Font.Name, LB_dgv_kitolto_hatterszin.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_dgv_kitolto_hatterszin_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_dgv_kitolto_hatterszin);
        }

        private void LB_dgv_hatter_MouseHover(object sender, EventArgs e)
        {
            LB_dgv_hatter.Font = new Font(LB_dgv_hatter.Font.Name, LB_dgv_hatter.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_dgv_hatter_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_dgv_hatter);
        }

        private void LB_dgv_forecolor_MouseHover(object sender, EventArgs e)
        {
            LB_dgv_forecolor.Font = new Font(LB_dgv_forecolor.Font.Name, LB_dgv_forecolor.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_dgv_forecolor_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_dgv_forecolor);
        }

        private void LB_dgv_grid_color_MouseHover(object sender, EventArgs e)
        {
            LB_dgv_grid_color.Font = new Font(LB_dgv_grid_color.Font.Name, LB_dgv_grid_color.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_dgv_grid_color_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_dgv_grid_color);
        }

        private void LB_dgv_kijelolt_hatter_MouseHover(object sender, EventArgs e)
        {
            LB_dgv_kijelolt_hatter.Font = new Font(LB_dgv_kijelolt_hatter.Font.Name, LB_dgv_kijelolt_hatter.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_dgv_kijelolt_hatter_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_dgv_kijelolt_hatter);
        }

        private void LB_kijelolt_betu_MouseHover(object sender, EventArgs e)
        {
            LB_kijelolt_betu.Font = new Font(LB_kijelolt_betu.Font.Name, LB_kijelolt_betu.Font.SizeInPoints, FontStyle.Underline);
        }

        private void LB_kijelolt_betu_MouseLeave(object sender, EventArgs e)
        {
            de.Label_formazasok(alapertelmezett, id, LB_kijelolt_betu);
        }
    }
}
