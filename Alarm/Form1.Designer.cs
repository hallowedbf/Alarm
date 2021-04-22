namespace Alarm
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
            this.hoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.minsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setAlarmButton = new System.Windows.Forms.Button();
            this.mainAlarm = new System.Windows.Forms.Timer(this.components);
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.hrsRemaining = new System.Windows.Forms.TextBox();
            this.minsRemaining = new System.Windows.Forms.TextBox();
            this.secsRemaining = new System.Windows.Forms.TextBox();
            this.timeRemainingUpdater = new System.Windows.Forms.Timer(this.components);
            this.soundPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // hoursUpDown
            // 
            this.hoursUpDown.Location = new System.Drawing.Point(30, 39);
            this.hoursUpDown.Name = "hoursUpDown";
            this.hoursUpDown.Size = new System.Drawing.Size(36, 20);
            this.hoursUpDown.TabIndex = 1;
            this.hoursUpDown.ValueChanged += new System.EventHandler(this.hoursUpDown_ValueChanged);
            // 
            // secondsUpDown
            // 
            this.secondsUpDown.Location = new System.Drawing.Point(114, 39);
            this.secondsUpDown.Name = "secondsUpDown";
            this.secondsUpDown.Size = new System.Drawing.Size(36, 20);
            this.secondsUpDown.TabIndex = 2;
            this.secondsUpDown.ValueChanged += new System.EventHandler(this.secondsUpDown_ValueChanged);
            // 
            // minsUpDown
            // 
            this.minsUpDown.Location = new System.Drawing.Point(72, 39);
            this.minsUpDown.Name = "minsUpDown";
            this.minsUpDown.Size = new System.Drawing.Size(36, 20);
            this.minsUpDown.TabIndex = 3;
            this.minsUpDown.ValueChanged += new System.EventHandler(this.minsUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Secs";
            // 
            // setAlarmButton
            // 
            this.setAlarmButton.Location = new System.Drawing.Point(49, 77);
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.setAlarmButton.TabIndex = 7;
            this.setAlarmButton.Text = "Set Alarm";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            this.setAlarmButton.Click += new System.EventHandler(this.setAlarmButton_Click);
            // 
            // mainAlarm
            // 
            this.mainAlarm.Tick += new System.EventHandler(this.mainAlarm_Tick);
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.BackColor = System.Drawing.Color.Black;
            this.timeRemainingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timeRemainingLabel.Location = new System.Drawing.Point(46, 117);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(86, 13);
            this.timeRemainingLabel.TabIndex = 8;
            this.timeRemainingLabel.Text = "Time Remaining:";
            this.timeRemainingLabel.Visible = false;
            // 
            // hrsRemaining
            // 
            this.hrsRemaining.BackColor = System.Drawing.Color.White;
            this.hrsRemaining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hrsRemaining.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hrsRemaining.Location = new System.Drawing.Point(30, 142);
            this.hrsRemaining.Name = "hrsRemaining";
            this.hrsRemaining.ReadOnly = true;
            this.hrsRemaining.Size = new System.Drawing.Size(36, 13);
            this.hrsRemaining.TabIndex = 9;
            this.hrsRemaining.Visible = false;
            // 
            // minsRemaining
            // 
            this.minsRemaining.BackColor = System.Drawing.Color.White;
            this.minsRemaining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minsRemaining.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minsRemaining.Location = new System.Drawing.Point(72, 142);
            this.minsRemaining.Name = "minsRemaining";
            this.minsRemaining.ReadOnly = true;
            this.minsRemaining.Size = new System.Drawing.Size(36, 13);
            this.minsRemaining.TabIndex = 10;
            this.minsRemaining.Visible = false;
            // 
            // secsRemaining
            // 
            this.secsRemaining.BackColor = System.Drawing.Color.White;
            this.secsRemaining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secsRemaining.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secsRemaining.Location = new System.Drawing.Point(114, 142);
            this.secsRemaining.Name = "secsRemaining";
            this.secsRemaining.ReadOnly = true;
            this.secsRemaining.Size = new System.Drawing.Size(36, 13);
            this.secsRemaining.TabIndex = 11;
            this.secsRemaining.Visible = false;
            // 
            // timeRemainingUpdater
            // 
            this.timeRemainingUpdater.Enabled = true;
            this.timeRemainingUpdater.Tick += new System.EventHandler(this.timeRemainingUpdater_Tick);
            // 
            // soundPlayTimer
            // 
            this.soundPlayTimer.Interval = 500;
            this.soundPlayTimer.Tick += new System.EventHandler(this.soundPlayTimer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 175);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(155, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(180, 210);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.secsRemaining);
            this.Controls.Add(this.minsRemaining);
            this.Controls.Add(this.hrsRemaining);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minsUpDown);
            this.Controls.Add(this.secondsUpDown);
            this.Controls.Add(this.hoursUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hoursUpDown;
        private System.Windows.Forms.NumericUpDown secondsUpDown;
        private System.Windows.Forms.NumericUpDown minsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setAlarmButton;
        private System.Windows.Forms.Timer mainAlarm;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.TextBox hrsRemaining;
        private System.Windows.Forms.TextBox minsRemaining;
        private System.Windows.Forms.TextBox secsRemaining;
        private System.Windows.Forms.Timer timeRemainingUpdater;
        private System.Windows.Forms.Timer soundPlayTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

