using System;
using System.Drawing;
using System.Windows.Forms;

namespace fodraszat
{
    public partial class regisztracio : Form
    {
        public regisztracio()
        {
            InitializeComponent();
        }
        string feltolt;
        string uzenet;
        string uzenet2;
        bool hiba = default(bool);
        bool teszt = default(bool);
        int szamlalo = default(int);

        int id = default(int);
        string alapertelmezett = default(string);

        public regisztracio(string _alapertelmezett,int _id)
        {
            InitializeComponent();
            alapertelmezett = _alapertelmezett;
            id = _id;
        }

        felhasznalo_adat_modositas fa = new felhasznalo_adat_modositas();
        fuggvenyek f = new fuggvenyek();
        design_beallitasok de = new design_beallitasok();

        private void regisztracio_Load(object sender, EventArgs e)
        {
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
        //______________________________________________________________________Alap gombok__
        private void BT_talca_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BT_kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //______________________________________________________________________Események

        private void TB_felh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_regisztracio.PerformClick();
            }
        }

        private void TB_jelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_regisztracio.PerformClick();
            }
        }

        private void TB_uj_jelszo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_regisztracio.PerformClick();
            }
        }

        private void TB_felh_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_felh);
            f.TB_elso_betu_mindig_nagybetu(TB_felh);
        }

        private void TB_jelszo_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_jelszo);
        }

        private void TB_uj_jelszo_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_uj_jelszo);
        }

        private void TB_jelszo_MouseHover(object sender, EventArgs e)
        {
            TB_jelszo.PasswordChar = '\0';
        }

        private void TB_jelszo_MouseLeave(object sender, EventArgs e)
        {
            TB_jelszo.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id, TB_jelszo));
        }

        private void TB_uj_jelszo_MouseHover(object sender, EventArgs e)
        {
            TB_uj_jelszo.PasswordChar = '\0';
        }

        private void TB_uj_jelszo_MouseLeave(object sender, EventArgs e)
        {
            TB_uj_jelszo.PasswordChar = Convert.ToChar(de.Jelszo_TextBox_beallitas1(alapertelmezett, id, TB_uj_jelszo));
        }

        //_____________________________________________________________________________Fő gomb

        private void BT_regisztracio_Click(object sender, EventArgs e)
        {
            csatlakoz cs = new csatlakoz();
            feltolt = "INSERT INTO belepesi_adatok(`felhasznalo`,`jelszo`) VALUES('" + TB_felh.Text + "' , '" + TB_jelszo.Text +"')";
            uzenet = "Sikeres regisztráltad a felhasználódat " + TB_felh.Text + "!\nKérlek jelentkezz be!";
            uzenet2 = "Regisztráció";
            

            if (T_idozito.Enabled == true)
            {
                T_idozito.Enabled = false;
                LB_hiba.Visible = false;
                szamlalo = 0;
            }

            teszt = f.vanewamp();
            if (T_idozito.Enabled == true)
            {
                T_idozito.Enabled = false;
                LB_hiba.Visible = false;
                szamlalo = 0;
            }          
           else if (teszt == false)
            {
                LB_hiba.Text = "A wampserver nem online!";
                szamlalo = 0;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
            }else if(!cs.kapcsolat_ellenorzes())
            {
                LB_hiba.Text = "Nincs feltöltve adatbázis!";
                szamlalo = 0;
                T_idozito.Enabled = true;
                T_idozito2.Enabled = true;
            }
           else 
            {
                hiba = fa._adat_ellenorzes_(feltolt, uzenet, uzenet2, TB_felh, TB_jelszo, TB_uj_jelszo, null);
                if (hiba == true)
                {
                    LB_hiba.Text = fa.hibauz();
                    szamlalo = 0;
                    T_idozito.Enabled = true;
                    T_idozito2.Enabled = true;
                }
                else
                {
                    f.adat_kezeles(feltolt);
                    bejelentkezes be = new bejelentkezes();
                    be.Show();
                    this.Close();
                }
            }
                     
        }

        private void BT_vissza_Click(object sender, EventArgs e)
        {
            bejelentkezes be = new bejelentkezes(alapertelmezett,id);
            be.Show();
            this.Close();
        }

        //___________________________________________________________________________Időzítők

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
            if (szamlalo == 10)
            {
                T_idozito.Enabled = false;
                szamlalo = 0;
            }
        }

        private void T_idozito2_Tick(object sender, EventArgs e)
        {
            if (fa.plusz_meret() == true)
            {
                this.Size = new Size(350, 480);
                LB_hiba.Size = new Size(350, 125);
            }
        else if (hiba == true)
            {
                this.Size = new Size(350, 450);
                LB_hiba.Size = new Size(350, 80);
            }
            else
            {
                this.Size = new Size(350, 375);
            }
            T_idozito2.Enabled = false;
        }

        //___________________________________________________________________________Egyéb esemény
        private void formazasok_betoltese()
        {            
            de.Form_formazasok(alapertelmezett, id,this); //háttér

            de.Button_formazasok(alapertelmezett, id, BT_kilepes, BT_regisztracio, BT_talca, BT_vissza); //gombok

            de.Label_formazasok(alapertelmezett, id, LB_felh, LB_felirat, LB_hiba, LB_jelszo, LB_uj_jelszo_ism); // label
            de.Panel_formazasok(alapertelmezett, id, P_1); //panel

            de.TextBox_formazasok(alapertelmezett, id, TB_felh, TB_jelszo, TB_uj_jelszo); //textbox

            de.Jelszo_TextBox_beallitas(alapertelmezett, id, TB_uj_jelszo, TB_jelszo);
        }
    }
}
