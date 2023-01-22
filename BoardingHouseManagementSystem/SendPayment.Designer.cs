
namespace BoardingHouseManagementSystem
{
    partial class SendPayment
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPymntDatez = new System.Windows.Forms.MaskedTextBox();
            this.tbPymntFnamez = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSendPymnt = new System.Windows.Forms.Button();
            this.tbAmntPay = new System.Windows.Forms.TextBox();
            this.tbOrNumz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.tbPymntDatez);
            this.panel3.Controls.Add(this.tbPymntFnamez);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnSendPymnt);
            this.panel3.Controls.Add(this.tbAmntPay);
            this.panel3.Controls.Add(this.tbOrNumz);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(164, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 266);
            this.panel3.TabIndex = 1;
            // 
            // tbPymntDatez
            // 
            this.tbPymntDatez.Location = new System.Drawing.Point(136, 104);
            this.tbPymntDatez.Mask = "00/00/0000";
            this.tbPymntDatez.Name = "tbPymntDatez";
            this.tbPymntDatez.Size = new System.Drawing.Size(321, 20);
            this.tbPymntDatez.TabIndex = 21;
            this.tbPymntDatez.ValidatingType = typeof(System.DateTime);
            // 
            // tbPymntFnamez
            // 
            this.tbPymntFnamez.Location = new System.Drawing.Point(136, 132);
            this.tbPymntFnamez.Name = "tbPymntFnamez";
            this.tbPymntFnamez.Size = new System.Drawing.Size(321, 20);
            this.tbPymntFnamez.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "FULLNAME:";
            // 
            // btnSendPymnt
            // 
            this.btnSendPymnt.Location = new System.Drawing.Point(213, 175);
            this.btnSendPymnt.Name = "btnSendPymnt";
            this.btnSendPymnt.Size = new System.Drawing.Size(75, 23);
            this.btnSendPymnt.TabIndex = 12;
            this.btnSendPymnt.Text = "PAY";
            this.btnSendPymnt.UseVisualStyleBackColor = true;
            this.btnSendPymnt.Click += new System.EventHandler(this.btnSendPymnt_Click);
            // 
            // tbAmntPay
            // 
            this.tbAmntPay.Location = new System.Drawing.Point(136, 78);
            this.tbAmntPay.Name = "tbAmntPay";
            this.tbAmntPay.Size = new System.Drawing.Size(321, 20);
            this.tbAmntPay.TabIndex = 7;
            // 
            // tbOrNumz
            // 
            this.tbOrNumz.Location = new System.Drawing.Point(136, 52);
            this.tbOrNumz.Name = "tbOrNumz";
            this.tbOrNumz.Size = new System.Drawing.Size(321, 20);
            this.tbOrNumz.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PAYMENT DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AMOUNT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OR NUM:";
            // 
            // SendPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Name = "SendPayment";
            this.Text = "SendPayment";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox tbPymntDatez;
        private System.Windows.Forms.TextBox tbPymntFnamez;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSendPymnt;
        private System.Windows.Forms.TextBox tbAmntPay;
        private System.Windows.Forms.TextBox tbOrNumz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}