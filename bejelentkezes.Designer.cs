namespace fodraszat
{
    partial class bejelentkezes
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
            this.BT_talca = new System.Windows.Forms.Button();
            this.BT_kilepes = new System.Windows.Forms.Button();
            this.TB_felh = new System.Windows.Forms.TextBox();
            this.TB_jelszo = new System.Windows.Forms.TextBox();
            this.LB_felh = new System.Windows.Forms.Label();
            this.LB_jelszo = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LB_hiba = new System.Windows.Forms.Label();
            this.T_idozito = new System.Windows.Forms.Timer(this.components);
            this.P_1 = new System.Windows.Forms.Panel();
            this.LB_felirat = new System.Windows.Forms.Label();
            this.BT_regisztracio = new System.Windows.Forms.Button();
            this.BT_belepes = new System.Windows.Forms.Button();
            this.T_ora = new System.Windows.Forms.Timer(this.components);
            this.CB_felhasznalonev = new System.Windows.Forms.CheckBox();
            this.BT_keszitok = new System.Windows.Forms.Button();
            this.LB_kulcs = new System.Windows.Forms.Label();
            this.LB_konyv = new System.Windows.Forms.Label();
            this.TB_felh_admin = new System.Windows.Forms.TextBox();
            this.TB_jelszo_admin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_talca
            // 
            this.BT_talca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_talca.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_talca.Location = new System.Drawing.Point(334, -1);
            this.BT_talca.Name = "BT_talca";
            this.BT_talca.Size = new System.Drawing.Size(35, 34);
            this.BT_talca.TabIndex = 7;
            this.BT_talca.Text = "▂";
            this.BT_talca.UseVisualStyleBackColor = false;
            this.BT_talca.Click += new System.EventHandler(this.BT_talca_Click);
            // 
            // BT_kilepes
            // 
            this.BT_kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kilepes.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_kilepes.Location = new System.Drawing.Point(366, -1);
            this.BT_kilepes.Name = "BT_kilepes";
            this.BT_kilepes.Size = new System.Drawing.Size(35, 34);
            this.BT_kilepes.TabIndex = 8;
            this.BT_kilepes.Text = "X";
            this.BT_kilepes.UseVisualStyleBackColor = false;
            this.BT_kilepes.Click += new System.EventHandler(this.BT_kilepes_Click);
            // 
            // TB_felh
            // 
            this.TB_felh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_felh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_felh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_felh.Location = new System.Drawing.Point(75, 100);
            this.TB_felh.MaxLength = 60;
            this.TB_felh.Name = "TB_felh";
            this.TB_felh.Size = new System.Drawing.Size(250, 34);
            this.TB_felh.TabIndex = 1;
            this.TB_felh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_felh.TextChanged += new System.EventHandler(this.TB_felh_TextChanged);
            this.TB_felh.Enter += new System.EventHandler(this.textbox_Enter);
            this.TB_felh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_felh_KeyDown);
            // 
            // TB_jelszo
            // 
            this.TB_jelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_jelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_jelszo.Location = new System.Drawing.Point(75, 190);
            this.TB_jelszo.MaxLength = 35;
            this.TB_jelszo.Name = "TB_jelszo";
            this.TB_jelszo.PasswordChar = '♥';
            this.TB_jelszo.Size = new System.Drawing.Size(250, 34);
            this.TB_jelszo.TabIndex = 2;
            this.TB_jelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_jelszo.TextChanged += new System.EventHandler(this.TB_jelszo_TextChanged);
            this.TB_jelszo.Enter += new System.EventHandler(this.textbox_Enter);
            this.TB_jelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_jelszo_KeyDown);
            this.TB_jelszo.MouseLeave += new System.EventHandler(this.TB_jelszo_MouseLeave);
            this.TB_jelszo.MouseHover += new System.EventHandler(this.TB_jelszo_MouseHover);
            // 
            // LB_felh
            // 
            this.LB_felh.BackColor = System.Drawing.Color.Transparent;
            this.LB_felh.Location = new System.Drawing.Point(75, 50);
            this.LB_felh.Name = "LB_felh";
            this.LB_felh.Size = new System.Drawing.Size(250, 34);
            this.LB_felh.TabIndex = 4;
            this.LB_felh.Text = "Felhasználónév";
            this.LB_felh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_jelszo
            // 
            this.LB_jelszo.BackColor = System.Drawing.Color.Transparent;
            this.LB_jelszo.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_jelszo.Location = new System.Drawing.Point(75, 140);
            this.LB_jelszo.Name = "LB_jelszo";
            this.LB_jelszo.Size = new System.Drawing.Size(250, 34);
            this.LB_jelszo.TabIndex = 5;
            this.LB_jelszo.Text = "Jelszó";
            this.LB_jelszo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 375);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // LB_hiba
            // 
            this.LB_hiba.BackColor = System.Drawing.Color.Transparent;
            this.LB_hiba.Location = new System.Drawing.Point(0, 327);
            this.LB_hiba.Name = "LB_hiba";
            this.LB_hiba.Size = new System.Drawing.Size(401, 45);
            this.LB_hiba.TabIndex = 9;
            this.LB_hiba.Text = "Hibás felhasználónév / jelszó!";
            this.LB_hiba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_hiba.Visible = false;
            // 
            // T_idozito
            // 
            this.T_idozito.Interval = 500;
            this.T_idozito.Tick += new System.EventHandler(this.T_idozito_Tick);
            // 
            // P_1
            // 
            this.P_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P_1.Location = new System.Drawing.Point(0, 31);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(336, 1);
            this.P_1.TabIndex = 9;
            // 
            // LB_felirat
            // 
            this.LB_felirat.BackColor = System.Drawing.Color.Transparent;
            this.LB_felirat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_felirat.Location = new System.Drawing.Point(0, 0);
            this.LB_felirat.Name = "LB_felirat";
            this.LB_felirat.Size = new System.Drawing.Size(300, 31);
            this.LB_felirat.TabIndex = 10;
            this.LB_felirat.Text = "- x - Fodrászat - x -";
            this.LB_felirat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_regisztracio
            // 
            this.BT_regisztracio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_regisztracio.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_regisztracio.Location = new System.Drawing.Point(200, 274);
            this.BT_regisztracio.Name = "BT_regisztracio";
            this.BT_regisztracio.Size = new System.Drawing.Size(150, 50);
            this.BT_regisztracio.TabIndex = 5;
            this.BT_regisztracio.Text = "Regisztráció";
            this.BT_regisztracio.UseVisualStyleBackColor = false;
            this.BT_regisztracio.Click += new System.EventHandler(this.BT_regisztracio_Click);
            // 
            // BT_belepes
            // 
            this.BT_belepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_belepes.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_belepes.Location = new System.Drawing.Point(50, 274);
            this.BT_belepes.Name = "BT_belepes";
            this.BT_belepes.Size = new System.Drawing.Size(150, 50);
            this.BT_belepes.TabIndex = 4;
            this.BT_belepes.Text = "Belépés";
            this.BT_belepes.UseVisualStyleBackColor = false;
            this.BT_belepes.Click += new System.EventHandler(this.BT_belepes_Click);
            // 
            // T_ora
            // 
            this.T_ora.Enabled = true;
            this.T_ora.Interval = 1000;
            this.T_ora.Tick += new System.EventHandler(this.T_ora_Tick);
            // 
            // CB_felhasznalonev
            // 
            this.CB_felhasznalonev.BackColor = System.Drawing.Color.Transparent;
            this.CB_felhasznalonev.Location = new System.Drawing.Point(24, 230);
            this.CB_felhasznalonev.Name = "CB_felhasznalonev";
            this.CB_felhasznalonev.Size = new System.Drawing.Size(377, 38);
            this.CB_felhasznalonev.TabIndex = 3;
            this.CB_felhasznalonev.Text = "Felhasználónév megjegyzése";
            this.CB_felhasznalonev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_felhasznalonev.UseVisualStyleBackColor = false;
            this.CB_felhasznalonev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_felhasznalonev_KeyDown);
            // 
            // BT_keszitok
            // 
            this.BT_keszitok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_keszitok.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_keszitok.Location = new System.Drawing.Point(301, -1);
            this.BT_keszitok.Name = "BT_keszitok";
            this.BT_keszitok.Size = new System.Drawing.Size(35, 34);
            this.BT_keszitok.TabIndex = 6;
            this.BT_keszitok.Text = "📖";
            this.BT_keszitok.UseVisualStyleBackColor = false;
            this.BT_keszitok.Click += new System.EventHandler(this.BT_keszitok_Click);
            // 
            // LB_kulcs
            // 
            this.LB_kulcs.BackColor = System.Drawing.Color.Transparent;
            this.LB_kulcs.Location = new System.Drawing.Point(325, 190);
            this.LB_kulcs.Name = "LB_kulcs";
            this.LB_kulcs.Size = new System.Drawing.Size(30, 34);
            this.LB_kulcs.TabIndex = 11;
            this.LB_kulcs.Text = "🔑";
            this.LB_kulcs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_konyv
            // 
            this.LB_konyv.BackColor = System.Drawing.Color.Transparent;
            this.LB_konyv.Location = new System.Drawing.Point(325, 100);
            this.LB_konyv.Name = "LB_konyv";
            this.LB_konyv.Size = new System.Drawing.Size(30, 34);
            this.LB_konyv.TabIndex = 12;
            this.LB_konyv.Text = "📑";
            this.LB_konyv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_felh_admin
            // 
            this.TB_felh_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_felh_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_felh_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_felh_admin.Location = new System.Drawing.Point(75, 137);
            this.TB_felh_admin.MaxLength = 60;
            this.TB_felh_admin.Name = "TB_felh_admin";
            this.TB_felh_admin.ReadOnly = true;
            this.TB_felh_admin.Size = new System.Drawing.Size(250, 34);
            this.TB_felh_admin.TabIndex = 13;
            this.TB_felh_admin.Text = "ADMIN";
            this.TB_felh_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_felh_admin.Visible = false;
            // 
            // TB_jelszo_admin
            // 
            this.TB_jelszo_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_jelszo_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_jelszo_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_jelszo_admin.Location = new System.Drawing.Point(75, 234);
            this.TB_jelszo_admin.MaxLength = 60;
            this.TB_jelszo_admin.Name = "TB_jelszo_admin";
            this.TB_jelszo_admin.ReadOnly = true;
            this.TB_jelszo_admin.Size = new System.Drawing.Size(250, 34);
            this.TB_jelszo_admin.TabIndex = 14;
            this.TB_jelszo_admin.Text = "ADMIN";
            this.TB_jelszo_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_jelszo_admin.Visible = false;
            // 
            // bejelentkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 375);
            this.Controls.Add(this.TB_jelszo_admin);
            this.Controls.Add(this.TB_felh_admin);
            this.Controls.Add(this.LB_konyv);
            this.Controls.Add(this.LB_kulcs);
            this.Controls.Add(this.BT_keszitok);
            this.Controls.Add(this.CB_felhasznalonev);
            this.Controls.Add(this.BT_regisztracio);
            this.Controls.Add(this.BT_belepes);
            this.Controls.Add(this.LB_felirat);
            this.Controls.Add(this.P_1);
            this.Controls.Add(this.LB_hiba);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LB_jelszo);
            this.Controls.Add(this.LB_felh);
            this.Controls.Add(this.TB_jelszo);
            this.Controls.Add(this.TB_felh);
            this.Controls.Add(this.BT_kilepes);
            this.Controls.Add(this.BT_talca);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "bejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bejelentkezes";
            this.Load += new System.EventHandler(this.bejelentkezes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_talca;
        private System.Windows.Forms.Button BT_kilepes;
        private System.Windows.Forms.TextBox TB_felh;
        private System.Windows.Forms.TextBox TB_jelszo;
        private System.Windows.Forms.Label LB_felh;
        private System.Windows.Forms.Label LB_jelszo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label LB_hiba;
        private System.Windows.Forms.Timer T_idozito;
        private System.Windows.Forms.Panel P_1;
        private System.Windows.Forms.Label LB_felirat;
        private System.Windows.Forms.Button BT_regisztracio;
        private System.Windows.Forms.Button BT_belepes;
        private System.Windows.Forms.Timer T_ora;
        private System.Windows.Forms.CheckBox CB_felhasznalonev;
        private System.Windows.Forms.Button BT_keszitok;
        private System.Windows.Forms.Label LB_kulcs;
        private System.Windows.Forms.Label LB_konyv;
        private System.Windows.Forms.TextBox TB_felh_admin;
        private System.Windows.Forms.TextBox TB_jelszo_admin;
    }
}