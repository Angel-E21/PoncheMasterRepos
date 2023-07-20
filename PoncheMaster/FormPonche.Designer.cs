namespace PoncheMaster
{
    partial class FormPonche
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
            this.ButtonPonche = new System.Windows.Forms.Button();
            this.pictureBoxCedula = new System.Windows.Forms.PictureBox();
            this.LabelCedula = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCedula)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPonche
            // 
            this.ButtonPonche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonPonche.Location = new System.Drawing.Point(58, 120);
            this.ButtonPonche.Name = "ButtonPonche";
            this.ButtonPonche.Size = new System.Drawing.Size(115, 29);
            this.ButtonPonche.TabIndex = 7;
            this.ButtonPonche.Text = "Ponchar";
            this.ButtonPonche.UseVisualStyleBackColor = true;
            this.ButtonPonche.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // pictureBoxCedula
            // 
            this.pictureBoxCedula.Location = new System.Drawing.Point(58, 74);
            this.pictureBoxCedula.MaximumSize = new System.Drawing.Size(26, 20);
            this.pictureBoxCedula.MinimumSize = new System.Drawing.Size(26, 20);
            this.pictureBoxCedula.Name = "pictureBoxCedula";
            this.pictureBoxCedula.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxCedula.TabIndex = 6;
            this.pictureBoxCedula.TabStop = false;
            // 
            // LabelCedula
            // 
            this.LabelCedula.AutoSize = true;
            this.LabelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelCedula.Location = new System.Drawing.Point(90, 74);
            this.LabelCedula.Name = "LabelCedula";
            this.LabelCedula.Size = new System.Drawing.Size(59, 20);
            this.LabelCedula.TabIndex = 5;
            this.LabelCedula.Text = "Cedula";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCedula.Location = new System.Drawing.Point(174, 74);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(152, 26);
            this.textBoxCedula.TabIndex = 4;
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNombreEmpleado.Location = new System.Drawing.Point(152, 29);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(51, 20);
            this.labelNombreEmpleado.TabIndex = 5;
            this.labelNombreEmpleado.Text = "Name";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(188, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 29);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // FormPonche
            // 
            this.AcceptButton = this.ButtonPonche;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonPonche);
            this.Controls.Add(this.pictureBoxCedula);
            this.Controls.Add(this.labelNombreEmpleado);
            this.Controls.Add(this.LabelCedula);
            this.Controls.Add(this.textBoxCedula);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormPonche";
            this.Text = "FormPonche";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCedula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPonche;
        private System.Windows.Forms.PictureBox pictureBoxCedula;
        private System.Windows.Forms.Label LabelCedula;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label labelNombreEmpleado;
        private System.Windows.Forms.Button buttonCancel;
    }
}