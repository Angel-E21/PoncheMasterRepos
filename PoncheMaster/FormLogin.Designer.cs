using System.Drawing;
using System.Windows.Forms;

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
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelNotPassWord = new System.Windows.Forms.Label();
            this.pictureBoxPasswordIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxDesign = new System.Windows.Forms.PictureBox();
            this.pictureBoxNameIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPic)).BeginInit();
            this.SuspendLayout();
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
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonLogin.Location = new System.Drawing.Point(184, 276);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(115, 29);
            this.ButtonLogin.TabIndex = 8;
            this.ButtonLogin.Text = "Log-In";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click_1);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPassword.Location = new System.Drawing.Point(100, 189);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUserPassword.Location = new System.Drawing.Point(184, 189);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(152, 26);
            this.textBoxUserPassword.TabIndex = 5;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUserName.Location = new System.Drawing.Point(184, 151);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(152, 26);
            this.textBoxUserName.TabIndex = 9;
            // 
            // labelNotPassWord
            // 
            this.labelNotPassWord.AutoSize = true;
            this.labelNotPassWord.Location = new System.Drawing.Point(244, 218);
            this.labelNotPassWord.Name = "labelNotPassWord";
            this.labelNotPassWord.Size = new System.Drawing.Size(92, 13);
            this.labelNotPassWord.TabIndex = 10;
            this.labelNotPassWord.Text = "Forgot Password?";
            this.labelNotPassWord.Click += new System.EventHandler(this.labelNotPassWord_Click);
            // 
            // pictureBoxPasswordIcon
            // 
            this.pictureBoxPasswordIcon.Location = new System.Drawing.Point(68, 189);
            this.pictureBoxPasswordIcon.Name = "pictureBoxPasswordIcon";
            this.pictureBoxPasswordIcon.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxPasswordIcon.TabIndex = 7;
            this.pictureBoxPasswordIcon.TabStop = false;
            // 
            // pictureBoxDesign
            // 
            this.pictureBoxDesign.Image = global::PoncheMaster.Properties.Resources.ball;
            this.pictureBoxDesign.Location = new System.Drawing.Point(184, 151);
            this.pictureBoxDesign.Name = "pictureBoxDesign";
            this.pictureBoxDesign.Size = new System.Drawing.Size(312, 214);
            this.pictureBoxDesign.TabIndex = 4;
            this.pictureBoxDesign.TabStop = false;
            // 
            // pictureBoxNameIcon
            // 
            this.pictureBoxNameIcon.Location = new System.Drawing.Point(68, 151);
            this.pictureBoxNameIcon.Name = "pictureBoxNameIcon";
            this.pictureBoxNameIcon.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxNameIcon.TabIndex = 2;
            this.pictureBoxNameIcon.TabStop = false;
            // 
            // pictureBoxUserPic
            // 
            this.pictureBoxUserPic.Location = new System.Drawing.Point(184, 42);
            this.pictureBoxUserPic.Name = "pictureBoxUserPic";
            this.pictureBoxUserPic.Size = new System.Drawing.Size(115, 77);
            this.pictureBoxUserPic.TabIndex = 2;
            this.pictureBoxUserPic.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.labelNotPassWord);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.pictureBoxPasswordIcon);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.pictureBoxDesign);
            this.Controls.Add(this.pictureBoxNameIcon);
            this.Controls.Add(this.pictureBoxUserPic);
            this.Controls.Add(this.LabelName);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormLogin";
            this.Text = "Log-in";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox pictureBoxUserPic;
        private System.Windows.Forms.PictureBox pictureBoxNameIcon;
        private System.Windows.Forms.PictureBox pictureBoxDesign;
        private Button ButtonLogin;
        private PictureBox pictureBoxPasswordIcon;
        private Label labelPassword;
        private TextBox textBoxUserPassword;
        private TextBox textBoxUserName;
        private Label labelNotPassWord;
    }
}

