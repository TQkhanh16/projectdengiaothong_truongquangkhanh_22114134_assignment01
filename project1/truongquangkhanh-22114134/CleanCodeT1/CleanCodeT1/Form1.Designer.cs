namespace CleanCodeT1
{
    partial class pnl_pot
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pnl_senter = new System.Windows.Forms.Panel();
            this.button_onred = new System.Windows.Forms.Button();
            this.PNL_RED = new System.Windows.Forms.Panel();
            this.button_offred = new System.Windows.Forms.Button();
            this.PNL_YELLOW = new System.Windows.Forms.Panel();
            this.PNL_GREEN = new System.Windows.Forms.Panel();
            this.button_onyellow = new System.Windows.Forms.Button();
            this.button_ongreen = new System.Windows.Forms.Button();
            this.button_offyellow = new System.Windows.Forms.Button();
            this.button_offgreen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            this.pnl_senter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_top.Controls.Add(this.button2);
            this.pnl_top.Controls.Add(this.Help);
            this.pnl_top.Controls.Add(this.settings);
            this.pnl_top.Controls.Add(this.btn_dashboard);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 187);
            this.pnl_top.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 8);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Help.Location = new System.Drawing.Point(577, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(211, 74);
            this.Help.TabIndex = 2;
            this.Help.Text = "HELP";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.button1_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.settings.Location = new System.Drawing.Point(307, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(211, 74);
            this.settings.TabIndex = 1;
            this.settings.Text = "SETING";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dashboard.Location = new System.Drawing.Point(12, 12);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(211, 74);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "DASHBOARD";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pnl_senter
            // 
            this.pnl_senter.AutoScroll = true;
            this.pnl_senter.BackColor = System.Drawing.Color.White;
            this.pnl_senter.Controls.Add(this.button7);
            this.pnl_senter.Controls.Add(this.button6);
            this.pnl_senter.Controls.Add(this.button5);
            this.pnl_senter.Controls.Add(this.button4);
            this.pnl_senter.Controls.Add(this.button3);
            this.pnl_senter.Controls.Add(this.button1);
            this.pnl_senter.Controls.Add(this.button_offgreen);
            this.pnl_senter.Controls.Add(this.button_offyellow);
            this.pnl_senter.Controls.Add(this.button_ongreen);
            this.pnl_senter.Controls.Add(this.button_onyellow);
            this.pnl_senter.Controls.Add(this.PNL_GREEN);
            this.pnl_senter.Controls.Add(this.PNL_YELLOW);
            this.pnl_senter.Controls.Add(this.button_offred);
            this.pnl_senter.Controls.Add(this.button_onred);
            this.pnl_senter.Controls.Add(this.PNL_RED);
            this.pnl_senter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_senter.Location = new System.Drawing.Point(0, 187);
            this.pnl_senter.Name = "pnl_senter";
            this.pnl_senter.Size = new System.Drawing.Size(800, 229);
            this.pnl_senter.TabIndex = 1;
            this.pnl_senter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_senter_Paint);
            // 
            // button_onred
            // 
            this.button_onred.BackColor = System.Drawing.Color.Gray;
            this.button_onred.Location = new System.Drawing.Point(148, 141);
            this.button_onred.Name = "button_onred";
            this.button_onred.Size = new System.Drawing.Size(75, 23);
            this.button_onred.TabIndex = 4;
            this.button_onred.Text = "ON";
            this.button_onred.UseVisualStyleBackColor = false;
            // 
            // PNL_RED
            // 
            this.PNL_RED.BackColor = System.Drawing.Color.Red;
            this.PNL_RED.Location = new System.Drawing.Point(12, 6);
            this.PNL_RED.Name = "PNL_RED";
            this.PNL_RED.Size = new System.Drawing.Size(211, 100);
            this.PNL_RED.TabIndex = 0;
            this.PNL_RED.Paint += new System.Windows.Forms.PaintEventHandler(this.pln_seting_Paint);
            // 
            // button_offred
            // 
            this.button_offred.Location = new System.Drawing.Point(148, 112);
            this.button_offred.Name = "button_offred";
            this.button_offred.Size = new System.Drawing.Size(75, 23);
            this.button_offred.TabIndex = 5;
            this.button_offred.Text = "OFF";
            this.button_offred.UseVisualStyleBackColor = true;
            // 
            // PNL_YELLOW
            // 
            this.PNL_YELLOW.BackColor = System.Drawing.Color.Yellow;
            this.PNL_YELLOW.Location = new System.Drawing.Point(307, 6);
            this.PNL_YELLOW.Name = "PNL_YELLOW";
            this.PNL_YELLOW.Size = new System.Drawing.Size(211, 100);
            this.PNL_YELLOW.TabIndex = 6;
            // 
            // PNL_GREEN
            // 
            this.PNL_GREEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PNL_GREEN.Location = new System.Drawing.Point(577, 6);
            this.PNL_GREEN.Name = "PNL_GREEN";
            this.PNL_GREEN.Size = new System.Drawing.Size(211, 100);
            this.PNL_GREEN.TabIndex = 1;
            // 
            // button_onyellow
            // 
            this.button_onyellow.BackColor = System.Drawing.Color.Gray;
            this.button_onyellow.Location = new System.Drawing.Point(443, 112);
            this.button_onyellow.Name = "button_onyellow";
            this.button_onyellow.Size = new System.Drawing.Size(75, 23);
            this.button_onyellow.TabIndex = 7;
            this.button_onyellow.Text = "ON";
            this.button_onyellow.UseVisualStyleBackColor = false;
            // 
            // button_ongreen
            // 
            this.button_ongreen.BackColor = System.Drawing.Color.Gray;
            this.button_ongreen.Location = new System.Drawing.Point(713, 112);
            this.button_ongreen.Name = "button_ongreen";
            this.button_ongreen.Size = new System.Drawing.Size(75, 23);
            this.button_ongreen.TabIndex = 8;
            this.button_ongreen.Text = "ON";
            this.button_ongreen.UseVisualStyleBackColor = false;
            // 
            // button_offyellow
            // 
            this.button_offyellow.Location = new System.Drawing.Point(443, 141);
            this.button_offyellow.Name = "button_offyellow";
            this.button_offyellow.Size = new System.Drawing.Size(75, 23);
            this.button_offyellow.TabIndex = 9;
            this.button_offyellow.Text = "OFF";
            this.button_offyellow.UseVisualStyleBackColor = true;
            // 
            // button_offgreen
            // 
            this.button_offgreen.Location = new System.Drawing.Point(713, 141);
            this.button_offgreen.Name = "button_offgreen";
            this.button_offgreen.Size = new System.Drawing.Size(75, 23);
            this.button_offgreen.TabIndex = 10;
            this.button_offgreen.Text = "OFF";
            this.button_offgreen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(307, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "button";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(577, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 52);
            this.button4.TabIndex = 13;
            this.button4.Text = "button";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(89, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "--->";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(384, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "--->";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button7.Location = new System.Drawing.Point(654, 127);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "--->";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // pnl_pot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_senter);
            this.Name = "pnl_pot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_senter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_senter;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button button_offgreen;
        private System.Windows.Forms.Button button_offyellow;
        private System.Windows.Forms.Button button_ongreen;
        private System.Windows.Forms.Button button_onyellow;
        private System.Windows.Forms.Panel PNL_GREEN;
        private System.Windows.Forms.Panel PNL_YELLOW;
        private System.Windows.Forms.Button button_offred;
        private System.Windows.Forms.Button button_onred;
        private System.Windows.Forms.Panel PNL_RED;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

