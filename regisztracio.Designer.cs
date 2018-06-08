namespace fodraszat
{
    partial class regisztracio
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
            this.LB_felirat = new System.Windows.Forms.Label();
            this.P_1 = new System.Windows.Forms.Panel();
            this.BT_kilepes = new System.Windows.Forms.Button();
            this.BT_talca = new System.Windows.Forms.Button();
            this.LB_uj_jelszo_ism = new System.Windows.Forms.Label();
            this.TB_uj_jelszo = new System.Windows.Forms.TextBox();
            this.BT_regisztracio = new System.Windows.Forms.Button();
            this.LB_jelszo = new System.Windows.Forms.Label();
            this.LB_felh = new System.Windows.Forms.Label();
            this.TB_jelszo = new System.Windows.Forms.TextBox();
            this.TB_felh = new System.Windows.Forms.TextBox();
            this.T_idozito = new System.Windows.Forms.Timer(this.components);
            this.T_idozito2 = new System.Windows.Forms.Timer(this.components);
            this.LB_hiba = new System.Windows.Forms.Label();
            this.BT_vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_felirat
            // 
            this.LB_felirat.BackColor = System.Drawing.Color.Transparent;
            this.LB_felirat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_felirat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_felirat.Location = new System.Drawing.Point(0, 0);
            this.LB_felirat.Name = "LB_felirat";
            this.LB_felirat.Size = new System.Drawing.Size(283, 30);
            this.LB_felirat.TabIndex = 14;
            this.LB_felirat.Text = "- ✄ - Regisztráció - ✄ -";
            this.LB_felirat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_1
            // 
            this.P_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P_1.Location = new System.Drawing.Point(0, 30);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(286, 2);
            this.P_1.TabIndex = 13;
            // 
            // BT_kilepes
            // 
            this.BT_kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kilepes.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_kilepes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_kilepes.Location = new System.Drawing.Point(316, -1);
            this.BT_kilepes.Name = "BT_kilepes";
            this.BT_kilepes.Size = new System.Drawing.Size(35, 34);
            this.BT_kilepes.TabIndex = 7;
            this.BT_kilepes.Text = "✖";
            this.BT_kilepes.UseVisualStyleBackColor = false;
            this.BT_kilepes.Click += new System.EventHandler(this.BT_kilepes_Click);
            // 
            // BT_talca
            // 
            this.BT_talca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_talca.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_talca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_talca.Location = new System.Drawing.Point(284, -1);
            this.BT_talca.Name = "BT_talca";
            this.BT_talca.Size = new System.Drawing.Size(35, 34);
            this.BT_talca.TabIndex = 6;
            this.BT_talca.Text = "▂";
            this.BT_talca.UseVisualStyleBackColor = false;
            this.BT_talca.Click += new System.EventHandler(this.BT_talca_Click);
            // 
            // LB_uj_jelszo_ism
            // 
            this.LB_uj_jelszo_ism.BackColor = System.Drawing.Color.Transparent;
            this.LB_uj_jelszo_ism.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_uj_jelszo_ism.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_uj_jelszo_ism.Location = new System.Drawing.Point(50, 204);
            this.LB_uj_jelszo_ism.Name = "LB_uj_jelszo_ism";
            this.LB_uj_jelszo_ism.Size = new System.Drawing.Size(250, 34);
            this.LB_uj_jelszo_ism.TabIndex = 24;
            this.LB_uj_jelszo_ism.Text = "Jelszó ismét";
            this.LB_uj_jelszo_ism.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_uj_jelszo
            // 
            this.TB_uj_jelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_uj_jelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_uj_jelszo.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_uj_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_uj_jelszo.Location = new System.Drawing.Point(50, 241);
            this.TB_uj_jelszo.MaxLength = 35;
            this.TB_uj_jelszo.Name = "TB_uj_jelszo";
            this.TB_uj_jelszo.PasswordChar = '♥';
            this.TB_uj_jelszo.Size = new System.Drawing.Size(250, 34);
            this.TB_uj_jelszo.TabIndex = 3;
            this.TB_uj_jelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_uj_jelszo.TextChanged += new System.EventHandler(this.TB_uj_jelszo_TextChanged);
            this.TB_uj_jelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_uj_jelszo_KeyDown);
            this.TB_uj_jelszo.MouseLeave += new System.EventHandler(this.TB_uj_jelszo_MouseLeave);
            this.TB_uj_jelszo.MouseHover += new System.EventHandler(this.TB_uj_jelszo_MouseHover);
            // 
            // BT_regisztracio
            // 
            this.BT_regisztracio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_regisztracio.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_regisztracio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_regisztracio.Location = new System.Drawing.Point(15, 300);
            this.BT_regisztracio.Name = "BT_regisztracio";
            this.BT_regisztracio.Size = new System.Drawing.Size(160, 50);
            this.BT_regisztracio.TabIndex = 4;
            this.BT_regisztracio.Text = "Regisztráció";
            this.BT_regisztracio.UseVisualStyleBackColor = false;
            this.BT_regisztracio.Click += new System.EventHandler(this.BT_regisztracio_Click);
            // 
            // LB_jelszo
            // 
            this.LB_jelszo.BackColor = System.Drawing.Color.Transparent;
            this.LB_jelszo.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_jelszo.Location = new System.Drawing.Point(56, 128);
            this.LB_jelszo.Name = "LB_jelszo";
            this.LB_jelszo.Size = new System.Drawing.Size(244, 34);
            this.LB_jelszo.TabIndex = 23;
            this.LB_jelszo.Text = "Jelszó";
            this.LB_jelszo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_felh
            // 
            this.LB_felh.BackColor = System.Drawing.Color.Transparent;
            this.LB_felh.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_felh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_felh.Location = new System.Drawing.Point(50, 54);
            this.LB_felh.Name = "LB_felh";
            this.LB_felh.Size = new System.Drawing.Size(250, 34);
            this.LB_felh.TabIndex = 22;
            this.LB_felh.Text = "Felhasználónév";
            this.LB_felh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_jelszo
            // 
            this.TB_jelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_jelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_jelszo.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_jelszo.Location = new System.Drawing.Point(50, 165);
            this.TB_jelszo.MaxLength = 35;
            this.TB_jelszo.Name = "TB_jelszo";
            this.TB_jelszo.PasswordChar = '♥';
            this.TB_jelszo.Size = new System.Drawing.Size(250, 34);
            this.TB_jelszo.TabIndex = 2;
            this.TB_jelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_jelszo.TextChanged += new System.EventHandler(this.TB_jelszo_TextChanged);
            this.TB_jelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_jelszo_KeyDown);
            this.TB_jelszo.MouseLeave += new System.EventHandler(this.TB_jelszo_MouseLeave);
            this.TB_jelszo.MouseHover += new System.EventHandler(this.TB_jelszo_MouseHover);
            // 
            // TB_felh
            // 
            this.TB_felh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_felh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_felh.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_felh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_felh.Location = new System.Drawing.Point(50, 91);
            this.TB_felh.MaxLength = 60;
            this.TB_felh.Name = "TB_felh";
            this.TB_felh.Size = new System.Drawing.Size(250, 34);
            this.TB_felh.TabIndex = 1;
            this.TB_felh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_felh.TextChanged += new System.EventHandler(this.TB_felh_TextChanged);
            this.TB_felh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_felh_KeyDown);
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
            // LB_hiba
            // 
            this.LB_hiba.BackColor = System.Drawing.Color.Transparent;
            this.LB_hiba.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_hiba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_hiba.Location = new System.Drawing.Point(0, 355);
            this.LB_hiba.Name = "LB_hiba";
            this.LB_hiba.Size = new System.Drawing.Size(350, 125);
            this.LB_hiba.TabIndex = 25;
            this.LB_hiba.Text = "Üzenet";
            this.LB_hiba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_hiba.Visible = false;
            // 
            // BT_vissza
            // 
            this.BT_vissza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_vissza.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_vissza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_vissza.Location = new System.Drawing.Point(180, 300);
            this.BT_vissza.Name = "BT_vissza";
            this.BT_vissza.Size = new System.Drawing.Size(160, 50);
            this.BT_vissza.TabIndex = 5;
            this.BT_vissza.Text = "Vissza";
            this.BT_vissza.UseVisualStyleBackColor = false;
            this.BT_vissza.Click += new System.EventHandler(this.BT_vissza_Click);
            // 
            // regisztracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 375);
            this.Controls.Add(this.BT_vissza);
            this.Controls.Add(this.LB_hiba);
            this.Controls.Add(this.LB_uj_jelszo_ism);
            this.Controls.Add(this.TB_uj_jelszo);
            this.Controls.Add(this.BT_regisztracio);
            this.Controls.Add(this.LB_jelszo);
            this.Controls.Add(this.LB_felh);
            this.Controls.Add(this.TB_jelszo);
            this.Controls.Add(this.TB_felh);
            this.Controls.Add(this.LB_felirat);
            this.Controls.Add(this.P_1);
            this.Controls.Add(this.BT_kilepes);
            this.Controls.Add(this.BT_talca);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "regisztracio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "regisztracio";
            this.Load += new System.EventHandler(this.regisztracio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_felirat;
        private System.Windows.Forms.Panel P_1;
        private System.Windows.Forms.Button BT_kilepes;
        private System.Windows.Forms.Button BT_talca;
        private System.Windows.Forms.Label LB_uj_jelszo_ism;
        private System.Windows.Forms.TextBox TB_uj_jelszo;
        private System.Windows.Forms.Button BT_regisztracio;
        private System.Windows.Forms.Label LB_jelszo;
        private System.Windows.Forms.Label LB_felh;
        private System.Windows.Forms.TextBox TB_jelszo;
        private System.Windows.Forms.TextBox TB_felh;
        private System.Windows.Forms.Timer T_idozito;
        private System.Windows.Forms.Timer T_idozito2;
        private System.Windows.Forms.Label LB_hiba;
        private System.Windows.Forms.Button BT_vissza;
    }
}