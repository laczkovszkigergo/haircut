using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fodraszat
{
    public partial class bejelentkezes : Form
    {
        public bejelentkezes()
        {
            InitializeComponent();
        }
        ToolTip tt = new ToolTip();

        bool kapcsolat = default(bool);
        string felhnev = default(string);
        string jelszo = default(string);
        int id = default(int);
        int iid = 0;
        string alapertelmezett = default(string);

        public bejelentkezes(string _alapertelmezett,int _id)
        {
            InitializeComponent();
            alapertelmezett = _alapertelmezett;
            id = _id;
        }

        bool hiba = default(bool);
        bool teszt = default(bool);

        int szamlalo = default(int);

        List<string> adatok = new List<string>();

        csatlakoz cs = new csatlakoz();
        fuggvenyek f = new fuggvenyek();
        design_beallitasok de = new design_beallitasok();
      
        private void bejelentkezes_Load(object sender, EventArgs e)
        {
            List<string> adatok = new List<string>();
            adatok.Clear();
            LB_felirat.Text = "Fodrászat   " + DateTime.Now.ToString("HH:mm:ss");
            try
            {
                string lekerdezes = "SELECT felhasznalo FROM felhasznalo_mentese";
                if (f.van_e_ilyen_adat(lekerdezes))
                {
                    CB_felhasznalonev.Checked = true;
                    TB_jelszo.Select();
                    TB_felh.Text = f.egy_adat_lekerdezese(lekerdezes);
                }
            }
            catch { }

            kozep();
            teszt = f.vanewamp();
            ellenorzes(); // formazasok_betoltese(); ide van meghívva
            T_ora.Enabled = true;
            TB_jelszo_admin.Text = "ADMIN";
            TB_felh_admin.Text = "ADMIN";
        }

        private void beolvasas_feltolteshez()
        {
            adatok.Clear();
            try
            {
                adatok.Add("1\tScholtz Tibor\t2018.06.10. 12:55");
                adatok.Add("2\tIgonda Péter\t2018.06.11. 10:40");
                adatok.Add("3\tGrajzel Zsanett\t2018.06.12. 12:30");
                adatok.Add("4\tMészáros Milán\t2018.06.13. 14:32");
                adatok.Add("5\tPéter Attila\t2018.06.15. 12:25");
                adatok.Add("6\tLieszkovszki Kinga\t2018.07.01. 09:30");
                adatok.Add("7\tKiss Dóra\t2018.07.02. 10:20");
                adatok.Add("8\tJudith T Jasmine\t2018.07.11. 12:30");
                adatok.Add("9\tDinka Anasztázia\t2018.07.20. 19:30");
                adatok.Add("10\tPécsi Stella Sybille\t2018.07.23. 18:50");
                for (int i = 0; i < adatok.Count; i++)
                {
                    string lekerdezes = "INSERT INTO proba(`id`,`vendegneve`,`idopont`) VALUES('" + adatok[i].Split('\t')[0] + "', '" + adatok[i].Split('\t')[1] + "', '" + adatok[i].Split('\t')[2] + "')";
                    f.adat_kezeles(lekerdezes);                    
                }
            }
            catch { MessageBox.Show("Nem sikerült feltölteni a próba adatokat!", "Sikertelen beolvasás", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //___________________________________________________________________________________________________Kilépés&Tálca
        private void BT_kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_talca_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //________________________________________________________________________________________________Középre igazítás
        private void _kozep()
        {
            Screen kijelzo = Screen.FromControl(this);
            Rectangle monitor = kijelzo.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(monitor.X, monitor.X + (monitor.Width - this.Width) / 2),
                Y = Math.Max(monitor.Y, monitor.Y + (monitor.Height - this.Height) / 2)
            };
        }

        public void kozep()
        {
            _kozep();
        }
        //___________________________________________________________________________________________________Ellenőrzések
        private void ellenorzes()
        {
            de.formazas_beallitasok_beolvasasa(id);
            formazasok_betoltese();
            teszt = f.vanewamp();
            if(teszt)
            {               
                kapcsolat = cs.kapcsolat_ellenorzes();
                if (!kapcsolat)
                {
                    f.adatbazis_letrehozas();
                    f.adatbazis_letrehozas_feltoltes(cs.tablak_letrehozása1(), cs.kapcsolodas());
                    f.adatbazis_letrehozas_feltoltes(cs.tablak_letrehozása2(), cs.kapcsolodas());
					f.adatbazis_letrehozas_feltoltes(cs.tablak_letrehozása3(), cs.kapcsolodas());
                    f.adatbazis_letrehozas_feltoltes(cs.tablak_letrehozása4(), cs.kapcsolodas());
                    f.adatbazis_letrehozas_feltoltes(cs.tablak_letrehozása5(), cs.kapcsolodas());
                    f.adatbazis_letrehozas_feltoltes(cs.tablak_letrehozása6(), cs.kapcsolodas());
                    f.adatbazis_letrehozas_feltoltes(cs.kulcs_beallitasok(), cs.kapcsolodas());
                    beolvasas_feltolteshez();
                    MessageBox.Show("Az adatbázis a táblákkal együtt létrehozva.\nHozzon létre egy új felhasználót a regisztráció gombra kattintva!\nKellemes munkavégzést kívánok!", "Adatbázis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.adat_kezeles("TRUNCATE felhasznalo_mentese");
                    CB_felhasznalonev.Checked = false;                    
                }
                kapcsolat = true;
            }
            else
            {
                hiba = true;
                T_idozito.Enabled = true;
                LB_hiba.Text = "A Wampserver nem online!";
            }
        }

        private void felh_jelszo_ellenorzes(string TB_felh,string TB_jelszo)
        {
            if (TB_felh_admin.Text == TB_felh && TB_jelszo_admin.Text == TB_jelszo)
            {
                
                admin be = new admin(alapertelmezett);
                be.Show();
                this.Hide();
            }
            else
            {           
            if (cs.kapcsolat_ellenorzes())
            {
                    try
                {
                    cs.kapcs.Open(); //meghívjuk a kapcsolódó parancsot, így ténylegesen is kapcsolódunk az adatbázishoz
                    cs.parancs.Connection = cs.kapcs;
                    cs.parancs.CommandText = "SELECT belepesi_adatok.id,belepesi_adatok.felhasznalo,belepesi_adatok.jelszo FROM belepesi_adatok WHERE belepesi_adatok.felhasznalo = '" + TB_felh + "' AND belepesi_adatok.jelszo = '" + TB_jelszo + "';";
                    // SQL lekérdezéssel megnézzük az adatbázisban a megadott értékeket (felhasználó név, jelszó)          
                    MySqlDataReader olvas = cs.parancs.ExecuteReader();
                    while (olvas.Read())    //beolvas amíg     
                    {
                        id = olvas.GetInt32(0);
                        felhnev = olvas.GetString(1); //lekérdezésben lévő első elem felh, a (0) jelenti az első elemet
                        jelszo = olvas.GetString(2); //lekérdezésben lévő második elem jelszo  (1)
                    }
                    olvas.Close();

                }
                catch { MessageBox.Show("Hiba van az adatbázissal", "Adatbázis", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                cs.kapcs.Close();
            }
            }
        }

        public void _felh_jelszo_ellenorzes(string TB_felh,string TB_jelszo)
        {
            felh_jelszo_ellenorzes(TB_felh,TB_jelszo);
        }

        private void TB_ellenorzes()
        {
            LB_hiba.Visible = false;
            hiba = false;
            
            if (TB_felh.Text != "" && TB_jelszo.Text != "")
            {
                LB_hiba.Visible = false;
                hiba = false;
                felh_jelszo_ellenorzes(TB_felh.Text,TB_jelszo.Text);
                if (felhnev != TB_felh.Text && jelszo != TB_jelszo.Text)
                {
                    LB_hiba.Visible = true;
                    hiba = true;
                    TB_felh.Text = default(string);
                    TB_jelszo.Text = default(string);
                    LB_hiba.Text = "Hibás felhasználónév / jelszó!";
                    TB_felh.Select();
                    TB_felh.Select(TB_felh.Text.Length, 0);
                    
                }
                else
                {
                        string lekerdezes = "INSERT INTO `felhasznalo_mentese`(`felhasznalo`) VALUES('" + TB_felh.Text + "')";
                        if (CB_felhasznalonev.Checked == true)
                        {
                        f.adat_kezeles("TRUNCATE felhasznalo_mentese");
                        f.adat_kezeles(lekerdezes);
                        }
                        else
                        {
                        f.adat_kezeles("TRUNCATE felhasznalo_mentese");
                        }
                        hiba = false;
                        LB_hiba.Visible = false;
                        T_ora.Enabled = false;
                        formazasok_betoltese();

                    string van_e_mar_proba = "SELECT * FROM proba";
                    if (!f.van_e_ilyen_adat(van_e_mar_proba))
                    {
                        beolvasas_feltolteshez();
                    }                  
                        adatkezeles be = new adatkezeles(id, felhnev, jelszo,alapertelmezett,this);
                        be.Show();
                        this.Hide();
                    }                                       
            }
                
            else
            {
                hiba = true;
                LB_hiba.Visible = true;
                LB_hiba.Text = "Töltsd ki a hiányzó mezőket!";
            }
        }

        private void formazasok_betoltese()
        {
            teszt = f.vanewamp();
            if (teszt && cs.kapcsolat_ellenorzes())
            {               
                try
                {
                    cs.kapcs.Open(); //meghívjuk a kapcsolódó parancsot, így ténylegesen is kapcsolódunk az adatbázishoz
                    cs.parancs.Connection = cs.kapcs;
                    cs.parancs.CommandText = "SELECT id FROM belepesi_adatok WHERE felhasznalo = '" + TB_felh.Text + "';";   
                    MySqlDataReader olvas = cs.parancs.ExecuteReader();
                    iid = default(int);
                    while (olvas.Read())    //beolvas amíg     
                    {
                        iid = olvas.GetInt32(0);                        
                    }
                    if (iid == default(int))
                    {
                        iid = 0;
                    }
                    olvas.Close();                   
                }
                catch { MessageBox.Show("Hiba van az adatbázissal", "Adatbázis, alapértelmezett-e", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                cs.kapcs.Close();
                try
                {
                    cs.kapcs.Open(); //meghívjuk a kapcsolódó parancsot, így ténylegesen is kapcsolódunk az adatbázishoz
                    cs.parancs.Connection = cs.kapcs;
                    cs.parancs.CommandText = "SELECT alapertelmezett FROM beallitasok WHERE fodrasz_az = '" + iid + "';";
                    //System.Windows.Forms.Clipboard.SetDataObject(cs.parancs.CommandText, true);  
                    MySqlDataReader olvas = cs.parancs.ExecuteReader();
                    while (olvas.Read())    //beolvas amíg     
                    {
                        alapertelmezett = olvas.GetString(0);                        
                    }
                    olvas.Close();
                    if (alapertelmezett == default(string))
                    {
                        alapertelmezett = "1";                        
                    }
                    else
                    {
                        id = iid;
                    }                 
                }
                catch { MessageBox.Show("Hiba van az adatbázissal", "Adatbázis, alapértelmezett", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                cs.kapcs.Close();
            }
            else
            {
                id = 0;
                alapertelmezett = "1";
            }

            de.Form_formazasok(alapertelmezett, id, this); //háttér

            de.Button_formazasok(alapertelmezett, id, BT_belepes, BT_kilepes, BT_regisztracio, BT_talca, BT_keszitok);//gombok

            de.Label_formazasok(alapertelmezett, id, LB_felh, LB_felirat, LB_hiba, LB_jelszo, LB_kulcs,LB_konyv); // label

            de.CheckBox_formazasok(alapertelmezett, id, CB_felhasznalonev); //checkbox

            de.Panel_formazasok(alapertelmezett, id, P_1); //panel

            de.TextBox_formazasok(alapertelmezett, id, TB_felh, TB_jelszo); //Textbox

            de.Jelszo_TextBox_beallitas(alapertelmezett, id, TB_jelszo); //jelszo Textbox

            LB_konyv.Size = new Size(30, TB_felh.Height);
            LB_kulcs.Size = new Size(30, TB_felh.Height);
        }
            
        //______________________________________________________________________________________________________FŐ_események
        private void BT_belepes_Click(object sender, EventArgs e)
        {
            hiba = false;
            if (T_idozito.Enabled == true)
            {
                T_idozito.Enabled = false;
                LB_hiba.Visible = false;
                szamlalo = 0;
            }
            teszt = f.vanewamp();            
            if (teszt)
            {
                kapcsolat = cs.kapcsolat_ellenorzes();          
                if (kapcsolat)
                {
                    TB_ellenorzes();
                    if (hiba == true)
                    {
                        T_idozito.Enabled = true;
                        szamlalo = 0;
                    }
                }
                else
                {
                    LB_hiba.Text = "Nincs feltöltve adatbázis!";
                    hiba = true;
                    T_idozito.Enabled = true;
                }
            }
           else
            {
                LB_hiba.Text = "A Wampserver nem online!";
                hiba = true;
                T_idozito.Enabled = true;
            }           
        }

        private void BT_regisztracio_Click(object sender, EventArgs e)
        {
            hiba = false;
            if (T_idozito.Enabled == true)
            {
                T_idozito.Enabled = false;
                LB_hiba.Visible = false;
                szamlalo = 0;
            }
            teszt = f.vanewamp();
            if (teszt)
            {
                ellenorzes();
                if (kapcsolat)
                {
                    T_ora.Enabled = false;
                    regisztracio at = new regisztracio(alapertelmezett, id);
                    at.Show();
                    this.Hide();
                }
            else
                {
                    LB_hiba.Text = "Nincs feltöltve adatbázis!";
                    hiba = true;
                    T_idozito.Enabled = true;            
                }
            }
            else
            {
                LB_hiba.Text = "A Wampserver nem online!";
                hiba = true;
                T_idozito.Enabled = true;
            }

        }

        private void BT_keszitok_Click(object sender, EventArgs e)
        {
            T_ora.Enabled = false;
            keszitok at = new keszitok(alapertelmezett, id);
            at.Show();
            this.Hide();
        }

        // _______________________________________________________________________________________________________IDŐZÍTŐ

        private void T_idozito_Tick(object sender, EventArgs e)
        {
            szamlalo++;
            if (hiba == true)
            {

                if (szamlalo % 2 == 0)
                {
                    LB_hiba.Visible = true;
                }
                else
                {
                    LB_hiba.Visible = false;
                }
            }
            else
            {
                LB_hiba.Visible = false;
            }
            if (szamlalo == 10)
            {
                T_idozito.Enabled = false;
                szamlalo = 0;
            }
        }

        private void T_ora_Tick(object sender, EventArgs e)
        {
            LB_felirat.Text = "Fodrászat   " + DateTime.Now.ToString("HH:mm:ss");
        }

        //_____________________________________________________________________________________________________Események

        private void TB_felh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_belepes.PerformClick();
            }
        }

        private void TB_jelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_belepes.PerformClick();
            }
            
        }

        private void TB_jelszo_MouseHover(object sender, EventArgs e)
        {
           TB_jelszo.PasswordChar = '\0';
        }

        private void TB_jelszo_MouseLeave(object sender, EventArgs e)
        {
            TB_jelszo.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id,TB_jelszo));
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            var aktualis = sender as TextBox;

            if (aktualis.Name == "TB_felh")
                tt.Show("Kis- és nagybetű különbséget nem különböztet meg a rendszer", TB_felh, -46, 35, 3000);
        }

        private void TB_felh_TextChanged(object sender, EventArgs e)
        {
            f.TB_elso_betu_mindig_nagybetu(TB_felh);
            f.betu_es_szam_TB(TB_felh);
            if (f.vanewamp() && cs.kapcsolat_ellenorzes())
            {
                try
                {
                    formazasok_betoltese();
                    de.formazas_beallitasok_beolvasasa(id);                  
                    hiba = false;
                    T_idozito.Enabled = true;
                }
                catch { }
            }
        }

        private void TB_jelszo_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_jelszo);
        }

        private void CB_felhasznalonev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              if (CB_felhasznalonev.Checked== true)
                {
                    CB_felhasznalonev.Checked = false;
                }
              else
                {
                    CB_felhasznalonev.Checked = true;
                }
            }
        }


    }
}
