namespace fodraszat
{
    partial class admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_adatok = new System.Windows.Forms.DataGridView();
            this.LB_ora = new System.Windows.Forms.Label();
            this.BT_kilepes = new System.Windows.Forms.Button();
            this.BT_talca = new System.Windows.Forms.Button();
            this.LB_felirat = new System.Windows.Forms.Label();
            this.P_1 = new System.Windows.Forms.Panel();
            this.BT_torles = new System.Windows.Forms.Button();
            this.BT_modositas = new System.Windows.Forms.Button();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.TB_jelszo = new System.Windows.Forms.TextBox();
            this.TB_felh = new System.Windows.Forms.TextBox();
            this.LB_tipus = new System.Windows.Forms.Label();
            this.LB_jelszo = new System.Windows.Forms.Label();
            this.LB_tisztit = new System.Windows.Forms.Label();
            this.LB_hiba_uzenet = new System.Windows.Forms.Label();
            this.T_idozito2 = new System.Windows.Forms.Timer(this.components);
            this.T_idozito = new System.Windows.Forms.Timer(this.components);
            this.BT_kijelentkezes = new System.Windows.Forms.Button();
            this.T_ora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_adatok)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_adatok
            // 
            this.DGV_adatok.AllowUserToAddRows = false;
            this.DGV_adatok.AllowUserToDeleteRows = false;
            this.DGV_adatok.AllowUserToResizeColumns = false;
            this.DGV_adatok.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_adatok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.DGV_adatok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_adatok.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DGV_adatok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_adatok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_adatok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_adatok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DGV_adatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_adatok.DefaultCellStyle = dataGridViewCellStyle23;
            this.DGV_adatok.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DGV_adatok.Location = new System.Drawing.Point(27, 88);
            this.DGV_adatok.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_adatok.Name = "DGV_adatok";
            this.DGV_adatok.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_adatok.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.DGV_adatok.RowHeadersVisible = false;
            this.DGV_adatok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV_adatok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_adatok.Size = new System.Drawing.Size(700, 315);
            this.DGV_adatok.TabIndex = 12;
            this.DGV_adatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_adatok_CellClick);
            this.DGV_adatok.CurrentCellChanged += new System.EventHandler(this.DGV_adatok_CurrentCellChanged);
            this.DGV_adatok.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_adatok_DataBindingComplete);
            // 
            // LB_ora
            // 
            this.LB_ora.BackColor = System.Drawing.Color.Transparent;
            this.LB_ora.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_ora.Location = new System.Drawing.Point(440, -1);
            this.LB_ora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ora.Name = "LB_ora";
            this.LB_ora.Size = new System.Drawing.Size(245, 30);
            this.LB_ora.TabIndex = 43;
            this.LB_ora.Text = "Óra";
            this.LB_ora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_kilepes
            // 
            this.BT_kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kilepes.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_kilepes.Location = new System.Drawing.Point(716, -1);
            this.BT_kilepes.Name = "BT_kilepes";
            this.BT_kilepes.Size = new System.Drawing.Size(35, 34);
            this.BT_kilepes.TabIndex = 41;
            this.BT_kilepes.Text = "X";
            this.BT_kilepes.UseVisualStyleBackColor = false;
            this.BT_kilepes.Click += new System.EventHandler(this.BT_kilepes_Click);
            // 
            // BT_talca
            // 
            this.BT_talca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_talca.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_talca.Location = new System.Drawing.Point(683, -1);
            this.BT_talca.Name = "BT_talca";
            this.BT_talca.Size = new System.Drawing.Size(35, 34);
            this.BT_talca.TabIndex = 40;
            this.BT_talca.Text = "▂";
            this.BT_talca.UseVisualStyleBackColor = false;
            this.BT_talca.Click += new System.EventHandler(this.BT_talca_Click);
            // 
            // LB_felirat
            // 
            this.LB_felirat.BackColor = System.Drawing.Color.Transparent;
            this.LB_felirat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_felirat.Location = new System.Drawing.Point(0, -1);
            this.LB_felirat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_felirat.Name = "LB_felirat";
            this.LB_felirat.Size = new System.Drawing.Size(441, 30);
            this.LB_felirat.TabIndex = 42;
            this.LB_felirat.Text = "- ✄ - Adminisztrátori felület - ✄ -";
            this.LB_felirat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_1
            // 
            this.P_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P_1.Location = new System.Drawing.Point(5, 30);
            this.P_1.Margin = new System.Windows.Forms.Padding(4);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(680, 2);
            this.P_1.TabIndex = 44;
            // 
            // BT_torles
            // 
            this.BT_torles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_torles.Location = new System.Drawing.Point(410, 505);
            this.BT_torles.Name = "BT_torles";
            this.BT_torles.Size = new System.Drawing.Size(140, 50);
            this.BT_torles.TabIndex = 46;
            this.BT_torles.Text = "Törlés";
            this.BT_torles.UseVisualStyleBackColor = false;
            this.BT_torles.Click += new System.EventHandler(this.BT_torles_Click);
            // 
            // BT_modositas
            // 
            this.BT_modositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_modositas.Location = new System.Drawing.Point(200, 505);
            this.BT_modositas.Name = "BT_modositas";
            this.BT_modositas.Size = new System.Drawing.Size(140, 50);
            this.BT_modositas.TabIndex = 45;
            this.BT_modositas.Text = "Módosítás";
            this.BT_modositas.UseVisualStyleBackColor = false;
            this.BT_modositas.Click += new System.EventHandler(this.BT_modositas_Click);
            // 
            // TB_id
            // 
            this.TB_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_id.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_id.Location = new System.Drawing.Point(13, 557);
            this.TB_id.Margin = new System.Windows.Forms.Padding(4);
            this.TB_id.MaxLength = 30;
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(250, 34);
            this.TB_id.TabIndex = 49;
            this.TB_id.TabStop = false;
            this.TB_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_id.Visible = false;
            // 
            // TB_jelszo
            // 
            this.TB_jelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_jelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_jelszo.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_jelszo.Location = new System.Drawing.Point(400, 455);
            this.TB_jelszo.Margin = new System.Windows.Forms.Padding(4);
            this.TB_jelszo.MaxLength = 35;
            this.TB_jelszo.Name = "TB_jelszo";
            this.TB_jelszo.Size = new System.Drawing.Size(250, 34);
            this.TB_jelszo.TabIndex = 48;
            this.TB_jelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_jelszo.TextChanged += new System.EventHandler(this.TB_jelszo_TextChanged);
            // 
            // TB_felh
            // 
            this.TB_felh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_felh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_felh.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_felh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_felh.Location = new System.Drawing.Point(100, 455);
            this.TB_felh.Margin = new System.Windows.Forms.Padding(4);
            this.TB_felh.MaxLength = 60;
            this.TB_felh.Name = "TB_felh";
            this.TB_felh.Size = new System.Drawing.Size(250, 34);
            this.TB_felh.TabIndex = 47;
            this.TB_felh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_felh.TextChanged += new System.EventHandler(this.TB_felh_TextChanged);
            // 
            // LB_tipus
            // 
            this.LB_tipus.BackColor = System.Drawing.Color.Transparent;
            this.LB_tipus.Location = new System.Drawing.Point(100, 407);
            this.LB_tipus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_tipus.Name = "LB_tipus";
            this.LB_tipus.Size = new System.Drawing.Size(250, 43);
            this.LB_tipus.TabIndex = 51;
            this.LB_tipus.Text = "Felhasználó név";
            this.LB_tipus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_jelszo
            // 
            this.LB_jelszo.BackColor = System.Drawing.Color.Transparent;
            this.LB_jelszo.Location = new System.Drawing.Point(400, 407);
            this.LB_jelszo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_jelszo.Name = "LB_jelszo";
            this.LB_jelszo.Size = new System.Drawing.Size(250, 43);
            this.LB_jelszo.TabIndex = 50;
            this.LB_jelszo.Text = "Jelszó";
            this.LB_jelszo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_tisztit
            // 
            this.LB_tisztit.BackColor = System.Drawing.Color.Transparent;
            this.LB_tisztit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_tisztit.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_tisztit.Location = new System.Drawing.Point(686, 477);
            this.LB_tisztit.Name = "LB_tisztit";
            this.LB_tisztit.Size = new System.Drawing.Size(41, 52);
            this.LB_tisztit.TabIndex = 52;
            this.LB_tisztit.Text = "✖";
            this.LB_tisztit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_tisztit.Click += new System.EventHandler(this.LB_tisztit_Click);
            // 
            // LB_hiba_uzenet
            // 
            this.LB_hiba_uzenet.BackColor = System.Drawing.Color.Transparent;
            this.LB_hiba_uzenet.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_hiba_uzenet.Location = new System.Drawing.Point(0, 570);
            this.LB_hiba_uzenet.Name = "LB_hiba_uzenet";
            this.LB_hiba_uzenet.Size = new System.Drawing.Size(750, 50);
            this.LB_hiba_uzenet.TabIndex = 53;
            this.LB_hiba_uzenet.Text = "Üdvözöllek";
            this.LB_hiba_uzenet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_hiba_uzenet.Visible = false;
            // 
            // T_idozito2
            // 
            this.T_idozito2.Tick += new System.EventHandler(this.T_idozito2_Tick);
            // 
            // T_idozito
            // 
            this.T_idozito.Interval = 500;
            this.T_idozito.Tick += new System.EventHandler(this.T_idozito_Tick);
            // 
            // BT_kijelentkezes
            // 
            this.BT_kijelentkezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kijelentkezes.Location = new System.Drawing.Point(12, 39);
            this.BT_kijelentkezes.Name = "BT_kijelentkezes";
            this.BT_kijelentkezes.Size = new System.Drawing.Size(140, 40);
            this.BT_kijelentkezes.TabIndex = 54;
            this.BT_kijelentkezes.Text = "Kijelentkezés";
            this.BT_kijelentkezes.UseVisualStyleBackColor = false;
            this.BT_kijelentkezes.Click += new System.EventHandler(this.BT_kijelentkezes_Click);
            // 
            // T_ora
            // 
            this.T_ora.Enabled = true;
            this.T_ora.Interval = 1000;
            this.T_ora.Tick += new System.EventHandler(this.T_ora_Tick);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 575);
            this.Controls.Add(this.BT_kijelentkezes);
            this.Controls.Add(this.LB_hiba_uzenet);
            this.Controls.Add(this.LB_tisztit);
            this.Controls.Add(this.LB_tipus);
            this.Controls.Add(this.LB_jelszo);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.TB_jelszo);
            this.Controls.Add(this.TB_felh);
            this.Controls.Add(this.BT_torles);
            this.Controls.Add(this.BT_modositas);
            this.Controls.Add(this.P_1);
            this.Controls.Add(this.LB_ora);
            this.Controls.Add(this.BT_kilepes);
            this.Controls.Add(this.BT_talca);
            this.Controls.Add(this.LB_felirat);
            this.Controls.Add(this.DGV_adatok);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_adatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_adatok;
        private System.Windows.Forms.Label LB_ora;
        private System.Windows.Forms.Button BT_kilepes;
        private System.Windows.Forms.Button BT_talca;
        private System.Windows.Forms.Label LB_felirat;
        private System.Windows.Forms.Panel P_1;
        private System.Windows.Forms.Button BT_torles;
        private System.Windows.Forms.Button BT_modositas;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.TextBox TB_jelszo;
        private System.Windows.Forms.TextBox TB_felh;
        private System.Windows.Forms.Label LB_tipus;
        private System.Windows.Forms.Label LB_jelszo;
        private System.Windows.Forms.Label LB_tisztit;
        private System.Windows.Forms.Label LB_hiba_uzenet;
        private System.Windows.Forms.Timer T_idozito2;
        private System.Windows.Forms.Timer T_idozito;
        private System.Windows.Forms.Button BT_kijelentkezes;
        private System.Windows.Forms.Timer T_ora;
    }
}