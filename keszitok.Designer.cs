namespace fodraszat
{
    partial class keszitok
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
            this.P_1 = new System.Windows.Forms.Panel();
            this.LB_felirat = new System.Windows.Forms.Label();
            this.LB_inform = new System.Windows.Forms.Label();
            this.T_ora = new System.Windows.Forms.Timer(this.components);
            this.BT_vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_kilepes
            // 
            this.BT_kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_kilepes.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_kilepes.Location = new System.Drawing.Point(466, -1);
            this.BT_kilepes.Name = "BT_kilepes";
            this.BT_kilepes.Size = new System.Drawing.Size(35, 34);
            this.BT_kilepes.TabIndex = 3;
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
            this.BT_talca.TabIndex = 2;
            this.BT_talca.Text = "▂";
            this.BT_talca.UseVisualStyleBackColor = false;
            this.BT_talca.Click += new System.EventHandler(this.BT_talca_Click);
            // 
            // P_1
            // 
            this.P_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P_1.Location = new System.Drawing.Point(0, 31);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(435, 1);
            this.P_1.TabIndex = 11;
            // 
            // LB_felirat
            // 
            this.LB_felirat.BackColor = System.Drawing.Color.Transparent;
            this.LB_felirat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_felirat.Location = new System.Drawing.Point(0, 0);
            this.LB_felirat.Name = "LB_felirat";
            this.LB_felirat.Size = new System.Drawing.Size(434, 31);
            this.LB_felirat.TabIndex = 12;
            this.LB_felirat.Text = "Készítők";
            this.LB_felirat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_inform
            // 
            this.LB_inform.BackColor = System.Drawing.Color.Transparent;
            this.LB_inform.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_inform.Location = new System.Drawing.Point(0, 36);
            this.LB_inform.Name = "LB_inform";
            this.LB_inform.Size = new System.Drawing.Size(500, 581);
            this.LB_inform.TabIndex = 13;
            this.LB_inform.Text = "Információk";
            this.LB_inform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_ora
            // 
            this.T_ora.Enabled = true;
            this.T_ora.Interval = 1000;
            this.T_ora.Tick += new System.EventHandler(this.T_ora_Tick);
            // 
            // BT_vissza
            // 
            this.BT_vissza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BT_vissza.Location = new System.Drawing.Point(150, 630);
            this.BT_vissza.Name = "BT_vissza";
            this.BT_vissza.Size = new System.Drawing.Size(200, 50);
            this.BT_vissza.TabIndex = 1;
            this.BT_vissza.Text = "Vissza";
            this.BT_vissza.UseVisualStyleBackColor = false;
            this.BT_vissza.Click += new System.EventHandler(this.BT_vissza_Click);
            // 
            // keszitok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.BT_vissza);
            this.Controls.Add(this.LB_inform);
            this.Controls.Add(this.LB_felirat);
            this.Controls.Add(this.P_1);
            this.Controls.Add(this.BT_kilepes);
            this.Controls.Add(this.BT_talca);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "keszitok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "keszitok";
            this.Load += new System.EventHandler(this.keszitok_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_kilepes;
        private System.Windows.Forms.Button BT_talca;
        private System.Windows.Forms.Panel P_1;
        private System.Windows.Forms.Label LB_felirat;
        private System.Windows.Forms.Label LB_inform;
        private System.Windows.Forms.Timer T_ora;
        private System.Windows.Forms.Button BT_vissza;
    }
}