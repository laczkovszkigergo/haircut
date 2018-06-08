namespace fodraszat
{
    partial class statisztika
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
            this.BT_vissza = new System.Windows.Forms.Button();
            this.BT_kilepes = new System.Windows.Forms.Button();
            this.BT_talca = new System.Windows.Forms.Button();
            this.LB_felirat = new System.Windows.Forms.Label();
            this.LB_információk = new System.Windows.Forms.Label();
            this.P_1 = new System.Windows.Forms.Panel();
            this.LB_adatok = new System.Windows.Forms.Label();
            this.P_2 = new System.Windows.Forms.Panel();
            this.CB_honap = new System.Windows.Forms.ComboBox();
            this.CB_ev = new System.Windows.Forms.ComboBox();
            this.LB_kereses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_vissza
            // 
            this.BT_vissza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_vissza.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_vissza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_vissza.Location = new System.Drawing.Point(5, 12);
            this.BT_vissza.Name = "BT_vissza";
            this.BT_vissza.Size = new System.Drawing.Size(120, 40);
            this.BT_vissza.TabIndex = 1;
            this.BT_vissza.Text = "Vissza";
            this.BT_vissza.UseVisualStyleBackColor = false;
            this.BT_vissza.Click += new System.EventHandler(this.BT_vissza_Click);
            // 
            // BT_kilepes
            // 
            this.BT_kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kilepes.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_kilepes.Location = new System.Drawing.Point(466, -1);
            this.BT_kilepes.Name = "BT_kilepes";
            this.BT_kilepes.Size = new System.Drawing.Size(35, 34);
            this.BT_kilepes.TabIndex = 5;
            this.BT_kilepes.Text = "✖";
            this.BT_kilepes.UseVisualStyleBackColor = false;
            this.BT_kilepes.Click += new System.EventHandler(this.BT_kilepes_Click);
            // 
            // BT_talca
            // 
            this.BT_talca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_talca.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_talca.Location = new System.Drawing.Point(434, -1);
            this.BT_talca.Name = "BT_talca";
            this.BT_talca.Size = new System.Drawing.Size(35, 34);
            this.BT_talca.TabIndex = 4;
            this.BT_talca.Text = "▂";
            this.BT_talca.UseVisualStyleBackColor = false;
            this.BT_talca.Click += new System.EventHandler(this.BT_talca_Click);
            // 
            // LB_felirat
            // 
            this.LB_felirat.BackColor = System.Drawing.Color.Transparent;
            this.LB_felirat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_felirat.Location = new System.Drawing.Point(127, 0);
            this.LB_felirat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_felirat.Name = "LB_felirat";
            this.LB_felirat.Size = new System.Drawing.Size(300, 32);
            this.LB_felirat.TabIndex = 15;
            this.LB_felirat.Text = "- ✄ - Statisztika - ✄ -";
            this.LB_felirat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_információk
            // 
            this.LB_információk.BackColor = System.Drawing.Color.Transparent;
            this.LB_információk.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_információk.Location = new System.Drawing.Point(13, 151);
            this.LB_információk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_információk.Name = "LB_információk";
            this.LB_információk.Size = new System.Drawing.Size(474, 340);
            this.LB_információk.TabIndex = 16;
            this.LB_információk.Text = "Információk";
            this.LB_információk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_1
            // 
            this.P_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P_1.Location = new System.Drawing.Point(125, 30);
            this.P_1.Margin = new System.Windows.Forms.Padding(4);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(310, 2);
            this.P_1.TabIndex = 41;
            // 
            // LB_adatok
            // 
            this.LB_adatok.BackColor = System.Drawing.Color.Transparent;
            this.LB_adatok.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_adatok.Location = new System.Drawing.Point(1, 55);
            this.LB_adatok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_adatok.Name = "LB_adatok";
            this.LB_adatok.Size = new System.Drawing.Size(500, 32);
            this.LB_adatok.TabIndex = 42;
            this.LB_adatok.Text = "adatai";
            this.LB_adatok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_2
            // 
            this.P_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P_2.Location = new System.Drawing.Point(0, 30);
            this.P_2.Margin = new System.Windows.Forms.Padding(4);
            this.P_2.Name = "P_2";
            this.P_2.Size = new System.Drawing.Size(5, 2);
            this.P_2.TabIndex = 42;
            // 
            // CB_honap
            // 
            this.CB_honap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_honap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_honap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_honap.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CB_honap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CB_honap.FormattingEnabled = true;
            this.CB_honap.ItemHeight = 27;
            this.CB_honap.Items.AddRange(new object[] {
            "",
            "január",
            "február",
            "március",
            "április",
            "május",
            "június",
            "július",
            "augusztus",
            "szeptember",
            "október",
            "november",
            "december"});
            this.CB_honap.Location = new System.Drawing.Point(347, 100);
            this.CB_honap.Name = "CB_honap";
            this.CB_honap.Size = new System.Drawing.Size(140, 35);
            this.CB_honap.TabIndex = 3;
            this.CB_honap.SelectedIndexChanged += new System.EventHandler(this.CB_honap_SelectedIndexChanged);
            this.CB_honap.MouseHover += new System.EventHandler(this.CB_honap_MouseHover);
            // 
            // CB_ev
            // 
            this.CB_ev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB_ev.DropDownHeight = 367;
            this.CB_ev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_ev.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CB_ev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CB_ev.FormattingEnabled = true;
            this.CB_ev.IntegralHeight = false;
            this.CB_ev.ItemHeight = 27;
            this.CB_ev.Location = new System.Drawing.Point(237, 100);
            this.CB_ev.Name = "CB_ev";
            this.CB_ev.Size = new System.Drawing.Size(100, 35);
            this.CB_ev.TabIndex = 2;
            this.CB_ev.SelectedIndexChanged += new System.EventHandler(this.CB_ev_SelectedIndexChanged);
            this.CB_ev.MouseHover += new System.EventHandler(this.CB_ev_MouseHover);
            // 
            // LB_kereses
            // 
            this.LB_kereses.BackColor = System.Drawing.Color.Transparent;
            this.LB_kereses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_kereses.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_kereses.Location = new System.Drawing.Point(13, 100);
            this.LB_kereses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_kereses.Name = "LB_kereses";
            this.LB_kereses.Size = new System.Drawing.Size(217, 35);
            this.LB_kereses.TabIndex = 45;
            this.LB_kereses.Text = "Év/hónap alapján";
            this.LB_kereses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_kereses.Click += new System.EventHandler(this.LB_kereses_Click);
            // 
            // statisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.LB_kereses);
            this.Controls.Add(this.CB_ev);
            this.Controls.Add(this.CB_honap);
            this.Controls.Add(this.P_2);
            this.Controls.Add(this.LB_adatok);
            this.Controls.Add(this.P_1);
            this.Controls.Add(this.LB_információk);
            this.Controls.Add(this.LB_felirat);
            this.Controls.Add(this.BT_kilepes);
            this.Controls.Add(this.BT_talca);
            this.Controls.Add(this.BT_vissza);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statisztika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "statisztika";
            this.Load += new System.EventHandler(this.statisztika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_vissza;
        private System.Windows.Forms.Button BT_kilepes;
        private System.Windows.Forms.Button BT_talca;
        private System.Windows.Forms.Label LB_felirat;
        private System.Windows.Forms.Label LB_információk;
        private System.Windows.Forms.Panel P_1;
        private System.Windows.Forms.Label LB_adatok;
        private System.Windows.Forms.Panel P_2;
        private System.Windows.Forms.ComboBox CB_honap;
        private System.Windows.Forms.ComboBox CB_ev;
        private System.Windows.Forms.Label LB_kereses;
    }
}