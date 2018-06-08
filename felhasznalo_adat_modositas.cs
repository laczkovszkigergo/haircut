using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace fodraszat
{
    public partial class felhasznalo_adat_modositas : Form
    {
        string felhnev = default(string);
        string jelszo = default(string);
        int id = default(int);
        string alapertelmezett = default(string);

        ToolTip tt = new ToolTip();
        

        string modosit;
        string uzenet;
        string uzenet2;

        bejelentkezes be = new bejelentkezes();
        csatlakoz cs = new csatlakoz();
        fuggvenyek f = new fuggvenyek();
        design_beallitasok de = new design_beallitasok();

        bool hiba = default(bool);
        bool mindenjo = default(bool);
        int szamlalo = default(int);
        bool _plusz_meret = default(bool);
        int[] darabolo = new int[3];
       
        public felhasznalo_adat_modositas()
        {
            InitializeComponent();
        }

        public felhasznalo_adat_modositas(int _id, string _felhnev,string _jelszo,string _alapertelmezett,adatkezeles _at)
        {
            InitializeComponent();
            felhnev = _felhnev;
            jelszo = _jelszo;
            id = _id;
            alapertelmezett = _alapertelmezett;

        }
        //____________________________________________________________________________________ALAP
        private void felhasznalo_adat_modositas_Load(object sender, EventArgs e)
        {
            TabC_felh.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabC_felh_mod.Text = "Fiók módosítása";
            TabC_torl.Text = " Fiók törlése ";

            if (f.vanewamp())
            {
                formazasok_betoltese();
            }
            else
            {
                LB_hiba.Text = "A wampserver nem online!";
                szamlalo = 0;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
            }
        }

        private void formazasok_betoltese()
        {
            de.Form_formazasok(alapertelmezett, id,this); //háttér

            de.Button_formazasok(alapertelmezett, id, BT_kilepes, BT_modositas, BT_talca, BT_torles, BT_vissza, BT_vissza2);

            de.Label_formazasok(alapertelmezett, id, LB_felh, LB_felirat, LB_hiba, LB_hiba2, LB_jelszo, LB_regi_jelszo, LB_regi_jelszo2, LB_uj_jelszo_ism); //label

            de.Panel_formazasok(alapertelmezett, id, P_1); //panel

            de.Panel_formazasok1(alapertelmezett, id, Panel1_hatter);

            de.TabControl_formazasok_hatter(alapertelmezett, id, TabC_felh);

            de.TextBox_formazasok(alapertelmezett, id, TB_felh, TB_jelszo, TB_regi_jelszo, TB_regi_jelszo2, TB_uj_jelszo); //textbox

            de.Jelszo_TextBox_beallitas(alapertelmezett, id, TB_jelszo, TB_regi_jelszo, TB_regi_jelszo2, TB_uj_jelszo);// jelszo textbox

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

        private void BT_talca_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //_________________________________________________________________________Egér_mozgás események
        private void TB_jelszo_MouseHover(object sender, EventArgs e)
        {
            TB_jelszo.PasswordChar = '\0';
        }

        private void TB_jelszo_MouseLeave(object sender, EventArgs e)
        {
            TB_jelszo.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id,TB_jelszo));
        }

        private void TB_uj_jelszo_MouseHover(object sender, EventArgs e)
        {
            TB_uj_jelszo.PasswordChar = '\0';
        }

        private void TB_uj_jelszo_MouseLeave(object sender, EventArgs e)
        {
            TB_uj_jelszo.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id, TB_uj_jelszo));
        }

        private void TB_regi_jelszo_MouseHover(object sender, EventArgs e)
        {
            TB_regi_jelszo.PasswordChar = '\0';
        }

        private void TB_regi_jelszo_MouseLeave(object sender, EventArgs e)
        {
            TB_regi_jelszo.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id, TB_regi_jelszo));
        }

        private void TB_regi_jelszo2_MouseHover(object sender, EventArgs e)
        {
            TB_regi_jelszo2.PasswordChar = '\0';
        }

        private void TB_regi_jelszo2_MouseLeave(object sender, EventArgs e)
        {
            TB_regi_jelszo2.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id, TB_regi_jelszo2));
        }

        //_______________________________________________________________________FŐesemények

        private void adat_modositas(string modosit)
        {
            try
            {
                //csatlakozás az adatbázishoz               
                //a regisztráció során megadott adatok feltöltése az adatbázisba
                cs.kapcs.Open(); //csatlakozás az adatbázishoz

                cs.ds = new DataSet();
                cs.da = new MySqlDataAdapter(modosit, cs.kapcs); // parancs futtatása
                cs.da.Fill(cs.ds, "Módosítás");
                // MessageBox.Show("Sikeres módosítás!"); //visszajelzés
            }
            catch { MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet
            finally { cs.kapcs.Close(); } //kapcsolat lezárása
        }

        private bool _adat_ellenorzes(string mod,string uz,string uz2,TextBox TB_felh,TextBox TB_jelszo,TextBox TB_uj_jelszo,TextBox TB_regi_jelszo)
        {
            LB_hiba.Visible = false;
            hiba = false;
            _plusz_meret = false;

            if(TB_regi_jelszo== null)
            {
                if (TB_felh.Text != "" || TB_jelszo.Text != "" && TB_uj_jelszo.Text != "")
                {
                    LB_hiba.Visible = false;
                    hiba = false;
                    if (TB_felh.Text == "" && TB_jelszo.Text != "")
                    {
                        TB_felh.Text = felhnev;

                    }
                    if (TB_jelszo.Text == "")
                    {
                        TB_jelszo.Text = jelszo;
                        TB_uj_jelszo.Text = jelszo;
                    }
                    if (TB_felh.Text.Contains("(") || TB_felh.Text.Contains(")") || TB_felh.Text.Contains("'") || TB_jelszo.Text.Contains("(") || TB_jelszo.Text.Contains(")") || TB_jelszo.Text.Contains("'"))
                    {
                        LB_hiba.Visible = true;
                        hiba = true;
                        TB_felh.Text = default(string);
                        TB_uj_jelszo.Text = default(string);
                        TB_jelszo.Text = default(string);
                        LB_hiba.Text = "A mező(k) nem megengedett karaktereket használ(nak), zárojelet vagy aposztrófot!";
                        TB_felh.Select();
                        TB_felh.Select(TB_felh.Text.Length, 0);
                        be._felh_jelszo_ellenorzes(TB_felh.Text, TB_jelszo.Text);
                        _plusz_meret = true;
                        return true;
                    }
                    else if (TB_felh.Text == TB_jelszo.Text)
                    {
                        LB_hiba.Visible = true;
                        hiba = true;
                        TB_uj_jelszo.Text = default(string);
                        TB_jelszo.Text = default(string);
                        LB_hiba.Text = "A felhasználónév és a jelszó\nMegegyezik!";
                        TB_jelszo.Select();
                        TB_jelszo.Select(TB_jelszo.Text.Length, 0);
                        return true;
                    }

                    else if (TB_uj_jelszo.Text != TB_jelszo.Text)
                    {
                        LB_hiba.Visible = true;
                        hiba = true;

                        TB_uj_jelszo.Text = default(string);
                        TB_jelszo.Text = default(string);
                        LB_hiba.Text = "A két jelszó nem egyezik meg!";
                        TB_jelszo.Select();
                        TB_jelszo.Select(TB_jelszo.Text.Length, 0);
                        return true;
                    }
                    else if (van_e_mar_ilyen_adat() == true)
                    {
                        LB_hiba.Visible = true;
                        hiba = true;

                        LB_hiba.Text = "A felhasználónév foglalt!";
                        TB_felh.Text = "";
                        TB_felh.Select(); // Fókuszba rakja a hibás textboxot
                        TB_felh.Select(TB_felh.Text.Length, 0); // a textbox utolsó eleméhez ugrik
                        return true;
                    }
                    else
                    {
                        hiba = false;
                        LB_hiba.Visible = false;
                        mindenjo = true;
                        MessageBox.Show(uz, uz2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    hiba = true;
                    LB_hiba.Visible = true;
                    LB_hiba.Text = "Töltsd ki a hiányzó mezőket!";
                    return true;
                }
            }
            else //______________________________________________________________________________________________________________________________________________________________
            {
                if ((TB_felh.Text != "" || (TB_jelszo.Text != "" && TB_uj_jelszo.Text != "")) && TB_regi_jelszo.Text != "")
                {
                    LB_hiba.Visible = false;
                    hiba = false;
                    if (TB_felh.Text == "" && TB_jelszo.Text != "")
                    {
                        TB_felh.Text = felhnev;

                    }
                    
                    if (TB_felh.Text.Contains("(") || TB_felh.Text.Contains(")") || TB_felh.Text.Contains("'") || TB_jelszo.Text.Contains("(") || TB_jelszo.Text.Contains(")") || TB_jelszo.Text.Contains("'") || TB_regi_jelszo.Text.Contains("(") || TB_regi_jelszo.Text.Contains(")") || TB_regi_jelszo.Text.Contains("'"))
                    {
                        LB_hiba.Visible = true;
                        hiba = true;
                        TB_felh.Text = default(string);
                        TB_uj_jelszo.Text = default(string);
                        TB_jelszo.Text = default(string);
                        TB_regi_jelszo.Text = default(string);
                        LB_hiba.Text = "A mező(k) nem megengedett karaktereket használ(nak), zárojelet vagy aposztrófot!";
                        TB_felh.Select();
                        TB_felh.Select(TB_felh.Text.Length, 0);
                        be._felh_jelszo_ellenorzes(TB_felh.Text, TB_jelszo.Text);
                        _plusz_meret = true;
                        return true;
                    }
                    else if (TB_felh.Text == TB_jelszo.Text)
                    {
                        LB_hiba.Visible = true;
                        hiba = true;
                        TB_uj_jelszo.Text = default(string);
                        TB_jelszo.Text = default(string);
                        LB_hiba.Text = "A felhasználónév és a jelszó\nMegegyezik!";
                        TB_jelszo.Select();
                        TB_jelszo.Select(TB_jelszo.Text.Length, 0);
                        return true;
                    }

                    else if (TB_uj_jelszo.Text != TB_jelszo.Text)
                    {
                        LB_hiba.Visible = true;
                        hiba = true;

                        TB_uj_jelszo.Text = default(string);
                        TB_jelszo.Text = default(string);
                        LB_hiba.Text = "A két jelszó nem egyezik meg!";
                        TB_jelszo.Select();
                        TB_jelszo.Select(TB_jelszo.Text.Length, 0);
                        return true;
                    }
                    else if (TB_regi_jelszo.Text != jelszo)
                    {
                        LB_hiba.Visible = true;
                        hiba = true;

                        TB_regi_jelszo.Text = default(string);
                        LB_hiba.Text = "Nem ez a régi jelszava!";
                        TB_regi_jelszo.Select();
                        TB_regi_jelszo.Select(TB_regi_jelszo.Text.Length, 0);
                        return true;
                    }

                    else if (van_e_mar_ilyen_adat() == true)
                    {
                        LB_hiba.Visible = true;
                        hiba = true;

                        LB_hiba.Text = "A felhasználónév foglalt!";
                        TB_felh.Text = "";
                        TB_felh.Select(); // Fókuszba rakja a hibás textboxot
                        TB_felh.Select(TB_felh.Text.Length, 0); // a textbox utolsó eleméhez ugrik
                        return true;
                    }
                    else if(TB_jelszo.Text == "" && hiba != true)
                    {
                        TB_jelszo.Text = jelszo;
                        TB_uj_jelszo.Text = jelszo;
                        return false;
                    }
                    else
                    {
                        hiba = false;
                        LB_hiba.Visible = false;
                        mindenjo = true;
                        MessageBox.Show(uz, uz2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    hiba = true;
                    LB_hiba.Visible = true;
                    LB_hiba.Text = "Töltsd ki a hiányzó mezőket!";
                    return true;
                }
            }
            

        }

        public bool _adat_ellenorzes_(string mod, string uz, string uz2,TextBox fel,TextBox jel,TextBox jel_ism,TextBox regi_jel)
        {
            return _adat_ellenorzes(mod,uz,uz2,fel,jel,jel_ism,regi_jel);
        }

        private void adat_ellenorzes()
        {
            _adat_ellenorzes(modosit,uzenet,uzenet2,TB_felh,TB_jelszo,TB_uj_jelszo,TB_regi_jelszo);
        }

        private bool van_e_mar_ilyen_adat()
        {
            try
            {
                cs.kapcs.Open(); //meghívjuk a kapcsolódó parancsot, így ténylegesen is kapcsolódunk az adatbázishoz     
                cs.parancs.Connection = cs.kapcs;
                cs.parancs.CommandText = "SELECT belepesi_adatok.felhasznalo FROM belepesi_adatok WHERE not (belepesi_adatok.id = '" + id + "') AND belepesi_adatok.felhasznalo= '" + TB_felh.Text + "';";
                // SQL lekérdezéssel megnézzük az adatbázisban a megadott értékeket (felhasználó név, jelszó)          
                MySqlDataReader olvas = cs.parancs.ExecuteReader();

                string felhasznalo = default(string); //változók

                while (olvas.Read())    //beolvas amíg     
                {
                    felhasznalo = olvas.GetString(0); //lekérdezésben lévő első elem felh, a (0) jelenti az első elemet
                }
                cs.kapcs.Close();
                //TERMEKNEV____________________________________________________________________________________

                if (felhasznalo != default(string))
                {
                    //  MessageBox.Show("Ez a felhasználó foglalt!", "Módosítás hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning); //hibaüzenet
                    return true;
                }
                else
                {
                    return false;
                }
            }catch { MessageBox.Show("Nincs feltöltve adatbázis!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning); return true; }
        }

        public string hibauz()
        {
            return LB_hiba.Text;
        }

        public bool plusz_meret()
        {
            return _plusz_meret;
        }

        //_________________________________________________________________Időzítő

        private void T_idozito_Tick(object sender, EventArgs e)
        {
            szamlalo++;
            if (hiba == true)
            {
                if (szamlalo % 2 == 0)
                {
                                       
                    LB_hiba.Visible = true;
                    if (LB_hiba2.Text != default(string))
                    {
                        LB_hiba2.Visible = true;
                    }
                    
                }
                else
                {                    
                    if (LB_hiba2.Text != default(string))
                    {
                        LB_hiba2.Visible = false;
                    }
                    LB_hiba.Visible = false;
                }
            }
            if (szamlalo == 10)
            {
                T_idozito.Enabled = false;
                szamlalo = 0;
            }
        }

        private void T_idoziti2_Tick(object sender, EventArgs e)
        {
            if (plusz_meret() == true)
            {
                this.Size = new Size(350, 580); //+100
                LB_hiba.Size = new Size(350, 125);
            }
            else if (hiba == true)
            {
                this.Size = new Size(350, 550); //+100
                LB_hiba.Size = new Size(350, 80);
            }
            else
            {
                this.Size = new Size(350, 475); //+100
            }
            T_idozito2.Enabled = false;
        }
        //_______________________________________________________________________Gomb
        private void BT_vissza_Click(object sender, EventArgs e)
        {
            adatkezeles at = new adatkezeles(id,felhnev, jelszo,alapertelmezett,this);
            at.Show();
            this.Close();
        }

        private void BT_vissza2_Click(object sender, EventArgs e)
        {
            adatkezeles at = new adatkezeles(id, felhnev, jelszo,alapertelmezett,this);
            at.Show();
            this.Close();
        }

        private void BT_modositas_Click(object sender, EventArgs e)
        {
            LB_hiba2.Visible = false;
            LB_hiba2.Text = default(string);
            uzenet = "Sikeresen módositottad a felhasználódat " + TB_felh.Text + "!\nKérlek lépj be újra!";
            uzenet2 = "Módosítás";
            adat_ellenorzes();
            modosit = "UPDATE `belepesi_adatok` SET `felhasznalo`='" + TB_felh.Text + "', " + "`jelszo`='" + TB_jelszo.Text + "'WHERE `felhasznalo`='" + felhnev + "' AND `jelszo`='" + jelszo + "' ";

            if (mindenjo)
            {
                adat_modositas(modosit);
                bejelentkezes be = new bejelentkezes();
                be.Show();
                this.Close();
            }

            if (hiba == true)
            {
                szamlalo = 0;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
            }                     
        }

        private void BT_torles_Click(object sender, EventArgs e)
        {
            LB_hiba2.Visible = false;
            LB_hiba2.Text = default(string);
            if(TB_regi_jelszo2.Text !="")
            {
                if (TB_regi_jelszo2.Text == jelszo)
                {
                    DialogResult dialogResult = MessageBox.Show(felhnev + " biztosan törölni akarod fiókodat?\nMinden hozzád kapcsolódó adat el fog veszni!", "Fiók törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string lekerdezes = @"Delete FROM `foglalas` Where `fodrasz_az` ='" + id + "'";
                        string lekerdezes1 = @"Delete FROM `beallitasok` Where `fodrasz_az` ='" + id + "'";
                        string lekerdezes2 = @"Delete FROM `belepesi_adatok` Where `id` ='" + id + "'";
                        string lekerdezes3 = @"Delete FROM `tipus_ar` Where `fodrasz_az` ='" + id + "'";
                        f.adat_kezeles(lekerdezes);
                        f.adat_kezeles(lekerdezes1);
                        f.adat_kezeles(lekerdezes2);
                        f.adat_kezeles(lekerdezes3);

                        MessageBox.Show("Sikeresen törölted a felhasználó fiókodat és a hozzá tartozó összes adatot!","Felhasználó fiók törlése",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        f.adat_kezeles("TRUNCATE felhasznalo_mentese");
                        bejelentkezes be = new bejelentkezes();
                        be.Show();
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else
                {
                    LB_hiba2.Text = "Nem ez a régi jelszavad!";
                    hiba = true;
                    szamlalo = 0;
                    T_idozito.Enabled = true;
                }
            }
            else
            {
                LB_hiba2.Text = "Töltsd ki a hiányzó mezőt!";
                hiba = true;
                szamlalo = 0;
                T_idozito.Enabled = true;
            }
            
        }

        //___________________________________________________________________Események
        private void TB_felh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_modositas.PerformClick();
            }
        }

        private void TB_jelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_modositas.PerformClick();
            }
        }

        private void TB_uj_jelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_modositas.PerformClick();
            }
        }

        private void TB_regi_jelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_modositas.PerformClick();
            }
        }

        private void TB_regi_jelszo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_torles.PerformClick();
            }
        }

        //__
        private void TB_felh_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_felh);
        }

        private void TB_jelszo_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_jelszo);
        }

        private void TB_uj_jelszo_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_uj_jelszo);
        }

        private void TB_regi_jelszo_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_regi_jelszo);
        }

        private void TB_regi_jelszo2_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_regi_jelszo2);
        }

        //__
        private void textbox_Enter(object sender, EventArgs e)
        {
            var aktualis = sender as TextBox;

            if (aktualis.Name == "TB_felh")
                tt.Show("Felhasználónév váltáshoz csak a régi jelszavad kell beírnod", TB_felh, -35, 35, 3000);

            else if (aktualis.Name == "TB_jelszo")
                tt.Show("Jelszó váltáshoz csak a régi jelszavad kell beírnod\nNe egyezzen meg a felhasználó névvel", TB_jelszo, -10, 35, 3000);

            else if (aktualis.Name == "TB_uj_jelszo")
                tt.Show("Ismételd meg a jelszavad", TB_uj_jelszo, 56, 35, 3000);

            else if (aktualis.Name == "TB_regi_jelszo")
                tt.Show("Módosításhoz add meg a régi jelszavad", TB_regi_jelszo, 17, 35, 3000);

            else if (aktualis.Name == "TB_regi_jelszo2")
                tt.Show("A fiókod törléséhez add meg a régi jelszavad", TB_regi_jelszo2, 3, 35, 3000);

        }

        //__________________________________________________________________Tabcontrol 

        private void TabC_felh_mod_Enter(object sender, EventArgs e)
        {
            this.Size = new Size(350, 475); //+100
        }

        private void TabC_torl_Enter(object sender, EventArgs e)
        {
            this.Size = new Size(350, 300); //+100
        }

        private void TabC_felh_DrawItem(object sender, DrawItemEventArgs e)
        {           
            //tabpage lekérése
            TabPage tabPages = TabC_felh.TabPages[e.Index];
            Graphics graphics = e.Graphics;
            Rectangle tabBounds = TabC_felh.GetTabRect(e.Index);

            darabolo = de.TabControl_formazasok_szoveg(alapertelmezett, id, TabC_felh); //tabcontrol szöveg

            Brush textBrush = new SolidBrush(Color.FromArgb(255, darabolo[0], darabolo[1], darabolo[2])); // BETŰSZIN         
            darabolo = de.TabControl_formazasok_hatter(alapertelmezett, id, TabC_felh); //tabcontrol háttér

            Brush hatterszin = new SolidBrush(Color.FromArgb(255,darabolo[0], darabolo[1], darabolo[2]));
            Color tab_hatter = Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);

            darabolo = de.TabControl_formazasok_tabcontrolvalto_hatter(alapertelmezett, id, TabC_felh); //tabcontrol háttér
            Brush gombvalto = new SolidBrush(Color.FromArgb(255, darabolo[0], darabolo[1], darabolo[2]));

            TabC_felh_mod.BackColor = tab_hatter;
            TabC_torl.BackColor = tab_hatter;

            if (e.State == DrawItemState.Selected)
            {
                graphics.FillRectangle(gombvalto, e.Bounds); //HÁTTÉRSZIN ha ki van jelölve                  
                if (TabC_felh.TabPages[e.Index].Name == "TabC_felh_mod")
                {                   
                    TB_regi_jelszo2.Text = "";
                }
             else
                {
                    TB_felh.Text = "";
                    TB_jelszo.Text = "";
                    TB_uj_jelszo.Text = "";
                    TB_regi_jelszo.Text = "";
                }
                
                if(e.Index ==0)
                {
                    
                    tabBounds.Width = 200;
                }
                else
                {
                      
                    tabBounds.Width = 250;
                }
            }
            else
            {
                graphics.FillRectangle(hatterszin, e.Bounds); //HÁTTÉRSZIN ha ki van jelölve
                if (e.Index == 0)
                {
                    tabBounds.Width = 200;
                }
                else
                { 
                    tabBounds.Width = 250;
                }                      
            }
            float size = float.Parse(de.TabControl_formazasok_betustilus(alapertelmezett, id, TabC_felh).Split(';')[1]);
            string betutipus = de.TabControl_formazasok_betustilus(alapertelmezett, id, TabC_felh).Split(';')[2];
            System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betutipus, true);
            Font tabFont = new Font(de.TabControl_formazasok_betustilus(alapertelmezett, id, TabC_felh).Split(';')[0], size, f); // betűtípus, méret, egyéb

            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Near;
            strFormat.LineAlignment = StringAlignment.Center;

            // draw text            
            graphics.DrawString(tabPages.Text, tabFont, textBrush, tabBounds, new StringFormat(strFormat));
            graphics.Dispose();
            textBrush.Dispose();
        }


    }
}
