namespace fodraszat
{
    partial class tipus_kezeles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LB_felirat = new System.Windows.Forms.Label();
            this.P_1 = new System.Windows.Forms.Panel();
            this.DGV_adatok = new System.Windows.Forms.DataGridView();
            this.LB_tipus = new System.Windows.Forms.Label();
            this.LB_ar = new System.Windows.Forms.Label();
            this.TB_ar = new System.Windows.Forms.TextBox();
            this.TB_tipus = new System.Windows.Forms.TextBox();
            this.BT_kilepes = new System.Windows.Forms.Button();
            this.BT_talca = new System.Windows.Forms.Button();
            this.LB_üdvözlet = new System.Windows.Forms.Label();
            this.BT_torles = new System.Windows.Forms.Button();
            this.BT_modositas = new System.Windows.Forms.Button();
            this.BT_feltoltes = new System.Windows.Forms.Button();
            this.LB_hiba_uzenet = new System.Windows.Forms.Label();
            this.LB_idotartam = new System.Windows.Forms.Label();
            this.TB_ora = new System.Windows.Forms.TextBox();
            this.TB_perc = new System.Windows.Forms.TextBox();
            this.LB_oraa = new System.Windows.Forms.Label();
            this.LB_perc = new System.Windows.Forms.Label();
            this.BT_vissza = new System.Windows.Forms.Button();
            this.T_ora = new System.Windows.Forms.Timer(this.components);
            this.LB_ora = new System.Windows.Forms.Label();
            this.T_idozito = new System.Windows.Forms.Timer(this.components);
            this.T_idozito2 = new System.Windows.Forms.Timer(this.components);
            this.TB_id = new System.Windows.Forms.TextBox();
            this.LB_tisztit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_adatok)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_felirat
            // 
            this.LB_felirat.BackColor = System.Drawing.Color.Transparent;
            this.LB_felirat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_felirat.Location = new System.Drawing.Point(0, 0);
            this.LB_felirat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_felirat.Name = "LB_felirat";
            this.LB_felirat.Size = new System.Drawing.Size(470, 30);
            this.LB_felirat.TabIndex = 14;
            this.LB_felirat.Text = "- ✄ - Hajvágás típusa, ára és ideje - ✄ -";
            this.LB_felirat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_1
            // 
            this.P_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P_1.Location = new System.Drawing.Point(0, 30);
            this.P_1.Margin = new System.Windows.Forms.Padding(4);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(745, 2);
            this.P_1.TabIndex = 13;
            // 
            // DGV_adatok
            // 
            this.DGV_adatok.AllowUserToAddRows = false;
            this.DGV_adatok.AllowUserToDeleteRows = false;
            this.DGV_adatok.AllowUserToResizeColumns = false;
            this.DGV_adatok.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_adatok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_adatok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_adatok.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DGV_adatok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_adatok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_adatok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_adatok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_adatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_adatok.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGV_adatok.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DGV_adatok.Location = new System.Drawing.Point(20, 87);
            this.DGV_adatok.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_adatok.Name = "DGV_adatok";
            this.DGV_adatok.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_adatok.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_adatok.RowHeadersVisible = false;
            this.DGV_adatok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV_adatok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_adatok.Size = new System.Drawing.Size(760, 315);
            this.DGV_adatok.TabIndex = 11;
            this.DGV_adatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_adatok_CellClick);
            this.DGV_adatok.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_adatok_DataBindingComplete);
            this.DGV_adatok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_adatok_KeyDown);
            // 
            // LB_tipus
            // 
            this.LB_tipus.BackColor = System.Drawing.Color.Transparent;
            this.LB_tipus.Location = new System.Drawing.Point(20, 413);
            this.LB_tipus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_tipus.Name = "LB_tipus";
            this.LB_tipus.Size = new System.Drawing.Size(250, 43);
            this.LB_tipus.TabIndex = 21;
            this.LB_tipus.Text = "Hajvágás típusa";
            this.LB_tipus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_ar
            // 
            this.LB_ar.BackColor = System.Drawing.Color.Transparent;
            this.LB_ar.Location = new System.Drawing.Point(280, 413);
            this.LB_ar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ar.Name = "LB_ar";
            this.LB_ar.Size = new System.Drawing.Size(250, 43);
            this.LB_ar.TabIndex = 20;
            this.LB_ar.Text = "Hajvágás ára (Ft)";
            this.LB_ar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_ar
            // 
            this.TB_ar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_ar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ar.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_ar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_ar.Location = new System.Drawing.Point(280, 460);
            this.TB_ar.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ar.MaxLength = 15;
            this.TB_ar.Name = "TB_ar";
            this.TB_ar.Size = new System.Drawing.Size(250, 34);
            this.TB_ar.TabIndex = 2;
            this.TB_ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ar.TextChanged += new System.EventHandler(this.TB_ar_TextChanged);
            // 
            // TB_tipus
            // 
            this.TB_tipus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_tipus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_tipus.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_tipus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_tipus.Location = new System.Drawing.Point(20, 460);
            this.TB_tipus.Margin = new System.Windows.Forms.Padding(4);
            this.TB_tipus.MaxLength = 50;
            this.TB_tipus.Name = "TB_tipus";
            this.TB_tipus.Size = new System.Drawing.Size(250, 34);
            this.TB_tipus.TabIndex = 1;
            this.TB_tipus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_tipus.TextChanged += new System.EventHandler(this.TB_tipus_TextChanged);
            // 
            // BT_kilepes
            // 
            this.BT_kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kilepes.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_kilepes.Location = new System.Drawing.Point(766, -1);
            this.BT_kilepes.Name = "BT_kilepes";
            this.BT_kilepes.Size = new System.Drawing.Size(35, 34);
            this.BT_kilepes.TabIndex = 10;
            this.BT_kilepes.Text = "X";
            this.BT_kilepes.UseVisualStyleBackColor = false;
            this.BT_kilepes.Click += new System.EventHandler(this.BT_kilepes_Click);
            // 
            // BT_talca
            // 
            this.BT_talca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_talca.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_talca.Location = new System.Drawing.Point(734, -1);
            this.BT_talca.Name = "BT_talca";
            this.BT_talca.Size = new System.Drawing.Size(35, 34);
            this.BT_talca.TabIndex = 9;
            this.BT_talca.Text = "▂";
            this.BT_talca.UseVisualStyleBackColor = false;
            this.BT_talca.Click += new System.EventHandler(this.BT_talca_Click);
            // 
            // LB_üdvözlet
            // 
            this.LB_üdvözlet.BackColor = System.Drawing.Color.Transparent;
            this.LB_üdvözlet.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_üdvözlet.Location = new System.Drawing.Point(126, 37);
            this.LB_üdvözlet.Name = "LB_üdvözlet";
            this.LB_üdvözlet.Size = new System.Drawing.Size(654, 46);
            this.LB_üdvözlet.TabIndex = 28;
            this.LB_üdvözlet.Text = "Üdvözöllek";
            this.LB_üdvözlet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_torles
            // 
            this.BT_torles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_torles.Location = new System.Drawing.Point(515, 502);
            this.BT_torles.Name = "BT_torles";
            this.BT_torles.Size = new System.Drawing.Size(140, 50);
            this.BT_torles.TabIndex = 7;
            this.BT_torles.Text = "Törlés";
            this.BT_torles.UseVisualStyleBackColor = false;
            this.BT_torles.Click += new System.EventHandler(this.BT_torles_Click);
            this.BT_torles.MouseHover += new System.EventHandler(this.BT_torles_MouseHover);
            // 
            // BT_modositas
            // 
            this.BT_modositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_modositas.Location = new System.Drawing.Point(330, 502);
            this.BT_modositas.Name = "BT_modositas";
            this.BT_modositas.Size = new System.Drawing.Size(140, 50);
            this.BT_modositas.TabIndex = 6;
            this.BT_modositas.Text = "Módosítás";
            this.BT_modositas.UseVisualStyleBackColor = false;
            this.BT_modositas.Click += new System.EventHandler(this.BT_modositas_Click);
            // 
            // BT_feltoltes
            // 
            this.BT_feltoltes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_feltoltes.Location = new System.Drawing.Point(145, 502);
            this.BT_feltoltes.Name = "BT_feltoltes";
            this.BT_feltoltes.Size = new System.Drawing.Size(140, 50);
            this.BT_feltoltes.TabIndex = 5;
            this.BT_feltoltes.Text = "Feltöltés";
            this.BT_feltoltes.UseVisualStyleBackColor = false;
            this.BT_feltoltes.Click += new System.EventHandler(this.BT_feltoltes_Click);
            // 
            // LB_hiba_uzenet
            // 
            this.LB_hiba_uzenet.BackColor = System.Drawing.Color.Transparent;
            this.LB_hiba_uzenet.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_hiba_uzenet.Location = new System.Drawing.Point(0, 555);
            this.LB_hiba_uzenet.Name = "LB_hiba_uzenet";
            this.LB_hiba_uzenet.Size = new System.Drawing.Size(800, 93);
            this.LB_hiba_uzenet.TabIndex = 32;
            this.LB_hiba_uzenet.Text = "Hiba üzenet";
            this.LB_hiba_uzenet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_hiba_uzenet.Visible = false;
            // 
            // LB_idotartam
            // 
            this.LB_idotartam.BackColor = System.Drawing.Color.Transparent;
            this.LB_idotartam.Location = new System.Drawing.Point(538, 413);
            this.LB_idotartam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_idotartam.Name = "LB_idotartam";
            this.LB_idotartam.Size = new System.Drawing.Size(250, 43);
            this.LB_idotartam.TabIndex = 34;
            this.LB_idotartam.Text = "Időtartam";
            this.LB_idotartam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_ora
            // 
            this.TB_ora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_ora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ora.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_ora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_ora.Location = new System.Drawing.Point(538, 460);
            this.TB_ora.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ora.MaxLength = 2;
            this.TB_ora.Name = "TB_ora";
            this.TB_ora.Size = new System.Drawing.Size(50, 34);
            this.TB_ora.TabIndex = 3;
            this.TB_ora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ora.TextChanged += new System.EventHandler(this.TB_ora_TextChanged);
            // 
            // TB_perc
            // 
            this.TB_perc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_perc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_perc.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_perc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_perc.Location = new System.Drawing.Point(663, 460);
            this.TB_perc.Margin = new System.Windows.Forms.Padding(4);
            this.TB_perc.MaxLength = 2;
            this.TB_perc.Name = "TB_perc";
            this.TB_perc.Size = new System.Drawing.Size(50, 34);
            this.TB_perc.TabIndex = 4;
            this.TB_perc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_perc.TextChanged += new System.EventHandler(this.TB_perc_TextChanged);
            // 
            // LB_oraa
            // 
            this.LB_oraa.BackColor = System.Drawing.Color.Transparent;
            this.LB_oraa.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_oraa.Location = new System.Drawing.Point(596, 460);
            this.LB_oraa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_oraa.Name = "LB_oraa";
            this.LB_oraa.Size = new System.Drawing.Size(59, 34);
            this.LB_oraa.TabIndex = 36;
            this.LB_oraa.Text = "óra";
            this.LB_oraa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LB_perc
            // 
            this.LB_perc.BackColor = System.Drawing.Color.Transparent;
            this.LB_perc.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_perc.Location = new System.Drawing.Point(721, 460);
            this.LB_perc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_perc.Name = "LB_perc";
            this.LB_perc.Size = new System.Drawing.Size(59, 34);
            this.LB_perc.TabIndex = 37;
            this.LB_perc.Text = "perc";
            this.LB_perc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BT_vissza
            // 
            this.BT_vissza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_vissza.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_vissza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_vissza.Location = new System.Drawing.Point(20, 42);
            this.BT_vissza.Name = "BT_vissza";
            this.BT_vissza.Size = new System.Drawing.Size(100, 40);
            this.BT_vissza.TabIndex = 8;
            this.BT_vissza.Text = "Vissza";
            this.BT_vissza.UseVisualStyleBackColor = false;
            this.BT_vissza.Click += new System.EventHandler(this.BT_vissza_Click);
            // 
            // T_ora
            // 
            this.T_ora.Enabled = true;
            this.T_ora.Interval = 1000;
            this.T_ora.Tick += new System.EventHandler(this.T_ora_Tick);
            // 
            // LB_ora
            // 
            this.LB_ora.BackColor = System.Drawing.Color.Transparent;
            this.LB_ora.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_ora.Location = new System.Drawing.Point(478, 0);
            this.LB_ora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ora.Name = "LB_ora";
            this.LB_ora.Size = new System.Drawing.Size(246, 30);
            this.LB_ora.TabIndex = 39;
            this.LB_ora.Text = "Óra";
            this.LB_ora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // TB_id
            // 
            this.TB_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_id.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_id.Location = new System.Drawing.Point(530, 49);
            this.TB_id.Margin = new System.Windows.Forms.Padding(4);
            this.TB_id.MaxLength = 30;
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
            this.LB_tisztit.Location = new System.Drawing.Point(739, 502);
            this.LB_tisztit.Name = "LB_tisztit";
            this.LB_tisztit.Size = new System.Drawing.Size(41, 52);
            this.LB_tisztit.TabIndex = 53;
            this.LB_tisztit.Text = "✖";
            this.LB_tisztit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_tisztit.Click += new System.EventHandler(this.LB_tisztit_Click);
            // 
            // tipus_kezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.LB_tisztit);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.LB_ora);
            this.Controls.Add(this.BT_vissza);
            this.Controls.Add(this.LB_perc);
            this.Controls.Add(this.LB_oraa);
            this.Controls.Add(this.TB_perc);
            this.Controls.Add(this.LB_idotartam);
            this.Controls.Add(this.TB_ora);
            this.Controls.Add(this.LB_hiba_uzenet);
            this.Controls.Add(this.BT_torles);
            this.Controls.Add(this.BT_modositas);
            this.Controls.Add(this.BT_feltoltes);
            this.Controls.Add(this.LB_üdvözlet);
            this.Controls.Add(this.BT_kilepes);
            this.Controls.Add(this.BT_talca);
            this.Controls.Add(this.LB_tipus);
            this.Controls.Add(this.LB_ar);
            this.Controls.Add(this.TB_ar);
            this.Controls.Add(this.TB_tipus);
            this.Controls.Add(this.DGV_adatok);
            this.Controls.Add(this.LB_felirat);
            this.Controls.Add(this.P_1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "tipus_kezeles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tipus_kezeles";
            this.Load += new System.EventHandler(this.tipus_hozzáadás_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_adatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_felirat;
        private System.Windows.Forms.Panel P_1;
        private System.Windows.Forms.DataGridView DGV_adatok;
        private System.Windows.Forms.Label LB_tipus;
        private System.Windows.Forms.Label LB_ar;
        private System.Windows.Forms.TextBox TB_ar;
        private System.Windows.Forms.TextBox TB_tipus;
        private System.Windows.Forms.Button BT_kilepes;
        private System.Windows.Forms.Button BT_talca;
        private System.Windows.Forms.Label LB_üdvözlet;
        private System.Windows.Forms.Button BT_torles;
        private System.Windows.Forms.Button BT_modositas;
        private System.Windows.Forms.Button BT_feltoltes;
        private System.Windows.Forms.Label LB_hiba_uzenet;
        private System.Windows.Forms.Label LB_idotartam;
        private System.Windows.Forms.TextBox TB_ora;
        private System.Windows.Forms.TextBox TB_perc;
        private System.Windows.Forms.Label LB_oraa;
        private System.Windows.Forms.Label LB_perc;
        private System.Windows.Forms.Button BT_vissza;
        private System.Windows.Forms.Timer T_ora;
        private System.Windows.Forms.Label LB_ora;
        private System.Windows.Forms.Timer T_idozito;
        private System.Windows.Forms.Timer T_idozito2;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label LB_tisztit;
    }
}