namespace fodraszat
{
    partial class adatkezeles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BT_kilepes = new System.Windows.Forms.Button();
            this.BT_talca = new System.Windows.Forms.Button();
            this.DGV_adatok = new System.Windows.Forms.DataGridView();
            this.TB_ora1 = new System.Windows.Forms.TextBox();
            this.TB_bejelentkezo = new System.Windows.Forms.TextBox();
            this.CB_tipus = new System.Windows.Forms.ComboBox();
            this.LB_datum = new System.Windows.Forms.Label();
            this.LB_bejelentkezo = new System.Windows.Forms.Label();
            this.LB_idopont = new System.Windows.Forms.Label();
            this.LB_tipus = new System.Windows.Forms.Label();
            this.BT_feltoltes = new System.Windows.Forms.Button();
            this.BT_modositas = new System.Windows.Forms.Button();
            this.BT_torles = new System.Windows.Forms.Button();
            this.LB_megjegyzes = new System.Windows.Forms.Label();
            this.BT_felhasznalo_modositas = new System.Windows.Forms.Button();
            this.BT_kijelentkezes = new System.Windows.Forms.Button();
            this.BT_tipus = new System.Windows.Forms.Button();
            this.LB_üdvözlet = new System.Windows.Forms.Label();
            this.LB_hiba_uzenet = new System.Windows.Forms.Label();
            this.T_idozito = new System.Windows.Forms.Timer(this.components);
            this.T_idozito2 = new System.Windows.Forms.Timer(this.components);
            this.TB_perc1 = new System.Windows.Forms.TextBox();
            this.LB_kettospont = new System.Windows.Forms.Label();
            this.LB_kettospont2 = new System.Windows.Forms.Label();
            this.TB_perc2 = new System.Windows.Forms.TextBox();
            this.TB_ora2 = new System.Windows.Forms.TextBox();
            this.LB_kotojel = new System.Windows.Forms.Label();
            this.LB_idopont_vege = new System.Windows.Forms.Label();
            this.LB_ora = new System.Windows.Forms.Label();
            this.T_ora = new System.Windows.Forms.Timer(this.components);
            this.LB_kereses = new System.Windows.Forms.Label();
            this.LB_aktualis = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.LB_tisztit = new System.Windows.Forms.Label();
            this.LB_frissítes = new System.Windows.Forms.Label();
            this.LB_kovetkezo = new System.Windows.Forms.Label();
            this.LB_vissza = new System.Windows.Forms.Label();
            this.LB_osszes_adat = new System.Windows.Forms.Label();
            this.LB_megjelenitett_adatok = new System.Windows.Forms.Label();
            this.T_idozito_3 = new System.Windows.Forms.Timer(this.components);
            this.LB_oldalszam = new System.Windows.Forms.Label();
            this.PANEL_feher = new System.Windows.Forms.Panel();
            this.BT_szemelyre_szabas = new System.Windows.Forms.Button();
            this.BT_statisztika = new System.Windows.Forms.Button();
            this.LB_datum_kiiras = new System.Windows.Forms.Label();
            this.dTP_1 = new System.Windows.Forms.DateTimePicker();
            this.LB_date = new System.Windows.Forms.Label();
            this.TB_megjegyzes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_adatok)).BeginInit();
            this.PANEL_feher.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_kilepes
            // 
            this.BT_kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kilepes.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_kilepes.Location = new System.Drawing.Point(1166, -1);
            this.BT_kilepes.Name = "BT_kilepes";
            this.BT_kilepes.Size = new System.Drawing.Size(35, 34);
            this.BT_kilepes.TabIndex = 18;
            this.BT_kilepes.Text = "✖";
            this.BT_kilepes.UseVisualStyleBackColor = false;
            this.BT_kilepes.Click += new System.EventHandler(this.BT_kilepes_Click_1);
            // 
            // BT_talca
            // 
            this.BT_talca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_talca.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_talca.Location = new System.Drawing.Point(1134, -1);
            this.BT_talca.Name = "BT_talca";
            this.BT_talca.Size = new System.Drawing.Size(35, 34);
            this.BT_talca.TabIndex = 17;
            this.BT_talca.Text = "▂";
            this.BT_talca.UseVisualStyleBackColor = false;
            this.BT_talca.Click += new System.EventHandler(this.BT_talca_Click_1);
            // 
            // DGV_adatok
            // 
            this.DGV_adatok.AllowUserToAddRows = false;
            this.DGV_adatok.AllowUserToDeleteRows = false;
            this.DGV_adatok.AllowUserToResizeColumns = false;
            this.DGV_adatok.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_adatok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_adatok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_adatok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_adatok.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DGV_adatok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_adatok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_adatok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_adatok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_adatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_adatok.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_adatok.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DGV_adatok.Location = new System.Drawing.Point(50, 155);
            this.DGV_adatok.Name = "DGV_adatok";
            this.DGV_adatok.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_adatok.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_adatok.RowHeadersVisible = false;
            this.DGV_adatok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DGV_adatok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_adatok.Size = new System.Drawing.Size(1100, 345);
            this.DGV_adatok.TabIndex = 1;
            this.DGV_adatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_adatok_CellClick);
            this.DGV_adatok.CurrentCellChanged += new System.EventHandler(this.DGV_adatok_CurrentCellChanged);
            this.DGV_adatok.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_adatok_DataBindingComplete);
            this.DGV_adatok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_adatok_KeyDown);
            // 
            // TB_ora1
            // 
            this.TB_ora1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_ora1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ora1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_ora1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_ora1.Location = new System.Drawing.Point(342, 552);
            this.TB_ora1.MaxLength = 2;
            this.TB_ora1.Name = "TB_ora1";
            this.TB_ora1.Size = new System.Drawing.Size(35, 34);
            this.TB_ora1.TabIndex = 3;
            this.TB_ora1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ora1.TextChanged += new System.EventHandler(this.TB_ora1_TextChanged);
            // 
            // TB_bejelentkezo
            // 
            this.TB_bejelentkezo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_bejelentkezo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_bejelentkezo.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_bejelentkezo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_bejelentkezo.Location = new System.Drawing.Point(608, 552);
            this.TB_bejelentkezo.MaxLength = 50;
            this.TB_bejelentkezo.Name = "TB_bejelentkezo";
            this.TB_bejelentkezo.Size = new System.Drawing.Size(250, 34);
            this.TB_bejelentkezo.TabIndex = 7;
            this.TB_bejelentkezo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_bejelentkezo.TextChanged += new System.EventHandler(this.TB_bejelentkezo_TextChanged);
            // 
            // CB_tipus
            // 
            this.CB_tipus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_tipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_tipus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_tipus.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CB_tipus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CB_tipus.FormattingEnabled = true;
            this.CB_tipus.IntegralHeight = false;
            this.CB_tipus.ItemHeight = 27;
            this.CB_tipus.Location = new System.Drawing.Point(875, 552);
            this.CB_tipus.Name = "CB_tipus";
            this.CB_tipus.Size = new System.Drawing.Size(250, 35);
            this.CB_tipus.TabIndex = 8;
            this.CB_tipus.SelectedIndexChanged += new System.EventHandler(this.CB_tipus_SelectedIndexChanged);
            // 
            // LB_datum
            // 
            this.LB_datum.BackColor = System.Drawing.Color.Transparent;
            this.LB_datum.Cursor = System.Windows.Forms.Cursors.Default;
            this.LB_datum.Location = new System.Drawing.Point(75, 514);
            this.LB_datum.Name = "LB_datum";
            this.LB_datum.Size = new System.Drawing.Size(250, 34);
            this.LB_datum.TabIndex = 15;
            this.LB_datum.Text = "Dátum";
            this.LB_datum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_datum.Click += new System.EventHandler(this.LB_datum_Click);
            // 
            // LB_bejelentkezo
            // 
            this.LB_bejelentkezo.BackColor = System.Drawing.Color.Transparent;
            this.LB_bejelentkezo.Location = new System.Drawing.Point(608, 514);
            this.LB_bejelentkezo.Name = "LB_bejelentkezo";
            this.LB_bejelentkezo.Size = new System.Drawing.Size(250, 34);
            this.LB_bejelentkezo.TabIndex = 16;
            this.LB_bejelentkezo.Text = "Bejelentkező neve";
            this.LB_bejelentkezo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_bejelentkezo.Click += new System.EventHandler(this.LB_bejelentkezo_Click);
            // 
            // LB_idopont
            // 
            this.LB_idopont.BackColor = System.Drawing.Color.Transparent;
            this.LB_idopont.Location = new System.Drawing.Point(342, 514);
            this.LB_idopont.Name = "LB_idopont";
            this.LB_idopont.Size = new System.Drawing.Size(103, 34);
            this.LB_idopont.TabIndex = 17;
            this.LB_idopont.Text = "Időpont";
            this.LB_idopont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_idopont.Click += new System.EventHandler(this.LB_idopont_Click);
            // 
            // LB_tipus
            // 
            this.LB_tipus.BackColor = System.Drawing.Color.Transparent;
            this.LB_tipus.Location = new System.Drawing.Point(875, 514);
            this.LB_tipus.Name = "LB_tipus";
            this.LB_tipus.Size = new System.Drawing.Size(234, 34);
            this.LB_tipus.TabIndex = 18;
            this.LB_tipus.Text = "Típus";
            this.LB_tipus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_tipus.Click += new System.EventHandler(this.LB_tipus_Click);
            // 
            // BT_feltoltes
            // 
            this.BT_feltoltes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_feltoltes.Location = new System.Drawing.Point(157, 677);
            this.BT_feltoltes.Name = "BT_feltoltes";
            this.BT_feltoltes.Size = new System.Drawing.Size(250, 50);
            this.BT_feltoltes.TabIndex = 10;
            this.BT_feltoltes.Text = "Feltöltés";
            this.BT_feltoltes.UseVisualStyleBackColor = false;
            this.BT_feltoltes.Click += new System.EventHandler(this.BT_feltoltes_Click);
            // 
            // BT_modositas
            // 
            this.BT_modositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_modositas.Location = new System.Drawing.Point(484, 677);
            this.BT_modositas.Name = "BT_modositas";
            this.BT_modositas.Size = new System.Drawing.Size(250, 50);
            this.BT_modositas.TabIndex = 11;
            this.BT_modositas.Text = "Módosítás";
            this.BT_modositas.UseVisualStyleBackColor = false;
            this.BT_modositas.Click += new System.EventHandler(this.BT_modositas_Click);
            // 
            // BT_torles
            // 
            this.BT_torles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_torles.Location = new System.Drawing.Point(795, 677);
            this.BT_torles.Name = "BT_torles";
            this.BT_torles.Size = new System.Drawing.Size(250, 50);
            this.BT_torles.TabIndex = 12;
            this.BT_torles.Text = "Törlés";
            this.BT_torles.UseVisualStyleBackColor = false;
            this.BT_torles.Click += new System.EventHandler(this.BT_torles_Click);
            this.BT_torles.MouseHover += new System.EventHandler(this.BT_torles_MouseHover);
            // 
            // LB_megjegyzes
            // 
            this.LB_megjegyzes.BackColor = System.Drawing.Color.Transparent;
            this.LB_megjegyzes.Location = new System.Drawing.Point(75, 589);
            this.LB_megjegyzes.Name = "LB_megjegyzes";
            this.LB_megjegyzes.Size = new System.Drawing.Size(1050, 34);
            this.LB_megjegyzes.TabIndex = 23;
            this.LB_megjegyzes.Text = "Megjegyzés (nem kötelező )";
            this.LB_megjegyzes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_megjegyzes.Click += new System.EventHandler(this.LB_megjegyzes_Click);
            // 
            // BT_felhasznalo_modositas
            // 
            this.BT_felhasznalo_modositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_felhasznalo_modositas.Location = new System.Drawing.Point(70, 73);
            this.BT_felhasznalo_modositas.Name = "BT_felhasznalo_modositas";
            this.BT_felhasznalo_modositas.Size = new System.Drawing.Size(250, 76);
            this.BT_felhasznalo_modositas.TabIndex = 13;
            this.BT_felhasznalo_modositas.Text = "Fiók kezelése";
            this.BT_felhasznalo_modositas.UseVisualStyleBackColor = false;
            this.BT_felhasznalo_modositas.Click += new System.EventHandler(this.BT_felhasznalo_modositas_Click);
            // 
            // BT_kijelentkezes
            // 
            this.BT_kijelentkezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kijelentkezes.Location = new System.Drawing.Point(8, 10);
            this.BT_kijelentkezes.Name = "BT_kijelentkezes";
            this.BT_kijelentkezes.Size = new System.Drawing.Size(200, 50);
            this.BT_kijelentkezes.TabIndex = 16;
            this.BT_kijelentkezes.Text = "Kijelentkezés";
            this.BT_kijelentkezes.UseVisualStyleBackColor = false;
            this.BT_kijelentkezes.Click += new System.EventHandler(this.BT_kijelentkezes_Click);
            // 
            // BT_tipus
            // 
            this.BT_tipus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_tipus.Location = new System.Drawing.Point(610, 73);
            this.BT_tipus.Name = "BT_tipus";
            this.BT_tipus.Size = new System.Drawing.Size(250, 76);
            this.BT_tipus.TabIndex = 15;
            this.BT_tipus.Text = "Típusok kezelése";
            this.BT_tipus.UseVisualStyleBackColor = false;
            this.BT_tipus.Click += new System.EventHandler(this.BT_tipus_Click);
            // 
            // LB_üdvözlet
            // 
            this.LB_üdvözlet.BackColor = System.Drawing.Color.Transparent;
            this.LB_üdvözlet.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_üdvözlet.Location = new System.Drawing.Point(214, 0);
            this.LB_üdvözlet.Name = "LB_üdvözlet";
            this.LB_üdvözlet.Size = new System.Drawing.Size(742, 70);
            this.LB_üdvözlet.TabIndex = 27;
            this.LB_üdvözlet.Text = "Üdvözöllek";
            this.LB_üdvözlet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_hiba_uzenet
            // 
            this.LB_hiba_uzenet.BackColor = System.Drawing.Color.Transparent;
            this.LB_hiba_uzenet.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_hiba_uzenet.Location = new System.Drawing.Point(25, 738);
            this.LB_hiba_uzenet.Name = "LB_hiba_uzenet";
            this.LB_hiba_uzenet.Size = new System.Drawing.Size(1150, 50);
            this.LB_hiba_uzenet.TabIndex = 28;
            this.LB_hiba_uzenet.Text = "Üdvözöllek";
            this.LB_hiba_uzenet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_hiba_uzenet.Visible = false;
            // 
            // T_idozito
            // 
            this.T_idozito.Interval = 500;
            this.T_idozito.Tick += new System.EventHandler(this.T_idozito_Tick);
            // 
            // T_idozito2
            // 
            this.T_idozito2.Tick += new System.EventHandler(this.T_idozito2_Tick);
            // 
            // TB_perc1
            // 
            this.TB_perc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_perc1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_perc1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_perc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_perc1.Location = new System.Drawing.Point(410, 552);
            this.TB_perc1.MaxLength = 2;
            this.TB_perc1.Name = "TB_perc1";
            this.TB_perc1.Size = new System.Drawing.Size(35, 34);
            this.TB_perc1.TabIndex = 4;
            this.TB_perc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_perc1.TextChanged += new System.EventHandler(this.TB_perc1_TextChanged);
            // 
            // LB_kettospont
            // 
            this.LB_kettospont.Location = new System.Drawing.Point(383, 552);
            this.LB_kettospont.Name = "LB_kettospont";
            this.LB_kettospont.Size = new System.Drawing.Size(21, 34);
            this.LB_kettospont.TabIndex = 31;
            this.LB_kettospont.Text = ":";
            this.LB_kettospont.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LB_kettospont2
            // 
            this.LB_kettospont2.Location = new System.Drawing.Point(525, 552);
            this.LB_kettospont2.Name = "LB_kettospont2";
            this.LB_kettospont2.Size = new System.Drawing.Size(21, 34);
            this.LB_kettospont2.TabIndex = 34;
            this.LB_kettospont2.Text = ":";
            this.LB_kettospont2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TB_perc2
            // 
            this.TB_perc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_perc2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_perc2.Enabled = false;
            this.TB_perc2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_perc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_perc2.Location = new System.Drawing.Point(552, 552);
            this.TB_perc2.MaxLength = 2;
            this.TB_perc2.Name = "TB_perc2";
            this.TB_perc2.ReadOnly = true;
            this.TB_perc2.Size = new System.Drawing.Size(35, 34);
            this.TB_perc2.TabIndex = 6;
            this.TB_perc2.TabStop = false;
            this.TB_perc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_perc2.TextChanged += new System.EventHandler(this.TB_perc2_TextChanged);
            // 
            // TB_ora2
            // 
            this.TB_ora2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_ora2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ora2.Enabled = false;
            this.TB_ora2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_ora2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_ora2.Location = new System.Drawing.Point(484, 552);
            this.TB_ora2.MaxLength = 2;
            this.TB_ora2.Name = "TB_ora2";
            this.TB_ora2.ReadOnly = true;
            this.TB_ora2.Size = new System.Drawing.Size(35, 34);
            this.TB_ora2.TabIndex = 5;
            this.TB_ora2.TabStop = false;
            this.TB_ora2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ora2.TextChanged += new System.EventHandler(this.TB_ora2_TextChanged);
            // 
            // LB_kotojel
            // 
            this.LB_kotojel.AutoSize = true;
            this.LB_kotojel.Location = new System.Drawing.Point(452, 552);
            this.LB_kotojel.Name = "LB_kotojel";
            this.LB_kotojel.Size = new System.Drawing.Size(28, 34);
            this.LB_kotojel.TabIndex = 35;
            this.LB_kotojel.Text = "-";
            this.LB_kotojel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LB_idopont_vege
            // 
            this.LB_idopont_vege.BackColor = System.Drawing.Color.Transparent;
            this.LB_idopont_vege.Location = new System.Drawing.Point(451, 514);
            this.LB_idopont_vege.Name = "LB_idopont_vege";
            this.LB_idopont_vege.Size = new System.Drawing.Size(156, 34);
            this.LB_idopont_vege.TabIndex = 36;
            this.LB_idopont_vege.Text = "Időpont vége";
            this.LB_idopont_vege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_idopont_vege.Click += new System.EventHandler(this.LB_idopont_vege_Click);
            // 
            // LB_ora
            // 
            this.LB_ora.BackColor = System.Drawing.Color.Transparent;
            this.LB_ora.Location = new System.Drawing.Point(962, 0);
            this.LB_ora.Name = "LB_ora";
            this.LB_ora.Size = new System.Drawing.Size(170, 70);
            this.LB_ora.TabIndex = 37;
            this.LB_ora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_ora
            // 
            this.T_ora.Enabled = true;
            this.T_ora.Interval = 1000;
            this.T_ora.Tick += new System.EventHandler(this.T_ora_Tick);
            // 
            // LB_kereses
            // 
            this.LB_kereses.BackColor = System.Drawing.Color.Transparent;
            this.LB_kereses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_kereses.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_kereses.Location = new System.Drawing.Point(554, 10);
            this.LB_kereses.Name = "LB_kereses";
            this.LB_kereses.Size = new System.Drawing.Size(40, 32);
            this.LB_kereses.TabIndex = 38;
            this.LB_kereses.Text = "🔎";
            this.LB_kereses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_kereses.Click += new System.EventHandler(this.LB_kereses_Click);
            this.LB_kereses.MouseHover += new System.EventHandler(this.LB_kereses_MouseHover);
            // 
            // LB_aktualis
            // 
            this.LB_aktualis.BackColor = System.Drawing.Color.Transparent;
            this.LB_aktualis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_aktualis.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_aktualis.Location = new System.Drawing.Point(270, 10);
            this.LB_aktualis.Name = "LB_aktualis";
            this.LB_aktualis.Size = new System.Drawing.Size(40, 32);
            this.LB_aktualis.TabIndex = 39;
            this.LB_aktualis.Text = "📝";
            this.LB_aktualis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_aktualis.Click += new System.EventHandler(this.LB_aktualis_Click);
            this.LB_aktualis.MouseHover += new System.EventHandler(this.LB_aktualis_MouseHover);
            // 
            // TB_id
            // 
            this.TB_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_id.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_id.Location = new System.Drawing.Point(75, 589);
            this.TB_id.MaxLength = 50;
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(250, 34);
            this.TB_id.TabIndex = 40;
            this.TB_id.TabStop = false;
            this.TB_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_id.Visible = false;
            // 
            // LB_tisztit
            // 
            this.LB_tisztit.BackColor = System.Drawing.Color.Transparent;
            this.LB_tisztit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_tisztit.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_tisztit.Location = new System.Drawing.Point(1084, 675);
            this.LB_tisztit.Name = "LB_tisztit";
            this.LB_tisztit.Size = new System.Drawing.Size(41, 52);
            this.LB_tisztit.TabIndex = 41;
            this.LB_tisztit.Text = "✖";
            this.LB_tisztit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_tisztit.Click += new System.EventHandler(this.LB_tisztit_Click);
            this.LB_tisztit.MouseHover += new System.EventHandler(this.LB_tisztit_MouseHover);
            // 
            // LB_frissítes
            // 
            this.LB_frissítes.BackColor = System.Drawing.Color.Transparent;
            this.LB_frissítes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_frissítes.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_frissítes.Location = new System.Drawing.Point(824, 10);
            this.LB_frissítes.Name = "LB_frissítes";
            this.LB_frissítes.Size = new System.Drawing.Size(40, 32);
            this.LB_frissítes.TabIndex = 42;
            this.LB_frissítes.Text = "⟳";
            this.LB_frissítes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_frissítes.Click += new System.EventHandler(this.LB_frissítes_Click);
            this.LB_frissítes.MouseHover += new System.EventHandler(this.LB_frissítes_MouseHover);
            // 
            // LB_kovetkezo
            // 
            this.LB_kovetkezo.BackColor = System.Drawing.Color.Transparent;
            this.LB_kovetkezo.Location = new System.Drawing.Point(135, 52);
            this.LB_kovetkezo.Name = "LB_kovetkezo";
            this.LB_kovetkezo.Size = new System.Drawing.Size(140, 32);
            this.LB_kovetkezo.TabIndex = 44;
            this.LB_kovetkezo.Text = "Következő";
            this.LB_kovetkezo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_kovetkezo.Click += new System.EventHandler(this.LB_kovetkezo_Click);
            this.LB_kovetkezo.MouseLeave += new System.EventHandler(this.LB_kovetkezo_MouseLeave);
            this.LB_kovetkezo.MouseHover += new System.EventHandler(this.LB_kovetkezo_MouseHover);
            // 
            // LB_vissza
            // 
            this.LB_vissza.BackColor = System.Drawing.Color.Transparent;
            this.LB_vissza.Location = new System.Drawing.Point(1, 52);
            this.LB_vissza.Name = "LB_vissza";
            this.LB_vissza.Size = new System.Drawing.Size(126, 32);
            this.LB_vissza.TabIndex = 43;
            this.LB_vissza.Text = "Vissza";
            this.LB_vissza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_vissza.Click += new System.EventHandler(this.LB_vissza_Click);
            this.LB_vissza.MouseLeave += new System.EventHandler(this.LB_vissza_MouseLeave);
            this.LB_vissza.MouseHover += new System.EventHandler(this.LB_vissza_MouseHover);
            // 
            // LB_osszes_adat
            // 
            this.LB_osszes_adat.BackColor = System.Drawing.Color.Transparent;
            this.LB_osszes_adat.Location = new System.Drawing.Point(825, 52);
            this.LB_osszes_adat.Name = "LB_osszes_adat";
            this.LB_osszes_adat.Size = new System.Drawing.Size(272, 32);
            this.LB_osszes_adat.TabIndex = 46;
            this.LB_osszes_adat.Text = "Összes adat:";
            this.LB_osszes_adat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_megjelenitett_adatok
            // 
            this.LB_megjelenitett_adatok.BackColor = System.Drawing.Color.Transparent;
            this.LB_megjelenitett_adatok.Location = new System.Drawing.Point(434, 52);
            this.LB_megjelenitett_adatok.Name = "LB_megjelenitett_adatok";
            this.LB_megjelenitett_adatok.Size = new System.Drawing.Size(374, 32);
            this.LB_megjelenitett_adatok.TabIndex = 45;
            this.LB_megjelenitett_adatok.Text = "Megjelenített adatok száma:";
            this.LB_megjelenitett_adatok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_idozito_3
            // 
            this.T_idozito_3.Enabled = true;
            this.T_idozito_3.Tick += new System.EventHandler(this.T_idozito_3_Tick);
            // 
            // LB_oldalszam
            // 
            this.LB_oldalszam.BackColor = System.Drawing.Color.Transparent;
            this.LB_oldalszam.Location = new System.Drawing.Point(281, 52);
            this.LB_oldalszam.Name = "LB_oldalszam";
            this.LB_oldalszam.Size = new System.Drawing.Size(149, 32);
            this.LB_oldalszam.TabIndex = 47;
            this.LB_oldalszam.Text = ". oldal";
            this.LB_oldalszam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PANEL_feher
            // 
            this.PANEL_feher.Controls.Add(this.LB_vissza);
            this.PANEL_feher.Controls.Add(this.LB_kovetkezo);
            this.PANEL_feher.Controls.Add(this.LB_oldalszam);
            this.PANEL_feher.Controls.Add(this.LB_megjelenitett_adatok);
            this.PANEL_feher.Controls.Add(this.LB_frissítes);
            this.PANEL_feher.Controls.Add(this.LB_osszes_adat);
            this.PANEL_feher.Controls.Add(this.LB_aktualis);
            this.PANEL_feher.Controls.Add(this.LB_kereses);
            this.PANEL_feher.Location = new System.Drawing.Point(50, 418);
            this.PANEL_feher.Name = "PANEL_feher";
            this.PANEL_feher.Size = new System.Drawing.Size(1100, 93);
            this.PANEL_feher.TabIndex = 48;
            // 
            // BT_szemelyre_szabas
            // 
            this.BT_szemelyre_szabas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_szemelyre_szabas.Location = new System.Drawing.Point(340, 73);
            this.BT_szemelyre_szabas.Name = "BT_szemelyre_szabas";
            this.BT_szemelyre_szabas.Size = new System.Drawing.Size(250, 76);
            this.BT_szemelyre_szabas.TabIndex = 14;
            this.BT_szemelyre_szabas.Text = "Személyre szabás";
            this.BT_szemelyre_szabas.UseVisualStyleBackColor = false;
            this.BT_szemelyre_szabas.Click += new System.EventHandler(this.BT_szemelyre_szabas_Click);
            // 
            // BT_statisztika
            // 
            this.BT_statisztika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_statisztika.Location = new System.Drawing.Point(880, 73);
            this.BT_statisztika.Name = "BT_statisztika";
            this.BT_statisztika.Size = new System.Drawing.Size(250, 76);
            this.BT_statisztika.TabIndex = 49;
            this.BT_statisztika.Text = "Statisztika";
            this.BT_statisztika.UseVisualStyleBackColor = false;
            this.BT_statisztika.Click += new System.EventHandler(this.BT_statisztika_Click);
            // 
            // LB_datum_kiiras
            // 
            this.LB_datum_kiiras.BackColor = System.Drawing.Color.Transparent;
            this.LB_datum_kiiras.Location = new System.Drawing.Point(75, 552);
            this.LB_datum_kiiras.Name = "LB_datum_kiiras";
            this.LB_datum_kiiras.Size = new System.Drawing.Size(250, 34);
            this.LB_datum_kiiras.TabIndex = 48;
            this.LB_datum_kiiras.Text = "Text";
            this.LB_datum_kiiras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dTP_1
            // 
            this.dTP_1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dTP_1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTP_1.Location = new System.Drawing.Point(75, 552);
            this.dTP_1.Name = "dTP_1";
            this.dTP_1.Size = new System.Drawing.Size(250, 33);
            this.dTP_1.TabIndex = 50;
            this.dTP_1.ValueChanged += new System.EventHandler(this.dTP_1_ValueChanged);
            // 
            // LB_date
            // 
            this.LB_date.BackColor = System.Drawing.Color.Transparent;
            this.LB_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_date.Location = new System.Drawing.Point(295, 552);
            this.LB_date.Name = "LB_date";
            this.LB_date.Size = new System.Drawing.Size(30, 34);
            this.LB_date.TabIndex = 51;
            this.LB_date.Text = "▼";
            this.LB_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_date.Click += new System.EventHandler(this.LB_datum_kiiras_Click);
            // 
            // TB_megjegyzes
            // 
            this.TB_megjegyzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_megjegyzes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_megjegyzes.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_megjegyzes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_megjegyzes.Location = new System.Drawing.Point(75, 637);
            this.TB_megjegyzes.MaxLength = 300;
            this.TB_megjegyzes.Name = "TB_megjegyzes";
            this.TB_megjegyzes.Size = new System.Drawing.Size(1050, 34);
            this.TB_megjegyzes.TabIndex = 52;
            this.TB_megjegyzes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_megjegyzes.TextChanged += new System.EventHandler(this.TB_megjegyzes_TextChanged);
            // 
            // adatkezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.TB_megjegyzes);
            this.Controls.Add(this.LB_date);
            this.Controls.Add(this.dTP_1);
            this.Controls.Add(this.LB_datum_kiiras);
            this.Controls.Add(this.BT_statisztika);
            this.Controls.Add(this.BT_szemelyre_szabas);
            this.Controls.Add(this.PANEL_feher);
            this.Controls.Add(this.LB_tisztit);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.LB_ora);
            this.Controls.Add(this.LB_idopont_vege);
            this.Controls.Add(this.LB_kotojel);
            this.Controls.Add(this.LB_kettospont2);
            this.Controls.Add(this.TB_perc2);
            this.Controls.Add(this.TB_ora2);
            this.Controls.Add(this.LB_kettospont);
            this.Controls.Add(this.TB_perc1);
            this.Controls.Add(this.LB_hiba_uzenet);
            this.Controls.Add(this.LB_üdvözlet);
            this.Controls.Add(this.BT_tipus);
            this.Controls.Add(this.BT_kijelentkezes);
            this.Controls.Add(this.BT_felhasznalo_modositas);
            this.Controls.Add(this.LB_megjegyzes);
            this.Controls.Add(this.BT_torles);
            this.Controls.Add(this.BT_modositas);
            this.Controls.Add(this.BT_feltoltes);
            this.Controls.Add(this.LB_tipus);
            this.Controls.Add(this.LB_idopont);
            this.Controls.Add(this.LB_bejelentkezo);
            this.Controls.Add(this.LB_datum);
            this.Controls.Add(this.CB_tipus);
            this.Controls.Add(this.TB_bejelentkezo);
            this.Controls.Add(this.TB_ora1);
            this.Controls.Add(this.DGV_adatok);
            this.Controls.Add(this.BT_kilepes);
            this.Controls.Add(this.BT_talca);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "adatkezeles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adatkezeles";
            this.Load += new System.EventHandler(this.adatkezeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_adatok)).EndInit();
            this.PANEL_feher.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_kilepes;
        private System.Windows.Forms.Button BT_talca;
        private System.Windows.Forms.DataGridView DGV_adatok;
        private System.Windows.Forms.TextBox TB_ora1;
        private System.Windows.Forms.TextBox TB_bejelentkezo;
        private System.Windows.Forms.ComboBox CB_tipus;
        private System.Windows.Forms.Label LB_datum;
        private System.Windows.Forms.Label LB_bejelentkezo;
        private System.Windows.Forms.Label LB_idopont;
        private System.Windows.Forms.Label LB_tipus;
        private System.Windows.Forms.Button BT_feltoltes;
        private System.Windows.Forms.Button BT_modositas;
        private System.Windows.Forms.Button BT_torles;
        private System.Windows.Forms.Label LB_megjegyzes;
        private System.Windows.Forms.Button BT_felhasznalo_modositas;
        private System.Windows.Forms.Button BT_kijelentkezes;
        private System.Windows.Forms.Button BT_tipus;
        private System.Windows.Forms.Label LB_üdvözlet;
        private System.Windows.Forms.Label LB_hiba_uzenet;
        private System.Windows.Forms.Timer T_idozito;
        private System.Windows.Forms.Timer T_idozito2;
        private System.Windows.Forms.TextBox TB_perc1;
        private System.Windows.Forms.Label LB_kettospont;
        private System.Windows.Forms.Label LB_kettospont2;
        private System.Windows.Forms.TextBox TB_perc2;
        private System.Windows.Forms.TextBox TB_ora2;
        private System.Windows.Forms.Label LB_kotojel;
        private System.Windows.Forms.Label LB_idopont_vege;
        private System.Windows.Forms.Label LB_ora;
        private System.Windows.Forms.Timer T_ora;
        private System.Windows.Forms.Label LB_kereses;
        private System.Windows.Forms.Label LB_aktualis;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label LB_tisztit;
        private System.Windows.Forms.Label LB_frissítes;
        private System.Windows.Forms.Label LB_kovetkezo;
        private System.Windows.Forms.Label LB_vissza;
        private System.Windows.Forms.Label LB_osszes_adat;
        private System.Windows.Forms.Label LB_megjelenitett_adatok;
        private System.Windows.Forms.Timer T_idozito_3;
        private System.Windows.Forms.Label LB_oldalszam;
        private System.Windows.Forms.Panel PANEL_feher;
        private System.Windows.Forms.Button BT_szemelyre_szabas;
        private System.Windows.Forms.Button BT_statisztika;
        private System.Windows.Forms.Label LB_datum_kiiras;
        private System.Windows.Forms.DateTimePicker dTP_1;
        private System.Windows.Forms.Label LB_date;
        private System.Windows.Forms.TextBox TB_megjegyzes;
    }
}

