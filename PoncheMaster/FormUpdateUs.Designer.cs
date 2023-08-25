namespace PoncheMaster
{
    partial class FormUpdateUs
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label iDUserTypeLabel;
            System.Windows.Forms.Label iDUserLabel;
            this.UsertypecomboBox = new System.Windows.Forms.ComboBox();
            this.ButtonCrear = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.poncheMasterDataSet = new PoncheMaster.PoncheMasterDataSet();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new PoncheMaster.PoncheMasterDataSetTableAdapters.UserTableTableAdapter();
            this.tableAdapterManager = new PoncheMaster.PoncheMasterDataSetTableAdapters.TableAdapterManager();
            this.iDUserComboBox = new System.Windows.Forms.ComboBox();
            this.userTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTypeTableAdapter = new PoncheMaster.PoncheMasterDataSetTableAdapters.UserTypeTableAdapter();
            usernameLabel = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            iDUserTypeLabel = new System.Windows.Forms.Label();
            iDUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poncheMasterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(12, 46);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(87, 20);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Username:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userPasswordLabel.Location = new System.Drawing.Point(12, 78);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(120, 20);
            userPasswordLabel.TabIndex = 18;
            userPasswordLabel.Text = "User Password:";
            // 
            // iDUserTypeLabel
            // 
            iDUserTypeLabel.AutoSize = true;
            iDUserTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDUserTypeLabel.Location = new System.Drawing.Point(12, 110);
            iDUserTypeLabel.Name = "iDUserTypeLabel";
            iDUserTypeLabel.Size = new System.Drawing.Size(102, 20);
            iDUserTypeLabel.TabIndex = 20;
            iDUserTypeLabel.Text = "IDUser Type:";
            // 
            // iDUserLabel
            // 
            iDUserLabel.AutoSize = true;
            iDUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDUserLabel.Location = new System.Drawing.Point(12, 17);
            iDUserLabel.Name = "iDUserLabel";
            iDUserLabel.Size = new System.Drawing.Size(64, 20);
            iDUserLabel.TabIndex = 24;
            iDUserLabel.Text = "IDUser:";
            // 
            // UsertypecomboBox
            // 
            this.UsertypecomboBox.DataSource = this.userTypeBindingSource;
            this.UsertypecomboBox.DisplayMember = "UserType";
            this.UsertypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertypecomboBox.FormattingEnabled = true;
            this.UsertypecomboBox.Location = new System.Drawing.Point(141, 108);
            this.UsertypecomboBox.Name = "UsertypecomboBox";
            this.UsertypecomboBox.Size = new System.Drawing.Size(143, 28);
            this.UsertypecomboBox.TabIndex = 23;
            this.UsertypecomboBox.ValueMember = "IDUserType";
            // 
            // ButtonCrear
            // 
            this.ButtonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonCrear.Location = new System.Drawing.Point(84, 155);
            this.ButtonCrear.Name = "ButtonCrear";
            this.ButtonCrear.Size = new System.Drawing.Size(115, 29);
            this.ButtonCrear.TabIndex = 22;
            this.ButtonCrear.Text = "Update";
            this.ButtonCrear.UseVisualStyleBackColor = true;
            this.ButtonCrear.Click += new System.EventHandler(this.ButtonCrear_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(141, 43);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(143, 26);
            this.usernameTextBox.TabIndex = 17;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordTextBox.Location = new System.Drawing.Point(141, 75);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(143, 26);
            this.userPasswordTextBox.TabIndex = 19;
            // 
            // poncheMasterDataSet
            // 
            this.poncheMasterDataSet.DataSetName = "PoncheMasterDataSet";
            this.poncheMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.poncheMasterDataSet;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.EmployeePositionTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.PoncheTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PoncheMaster.PoncheMasterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableTableAdapter = this.userTableTableAdapter;
            this.tableAdapterManager.UserTypeTableAdapter = null;
            // 
            // iDUserComboBox
            // 
            this.iDUserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource, "IDUser", true));
            this.iDUserComboBox.DataSource = this.userTableBindingSource1;
            this.iDUserComboBox.DisplayMember = "Username";
            this.iDUserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDUserComboBox.FormattingEnabled = true;
            this.iDUserComboBox.Location = new System.Drawing.Point(141, 9);
            this.iDUserComboBox.Name = "iDUserComboBox";
            this.iDUserComboBox.Size = new System.Drawing.Size(143, 28);
            this.iDUserComboBox.TabIndex = 25;
            this.iDUserComboBox.ValueMember = "IDUser";
            // 
            // userTableBindingSource1
            // 
            this.userTableBindingSource1.DataMember = "UserTable";
            this.userTableBindingSource1.DataSource = this.poncheMasterDataSet;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(206, 155);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 29);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // userTypeBindingSource
            // 
            this.userTypeBindingSource.DataMember = "UserType";
            this.userTypeBindingSource.DataSource = this.poncheMasterDataSet;
            // 
            // userTypeTableAdapter
            // 
            this.userTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdateUs
            // 
            this.AcceptButton = this.ButtonCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(339, 196);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(iDUserLabel);
            this.Controls.Add(this.iDUserComboBox);
            this.Controls.Add(this.UsertypecomboBox);
            this.Controls.Add(this.ButtonCrear);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(userPasswordLabel);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(iDUserTypeLabel);
            this.MaximumSize = new System.Drawing.Size(355, 235);
            this.MinimumSize = new System.Drawing.Size(355, 235);
            this.Name = "FormUpdateUs";
            this.Text = "FormUpdateUs";
            this.Load += new System.EventHandler(this.FormUpdateUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poncheMasterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UsertypecomboBox;
        private System.Windows.Forms.Button ButtonCrear;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private PoncheMasterDataSet poncheMasterDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private PoncheMasterDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private PoncheMasterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox iDUserComboBox;
        private System.Windows.Forms.BindingSource userTableBindingSource1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private PoncheMasterDataSetTableAdapters.UserTypeTableAdapter userTypeTableAdapter;
    }
}