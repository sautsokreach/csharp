
namespace HR_contract
{
    partial class frminsertEmployeecontract
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label bonusLabel;
            System.Windows.Forms.Label typeofstaffLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label hireDateLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            this.hRDataSet = new HR_contract.HRDataSet();
            this.tbl_contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_contractTableAdapter = new HR_contract.HRDataSetTableAdapters.tbl_contractTableAdapter();
            this.tableAdapterManager = new HR_contract.HRDataSetTableAdapters.TableAdapterManager();
            this.txtbonus = new System.Windows.Forms.TextBox();
            this.cbotypestaff = new System.Windows.Forms.ComboBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtfirstN = new System.Windows.Forms.TextBox();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            salaryLabel = new System.Windows.Forms.Label();
            bonusLabel = new System.Windows.Forms.Label();
            typeofstaffLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            hireDateLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_contractBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(48, 236);
            salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(91, 40);
            salaryLabel.TabIndex = 9;
            salaryLabel.Text = "ប្រាក់ខែ";
            // 
            // bonusLabel
            // 
            bonusLabel.AutoSize = true;
            bonusLabel.Location = new System.Drawing.Point(52, 344);
            bonusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bonusLabel.Name = "bonusLabel";
            bonusLabel.Size = new System.Drawing.Size(107, 40);
            bonusLabel.TabIndex = 11;
            bonusLabel.Text = "ប្រាក់រង្វន់";
            // 
            // typeofstaffLabel
            // 
            typeofstaffLabel.AutoSize = true;
            typeofstaffLabel.Location = new System.Drawing.Point(52, 450);
            typeofstaffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeofstaffLabel.Name = "typeofstaffLabel";
            typeofstaffLabel.Size = new System.Drawing.Size(155, 40);
            typeofstaffLabel.TabIndex = 13;
            typeofstaffLabel.Text = "ប្រភេទបុគ្គលិក";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("សម្រាប់កូនខ្មែរ", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Highlight;
            label1.Location = new System.Drawing.Point(500, -1);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(263, 60);
            label1.TabIndex = 19;
            label1.Text = "កិច្ចសន្យាបុគ្គលិក";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(48, 34);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 40);
            label2.TabIndex = 25;
            label2.Text = "អត្ថលេខ";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Location = new System.Drawing.Point(52, 134);
            hireDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new System.Drawing.Size(157, 40);
            hireDateLabel.TabIndex = 7;
            hireDateLabel.Text = "ថ្ងៃចុះកិច្ចសន្យា";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(569, 344);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(82, 40);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "អ៊ីម៉ែល";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(569, 449);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(131, 40);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "លេខទូរស័ព្ទ";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(575, 240);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(58, 40);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "ភេទ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(566, 30);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(122, 40);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "នាមត្រកូល";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(569, 127);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(89, 40);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "នាមខ្លួន";
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_contractBindingSource
            // 
            this.tbl_contractBindingSource.DataMember = "tbl_contract";
            this.tbl_contractBindingSource.DataSource = this.hRDataSet;
            // 
            // tbl_contractTableAdapter
            // 
            this.tbl_contractTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_contractTableAdapter = this.tbl_contractTableAdapter;
            this.tableAdapterManager.UpdateOrder = HR_contract.HRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtbonus
            // 
            this.txtbonus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "bonus", true));
            this.txtbonus.Location = new System.Drawing.Point(50, 389);
            this.txtbonus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbonus.Name = "txtbonus";
            this.txtbonus.Size = new System.Drawing.Size(311, 48);
            this.txtbonus.TabIndex = 12;
            // 
            // cbotypestaff
            // 
            this.cbotypestaff.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "typeofstaff", true));
            this.cbotypestaff.FormattingEnabled = true;
            this.cbotypestaff.Items.AddRange(new object[] {
            "ពេញសិទ្ធ",
            "កិច្ចសន្យា"});
            this.cbotypestaff.Location = new System.Drawing.Point(50, 495);
            this.cbotypestaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbotypestaff.Name = "cbotypestaff";
            this.cbotypestaff.Size = new System.Drawing.Size(309, 48);
            this.cbotypestaff.TabIndex = 14;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(307, 663);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(136, 56);
            this.btnok.TabIndex = 20;
            this.btnok.Text = "យល់ព្រម";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(731, 663);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 56);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(935, 663);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 56);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "សម្អាត";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(521, 663);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 56);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "កែប្រែ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.txtfirstN);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.txtLastN);
            this.groupBox1.Controls.Add(genderLabel);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(hireDateLabel);
            this.groupBox1.Controls.Add(this.dtpdob);
            this.groupBox1.Controls.Add(salaryLabel);
            this.groupBox1.Controls.Add(this.txtsalary);
            this.groupBox1.Controls.Add(bonusLabel);
            this.groupBox1.Controls.Add(this.txtbonus);
            this.groupBox1.Controls.Add(typeofstaffLabel);
            this.groupBox1.Controls.Add(this.cbotypestaff);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Location = new System.Drawing.Point(215, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 575);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "lastName", true));
            this.txtid.Location = new System.Drawing.Point(50, 79);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(311, 48);
            this.txtid.TabIndex = 21;
            // 
            // txtfirstN
            // 
            this.txtfirstN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "firstName", true));
            this.txtfirstN.Enabled = false;
            this.txtfirstN.Location = new System.Drawing.Point(573, 176);
            this.txtfirstN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfirstN.Name = "txtfirstN";
            this.txtfirstN.Size = new System.Drawing.Size(309, 48);
            this.txtfirstN.TabIndex = 2;
            // 
            // txtLastN
            // 
            this.txtLastN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "lastName", true));
            this.txtLastN.Enabled = false;
            this.txtLastN.Location = new System.Drawing.Point(571, 79);
            this.txtLastN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.Size = new System.Drawing.Size(311, 48);
            this.txtLastN.TabIndex = 4;
            // 
            // cboGender
            // 
            this.cboGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "gender", true));
            this.cboGender.Enabled = false;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "ប្រុស",
            "ស្រី"});
            this.cboGender.Location = new System.Drawing.Point(573, 285);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(309, 48);
            this.cboGender.TabIndex = 6;
            // 
            // dtpdob
            // 
            this.dtpdob.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_contractBindingSource, "hireDate", true));
            this.dtpdob.Font = new System.Drawing.Font("សម្រាប់កូនខ្មែរ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdob.Location = new System.Drawing.Point(50, 179);
            this.dtpdob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(309, 48);
            this.dtpdob.TabIndex = 8;
            // 
            // txtsalary
            // 
            this.txtsalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "salary", true));
            this.txtsalary.Location = new System.Drawing.Point(50, 285);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(309, 48);
            this.txtsalary.TabIndex = 10;
            // 
            // txtphone
            // 
            this.txtphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "phone", true));
            this.txtphone.Enabled = false;
            this.txtphone.Location = new System.Drawing.Point(576, 494);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(306, 48);
            this.txtphone.TabIndex = 16;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_contractBindingSource, "email", true));
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(576, 389);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(306, 48);
            this.txtemail.TabIndex = 18;
            // 
            // frminsertEmployeecontract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1226, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnok);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("សម្រាប់កូនខ្មែរ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "frminsertEmployeecontract";
            this.Text = "frminsertEmployeecontract";
            this.Load += new System.EventHandler(this.frminsertEmployeecontract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_contractBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource tbl_contractBindingSource;
        private HRDataSetTableAdapters.tbl_contractTableAdapter tbl_contractTableAdapter;
        private HRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbonus;
        private System.Windows.Forms.ComboBox cbotypestaff;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtfirstN;
        private System.Windows.Forms.TextBox txtLastN;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
    }
}