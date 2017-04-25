namespace Http_Server
{
    partial class Form1
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
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.txtbox_ip = new System.Windows.Forms.TextBox();
            this.numeric_port = new System.Windows.Forms.NumericUpDown();
            this.numeric_timeout = new System.Windows.Forms.NumericUpDown();
            this.txtbox_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_timeelapsed = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.checkBox_autoip = new System.Windows.Forms.CheckBox();
            this.numeric_maxcon = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_autopath = new System.Windows.Forms.CheckBox();
            this.Main = new System.Windows.Forms.TabPage();
            this.txtbox_log = new System.Windows.Forms.TextBox();
            this.Tab_log = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_timeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_maxcon)).BeginInit();
            this.Main.SuspendLayout();
            this.Tab_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(274, 44);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(109, 31);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Initiate Server";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(285, 84);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(84, 23);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Terminate";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // txtbox_ip
            // 
            this.txtbox_ip.Location = new System.Drawing.Point(74, 41);
            this.txtbox_ip.Name = "txtbox_ip";
            this.txtbox_ip.Size = new System.Drawing.Size(106, 20);
            this.txtbox_ip.TabIndex = 3;
            // 
            // numeric_port
            // 
            this.numeric_port.Location = new System.Drawing.Point(74, 64);
            this.numeric_port.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_port.Name = "numeric_port";
            this.numeric_port.Size = new System.Drawing.Size(52, 20);
            this.numeric_port.TabIndex = 4;
            // 
            // numeric_timeout
            // 
            this.numeric_timeout.Location = new System.Drawing.Point(74, 90);
            this.numeric_timeout.Name = "numeric_timeout";
            this.numeric_timeout.Size = new System.Drawing.Size(52, 20);
            this.numeric_timeout.TabIndex = 5;
            // 
            // txtbox_path
            // 
            this.txtbox_path.Location = new System.Drawing.Point(74, 139);
            this.txtbox_path.Name = "txtbox_path";
            this.txtbox_path.Size = new System.Drawing.Size(106, 20);
            this.txtbox_path.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Timeout:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Root Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(51, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "C# http Server (for internal testing)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time Elapsed:";
            // 
            // label_timeelapsed
            // 
            this.label_timeelapsed.AutoSize = true;
            this.label_timeelapsed.Location = new System.Drawing.Point(361, 124);
            this.label_timeelapsed.Name = "label_timeelapsed";
            this.label_timeelapsed.Size = new System.Drawing.Size(13, 13);
            this.label_timeelapsed.TabIndex = 13;
            this.label_timeelapsed.Text = "0";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // checkBox_autoip
            // 
            this.checkBox_autoip.AutoSize = true;
            this.checkBox_autoip.Location = new System.Drawing.Point(186, 43);
            this.checkBox_autoip.Name = "checkBox_autoip";
            this.checkBox_autoip.Size = new System.Drawing.Size(61, 17);
            this.checkBox_autoip.TabIndex = 14;
            this.checkBox_autoip.Text = "Auto IP";
            this.checkBox_autoip.UseVisualStyleBackColor = true;
            this.checkBox_autoip.CheckedChanged += new System.EventHandler(this.checkBox_autoip_CheckedChanged);
            // 
            // numeric_maxcon
            // 
            this.numeric_maxcon.Location = new System.Drawing.Point(74, 116);
            this.numeric_maxcon.Name = "numeric_maxcon";
            this.numeric_maxcon.Size = new System.Drawing.Size(52, 20);
            this.numeric_maxcon.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Max Con";
            // 
            // checkBox_autopath
            // 
            this.checkBox_autopath.AutoSize = true;
            this.checkBox_autopath.Location = new System.Drawing.Point(186, 141);
            this.checkBox_autopath.Name = "checkBox_autopath";
            this.checkBox_autopath.Size = new System.Drawing.Size(72, 17);
            this.checkBox_autopath.TabIndex = 18;
            this.checkBox_autopath.Text = "Auto path";
            this.checkBox_autopath.UseVisualStyleBackColor = true;
            this.checkBox_autopath.CheckedChanged += new System.EventHandler(this.checkBox_autopath_CheckedChanged);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.txtbox_log);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(377, 241);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // txtbox_log
            // 
            this.txtbox_log.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbox_log.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_log.Location = new System.Drawing.Point(-2, -2);
            this.txtbox_log.Multiline = true;
            this.txtbox_log.Name = "txtbox_log";
            this.txtbox_log.ReadOnly = true;
            this.txtbox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_log.Size = new System.Drawing.Size(377, 242);
            this.txtbox_log.TabIndex = 2;
            this.txtbox_log.TextChanged += new System.EventHandler(this.txtbox_log_TextChanged);
            // 
            // Tab_log
            // 
            this.Tab_log.Controls.Add(this.Main);
            this.Tab_log.Location = new System.Drawing.Point(12, 164);
            this.Tab_log.Name = "Tab_log";
            this.Tab_log.SelectedIndex = 0;
            this.Tab_log.Size = new System.Drawing.Size(385, 267);
            this.Tab_log.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 433);
            this.Controls.Add(this.Tab_log);
            this.Controls.Add(this.checkBox_autopath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numeric_maxcon);
            this.Controls.Add(this.checkBox_autoip);
            this.Controls.Add(this.label_timeelapsed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_path);
            this.Controls.Add(this.numeric_timeout);
            this.Controls.Add(this.numeric_port);
            this.Controls.Add(this.txtbox_ip);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "C# Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_timeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_maxcon)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.Tab_log.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TextBox txtbox_ip;
        private System.Windows.Forms.NumericUpDown numeric_port;
        private System.Windows.Forms.NumericUpDown numeric_timeout;
        private System.Windows.Forms.TextBox txtbox_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_timeelapsed;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBox_autoip;
        private System.Windows.Forms.NumericUpDown numeric_maxcon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_autopath;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TextBox txtbox_log;
        private System.Windows.Forms.TabControl Tab_log;
    }
}

