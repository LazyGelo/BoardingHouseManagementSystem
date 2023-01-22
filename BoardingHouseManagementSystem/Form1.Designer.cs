
namespace BoardingHouseManagementSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginT = new System.Windows.Forms.Button();
            this.btnLoginA = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLoginT);
            this.panel1.Controls.Add(this.btnLoginA);
            this.panel1.Controls.Add(this.tbPass);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(177, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 234);
            this.panel1.TabIndex = 0;
            // 
            // btnLoginT
            // 
            this.btnLoginT.Location = new System.Drawing.Point(224, 174);
            this.btnLoginT.Name = "btnLoginT";
            this.btnLoginT.Size = new System.Drawing.Size(75, 23);
            this.btnLoginT.TabIndex = 5;
            this.btnLoginT.Text = "TENANT";
            this.btnLoginT.UseVisualStyleBackColor = true;
            this.btnLoginT.Click += new System.EventHandler(this.btnLoginT_Click);
            // 
            // btnLoginA
            // 
            this.btnLoginA.Location = new System.Drawing.Point(154, 174);
            this.btnLoginA.Name = "btnLoginA";
            this.btnLoginA.Size = new System.Drawing.Size(75, 23);
            this.btnLoginA.TabIndex = 4;
            this.btnLoginA.Text = "ADMIN";
            this.btnLoginA.UseVisualStyleBackColor = true;
            this.btnLoginA.Click += new System.EventHandler(this.btnLoginA_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(154, 137);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(145, 20);
            this.tbPass.TabIndex = 3;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(154, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(145, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMAIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginA;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnLoginT;
    }
}

