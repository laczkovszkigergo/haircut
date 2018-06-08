using System;
using System.Drawing;
using System.Windows.Forms;

namespace fodraszat
{
    public partial class admin : Form
    {

        string alapertelmezett = default(string);
        int id = 0;

        int szamlalo = default(int);
        bool hiba = default(bool);
        string uz = default(string);

        design_beallitasok de = new design_beallitasok();
        fuggvenyek f = new fuggvenyek();

        public admin()
        {
            InitializeComponent();
        }

        public admin(string _alapertelmezett)
        {
            InitializeComponent();
            alapertelmezett = _alapertelmezett;
        }

        private void formazasok_betoltese()
        {          
            de.Form_formazasok(alapertelmezett, id, this);
            de.Button_formazasok(alapertelmezett, id, BT_kilepes, BT_modositas, BT_talca, BT_torles,BT_kijelentkezes);
            de.Label_formazasok(alapertelmezett, id, LB_felirat, LB_jelszo, LB_ora, LB_tipus,LB_tisztit,LB_hiba_uzenet);
            de.Datagrid_formazasok(alapertelmezett, id, DGV_adatok);
            de.TextBox_formazasok(alapertelmezett, id, TB_felh, TB_id, TB_jelszo);
            de.Panel_formazasok(alapertelmezett, id, P_1);         
        }

        private void admin_Load(object sender, EventArgs e)
        {
            formazasok_betoltese();
            megjelenites();
            LB_ora.Text = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss");
        }

        private void DGV_adatok_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.DGV_adatok.Columns[0].Visible = false;
        }

        //______________________________________________________________________________________Alap gombok
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

        //_______________________________________________________________________________________Datagridview

