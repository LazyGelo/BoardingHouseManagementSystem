
namespace BoardingHouseManagementSystem
{
    partial class TNTPaymentt
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
            this.searchOr = new System.Windows.Forms.Button();
            this.tbSearchOrNum = new System.Windows.Forms.TextBox();
            this.searchOrNum = new System.Windows.Forms.Label();
            this.gvPayment2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPayRent = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayment2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btnPayRent);
            this.panel2.Controls.Add(this.searchOr);
            this.panel2.Controls.Add(this.tbSearchOrNum);
            this.panel2.Controls.Add(this.searchOrNum);
            this.panel2.Controls.Add(this.gvPayment2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(31, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 342);
            this.panel2.TabIndex = 0;
            // 
            // searchOr
            // 
            this.searchOr.Location = new System.Drawing.Point(399, 75);
            this.searchOr.Name = "searchOr";
            this.searchOr.Size = new System.Drawing.Size(75, 23);
            this.searchOr.TabIndex = 8;
            this.searchOr.Text = "search";
            this.searchOr.UseVisualStyleBackColor = true;
            this.searchOr.Click += new System.EventHandler(this.searchOr_Click);
            // 
            // tbSearchOrNum
            // 
            this.tbSearchOrNum.Location = new System.Drawing.Point(182, 77);
            this.tbSearchOrNum.Name = "tbSearchOrNum";
            this.tbSearchOrNum.Size = new System.Drawing.Size(211, 20);
            this.tbSearchOrNum.TabIndex = 7;
            // 
            // searchOrNum
            // 
            this.searchOrNum.AutoSize = true;
            this.searchOrNum.Location = new System.Drawing.Point(104, 80);
            this.searchOrNum.Name = "searchOrNum";
            this.searchOrNum.Size = new System.Drawing.Size(74, 13);
            this.searchOrNum.TabIndex = 6;
            this.searchOrNum.Text = "Enter Or Num:";
            // 
            // gvPayment2
            // 
            this.gvPayment2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPayment2.Location = new System.Drawing.Point(3, 103);
            this.gvPayment2.Name = "gvPayment2";
            this.gvPayment2.Size = new System.Drawing.Size(550, 193);
            this.gvPayment2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(182, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 34);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT";
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
            // btnPayRent
            // 
            this.btnPayRent.Location = new System.Drawing.Point(477, 316);
            this.btnPayRent.Name = "btnPayRent";
            this.btnPayRent.Size = new System.Drawing.Size(75, 23);
            this.btnPayRent.TabIndex = 9;
            this.btnPayRent.Text = "PAY";
            this.btnPayRent.UseVisualStyleBackColor = true;
            this.btnPayRent.Click += new System.EventHandler(this.btnPayRent_Click);
            // 
            // TNTPaymentt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TNTPaymentt";
            this.Size = new System.Drawing.Size(650, 451);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayment2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvPayment2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchOr;
        private System.Windows.Forms.TextBox tbSearchOrNum;
        private System.Windows.Forms.Label searchOrNum;
        private System.Windows.Forms.Button btnPayRent;
    }
}
