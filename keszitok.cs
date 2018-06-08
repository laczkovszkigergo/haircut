using System;
using System.Windows.Forms;

namespace fodraszat
{
    public partial class keszitok : Form
    {

        string alapertelmezett;
        int id;

        public keszitok()
        {
            InitializeComponent();
        }
        public keszitok(string _alapertelmezett, int _id)
        {
            InitializeComponent();
            alapertelmezett = _alapertelmezett;
            id = _id;
        }

        design_beallitasok de = new design_beallitasok();

        private void keszitok_Load(object sender, EventArgs e)
        {
            LB_felirat.Text = "Készítők   " + DateTime.Now.ToString("HH:mm:ss");
            formazasi_beallitasok_betoltese();
            LB_inform.Text = "A programot készítette Laczkovszki Gergő.\nMunkában résztvevők:\n\nGyarmati Viktória\nIgonda Péter\nMészáros Milán\nPéter Attila\nSzabó Viktor\nScholtz Tibor.\n\nHálás köszönet érte nekik!";
        }
        //________________________________________________________________Események
        private void formazasi_beallitasok_betoltese()
        {
            de.Form_formazasok(alapertelmezett, id, this);

            de.Panel_formazasok(alapertelmezett, id, P_1);

            de.Label_formazasok(alapertelmezett, id, LB_felirat,LB_inform);

            de.Button_formazasok(alapertelmezett, id, BT_kilepes, BT_talca,BT_vissza);
        }
        // ________________________________________________________________Gombok
        private void BT_talca_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BT_kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //_________________________________________________________________Időzítők
        private void T_ora_Tick(object sender, EventArgs e)
        {
            LB_felirat.Text = "Készítők   " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void BT_vissza_Click(object sender, EventArgs e)
        {
            bejelentkezes be = new bejelentkezes(alapertelmezett, id);
            be.Show();
            this.Close();
        }
    }
}
