
namespace BoardingHouseManagementSystem
{
    partial class ADMNTNTp
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
            this.btnUpdProfile = new System.Windows.Forms.Button();
            this.addTnt = new System.Windows.Forms.Button();
            this.gvTenant = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTenant)).BeginInit();
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
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btnUpdProfile);
            this.panel2.Controls.Add(this.addTnt);
            this.panel2.Controls.Add(this.gvTenant);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(31, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 342);
            this.panel2.TabIndex = 0;
            // 
            // btnUpdProfile
            // 
            this.btnUpdProfile.Location = new System.Drawing.Point(468, 306);
            this.btnUpdProfile.Name = "btnUpdProfile";
            this.btnUpdProfile.Size = new System.Drawing.Size(75, 23);
            this.btnUpdProfile.TabIndex = 7;
            this.btnUpdProfile.Text = "UPDATE";
            this.btnUpdProfile.UseVisualStyleBackColor = true;
            this.btnUpdProfile.Click += new System.EventHandler(this.btnUpdProfile_Click);
            // 
            // addTnt
            // 
            this.addTnt.Location = new System.Drawing.Point(387, 306);
            this.addTnt.Name = "addTnt";
            this.addTnt.Size = new System.Drawing.Size(75, 23);
            this.addTnt.TabIndex = 6;
            this.addTnt.Text = "ADD TENANT";
            this.addTnt.UseVisualStyleBackColor = true;
            this.addTnt.Click += new System.EventHandler(this.addTnt_Click);
            // 
            // gvTenant
            // 
            this.gvTenant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTenant.Location = new System.Drawing.Point(15, 73);
            this.gvTenant.Name = "gvTenant";
            this.gvTenant.Size = new System.Drawing.Size(528, 227);
            this.gvTenant.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TENANTS PROFILE";
            // 
            // ADMNTNTp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ADMNTNTp";
            this.Size = new System.Drawing.Size(648, 450);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTenant)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvTenant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTnt;
        private System.Windows.Forms.Button btnUpdProfile;
    }
}
