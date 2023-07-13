namespace HR_contract
{
    partial class FormHomePage
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
            this.Exit = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.contract = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.contract1 = new HR_contract.Contract();
            this.background1 = new HR_contract.Background();
            this.dashboard1 = new HR_contract.Dashboard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.contract);
            this.panel1.Controls.Add(this.background);
            this.panel1.Controls.Add(this.home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 783);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(67, 316);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // setting
            // 
            this.setting.Location = new System.Drawing.Point(67, 263);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(95, 23);
            this.setting.TabIndex = 4;
            this.setting.Text = "Setting";
            this.setting.UseVisualStyleBackColor = true;
            // 
            // contract
            // 
            this.contract.Location = new System.Drawing.Point(67, 204);
            this.contract.Name = "contract";
            this.contract.Size = new System.Drawing.Size(95, 23);
            this.contract.TabIndex = 3;
            this.contract.Text = "Contract";
            this.contract.UseVisualStyleBackColor = true;
            this.contract.Click += new System.EventHandler(this.contract_Click);
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(67, 136);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(95, 23);
            this.background.TabIndex = 2;
            this.background.Text = "Background";
            this.background.UseVisualStyleBackColor = true;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(76, 77);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // contract1
            // 
            this.contract1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contract1.Location = new System.Drawing.Point(254, 0);
            this.contract1.Name = "contract1";
            this.contract1.Size = new System.Drawing.Size(1369, 708);
            this.contract1.TabIndex = 3;
            // 
            // background1
            // 
            this.background1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.background1.Location = new System.Drawing.Point(254, 0);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(1369, 708);
            this.background1.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dashboard1.Location = new System.Drawing.Point(254, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1369, 630);
            this.dashboard1.TabIndex = 1;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1742, 783);
            this.Controls.Add(this.contract1);
            this.Controls.Add(this.background1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.panel1);
            this.Name = "FormHomePage";
            this.Text = "FormHomePage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button contract;
        private System.Windows.Forms.Button background;
        private System.Windows.Forms.Button home;
        private Dashboard dashboard1;
        private Background background1;
        private Contract contract1;
    }
}