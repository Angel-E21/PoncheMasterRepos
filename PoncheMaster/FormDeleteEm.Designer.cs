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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ButtonPonche = new System.Windows.Forms.Button();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(188, 89);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 29);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonPonche
            // 
            this.ButtonPonche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonPonche.Location = new System.Drawing.Point(58, 89);
            this.ButtonPonche.Name = "ButtonPonche";
            this.ButtonPonche.Size = new System.Drawing.Size(115, 29);
            this.ButtonPonche.TabIndex = 12;
            this.ButtonPonche.Text = "Eliminar";
            this.ButtonPonche.UseVisualStyleBackColor = true;
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(163, 42);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(184, 28);
            this.comboBoxEmployeeID.TabIndex = 38;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(13, 42);
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
            this.labelEmployeeID.Location = new System.Drawing.Point(45, 42);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.labelEmployeeID.TabIndex = 36;
            this.labelEmployeeID.Text = "Employee ID";
            // 
            // FormDeleteEm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.labelEmployeeID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonPonche);
            this.Location = new System.Drawing.Point(400, 200);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormDeleteEm";
            this.Text = "FormDeleteEm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button ButtonPonche;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label labelEmployeeID;
    }
}