using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fodraszat
{
    public partial class statisztika : Form
    {
        string alapertelmezett = default(string);
        string felh = default(string);
        string jelszo = default(string);
        int id = default(int);

        int hany_idopont_van_osszesen = default(int);       
        int kuncsaftok_szama = default(int);
        int osszeg = default(int);
        string legtobbet_jaro_kuncsaft = default(string);

        bool keres = false;

        List<int> tipus_id = new List<int>();
        List<int> tipus_ara = new List<int>();
        List<string> honapok_szamban = new List<string>();
        List<string> evek_szamban = new List<string>();

        ToolTip tip = new ToolTip();


        public statisztika()
        {
            InitializeComponent();
        }

        public statisztika(string _felh, string _jelszo, int _id, string _alapertelmezett)
        {
            InitializeComponent();
            alapertelmezett = _alapertelmezett;
            felh = _felh;
            jelszo = _jelszo;
            id = _id;
        }

        design_beallitasok de = new design_beallitasok();
        fuggvenyek f = new fuggvenyek();
        csatlakoz cs = new csatlakoz();

        private void statisztika_Load(object sender, EventArgs e)
        {
            formazasok_betoltese();
            CB_ev.Items.Clear();
            CB_ev.Items.Add("");

            string lekerdezes = "SELECT DISTINCT foglalas.idopont FROM foglalas WHERE fodrasz_az='"+id+"'";
            f.lista_feltoltes_string(lekerdezes,evek_szamban);
         
            for (int i = 0; i < evek_szamban.Count; i++)
            {               
                CB_ev.Items.Add(evek_szamban[i]);
            }            
            for (int i = 1; i <= 12; i++)
            {
                if (Convert.ToString(i).Length ==1)
                {
                    honapok_szamban.Add("0" + i);
                }
                else
                {
                    honapok_szamban.Add(i+"");
                }
            }
        }
        //_____________________________________________________________________________Beolvasási esemény
        private void formazasok_betoltese()
        {
            de.Form_formazasok(alapertelmezett,id,this);
            de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_kereses);
            de.Label_formazasok(alapertelmezett, id, LB_felirat, LB_információk, LB_adatok,LB_kereses);
            de.Button_formazasok(alapertelmezett, id, BT_kilepes, BT_talca, BT_vissza);
            de.Panel_formazasok(alapertelmezett, id, P_1,P_2);
            de.Combobox_Formazasok(alapertelmezett, id, CB_ev, CB_honap);
            LB_adatok.Text = felh + " a statisztikai adataid";
            lekerdezesek();
            LB_kereses.Size = new Size(LB_kereses.Width, CB_ev.Height);
        }

        //_____________________________________________________________________________Gombok
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
            adatkezeles at = new adatkezeles(id, felh, jelszo, alapertelmezett);
            at.Show();
            this.Close();
        }

        //______________________________________________________________________________Események
        private static string Elso_betu_nagy(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }// seged fuggveny

        private void lekerdezesek()
        {
            //System.Windows.Forms.Clipboard.SetDataObject(lekerdezes, true);
            tipus_ara.Clear();
            tipus_id.Clear();
            osszeg = 0;

            string keresunk = default(string);
            string ido = default(string);
            if (keres)
            {
                string evszam = default(string);                                
                string honap_szam = default(string);
                try
                {
                    if (CB_honap.SelectedIndex != 0)
                    {
                        honap_szam = honapok_szamban[CB_honap.SelectedIndex-1];
                    }
                    else
                    {
                        honap_szam = honapok_szamban[CB_honap.SelectedIndex];
                    }
                    if (CB_honap.SelectedIndex ==0)
                    {
                        honap_szam = "";
                    }
                                      
                }
                catch { honap_szam = ""; }

                try
                {
                    evszam = CB_ev.Text.Substring(2);
                }
                catch { evszam= ""; }

                ido = CB_ev.Text + ". év " + CB_honap.Text + "i hónapjában:\n";

                if (CB_ev.Text == "" && CB_honap.Text !="")
                {
                    ido = CB_honap.Text + "i hónapokban:\n";
                    ido = Elso_betu_nagy(ido);
                }
                if (CB_ev.Text !="" && CB_honap.Text =="")
                {
                    ido = CB_ev.Text + "-(e/a/ö)-s évben:\n";
                }
                if (CB_ev.Text =="" && CB_honap.Text =="")
                {
                    ido = "";
                }               
                keresunk = " AND Date_Format (foglalas.idopont,'%y. %m. %d. %H:%i') like '%" + evszam + ". %" + honap_szam + ". %%. %%:%%'";
            }
            else
            {
                keresunk = default(string);
                ido = default(string);
            }           
            string lekerdezes = "SELECT COUNT(*) FROM foglalas WHERE fodrasz_az = '" + id + "'"+keresunk;           
            hany_idopont_van_osszesen = Convert.ToInt32(f.egy_adat_lekerdezese(lekerdezes));

            lekerdezes = "SELECT tipus_ar.id,tipus_ar.ar FROM tipus_ar WHERE fodrasz_az ='"+id+"'";

            cs.kapcs.Open();
            cs.parancs.Connection = cs.kapcs;
            cs.parancs.CommandText = lekerdezes;
            MySqlDataReader olvas = cs.parancs.ExecuteReader();
            
            while (olvas.Read())    //beolvas amíg     
            {
                tipus_id.Add(olvas.GetInt32(0));
                tipus_ara.Add(olvas.GetInt32(1));
            }
            olvas.Close();
            cs.kapcs.Close();

            for (int i = 0; i < tipus_id.Count; i++)
            {           
                lekerdezes = "SELECT COUNT(*) FROM foglalas WHERE fodrasz_az ='" + id + "' && tipus_az ='"+tipus_id[i]+"'"+keresunk;           
                osszeg += Convert.ToInt32(f.egy_adat_lekerdezese(lekerdezes)) * tipus_ara[i];
            }

            lekerdezes = "SELECT COUNT(DISTINCt(foglalas.nev)) FROM foglalas WHERE foglalas.fodrasz_az = '"+id+"'"+keresunk;
            kuncsaftok_szama = Convert.ToInt32(f.egy_adat_lekerdezese(lekerdezes));

            lekerdezes = "SELECT DISTINCT(foglalas.nev), COUNT(foglalas.nev) FROM foglalas WHERE fodrasz_az ='"+id+"' " + keresunk + " GROUP BY foglalas.nev DESC Limit 1";
            legtobbet_jaro_kuncsaft = f.egy_adat_lekerdezese(lekerdezes);
           // System.Windows.Forms.Clipboard.SetDataObject(lekerdezes, true);
            LB_információk.Text = "";
            if (CB_ev.Text != "" || CB_honap.Text != "")
            {
                LB_információk.Text += ido;
            }      
               
            if (kuncsaftok_szama ==0)
            {
                LB_információk.Text += "Nem járnak hozzád vengédek.\n";
            }
            else
            {
                LB_információk.Text += kuncsaftok_szama + " vendég jár hozzád.\n";
            }
            
            if (hany_idopont_van_osszesen ==0)
            {
                LB_információk.Text += "Nincs foglalásod.\n";
            }
            else
            {
                LB_információk.Text += hany_idopont_van_osszesen + " foglalásod van összesen.\n";
            }        
            if (kuncsaftok_szama != 0)
            {
                LB_információk.Text += legtobbet_jaro_kuncsaft + " jár hozzád a legtöbbször.\n";
            }          
            if (osszeg !=0)
            {
                LB_információk.Text += String.Format("{0:#,###,###.##}", osszeg) + " FT értékű a foglalások összege.\n"; // itt kiiratom az eredményt
            }
            else
            {
                LB_információk.Text += "Ebben az időintervallumban nem volt/nincs bevételed.\n"; // itt kiiratom az eredményt
            }
            

        }

        private void LB_kereses_Click(object sender, EventArgs e)
        {            
            if (keres == true)
            {
                keres = false;              
                lekerdezesek();
                de.Label_formazasok(alapertelmezett, id, LB_kereses);
            }
            else
            {               
                keres = true;                
                lekerdezesek();
                de.Szines_hatteru_Label_formazasok(alapertelmezett, id, LB_kereses);
            }
        }

        private void CB_ev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keres)
            {
                lekerdezesek();
            }
        }

        private void CB_honap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keres)
            {
                lekerdezesek();
            }
        }

        private void CB_ev_MouseHover(object sender, EventArgs e)
        {
            if(keres)
            {

            }
            else
            {
                tip.SetToolTip(CB_ev, "Szűréshez, kattintcs a feliratra!");
            }
            
        }

        private void CB_honap_MouseHover(object sender, EventArgs e)
        {
            if (keres)
            {

            }
            else
            {
                tip.SetToolTip(CB_ev, "Szűréshez, kattintcs a feliratra!");
            }
        }
    }
}
