
namespace BoardingHouseManagementSystem
{
    partial class TNTSuggest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbDateSugg = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.tbSuggests = new System.Windows.Forms.TextBox();
            this.tbTntId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSuggNumz = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(31, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 342);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.tbSuggNumz);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbDateSugg);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnReport);
            this.panel4.Controls.Add(this.tbSuggests);
            this.panel4.Controls.Add(this.tbTntId);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(41, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 266);
            this.panel4.TabIndex = 5;
            // 
            // tbDateSugg
            // 
            this.tbDateSugg.Location = new System.Drawing.Point(133, 45);
            this.tbDateSugg.Mask = "00/00/0000";
            this.tbDateSugg.Name = "tbDateSugg";
            this.tbDateSugg.Size = new System.Drawing.Size(321, 20);
            this.tbDateSugg.TabIndex = 15;
            this.tbDateSugg.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "SUGGESTION:";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(204, 123);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tbSuggests
            // 
            this.tbSuggests.Location = new System.Drawing.Point(133, 71);
            this.tbSuggests.Name = "tbSuggests";
            this.tbSuggests.Size = new System.Drawing.Size(321, 20);
            this.tbSuggests.TabIndex = 7;
            // 
            // tbTntId
            // 
            this.tbTntId.Location = new System.Drawing.Point(133, 17);
            this.tbTntId.Name = "tbTntId";
            this.tbTntId.Size = new System.Drawing.Size(321, 20);
            this.tbTntId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "TENANT NAME:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(182, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 34);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUGGESTION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(17, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 404);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "SUGG NUM:";
            // 
            // tbSuggNumz
            // 
            this.tbSuggNumz.Location = new System.Drawing.Point(133, 97);
            this.tbSuggNumz.Name = "tbSuggNumz";
            this.tbSuggNumz.Size = new System.Drawing.Size(321, 20);
            this.tbSuggNumz.TabIndex = 17;
            // 
            // TNTSuggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TNTSuggest";
            this.Size = new System.Drawing.Size(650, 451);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox tbSuggests;
        private System.Windows.Forms.TextBox tbTntId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tbDateSugg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSuggNumz;
        private System.Windows.Forms.Label label4;
    }
}
