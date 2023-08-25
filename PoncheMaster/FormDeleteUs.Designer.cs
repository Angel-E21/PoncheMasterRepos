namespace PoncheMaster
{
    partial class FormDeleteUs
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
            System.Windows.Forms.Label iDUserLabel;
            this.iDUserComboBox = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ButtonCrear = new System.Windows.Forms.Button();
            this.poncheMasterDataSet = new PoncheMaster.PoncheMasterDataSet();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new PoncheMaster.PoncheMasterDataSetTableAdapters.UserTableTableAdapter();
            iDUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poncheMasterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDUserLabel
            // 
            iDUserLabel.AutoSize = true;
            iDUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDUserLabel.Location = new System.Drawing.Point(12, 9);
            iDUserLabel.Name = "iDUserLabel";
            iDUserLabel.Size = new System.Drawing.Size(64, 20);
            iDUserLabel.TabIndex = 28;
            iDUserLabel.Text = "IDUser:";
            // 
            // iDUserComboBox
            // 
            this.iDUserComboBox.DataSource = this.userTableBindingSource;
            this.iDUserComboBox.DisplayMember = "Username";
            this.iDUserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDUserComboBox.FormattingEnabled = true;
            this.iDUserComboBox.Location = new System.Drawing.Point(109, 9);
            this.iDUserComboBox.Name = "iDUserComboBox";
            this.iDUserComboBox.Size = new System.Drawing.Size(143, 28);
            this.iDUserComboBox.TabIndex = 29;
            this.iDUserComboBox.ValueMember = "IDUser";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(165, 75);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 29);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonCrear
            // 
            this.ButtonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonCrear.Location = new System.Drawing.Point(37, 75);
            this.ButtonCrear.Name = "ButtonCrear";
            this.ButtonCrear.Size = new System.Drawing.Size(115, 29);
            this.ButtonCrear.TabIndex = 27;
            this.ButtonCrear.Text = "Create";
            this.ButtonCrear.UseVisualStyleBackColor = true;
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
            // FormDeleteUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 140);
            this.Controls.Add(iDUserLabel);
            this.Controls.Add(this.iDUserComboBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonCrear);
            this.Name = "FormDeleteUs";
            this.Text = "FormDeleteUs";
            this.Load += new System.EventHandler(this.FormDeleteUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poncheMasterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox iDUserComboBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button ButtonCrear;
        private PoncheMasterDataSet poncheMasterDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private PoncheMasterDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
    }
}