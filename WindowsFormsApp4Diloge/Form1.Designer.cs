namespace WindowsFormsApp4Diloge
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
            this.btnyes = new System.Windows.Forms.Button();
            this.lblcancel = new System.Windows.Forms.Label();
            this.lblyesno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyes.Location = new System.Drawing.Point(279, 146);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(107, 41);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Yes";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // lblcancel
            // 
            this.lblcancel.AutoSize = true;
            this.lblcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcancel.ForeColor = System.Drawing.Color.DarkRed;
            this.lblcancel.Location = new System.Drawing.Point(178, 221);
            this.lblcancel.Name = "lblcancel";
            this.lblcancel.Size = new System.Drawing.Size(29, 20);
            this.lblcancel.TabIndex = 1;
            this.lblcancel.Text = ".....";
            // 
            // lblyesno
            // 
            this.lblyesno.AutoSize = true;
            this.lblyesno.BackColor = System.Drawing.SystemColors.Control;
            this.lblyesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyesno.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblyesno.Location = new System.Drawing.Point(179, 281);
            this.lblyesno.Name = "lblyesno";
            this.lblyesno.Size = new System.Drawing.Size(23, 16);
            this.lblyesno.TabIndex = 2;
            this.lblyesno.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Purchase Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "do you want to purchase  inoventic software ? press Yes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblyesno);
            this.Controls.Add(this.lblcancel);
            this.Controls.Add(this.btnyes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label lblcancel;
        private System.Windows.Forms.Label lblyesno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

