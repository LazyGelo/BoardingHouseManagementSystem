
namespace BoardingHouseManagementSystem
{
    partial class AdminPage
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
            this.ADMNDb = new System.Windows.Forms.Button();
            this.ADMNTp = new System.Windows.Forms.Button();
            this.ADMNRoom = new System.Windows.Forms.Button();
            this.ADMNPayment = new System.Windows.Forms.Button();
            this.ADMNNotice = new System.Windows.Forms.Button();
            this.ADMNSugg = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.panelName = new System.Windows.Forms.Panel();
            this.admnTp1 = new BoardingHouseManagementSystem.ADMNTNTp();
            this.admnSugg1 = new BoardingHouseManagementSystem.ADMNSuggest();
            this.admnRoom1 = new BoardingHouseManagementSystem.ADMNRoomm();
            this.admnPayment1 = new BoardingHouseManagementSystem.ADMNPaymentt();
            this.admnNotice1 = new BoardingHouseManagementSystem.ADMNNoticee();
            this.admnDash1 = new BoardingHouseManagementSystem.ADMNDash();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.ADMNDb);
            this.flowLayoutPanel1.Controls.Add(this.ADMNTp);
            this.flowLayoutPanel1.Controls.Add(this.ADMNRoom);
            this.flowLayoutPanel1.Controls.Add(this.ADMNPayment);
            this.flowLayoutPanel1.Controls.Add(this.ADMNNotice);
            this.flowLayoutPanel1.Controls.Add(this.ADMNSugg);
            this.flowLayoutPanel1.Controls.Add(this.logOut);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 451);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ADMNDb
            // 
            this.ADMNDb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMNDb.Location = new System.Drawing.Point(3, 3);
            this.ADMNDb.Name = "ADMNDb";
            this.ADMNDb.Size = new System.Drawing.Size(139, 40);
            this.ADMNDb.TabIndex = 0;
            this.ADMNDb.Text = "DASHBOARD";
            this.ADMNDb.UseVisualStyleBackColor = false;
            this.ADMNDb.Click += new System.EventHandler(this.ADMNDb_Click);
            // 
            // ADMNTp
            // 
            this.ADMNTp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMNTp.Location = new System.Drawing.Point(3, 49);
            this.ADMNTp.Name = "ADMNTp";
            this.ADMNTp.Size = new System.Drawing.Size(139, 40);
            this.ADMNTp.TabIndex = 1;
            this.ADMNTp.Text = "TENANTS PROFILE";
            this.ADMNTp.UseVisualStyleBackColor = false;
            this.ADMNTp.Click += new System.EventHandler(this.ADMNTp_Click);
            // 
            // ADMNRoom
            // 
            this.ADMNRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMNRoom.Location = new System.Drawing.Point(3, 95);
            this.ADMNRoom.Name = "ADMNRoom";
            this.ADMNRoom.Size = new System.Drawing.Size(139, 40);
            this.ADMNRoom.TabIndex = 2;
            this.ADMNRoom.Text = "ROOM";
            this.ADMNRoom.UseVisualStyleBackColor = false;
            this.ADMNRoom.Click += new System.EventHandler(this.ADMNRoom_Click);
            // 
            // ADMNPayment
            // 
            this.ADMNPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMNPayment.Location = new System.Drawing.Point(3, 141);
            this.ADMNPayment.Name = "ADMNPayment";
            this.ADMNPayment.Size = new System.Drawing.Size(139, 40);
            this.ADMNPayment.TabIndex = 3;
            this.ADMNPayment.Text = "PAYMENT";
            this.ADMNPayment.UseVisualStyleBackColor = false;
            this.ADMNPayment.Click += new System.EventHandler(this.ADMNPayment_Click);
            // 
            // ADMNNotice
            // 
            this.ADMNNotice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMNNotice.Location = new System.Drawing.Point(3, 187);
            this.ADMNNotice.Name = "ADMNNotice";
            this.ADMNNotice.Size = new System.Drawing.Size(139, 40);
            this.ADMNNotice.TabIndex = 4;
            this.ADMNNotice.Text = "NOTICE";
            this.ADMNNotice.UseVisualStyleBackColor = false;
            this.ADMNNotice.Click += new System.EventHandler(this.ADMNNotice_Click);
            // 
            // ADMNSugg
            // 
            this.ADMNSugg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMNSugg.Location = new System.Drawing.Point(3, 233);
            this.ADMNSugg.Name = "ADMNSugg";
            this.ADMNSugg.Size = new System.Drawing.Size(139, 40);
            this.ADMNSugg.TabIndex = 5;
            this.ADMNSugg.Text = "SUGGESTION";
            this.ADMNSugg.UseVisualStyleBackColor = false;
            this.ADMNSugg.Click += new System.EventHandler(this.ADMNSugg_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOut.Location = new System.Drawing.Point(3, 279);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(139, 40);
            this.logOut.TabIndex = 6;
            this.logOut.Text = "LOGOUT";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panelName
            // 
            this.panelName.Location = new System.Drawing.Point(150, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(648, 450);
            this.panelName.TabIndex = 8;
            // 
            // admnTp1
            // 
            this.admnTp1.Location = new System.Drawing.Point(150, 0);
            this.admnTp1.Name = "admnTp1";
            this.admnTp1.Size = new System.Drawing.Size(648, 450);
            this.admnTp1.TabIndex = 7;
            // 
            // admnSugg1
            // 
            this.admnSugg1.Location = new System.Drawing.Point(150, 0);
            this.admnSugg1.Name = "admnSugg1";
            this.admnSugg1.Size = new System.Drawing.Size(648, 450);
            this.admnSugg1.TabIndex = 6;
            // 
            // admnRoom1
            // 
            this.admnRoom1.Location = new System.Drawing.Point(150, 0);
            this.admnRoom1.Name = "admnRoom1";
            this.admnRoom1.Size = new System.Drawing.Size(648, 450);
            this.admnRoom1.TabIndex = 5;
            // 
            // admnPayment1
            // 
            this.admnPayment1.Location = new System.Drawing.Point(150, 0);
            this.admnPayment1.Name = "admnPayment1";
            this.admnPayment1.Size = new System.Drawing.Size(648, 450);
            this.admnPayment1.TabIndex = 4;
            // 
            // admnNotice1
            // 
            this.admnNotice1.Location = new System.Drawing.Point(150, 0);
            this.admnNotice1.Name = "admnNotice1";
            this.admnNotice1.Size = new System.Drawing.Size(648, 450);
            this.admnNotice1.TabIndex = 3;
            // 
            // admnDash1
            // 
            this.admnDash1.Location = new System.Drawing.Point(150, 0);
            this.admnDash1.Name = "admnDash1";
            this.admnDash1.Size = new System.Drawing.Size(648, 450);
            this.admnDash1.TabIndex = 2;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.admnTp1);
            this.Controls.Add(this.admnSugg1);
            this.Controls.Add(this.admnRoom1);
            this.Controls.Add(this.admnPayment1);
            this.Controls.Add(this.admnNotice1);
            this.Controls.Add(this.admnDash1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ADMNDash admnDash1;
        private ADMNNoticee admnNotice1;
        private ADMNPaymentt admnPayment1;
        private ADMNRoomm admnRoom1;
        private ADMNSuggest admnSugg1;
        private ADMNTNTp admnTp1;
        private System.Windows.Forms.Button ADMNDb;
        private System.Windows.Forms.Button ADMNTp;
        private System.Windows.Forms.Button ADMNRoom;
        private System.Windows.Forms.Button ADMNPayment;
        private System.Windows.Forms.Button ADMNNotice;
        private System.Windows.Forms.Button ADMNSugg;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panelName;
    }
}