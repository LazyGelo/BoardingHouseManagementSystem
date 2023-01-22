
namespace BoardingHouseManagementSystem
{
    partial class ADMNPaymentt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPaymnt = new System.Windows.Forms.Button();
            this.gvPayments = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayments)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 404);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btnPaymnt);
            this.panel2.Controls.Add(this.gvPayments);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(31, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 342);
            this.panel2.TabIndex = 0;
            // 
            // btnPaymnt
            // 
            this.btnPaymnt.Location = new System.Drawing.Point(466, 299);
            this.btnPaymnt.Name = "btnPaymnt";
            this.btnPaymnt.Size = new System.Drawing.Size(75, 31);
            this.btnPaymnt.TabIndex = 2;
            this.btnPaymnt.Text = "UPDATE";
            this.btnPaymnt.UseVisualStyleBackColor = true;
            this.btnPaymnt.Click += new System.EventHandler(this.btnPaymnt_Click);
            // 
            // gvPayments
            // 
            this.gvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPayments.Location = new System.Drawing.Point(15, 87);
            this.gvPayments.Name = "gvPayments";
            this.gvPayments.Size = new System.Drawing.Size(526, 188);
            this.gvPayments.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(176, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 34);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT REPORT";
            // 
            // ADMNPaymentt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ADMNPaymentt";
            this.Size = new System.Drawing.Size(648, 450);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPayments)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvPayments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaymnt;
    }
}
