namespace fodraszat
{
    partial class felhasznalo_adat_modositas
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
            this.BT_kilepes = new System.Windows.Forms.Button();
            this.BT_talca = new System.Windows.Forms.Button();
            this.BT_vissza = new System.Windows.Forms.Button();
            this.BT_modositas = new System.Windows.Forms.Button();
            this.LB_jelszo = new System.Windows.Forms.Label();
            this.LB_felh = new System.Windows.Forms.Label();
            this.TB_jelszo = new System.Windows.Forms.TextBox();
            this.TB_felh = new System.Windows.Forms.TextBox();
            this.LB_uj_jelszo_ism = new System.Windows.Forms.Label();
            this.TB_uj_jelszo = new System.Windows.Forms.TextBox();
            this.LB_hiba = new System.Windows.Forms.Label();
            this.T_idozito = new System.Windows.Forms.Timer(this.components);
            this.T_idozito2 = new System.Windows.Forms.Timer(this.components);
            this.LB_felirat = new System.Windows.Forms.Label();
            this.P_1 = new System.Windows.Forms.Panel();
            this.LB_regi_jelszo = new System.Windows.Forms.Label();
            this.TB_regi_jelszo = new System.Windows.Forms.TextBox();
            this.TabC_felh = new System.Windows.Forms.TabControl();
            this.TabC_felh_mod = new System.Windows.Forms.TabPage();
            this.TabC_torl = new System.Windows.Forms.TabPage();
            this.LB_hiba2 = new System.Windows.Forms.Label();
            this.LB_regi_jelszo2 = new System.Windows.Forms.Label();
            this.TB_regi_jelszo2 = new System.Windows.Forms.TextBox();
            this.BT_vissza2 = new System.Windows.Forms.Button();
            this.BT_torles = new System.Windows.Forms.Button();
            this.Panel1_hatter = new System.Windows.Forms.Panel();
            this.TabC_felh.SuspendLayout();
            this.TabC_felh_mod.SuspendLayout();
            this.TabC_torl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_kilepes
            // 
            this.BT_kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kilepes.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_kilepes.Location = new System.Drawing.Point(316, -1);
            this.BT_kilepes.Name = "BT_kilepes";
            this.BT_kilepes.Size = new System.Drawing.Size(35, 34);
            this.BT_kilepes.TabIndex = 9;
            this.BT_kilepes.Text = "✖";
            this.BT_kilepes.UseVisualStyleBackColor = false;
            this.BT_kilepes.Click += new System.EventHandler(this.BT_kilepes_Click);
            // 
            // BT_talca
            // 
            this.BT_talca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_talca.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_talca.Location = new System.Drawing.Point(284, -1);
            this.BT_talca.Name = "BT_talca";
            this.BT_talca.Size = new System.Drawing.Size(35, 34);
            this.BT_talca.TabIndex = 8;
            this.BT_talca.Text = "▂";
            this.BT_talca.UseVisualStyleBackColor = false;
            this.BT_talca.Click += new System.EventHandler(this.BT_talca_Click);
            // 
            // BT_vissza
            // 
            this.BT_vissza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_vissza.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_vissza.Location = new System.Drawing.Point(183, 322);
            this.BT_vissza.Name = "BT_vissza";
            this.BT_vissza.Size = new System.Drawing.Size(150, 50);
            this.BT_vissza.TabIndex = 7;
            this.BT_vissza.Text = "Vissza";
            this.BT_vissza.UseVisualStyleBackColor = false;
            this.BT_vissza.Click += new System.EventHandler(this.BT_vissza_Click);
            // 
            // BT_modositas
            // 
            this.BT_modositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_modositas.Location = new System.Drawing.Point(23, 322);
            this.BT_modositas.Name = "BT_modositas";
            this.BT_modositas.Size = new System.Drawing.Size(150, 50);
            this.BT_modositas.TabIndex = 6;
            this.BT_modositas.Text = "Módosítás";
            this.BT_modositas.UseVisualStyleBackColor = false;
            this.BT_modositas.Click += new System.EventHandler(this.BT_modositas_Click);
            // 
            // LB_jelszo
            // 
            this.LB_jelszo.BackColor = System.Drawing.Color.Transparent;
            this.LB_jelszo.Location = new System.Drawing.Point(51, 77);
            this.LB_jelszo.Name = "LB_jelszo";
            this.LB_jelszo.Size = new System.Drawing.Size(250, 34);
            this.LB_jelszo.TabIndex = 15;
            this.LB_jelszo.Text = "Új jelszó";
            this.LB_jelszo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_felh
            // 
            this.LB_felh.BackColor = System.Drawing.Color.Transparent;
            this.LB_felh.Location = new System.Drawing.Point(51, 3);
            this.LB_felh.Name = "LB_felh";
            this.LB_felh.Size = new System.Drawing.Size(250, 34);
            this.LB_felh.TabIndex = 14;
            this.LB_felh.Text = "Új felhasználónév";
            this.LB_felh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_jelszo
            // 
            this.TB_jelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_jelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_jelszo.Location = new System.Drawing.Point(51, 114);
            this.TB_jelszo.MaxLength = 35;
            this.TB_jelszo.Name = "TB_jelszo";
            this.TB_jelszo.PasswordChar = '♥';
            this.TB_jelszo.Size = new System.Drawing.Size(250, 34);
            this.TB_jelszo.TabIndex = 3;
            this.TB_jelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_jelszo.TextChanged += new System.EventHandler(this.TB_jelszo_TextChanged);
            this.TB_jelszo.Enter += new System.EventHandler(this.textbox_Enter);
            this.TB_jelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_jelszo_KeyDown);
            this.TB_jelszo.MouseLeave += new System.EventHandler(this.TB_jelszo_MouseLeave);
            this.TB_jelszo.MouseHover += new System.EventHandler(this.TB_jelszo_MouseHover);
            // 
            // TB_felh
            // 
            this.TB_felh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_felh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_felh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_felh.Location = new System.Drawing.Point(51, 40);
            this.TB_felh.MaxLength = 60;
            this.TB_felh.Name = "TB_felh";
            this.TB_felh.Size = new System.Drawing.Size(250, 34);
            this.TB_felh.TabIndex = 2;
            this.TB_felh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_felh.TextChanged += new System.EventHandler(this.TB_felh_TextChanged);
            this.TB_felh.Enter += new System.EventHandler(this.textbox_Enter);
            this.TB_felh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_felh_KeyDown);
            // 
            // LB_uj_jelszo_ism
            // 
            this.LB_uj_jelszo_ism.BackColor = System.Drawing.Color.Transparent;
            this.LB_uj_jelszo_ism.Location = new System.Drawing.Point(51, 153);
            this.LB_uj_jelszo_ism.Name = "LB_uj_jelszo_ism";
            this.LB_uj_jelszo_ism.Size = new System.Drawing.Size(250, 34);
            this.LB_uj_jelszo_ism.TabIndex = 17;
            this.LB_uj_jelszo_ism.Text = "Új jelszó ismét";
            this.LB_uj_jelszo_ism.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_uj_jelszo
            // 
            this.TB_uj_jelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_uj_jelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_uj_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_uj_jelszo.Location = new System.Drawing.Point(51, 190);
            this.TB_uj_jelszo.MaxLength = 35;
            this.TB_uj_jelszo.Name = "TB_uj_jelszo";
            this.TB_uj_jelszo.PasswordChar = '♥';
            this.TB_uj_jelszo.Size = new System.Drawing.Size(250, 34);
            this.TB_uj_jelszo.TabIndex = 4;
            this.TB_uj_jelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_uj_jelszo.TextChanged += new System.EventHandler(this.TB_uj_jelszo_TextChanged);
            this.TB_uj_jelszo.Enter += new System.EventHandler(this.textbox_Enter);
            this.TB_uj_jelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_uj_jelszo_KeyDown);
            this.TB_uj_jelszo.MouseLeave += new System.EventHandler(this.TB_uj_jelszo_MouseLeave);
            this.TB_uj_jelszo.MouseHover += new System.EventHandler(this.TB_uj_jelszo_MouseHover);
            // 
            // LB_hiba
            // 
            this.LB_hiba.BackColor = System.Drawing.Color.Transparent;
            this.LB_hiba.Location = new System.Drawing.Point(1, 375);
            this.LB_hiba.Name = "LB_hiba";
            this.LB_hiba.Size = new System.Drawing.Size(348, 89);
            this.LB_hiba.TabIndex = 18;
            this.LB_hiba.Text = "Üzenet";
            this.LB_hiba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_hiba.Visible = false;
            // 
            // T_idozito
            // 
            this.T_idozito.Interval = 500;
            this.T_idozito.Tick += new System.EventHandler(this.T_idozito_Tick);
            // 
            // T_idozito2
            // 
            this.T_idozito2.Enabled = true;
            this.T_idozito2.Tick += new System.EventHandler(this.T_idoziti2_Tick);
            // 
            // LB_felirat
            // 
            this.LB_felirat.BackColor = System.Drawing.Color.Transparent;
            this.LB_felirat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_felirat.Location = new System.Drawing.Point(1, 0);
            this.LB_felirat.Name = "LB_felirat";
            this.LB_felirat.Size = new System.Drawing.Size(283, 31);
            this.LB_felirat.TabIndex = 20;
            this.LB_felirat.Text = " Felhasználó fiók";
            this.LB_felirat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_1
            // 
            this.P_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P_1.Location = new System.Drawing.Point(1, 32);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(286, 1);
            this.P_1.TabIndex = 19;
            // 
            // LB_regi_jelszo
            // 
            this.LB_regi_jelszo.BackColor = System.Drawing.Color.Transparent;
            this.LB_regi_jelszo.Location = new System.Drawing.Point(51, 224);
            this.LB_regi_jelszo.Name = "LB_regi_jelszo";
            this.LB_regi_jelszo.Size = new System.Drawing.Size(250, 34);
            this.LB_regi_jelszo.TabIndex = 22;
            this.LB_regi_jelszo.Text = "Régi jelszó";
            this.LB_regi_jelszo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_regi_jelszo
            // 
            this.TB_regi_jelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_regi_jelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_regi_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_regi_jelszo.Location = new System.Drawing.Point(51, 261);
            this.TB_regi_jelszo.MaxLength = 35;
            this.TB_regi_jelszo.Name = "TB_regi_jelszo";
            this.TB_regi_jelszo.PasswordChar = '♥';
            this.TB_regi_jelszo.Size = new System.Drawing.Size(250, 34);
            this.TB_regi_jelszo.TabIndex = 5;
            this.TB_regi_jelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_regi_jelszo.TextChanged += new System.EventHandler(this.TB_regi_jelszo_TextChanged);
            this.TB_regi_jelszo.Enter += new System.EventHandler(this.textbox_Enter);
            this.TB_regi_jelszo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_regi_jelszo_KeyDown);
            this.TB_regi_jelszo.MouseLeave += new System.EventHandler(this.TB_regi_jelszo_MouseLeave);
            this.TB_regi_jelszo.MouseHover += new System.EventHandler(this.TB_regi_jelszo_MouseHover);
            // 
            // TabC_felh
            // 
            this.TabC_felh.Controls.Add(this.TabC_felh_mod);
            this.TabC_felh.Controls.Add(this.TabC_torl);
            this.TabC_felh.Location = new System.Drawing.Point(0, 33);
            this.TabC_felh.Name = "TabC_felh";
            this.TabC_felh.SelectedIndex = 0;
            this.TabC_felh.Size = new System.Drawing.Size(357, 650);
            this.TabC_felh.TabIndex = 1;
            this.TabC_felh.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabC_felh_DrawItem);
            // 
            // TabC_felh_mod
            // 
            this.TabC_felh_mod.Controls.Add(this.LB_felh);
            this.TabC_felh_mod.Controls.Add(this.LB_regi_jelszo);
            this.TabC_felh_mod.Controls.Add(this.BT_vissza);
            this.TabC_felh_mod.Controls.Add(this.TB_regi_jelszo);
            this.TabC_felh_mod.Controls.Add(this.TB_felh);
            this.TabC_felh_mod.Controls.Add(this.TB_jelszo);
            this.TabC_felh_mod.Controls.Add(this.LB_jelszo);
            this.TabC_felh_mod.Controls.Add(this.LB_hiba);
            this.TabC_felh_mod.Controls.Add(this.BT_modositas);
            this.TabC_felh_mod.Controls.Add(this.LB_uj_jelszo_ism);
            this.TabC_felh_mod.Controls.Add(this.TB_uj_jelszo);
            this.TabC_felh_mod.Location = new System.Drawing.Point(4, 43);
            this.TabC_felh_mod.Name = "TabC_felh_mod";
            this.TabC_felh_mod.Padding = new System.Windows.Forms.Padding(3);
            this.TabC_felh_mod.Size = new System.Drawing.Size(349, 603);
            this.TabC_felh_mod.TabIndex = 0;
            this.TabC_felh_mod.Text = "Fiók módo";
            this.TabC_felh_mod.UseVisualStyleBackColor = true;
            this.TabC_felh_mod.Enter += new System.EventHandler(this.TabC_felh_mod_Enter);
            // 
            // TabC_torl
            // 
            this.TabC_torl.Controls.Add(this.LB_hiba2);
            this.TabC_torl.Controls.Add(this.LB_regi_jelszo2);
            this.TabC_torl.Controls.Add(this.TB_regi_jelszo2);
            this.TabC_torl.Controls.Add(this.BT_vissza2);
            this.TabC_torl.Controls.Add(this.BT_torles);
            this.TabC_torl.Location = new System.Drawing.Point(4, 43);
            this.TabC_torl.Name = "TabC_torl";
            this.TabC_torl.Padding = new System.Windows.Forms.Padding(3);
            this.TabC_torl.Size = new System.Drawing.Size(349, 603);
            this.TabC_torl.TabIndex = 1;
            this.TabC_torl.Text = " Fiók törlése ";
            this.TabC_torl.UseVisualStyleBackColor = true;
            this.TabC_torl.Enter += new System.EventHandler(this.TabC_torl_Enter);
            // 
            // LB_hiba2
            // 
            this.LB_hiba2.BackColor = System.Drawing.Color.Transparent;
            this.LB_hiba2.Location = new System.Drawing.Point(0, 166);
            this.LB_hiba2.Name = "LB_hiba2";
            this.LB_hiba2.Size = new System.Drawing.Size(348, 55);
            this.LB_hiba2.TabIndex = 25;
            this.LB_hiba2.Text = "Üzenet";
            this.LB_hiba2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_hiba2.Visible = false;
            // 
            // LB_regi_jelszo2
            // 
            this.LB_regi_jelszo2.BackColor = System.Drawing.Color.Transparent;
            this.LB_regi_jelszo2.Location = new System.Drawing.Point(51, 19);
            this.LB_regi_jelszo2.Name = "LB_regi_jelszo2";
            this.LB_regi_jelszo2.Size = new System.Drawing.Size(250, 34);
            this.LB_regi_jelszo2.TabIndex = 24;
            this.LB_regi_jelszo2.Text = "Régi jelszó";
            this.LB_regi_jelszo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_regi_jelszo2
            // 
            this.TB_regi_jelszo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TB_regi_jelszo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_regi_jelszo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TB_regi_jelszo2.Location = new System.Drawing.Point(51, 56);
            this.TB_regi_jelszo2.MaxLength = 35;
            this.TB_regi_jelszo2.Name = "TB_regi_jelszo2";
            this.TB_regi_jelszo2.PasswordChar = '♥';
            this.TB_regi_jelszo2.Size = new System.Drawing.Size(250, 34);
            this.TB_regi_jelszo2.TabIndex = 1;
            this.TB_regi_jelszo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_regi_jelszo2.TextChanged += new System.EventHandler(this.TB_regi_jelszo2_TextChanged);
            this.TB_regi_jelszo2.Enter += new System.EventHandler(this.textbox_Enter);
            this.TB_regi_jelszo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_regi_jelszo2_KeyDown);
            this.TB_regi_jelszo2.MouseLeave += new System.EventHandler(this.TB_regi_jelszo2_MouseLeave);
            this.TB_regi_jelszo2.MouseHover += new System.EventHandler(this.TB_regi_jelszo2_MouseHover);
            // 
            // BT_vissza2
            // 
            this.BT_vissza2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_vissza2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_vissza2.Location = new System.Drawing.Point(181, 113);
            this.BT_vissza2.Name = "BT_vissza2";
            this.BT_vissza2.Size = new System.Drawing.Size(150, 50);
            this.BT_vissza2.TabIndex = 3;
            this.BT_vissza2.Text = "Vissza";
            this.BT_vissza2.UseVisualStyleBackColor = false;
            this.BT_vissza2.Click += new System.EventHandler(this.BT_vissza2_Click);
            // 
            // BT_torles
            // 
            this.BT_torles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_torles.Location = new System.Drawing.Point(21, 113);
            this.BT_torles.Name = "BT_torles";
            this.BT_torles.Size = new System.Drawing.Size(150, 50);
            this.BT_torles.TabIndex = 2;
            this.BT_torles.Text = "Fiók törlése";
            this.BT_torles.UseVisualStyleBackColor = false;
            this.BT_torles.Click += new System.EventHandler(this.BT_torles_Click);
            // 
            // Panel1_hatter
            // 
            this.Panel1_hatter.Location = new System.Drawing.Point(0, 76);
            this.Panel1_hatter.Name = "Panel1_hatter";
            this.Panel1_hatter.Size = new System.Drawing.Size(15, 650);
            this.Panel1_hatter.TabIndex = 23;
            // 
            // felhasznalo_adat_modositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 475);
            this.Controls.Add(this.Panel1_hatter);
            this.Controls.Add(this.TabC_felh);
            this.Controls.Add(this.LB_felirat);
            this.Controls.Add(this.P_1);
            this.Controls.Add(this.BT_kilepes);
            this.Controls.Add(this.BT_talca);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "felhasznalo_adat_modositas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uj_tipus";
            this.Load += new System.EventHandler(this.felhasznalo_adat_modositas_Load);
            this.TabC_felh.ResumeLayout(false);
            this.TabC_felh_mod.ResumeLayout(false);
            this.TabC_felh_mod.PerformLayout();
            this.TabC_torl.ResumeLayout(false);
            this.TabC_torl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_kilepes;
        private System.Windows.Forms.Button BT_talca;
        private System.Windows.Forms.Button BT_vissza;
        private System.Windows.Forms.Button BT_modositas;
        private System.Windows.Forms.Label LB_jelszo;
        private System.Windows.Forms.Label LB_felh;
        private System.Windows.Forms.TextBox TB_jelszo;
        private System.Windows.Forms.TextBox TB_felh;
        private System.Windows.Forms.Label LB_uj_jelszo_ism;
        private System.Windows.Forms.TextBox TB_uj_jelszo;
        private System.Windows.Forms.Label LB_hiba;
        private System.Windows.Forms.Timer T_idozito;
        private System.Windows.Forms.Timer T_idozito2;
        private System.Windows.Forms.Label LB_felirat;
        private System.Windows.Forms.Panel P_1;
        private System.Windows.Forms.Label LB_regi_jelszo;
        private System.Windows.Forms.TextBox TB_regi_jelszo;
        private System.Windows.Forms.TabControl TabC_felh;
        private System.Windows.Forms.TabPage TabC_felh_mod;
        private System.Windows.Forms.TabPage TabC_torl;
        private System.Windows.Forms.Label LB_regi_jelszo2;
        private System.Windows.Forms.TextBox TB_regi_jelszo2;
        private System.Windows.Forms.Button BT_vissza2;
        private System.Windows.Forms.Button BT_torles;
        private System.Windows.Forms.Label LB_hiba2;
        private System.Windows.Forms.Panel Panel1_hatter;
    }
}