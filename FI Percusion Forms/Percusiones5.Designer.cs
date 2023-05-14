namespace Proyecto_Segundo_Semestre
{
    partial class Percusiones5
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
            this.btnCerrarPercusiones5 = new System.Windows.Forms.Button();
            this.nudBomboAudiotek = new System.Windows.Forms.NumericUpDown();
            this.lblBomboAudiotek = new System.Windows.Forms.Label();
            this.lblGuitarrasElectricas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBomboAudiotek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarPercusiones5
            // 
            this.btnCerrarPercusiones5.Location = new System.Drawing.Point(649, 12);
            this.btnCerrarPercusiones5.Name = "btnCerrarPercusiones5";
            this.btnCerrarPercusiones5.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarPercusiones5.TabIndex = 0;
            this.btnCerrarPercusiones5.Text = "X";
            this.btnCerrarPercusiones5.UseVisualStyleBackColor = true;
            this.btnCerrarPercusiones5.Click += new System.EventHandler(this.btnCerrarPercusiones5_Click);
            // 
            // nudBomboAudiotek
            // 
            this.nudBomboAudiotek.Location = new System.Drawing.Point(271, 307);
            this.nudBomboAudiotek.Name = "nudBomboAudiotek";
            this.nudBomboAudiotek.Size = new System.Drawing.Size(156, 20);
            this.nudBomboAudiotek.TabIndex = 23;
            // 
            // lblBomboAudiotek
            // 
            this.lblBomboAudiotek.AutoSize = true;
            this.lblBomboAudiotek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomboAudiotek.Location = new System.Drawing.Point(285, 284);
            this.lblBomboAudiotek.Name = "lblBomboAudiotek";
            this.lblBomboAudiotek.Size = new System.Drawing.Size(127, 20);
            this.lblBomboAudiotek.TabIndex = 22;
            this.lblBomboAudiotek.Text = "Bombo Audiotek";
            // 
            // lblGuitarrasElectricas
            // 
            this.lblGuitarrasElectricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuitarrasElectricas.Location = new System.Drawing.Point(290, 12);
            this.lblGuitarrasElectricas.Name = "lblGuitarrasElectricas";
            this.lblGuitarrasElectricas.Size = new System.Drawing.Size(137, 35);
            this.lblGuitarrasElectricas.TabIndex = 20;
            this.lblGuitarrasElectricas.Text = "Bombo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Segundo_Semestre.Properties.Resources.Bombo_Audiotek;
            this.pictureBox3.Location = new System.Drawing.Point(271, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 175);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // Percusiones5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 749);
            this.Controls.Add(this.nudBomboAudiotek);
            this.Controls.Add(this.lblBomboAudiotek);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblGuitarrasElectricas);
            this.Controls.Add(this.btnCerrarPercusiones5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(440, 30);
            this.Name = "Percusiones5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Percusiones5";
            ((System.ComponentModel.ISupportInitialize)(this.nudBomboAudiotek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarPercusiones5;
        private System.Windows.Forms.NumericUpDown nudBomboAudiotek;
        private System.Windows.Forms.Label lblBomboAudiotek;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblGuitarrasElectricas;
    }
}