        private void DGV_adatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TB_id.Text = DGV_adatok.CurrentRow.Cells[0].Value.ToString();
                TB_felh.Text = DGV_adatok.CurrentRow.Cells[1].Value.ToString();
                TB_jelszo.Text = DGV_adatok.CurrentRow.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void DGV_adatok_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                TB_id.Text = DGV_adatok.CurrentRow.Cells[0].Value.ToString();
            TB_felh.Text = DGV_adatok.CurrentRow.Cells[1].Value.ToString();
            TB_jelszo.Text = DGV_adatok.CurrentRow.Cells[2].Value.ToString();
        }
            catch { }
        }

        //________________________________________________________________________________________Események

        private void megjelenites()
        {
            string lekerdezes = "SELECT id,felhasznalo AS 'Felhasználó',jelszo AS 'Jelszó' FROM belepesi_adatok";
            f.megjelen(lekerdezes, DGV_adatok);
            tisztít();
        }
        
        private void modositas()
        {
            string fodrasz = "["+TB_felh.Text + "] nevű felhasználót?";
            DialogResult dialogResult = MessageBox.Show("Biztosan módosítani akarod a(z)" + fodrasz, "Módosítás", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string feltoltes = @"UPDATE `belepesi_adatok` SET `felhasznalo`= '" + TB_felh.Text + "', `jelszo`= '" + TB_jelszo.Text + "' WHERE `id`=" + TB_id.Text + ";";
            // System.Windows.Forms.Clipboard.SetDataObject(feltoltes, true);

            if (dialogResult == DialogResult.Yes)
            {
                f.adat_kezeles(feltoltes);
                megjelenites();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void torles()
        {
            uz = default(string);
            string fodrasz = "[" + TB_felh.Text + "]";

            if (TB_id.Text != "")
            {            
            if (torolheto_e())
            {
                try
                {
                    
                    string feltoltes = @"DELETE FROM  `belepesi_adatok` Where `id` ='" + TB_id.Text + "'";
                    DialogResult dialogResult = MessageBox.Show("Biztosan törölni akarod a(z) " + fodrasz+ " nevű fodrászt?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                }
                catch { MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet
            }
            else
            {
                try
                {
                    string feltoltes = @"DELETE FROM  `tipus_ar` Where `fodrasz_az` ='" + TB_id.Text + "'";
                    string feltoltes2 = @"DELETE FROM `foglalas` WHERE `fodrasz_az` ='" + TB_id.Text + "'";
                    string feltoltes3 = @"DELETE FROM  `belepesi_adatok` Where `id` ='" + TB_id.Text + "'";
                    DialogResult dialogResult = MessageBox.Show(fodrasz+"-hoz/hez/höz tartoznak 'Foglalási' és/vagy 'Típus' adatok is!\nAmennyiben törli a fiókot a hozzátartozó adatok is törlődnek!","Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        f.adat_kezeles(feltoltes);
                        f.adat_kezeles(feltoltes2);
                        f.adat_kezeles(feltoltes3);
                        megjelenites();
                            uz = "törlés!";
                            hiba = false;
                            T_idozito.Start();
                            T_idozito2.Start();
                        }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch { MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error); } //hibaüzenet
            }
            }
            else
            {
                hiba = true;
                uz = "Nincs kijelölve adat!";
                T_idozito.Start();
                T_idozito2.Start();
            }
        }

        private bool torolheto_e()
        {
            string feltoltes = @"SELECT * FROM  `foglalas` Where `fodrasz_az` ='" + TB_id.Text + "'";
            if (f.van_e_ilyen_adat(feltoltes))
            {
                return false;               
            }
            else
            {
                feltoltes = @"SELECT * FROM  `tipus_ar` Where `fodrasz_az` ='" + TB_id.Text + "'";
                if (f.van_e_ilyen_adat(feltoltes))
                {
                    return false;
                   
                }
                else
                {
                    return true;
                }
            }
        }

        private void tisztít()
        {
            TB_id.Text = "";
            TB_felh.Text = "";
            TB_jelszo.Text = "";
            hiba = false;
            uz = "";
            LB_hiba_uzenet.Text = "";
            T_idozito2.Start();
        }

        //________________________________________________________________________________________Gomb események

        private void BT_modositas_Click(object sender, EventArgs e)
        {
            uz = default(string);
            hiba = false;
            if (TB_id.Text !="")
            {
                string lekerdezes = "SELECT belepesi_adatok.felhasznalo FROM belepesi_adatok WHERE not (id = '" + TB_id.Text + "') AND belepesi_adatok.felhasznalo = '" + TB_felh.Text + "'";
                // System.Windows.Forms.Clipboard.SetDataObject(lekerdezes, true);

                if (!f.van_e_ilyen_adat(lekerdezes))
                {
                    modositas();
                    uz = "módosítás!";
                    hiba = false;
                    T_idozito.Start();
                    T_idozito2.Start();
                }
                else
                {
                    T_idozito.Enabled = true;
                    T_idozito2.Enabled = true;
                    LB_hiba_uzenet.Text = "Ez a felhasználónév már foglalt!";
                    hiba = true;
                }
            }
            else
            {
                hiba = true;
                uz = "Nincs kijelölve adat!";
                T_idozito.Start();
                T_idozito2.Start();
            }
            
        }

        private void BT_torles_Click(object sender, EventArgs e)
        {
            torles();
        }

        private void TB_felh_TextChanged(object sender, EventArgs e)
        {
            f.TB_elso_betu_mindig_nagybetu(TB_felh);
            f.betu_es_szam_TB(TB_felh);
            if (TB_felh.Text =="" && TB_jelszo.Text =="")
            {
                TB_id.Text = "";
            }
        }

        private void TB_jelszo_TextChanged(object sender, EventArgs e)
        {
            f.betu_es_szam_TB(TB_jelszo);
            if (TB_felh.Text == "" && TB_jelszo.Text == "")
            {
                TB_id.Text = "";
            }
        }

        private void BT_kijelentkezes_Click(object sender, EventArgs e)
        {
            bejelentkezes at = new bejelentkezes();
            at.Show();
            this.Close();
        }

        //________________________________________________________________________________________Label click
        private void LB_tisztit_Click(object sender, EventArgs e)
        {
            tisztít();
        }

        //________________________________________________________________________________________Timerek

        private void T_idozito_Tick(object sender, EventArgs e)
        {
            szamlalo++;
             if (uz == "törlés!" || uz == "módosítás!")
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
            else if (uz == "Nincs kijelölve adat!" && hiba == true)
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
            if (hiba == true || (uz == "törlés!" || uz == "módosítás!"))
            {
                this.Size = new Size(750,625);
            }
            else
            {
                this.Size = new Size(750,575);
            }
            T_idozito2.Enabled = false;
        }

        private void T_ora_Tick(object sender, EventArgs e)
        {
            LB_ora.Text = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss");
        }
    }
}
