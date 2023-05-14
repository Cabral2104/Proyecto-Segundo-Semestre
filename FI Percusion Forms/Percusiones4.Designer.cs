namespace Proyecto_Segundo_Semestre
{
    partial class Percusiones4
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
            this.btnCerrarPercusiones4 = new System.Windows.Forms.Button();
            this.nudTrianguloXO = new System.Windows.Forms.NumericUpDown();
            this.lblTrianguloXO = new System.Windows.Forms.Label();
            this.nudTrianguloCharls = new System.Windows.Forms.NumericUpDown();
            this.lblTrianguloCharls = new System.Windows.Forms.Label();
            this.lblGuitarrasElectricas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrianguloXO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrianguloCharls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarPercusiones4
            // 
            this.btnCerrarPercusiones4.Location = new System.Drawing.Point(649, 12);
            this.btnCerrarPercusiones4.Name = "btnCerrarPercusiones4";
            this.btnCerrarPercusiones4.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarPercusiones4.TabIndex = 0;
            this.btnCerrarPercusiones4.Text = "X";
            this.btnCerrarPercusiones4.UseVisualStyleBackColor = true;
            this.btnCerrarPercusiones4.Click += new System.EventHandler(this.btnCerrarPercusiones4_Click);
            // 
            // nudTrianguloXO
            // 
            this.nudTrianguloXO.Location = new System.Drawing.Point(432, 346);
            this.nudTrianguloXO.Name = "nudTrianguloXO";
            this.nudTrianguloXO.Size = new System.Drawing.Size(156, 20);
            this.nudTrianguloXO.TabIndex = 19;
            // 
            // lblTrianguloXO
            // 
            this.lblTrianguloXO.AutoSize = true;
            this.lblTrianguloXO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrianguloXO.Location = new System.Drawing.Point(462, 323);
            this.lblTrianguloXO.Name = "lblTrianguloXO";
            this.lblTrianguloXO.Size = new System.Drawing.Size(101, 20);
            this.lblTrianguloXO.TabIndex = 18;
            this.lblTrianguloXO.Text = "Triangulo XO";
            // 
            // nudTrianguloCharls
            // 
            this.nudTrianguloCharls.Location = new System.Drawing.Point(115, 346);
            this.nudTrianguloCharls.Name = "nudTrianguloCharls";
            this.nudTrianguloCharls.Size = new System.Drawing.Size(156, 20);
            this.nudTrianguloCharls.TabIndex = 16;
            // 
            // lblTrianguloCharls
            // 
            this.lblTrianguloCharls.AutoSize = true;
            this.lblTrianguloCharls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrianguloCharls.Location = new System.Drawing.Point(130, 323);
            this.lblTrianguloCharls.Name = "lblTrianguloCharls";
            this.lblTrianguloCharls.Size = new System.Drawing.Size(123, 20);
            this.lblTrianguloCharls.TabIndex = 15;
            this.lblTrianguloCharls.Text = "Triangulo Charls";
            this.lblTrianguloCharls.Click += new System.EventHandler(this.lblTimbalAdams32_Click);
            // 
            // lblGuitarrasElectricas
            // 
            this.lblGuitarrasElectricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuitarrasElectricas.Location = new System.Drawing.Point(293, 41);
            this.lblGuitarrasElectricas.Name = "lblGuitarrasElectricas";
            this.lblGuitarrasElectricas.Size = new System.Drawing.Size(162, 35);
            this.lblGuitarrasElectricas.TabIndex = 13;
            this.lblGuitarrasElectricas.Text = "Triangulos";
            this.lblGuitarrasElectricas.Click += new System.EventHandler(this.lblGuitarrasElectricas_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Segundo_Semestre.Properties.Resources.Triangulo_XO;
            this.pictureBox3.Location = new System.Drawing.Point(432, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 136);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Segundo_Semestre.Properties.Resources.Triangulo_Charls;
            this.pictureBox1.Location = new System.Drawing.Point(115, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 158);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Percusiones4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 749);
            this.Controls.Add(this.nudTrianguloXO);
            this.Controls.Add(this.lblTrianguloXO);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.nudTrianguloCharls);
            this.Controls.Add(this.lblTrianguloCharls);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGuitarrasElectricas);
            this.Controls.Add(this.btnCerrarPercusiones4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(440, 30);
            this.Name = "Percusiones4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Percusiones4";
            ((System.ComponentModel.ISupportInitialize)(this.nudTrianguloXO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrianguloCharls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarPercusiones4;
        private System.Windows.Forms.NumericUpDown nudTrianguloXO;
        private System.Windows.Forms.Label lblTrianguloXO;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown nudTrianguloCharls;
        private System.Windows.Forms.Label lblTrianguloCharls;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGuitarrasElectricas;
    }
}