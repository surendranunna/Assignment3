namespace WindowsFormsApp3
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateDay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimesSec = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(261, 38);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(222, 20);
            this.dtPicker.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(157, 89);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(35, 13);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(157, 128);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label2";
            // 
            // lblDateDay
            // 
            this.lblDateDay.AutoSize = true;
            this.lblDateDay.Location = new System.Drawing.Point(157, 178);
            this.lblDateDay.Name = "lblDateDay";
            this.lblDateDay.Size = new System.Drawing.Size(35, 13);
            this.lblDateDay.TabIndex = 3;
            this.lblDateDay.Text = "label3";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(157, 223);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label4";
            // 
            // lblTimesSec
            // 
            this.lblTimesSec.AutoSize = true;
            this.lblTimesSec.Location = new System.Drawing.Point(157, 261);
            this.lblTimesSec.Name = "lblTimesSec";
            this.lblTimesSec.Size = new System.Drawing.Size(35, 13);
            this.lblTimesSec.TabIndex = 5;
            this.lblTimesSec.Text = "label5";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(577, 290);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(103, 45);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTimesSec);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDateDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dtPicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateDay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimesSec;
        private System.Windows.Forms.Button btnShow;
    }
}

