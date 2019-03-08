namespace MultiFaceRec
{
    partial class welcomeForm
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
            this.custButton = new System.Windows.Forms.Button();
            this.empButton = new System.Windows.Forms.Button();
            this.welcomeLabel2 = new System.Windows.Forms.Label();
            this.lblWlc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // custButton
            // 
            this.custButton.Location = new System.Drawing.Point(2, 109);
            this.custButton.Name = "custButton";
            this.custButton.Size = new System.Drawing.Size(189, 110);
            this.custButton.TabIndex = 1;
            this.custButton.Text = "Customer";
            this.custButton.UseVisualStyleBackColor = true;
         //   this.custButton.Click += new System.EventHandler(this.custButton_Click);
            // 
            // empButton
            // 
            this.empButton.Location = new System.Drawing.Point(197, 109);
            this.empButton.Name = "empButton";
            this.empButton.Size = new System.Drawing.Size(197, 110);
            this.empButton.TabIndex = 2;
            this.empButton.Text = "Employee";
            this.empButton.UseVisualStyleBackColor = true;
           // this.empButton.Click += new System.EventHandler(this.empButton_Click);
            // 
            // welcomeLabel2
            // 
            this.welcomeLabel2.AutoSize = true;
            this.welcomeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel2.Location = new System.Drawing.Point(168, 72);
            this.welcomeLabel2.Name = "welcomeLabel2";
            this.welcomeLabel2.Size = new System.Drawing.Size(84, 24);
            this.welcomeLabel2.TabIndex = 3;
            this.welcomeLabel2.Text = "I am a...";
            // 
            // lblWlc
            // 
            this.lblWlc.AutoSize = true;
            this.lblWlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlc.Location = new System.Drawing.Point(12, 18);
            this.lblWlc.Name = "lblWlc";
            this.lblWlc.Size = new System.Drawing.Size(230, 24);
            this.lblWlc.TabIndex = 4;
            this.lblWlc.Text = "eyePOS Welcomes you";
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 225);
            this.Controls.Add(this.lblWlc);
            this.Controls.Add(this.welcomeLabel2);
            this.Controls.Add(this.empButton);
            this.Controls.Add(this.custButton);
            this.Name = "welcomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button custButton;
        private System.Windows.Forms.Button empButton;
        private System.Windows.Forms.Label welcomeLabel2;
        private System.Windows.Forms.Label lblWlc;
    }
}