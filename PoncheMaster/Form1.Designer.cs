using System.Drawing;

namespace PoncheMaster
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.pictureBoxUserPic = new System.Windows.Forms.PictureBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBoxNameIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxPasswordIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUserName.Location = new System.Drawing.Point(184, 151);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(152, 26);
            this.textBoxUserName.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelName.Location = new System.Drawing.Point(100, 151);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(51, 20);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name";
            // 
            // pictureBoxUserPic
            // 
            this.pictureBoxUserPic.Location = new System.Drawing.Point(184, 42);
            this.pictureBoxUserPic.Name = "pictureBoxUserPic";
            this.pictureBoxUserPic.Size = new System.Drawing.Size(115, 77);
            this.pictureBoxUserPic.TabIndex = 2;
            this.pictureBoxUserPic.TabStop = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonLogin.Location = new System.Drawing.Point(184, 284);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(115, 29);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Log-In";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUserPassword.Location = new System.Drawing.Point(184, 197);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(152, 26);
            this.textBoxUserPassword.TabIndex = 0;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPassword.Location = new System.Drawing.Point(100, 197);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // pictureBoxNameIcon
            // 
            this.pictureBoxNameIcon.Location = new System.Drawing.Point(68, 151);
            this.pictureBoxNameIcon.Name = "pictureBoxNameIcon";
            this.pictureBoxNameIcon.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxNameIcon.TabIndex = 2;
            this.pictureBoxNameIcon.TabStop = false;
            // 
            // pictureBoxPasswordIcon
            // 
            this.pictureBoxPasswordIcon.Location = new System.Drawing.Point(68, 197);
            this.pictureBoxPasswordIcon.Name = "pictureBoxPasswordIcon";
            this.pictureBoxPasswordIcon.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxPasswordIcon.TabIndex = 2;
            this.pictureBoxPasswordIcon.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.pictureBoxPasswordIcon);
            this.Controls.Add(this.pictureBoxNameIcon);
            this.Controls.Add(this.pictureBoxUserPic);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.textBoxUserName);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormLogin";
            this.Text = "Log-in";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox pictureBoxUserPic;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBoxNameIcon;
        private System.Windows.Forms.PictureBox pictureBoxPasswordIcon;
    }
}

