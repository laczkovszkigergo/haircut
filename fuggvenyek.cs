using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace fodraszat
{
    class fuggvenyek
    {
        csatlakoz cs = new csatlakoz();

        private void _adatbazis_letrehozas_feltoltes(string adatbazis_feltolt, string kapcsolodas)
        {
            string adatb_fel = adatbazis_feltolt;
            string kap = kapcsolodas;

            try
            {
                cs.kapcs.Open(); //csatlakozás az adatbázishoz
                cs.ds = new DataSet();
                cs.da = new MySqlDataAdapter(adatb_fel, kap); // parancs futtatása
                cs.da.Fill(cs.ds, "Feltöltés");
            }
            catch
            { }
            finally {cs.kapcs.Close(); } //kapcsolat lezárása
        }
        public void adatbazis_letrehozas_feltoltes(string adatbazis_feltolt, string kapcsolodas)
        {
            _adatbazis_letrehozas_feltoltes(adatbazis_feltolt, kapcsolodas);
        }

        public bool vanewamp()
        {
            return _vanewamp();
        }
        private bool _vanewamp()
        {
            MySqlConnection wamp;
            string wampkapcs = @"server=127.0.0.1;userid=root;password=";
            try
            {
                wamp = new MySqlConnection(wampkapcs);
                wamp.Open();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        //____________________________________________________________________________________________adatmüveletek
        private void _adatbazis_letrehozas()
        {          
            MySqlConnection csat = null;
            string csa = @"server=127.0.0.1;userid=root;password=";
            try
            {              
                csat = new MySqlConnection(csa);
                csat.Open();
                cs.parancs = new MySqlCommand(cs.adatbazis_letrehozasa(), csat);
                cs.parancs.ExecuteNonQuery();
                
                
            }catch {}
            csat.Close();
        }
        public void adatbazis_letrehozas()
        {
            _adatbazis_letrehozas();
        }

        private string _egy_adat_lekerdezese(string lekerdezes)
        {
            var adat = default(string);
            cs.kapcs.Open();
            cs.parancs.Connection = cs.kapcs;
            cs.parancs.CommandText = lekerdezes;
            MySqlDataReader olvas = cs.parancs.ExecuteReader();
            while (olvas.Read())    //beolvas amíg     
            {
                adat = olvas.GetString(0);
                break;
            }
            olvas.Close();
            cs.kapcs.Close();
            return adat;
        }
        public string egy_adat_lekerdezese(string lekerdezes)
        {
            return _egy_adat_lekerdezese(lekerdezes);
        }

        private void _megjelen(string lekerdezes, System.Windows.Forms.DataGridView DGV)
        {
            try
            {
                if (cs.kapcs.State != ConnectionState.Open)
                {
                    cs.kapcs.Open();
                }

                cs.ds = new DataSet();
                cs.da = new MySqlDataAdapter(lekerdezes, cs.kapcs);
                cs.da.Fill(cs.ds, "Foglalas");
                DGV.DataSource = cs.ds.Tables["Foglalas"];
                try
                {
                    DGV.Rows[0].Selected = false;

                    if (cs.ds.Tables["Foglalas"].Rows.Count != 0)
                    {
                        DGV.DataSource = cs.ds.Tables["Foglalas"];
                    }

                }
                catch { }

            }
            catch { System.Windows.Forms.MessageBox.Show("Megszakadt a kapcsolat az adatbázissal!", "Adatbázis!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning); }
            cs.kapcs.Close();
        }
        public void megjelen(string lekerdezes, System.Windows.Forms.DataGridView DGV)
        {
            _megjelen(lekerdezes, DGV);
        }

        private void _adat_kezeles(string lekerdezes)
        {
            try
            {
                cs.kapcs.Open(); //csatlakozás az adatbázishoz
                cs.ds = new DataSet();
                cs.da = new MySqlDataAdapter(lekerdezes, cs.kapcs); // parancs futtatása
                cs.da.Fill(cs.ds, "Feltoltes");
            }
            catch { System.Windows.Forms.MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz!", "Csatlakozási hiba!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); } //hibaüzenet
            finally { cs.kapcs.Close(); } //kapcsolat lezárása
        }
        public void adat_kezeles(string lekerdezes)
        {
            _adat_kezeles(lekerdezes);
        }

        private bool _van_e_ilyen_adat(string lekerdezes)
        {
            string adat = default(string);
            cs.kapcs.Open();
            cs.parancs.Connection = cs.kapcs;
            cs.parancs.CommandText = lekerdezes;
            MySqlDataReader olvas = cs.parancs.ExecuteReader();

            while (olvas.Read())    //beolvas amíg     
            {
                adat = olvas.GetString(0);
                break;
            }
            olvas.Close();
            cs.kapcs.Close();

            if (adat != default(string))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool van_e_ilyen_adat(string lekerdezes)
        {
            return _van_e_ilyen_adat(lekerdezes);
        }

        //____________________________________________________________________________________________lista, combobox feltöltések
        private void _lista_feltoltes(string lekerdezes, List<int> lista)
        {
            try
            {
                int tipus_az = default(int);
                cs.kapcs.Open();
                cs.parancs.CommandText = lekerdezes;
                // SQL lekérdezéssel megnézzük az adatbázisban a megadott értékeket (felhasználó név, jelszó)          
                MySqlDataReader olvas = cs.parancs.ExecuteReader();
                while (olvas.Read())    //beolvas amíg     
                {
                    tipus_az = olvas.GetInt32(0);

                    if (lista.Contains(tipus_az))
                    {

                    }
                    else
                    {
                        lista.Add(tipus_az);
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Nem sikerült beolvasni az adatok!", "Sikertelen beolvasás", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }
            cs.kapcs.Close();
        }
        public void lista_feltoltes(string lekerdezes,List<int> lista)
        {
            _lista_feltoltes(lekerdezes, lista);
        }

        private void _lista_feltoltes_string(string lekerdezes, List<string> lista)
        {
            try
            {
                string tipus_az = default(string);
                cs.kapcs.Open();
                cs.parancs.CommandText = lekerdezes;
                // SQL lekérdezéssel megnézzük az adatbázisban a megadott értékeket (felhasználó név, jelszó)          
                MySqlDataReader olvas = cs.parancs.ExecuteReader();
                while (olvas.Read())    //beolvas amíg     
                {
                    tipus_az = olvas.GetString(0).Split('.')[0];
                    if (lista.Contains(tipus_az))
                    {

                    }
                    else
                    {
                        lista.Add(tipus_az);
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Nem sikerült beolvasni az adatok!", "Sikertelen beolvasás", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }
            cs.kapcs.Close();
        }
        public void lista_feltoltes_string(string lekerdezes, List<string> lista)
        {
            _lista_feltoltes_string(lekerdezes, lista);
        }

        private void _combobox_feltoltes(string lekerdezes, System.Windows.Forms.ComboBox CB)
        {
            CB.Items.Clear();
            try
            {
                string tipus = default(string);
                cs.kapcs.Open();
                cs.parancs.CommandText = lekerdezes;
                cs.parancs.Connection = cs.kapcs;
                // SQL lekérdezéssel megnézzük az adatbázisban a megadott értékeket (felhasználó név, jelszó)          
                MySqlDataReader olvas = cs.parancs.ExecuteReader();
                CB.Items.Add("");
                while (olvas.Read())    //beolvas amíg     
                {
                    tipus = olvas.GetString(0);
                    if (CB.Items.Contains(tipus))
                    {

                    }
                    else
                    {
                        CB.Items.Add(tipus);
                    }
                }olvas.Close();
            }
            catch { System.Windows.Forms.MessageBox.Show("Nem sikerült beolvasni a típusokat!", "Sikertelen beolvasás", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }
            cs.kapcs.Close();
        }
        public void combobox_feltoltes(string lekerdezes, System.Windows.Forms.ComboBox CB)
        {
            _combobox_feltoltes(lekerdezes, CB);
        }

        //____________________________________________________________________________________________Textbox műveletek
        private void _perc(System.Windows.Forms.TextBox be)
        {
            if (be.Text != "")
            {
                char[] szoveg = be.Text.ToCharArray();

                if (szoveg[0] != '0' && szoveg[0] != '1' && szoveg[0] != '2' && szoveg[0] != '3' && szoveg[0] != '4' && szoveg[0] != '5')
                {
                    be.Text = be.Text.Substring(0, be.Text.Length - 1);
                    be.SelectionStart = be.Text.Length;
                }
            }

        }
        public void perc(System.Windows.Forms.TextBox be)
        {
            _perc(be);
        }

        private void _ora(System.Windows.Forms.TextBox be)
        {
            if (be.Text != "")
            {
                char[] szoveg = be.Text.ToCharArray();

                if (szoveg[0] != '0' && szoveg[0] != '1' && szoveg[0] != '2')
                {
                    be.Text = be.Text.Substring(0, be.Text.Length - 1);
                    be.SelectionStart = be.Text.Length;
                }
                if (szoveg.Length > 1)
                {
                    if (szoveg[0] == '2' && szoveg[1] != '0' && szoveg[1] != '1' && szoveg[1] != '2' && szoveg[1] != '3')
                    {
                        be.Text = be.Text.Substring(0, be.Text.Length - 1);
                        be.SelectionStart = be.Text.Length;
                    }
                }

            }

        }
        public void ora (System.Windows.Forms.TextBox be)
        {
            _ora(be);
        }

        private void _szam_tb(System.Windows.Forms.TextBox be)
        {
            if (!Regex.IsMatch(be.Text, @"^[0-9]+$") && be.Text.Length != 0)
            {
                be.Text = be.Text.Substring(0, be.Text.Length - 1);
                be.SelectionStart = be.Text.Length;
            }
        }
        public void szam_tb(System.Windows.Forms.TextBox be)
        {
            _szam_tb(be);
        }

        private void _betu_tb(System.Windows.Forms.TextBox be)
        {
            if (!Regex.IsMatch(be.Text, @"^[a-z +aáeéiíoóöőuúüű+AÁEÉIÍOÓÖŐUÚÜŰ+A-Z ]+$") && be.Text.Length != 0)
            {
                be.Text = be.Text.Substring(0, be.Text.Length - 1);
                be.SelectionStart = be.Text.Length;
            }
            _no_double_space(be);
        }
        public void betu_tb(System.Windows.Forms.TextBox be)
        {
            _betu_tb(be);
        }

        private void _betu_rtb(System.Windows.Forms.RichTextBox be)
        {
            if (!Regex.IsMatch(be.Text, @"^[a-z +aáeéiíoóöőuúüű+AÁEÉIÍOÓÖŐUÚÜŰ+A-Z ]+$") && be.Text.Length != 0)
            {
                be.Text = be.Text.Substring(0, be.Text.Length - 1);
                be.SelectionStart = be.Text.Length;
            }
        }
        public void betu_rtb(System.Windows.Forms.RichTextBox be)
        {
            _betu_rtb(be);
        }

        private void _betu_es_szam_Tb(System.Windows.Forms.TextBox be)
        {
            if(!Regex.IsMatch(be.Text, @"^[a-zA-Z +aáeéiíoóöőuúüű+AÁEÉIÍOÓÖŐUÚÜŰ+0-9 ]+$") && be.Text.Length != 0)
            {
                be.Text = be.Text.Substring(0, be.Text.Length - 1);
                be.SelectionStart = be.Text.Length;
            }
            _no_double_space(be);
        }
        public void betu_es_szam_TB(System.Windows.Forms.TextBox be)
        {
            _betu_es_szam_Tb(be);
        }

        private void _rTB_elso_betu_mindig_nagybetu(System.Windows.Forms.RichTextBox rTB)
        {
            if (rTB.Text.Length <= 0) return;
            string s = rTB.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = rTB.SelectionStart;
                int curSelLength = rTB.SelectionLength;
                rTB.SelectionStart = 0;
                rTB.SelectionLength = 1;
                rTB.SelectedText = s.ToUpper();
                rTB.SelectionStart = curSelStart;
                rTB.SelectionLength = curSelLength;
            }
        }
        public void rTB_elso_betu_mindig_nagybetu(System.Windows.Forms.RichTextBox rTB)
        {
            _rTB_elso_betu_mindig_nagybetu(rTB);
        }

        private void _TB_elso_betu_mindig_nagybetu(System.Windows.Forms.TextBox TB)
        {
            if (TB.Text.Length <= 0) return;
            string s = TB.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = TB.SelectionStart;
                int curSelLength = TB.SelectionLength;
                TB.SelectionStart = 0;
                TB.SelectionLength = 1;
                TB.SelectedText = s.ToUpper();
                TB.SelectionStart = curSelStart;
                TB.SelectionLength = curSelLength;
            }
        }
        public void TB_elso_betu_mindig_nagybetu(System.Windows.Forms.TextBox TB)
        {
            _TB_elso_betu_mindig_nagybetu(TB);
        }

        private void _LB_elso_betu_mindig_nagybetu(System.Windows.Forms.Label LB)
        {
            if (LB.Text.Length <= 0) return;
            string s = LB.Text.Substring(0, 1);
            LB.Text = s.ToUpper();
        }
        public void LB_elso_betu_mindig_nagybetu(System.Windows.Forms.Label LB)
        {
            _LB_elso_betu_mindig_nagybetu(LB);
        }

        private void _no_double_space(System.Windows.Forms.TextBox TB)
        {
            TB.Text = Regex.Replace(TB.Text, "^[ \t\r\n]", "");
        }         
       
    }
}
