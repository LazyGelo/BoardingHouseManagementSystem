
namespace BoardingHouseManagementSystem
{
    partial class UpdateSuggest
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
            this.cbUpdStatus3 = new System.Windows.Forms.ComboBox();
            this.btnUpdateSuggest = new System.Windows.Forms.Button();
            this.tbUpdSuggNum = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 4;
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
            this.panel3.Controls.Add(this.cbUpdStatus3);
            this.panel3.Controls.Add(this.btnUpdateSuggest);
            this.panel3.Controls.Add(this.tbUpdSuggNum);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(42, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 266);
            this.panel3.TabIndex = 2;
            // 
            // cbUpdStatus3
            // 
            this.cbUpdStatus3.FormattingEnabled = true;
            this.cbUpdStatus3.Location = new System.Drawing.Point(208, 103);
            this.cbUpdStatus3.Name = "cbUpdStatus3";
            this.cbUpdStatus3.Size = new System.Drawing.Size(148, 21);
            this.cbUpdStatus3.TabIndex = 13;
            // 
            // btnUpdateSuggest
            // 
            this.btnUpdateSuggest.Location = new System.Drawing.Point(208, 170);
            this.btnUpdateSuggest.Name = "btnUpdateSuggest";
            this.btnUpdateSuggest.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSuggest.TabIndex = 12;
            this.btnUpdateSuggest.Text = "UPDATE";
            this.btnUpdateSuggest.UseVisualStyleBackColor = true;
            this.btnUpdateSuggest.Click += new System.EventHandler(this.btnUpdateSuggest_Click);
            // 
            // tbUpdSuggNum
            // 
            this.tbUpdSuggNum.Location = new System.Drawing.Point(208, 75);
            this.tbUpdSuggNum.Name = "tbUpdSuggNum";
            this.tbUpdSuggNum.Size = new System.Drawing.Size(148, 20);
            this.tbUpdSuggNum.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "STATUS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUGG NUM:";
            // 
            // UpdateSuggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateSuggest";
            this.Text = "UpdateSuggest";
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
        private System.Windows.Forms.ComboBox cbUpdStatus3;
        private System.Windows.Forms.Button btnUpdateSuggest;
        private System.Windows.Forms.TextBox tbUpdSuggNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}