namespace PoncheMaster
{
    partial class FormHelp
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
            this.labelHelp = new System.Windows.Forms.Label();
            this.pictureBoxDesign = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(26, 49);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(362, 80);
            this.labelHelp.TabIndex = 1;
            this.labelHelp.Text = "the Company doesn\'t give empleyees privileges to \r\nchange their own password, ple" +
    "ase contact your \r\nsupervisor, or administratar to proceed the chage\r\n          " +
    "          sorry for the inconvenience\r\n";
            this.labelHelp.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // pictureBoxDesign
            // 
            this.pictureBoxDesign.Image = global::PoncheMaster.Properties.Resources.ball;
            this.pictureBoxDesign.Location = new System.Drawing.Point(292, 75);
            this.pictureBoxDesign.Name = "pictureBoxDesign";
            this.pictureBoxDesign.Size = new System.Drawing.Size(163, 109);
            this.pictureBoxDesign.TabIndex = 0;
            this.pictureBoxDesign.TabStop = false;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 176);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.pictureBoxDesign);
            this.Name = "FormHelp";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDesign;
        private System.Windows.Forms.Label labelHelp;
    }
}