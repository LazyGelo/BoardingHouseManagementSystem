
namespace BoardingHouseManagementSystem
{
    partial class AddRoom
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbStartt = new System.Windows.Forms.MaskedTextBox();
            this.tbTntFname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddRM = new System.Windows.Forms.Button();
            this.tbMonthlyy = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbRNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(92, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 404);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(31, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 342);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.tbStartt);
            this.panel3.Controls.Add(this.tbTntFname);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnAddRM);
            this.panel3.Controls.Add(this.tbMonthlyy);
            this.panel3.Controls.Add(this.tbDesc);
            this.panel3.Controls.Add(this.tbRNum);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(43, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 266);
            this.panel3.TabIndex = 0;
            // 
            // tbStartt
            // 
            this.tbStartt.Location = new System.Drawing.Point(133, 94);
            this.tbStartt.Mask = "00/00/0000";
            this.tbStartt.Name = "tbStartt";
            this.tbStartt.Size = new System.Drawing.Size(321, 20);
            this.tbStartt.TabIndex = 21;
            this.tbStartt.ValidatingType = typeof(System.DateTime);
            // 
            // tbTntFname
            // 
            this.tbTntFname.Location = new System.Drawing.Point(133, 121);
            this.tbTntFname.Name = "tbTntFname";
            this.tbTntFname.Size = new System.Drawing.Size(321, 20);
            this.tbTntFname.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "FULLNAME:";
            // 
            // btnAddRM
            // 
            this.btnAddRM.Location = new System.Drawing.Point(213, 175);
            this.btnAddRM.Name = "btnAddRM";
            this.btnAddRM.Size = new System.Drawing.Size(75, 23);
            this.btnAddRM.TabIndex = 12;
            this.btnAddRM.Text = "ADD";
            this.btnAddRM.UseVisualStyleBackColor = true;
            this.btnAddRM.Click += new System.EventHandler(this.btnAddRM_Click);
            // 
            // tbMonthlyy
            // 
            this.tbMonthlyy.Location = new System.Drawing.Point(133, 68);
            this.tbMonthlyy.Name = "tbMonthlyy";
            this.tbMonthlyy.Size = new System.Drawing.Size(321, 20);
            this.tbMonthlyy.TabIndex = 8;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(133, 42);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(321, 20);
            this.tbDesc.TabIndex = 7;
            // 
            // tbRNum
            // 
            this.tbRNum.Location = new System.Drawing.Point(133, 17);
            this.tbRNum.Name = "tbRNum";
            this.tbRNum.Size = new System.Drawing.Size(321, 20);
            this.tbRNum.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DATE START:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MONTHLY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPTION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROOM NUM:";
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddRM;
        private System.Windows.Forms.TextBox tbMonthlyy;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbRNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTntFname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tbStartt;
    }
}