
namespace BoardingHouseManagementSystem
{
    partial class TenantPage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TNTNotice = new System.Windows.Forms.Button();
            this.TNTRoom = new System.Windows.Forms.Button();
            this.TNTSugg = new System.Windows.Forms.Button();
            this.TNTPayment = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.panelName2 = new System.Windows.Forms.Panel();
            this.tntSugg1 = new BoardingHouseManagementSystem.TNTSuggest();
            
            this.tntPayment1 = new BoardingHouseManagementSystem.TNTPaymentt();
            this.tntNotice1 = new BoardingHouseManagementSystem.TNTNoticee();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.TNTNotice);
            this.flowLayoutPanel1.Controls.Add(this.TNTRoom);
            this.flowLayoutPanel1.Controls.Add(this.TNTSugg);
            this.flowLayoutPanel1.Controls.Add(this.TNTPayment);
            this.flowLayoutPanel1.Controls.Add(this.logOut);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 451);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // TNTNotice
            // 
            this.TNTNotice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TNTNotice.Location = new System.Drawing.Point(3, 3);
            this.TNTNotice.Name = "TNTNotice";
            this.TNTNotice.Size = new System.Drawing.Size(139, 40);
            this.TNTNotice.TabIndex = 0;
            this.TNTNotice.Text = "NOTICE";
            this.TNTNotice.UseVisualStyleBackColor = false;
            this.TNTNotice.Click += new System.EventHandler(this.TNTNotice_Click);
            // 
            // TNTSugg
            // 
            this.TNTSugg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TNTSugg.Location = new System.Drawing.Point(3, 95);
            this.TNTSugg.Name = "TNTSugg";
            this.TNTSugg.Size = new System.Drawing.Size(139, 40);
            this.TNTSugg.TabIndex = 2;
            this.TNTSugg.Text = "SUGGESTION";
            this.TNTSugg.UseVisualStyleBackColor = false;
            this.TNTSugg.Click += new System.EventHandler(this.TNTSugg_Click);
            // 
            // TNTPayment
            // 
            this.TNTPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TNTPayment.Location = new System.Drawing.Point(3, 141);
            this.TNTPayment.Name = "TNTPayment";
            this.TNTPayment.Size = new System.Drawing.Size(139, 40);
            this.TNTPayment.TabIndex = 3;
            this.TNTPayment.Text = "PAYMENT";
            this.TNTPayment.UseVisualStyleBackColor = false;
            this.TNTPayment.Click += new System.EventHandler(this.TNTPayment_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOut.Location = new System.Drawing.Point(3, 187);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(139, 40);
            this.logOut.TabIndex = 6;
            this.logOut.Text = "LOGOUT";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panelName2
            // 
            this.panelName2.Location = new System.Drawing.Point(150, 0);
            this.panelName2.Name = "panelName2";
            this.panelName2.Size = new System.Drawing.Size(650, 451);
            this.panelName2.TabIndex = 7;
            // 
            // tntSugg1
            // 
            this.tntSugg1.Location = new System.Drawing.Point(150, 0);
            this.tntSugg1.Name = "tntSugg1";
            this.tntSugg1.Size = new System.Drawing.Size(650, 451);
            this.tntSugg1.TabIndex = 6;
            // 
          
            // tntPayment1
            // 
            this.tntPayment1.Location = new System.Drawing.Point(150, 0);
            this.tntPayment1.Name = "tntPayment1";
            this.tntPayment1.Size = new System.Drawing.Size(650, 451);
            this.tntPayment1.TabIndex = 4;
            // 
            // tntNotice1
            // 
            this.tntNotice1.Location = new System.Drawing.Point(150, 0);
            this.tntNotice1.Name = "tntNotice1";
            this.tntNotice1.Size = new System.Drawing.Size(650, 451);
            this.tntNotice1.TabIndex = 3;
            // 
            // TenantPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelName2);
            this.Controls.Add(this.tntSugg1);
            
            this.Controls.Add(this.tntPayment1);
            this.Controls.Add(this.tntNotice1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TenantPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TenantPage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TNTNotice;
        private System.Windows.Forms.Button TNTRoom;
        private System.Windows.Forms.Button TNTSugg;
        private System.Windows.Forms.Button TNTPayment;
        private System.Windows.Forms.Button logOut;
        private TNTNoticee tntNotice1;
        private TNTPaymentt tntPayment1;
       
        private TNTSuggest tntSugg1;
        private System.Windows.Forms.Panel panelName2;
    }
}