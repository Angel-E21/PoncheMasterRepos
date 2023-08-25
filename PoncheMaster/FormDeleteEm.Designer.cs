namespace PoncheMaster
{
    partial class FormDeleteEm
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
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poncheMasterDataSet = new PoncheMaster.PoncheMasterDataSet();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new PoncheMaster.PoncheMasterDataSetTableAdapters.EmployeeTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poncheMasterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonEliminar.Location = new System.Drawing.Point(58, 89);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(115, 29);
            this.ButtonEliminar.TabIndex = 12;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.DataSource = this.employeeBindingSource;
            this.comboBoxEmployeeID.DisplayMember = "Cedula";
            this.comboBoxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(183, 35);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(184, 28);
            this.comboBoxEmployeeID.TabIndex = 38;
            this.comboBoxEmployeeID.ValueMember = "IDEmployee";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.poncheMasterDataSet;
            // 
            // poncheMasterDataSet
            // 
            this.poncheMasterDataSet.DataSetName = "PoncheMasterDataSet";
            this.poncheMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(12, 38);
            this.pictureBox7.MaximumSize = new System.Drawing.Size(26, 20);
            this.pictureBox7.MinimumSize = new System.Drawing.Size(26, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 20);
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmployeeID.Location = new System.Drawing.Point(44, 38);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(133, 20);
            this.labelEmployeeID.TabIndex = 36;
            this.labelEmployeeID.Text = "Employee Cedula";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(198, 89);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 29);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormDeleteEm
            // 
            this.AcceptButton = this.ButtonEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.labelEmployeeID);
            this.Controls.Add(this.ButtonEliminar);
            this.Location = new System.Drawing.Point(400, 200);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormDeleteEm";
            this.Text = "FormDeleteEm";
            this.Load += new System.EventHandler(this.FormDeleteEm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poncheMasterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label labelEmployeeID;
        private PoncheMasterDataSet poncheMasterDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PoncheMasterDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button buttonCancel;
    }
}