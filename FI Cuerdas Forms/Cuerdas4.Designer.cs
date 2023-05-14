namespace Proyecto_Segundo_Semestre
{
    partial class Cuerdas4
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
            this.btnCerrarCuerdas4 = new System.Windows.Forms.Button();
            this.lblArpas = new System.Windows.Forms.Label();
            this.lblArpaSelvi = new System.Windows.Forms.Label();
            this.nudArpaSelvi = new System.Windows.Forms.NumericUpDown();
            this.lblArpaSelta = new System.Windows.Forms.Label();
            this.nudArpaSelta = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudArpaSelvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArpaSelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarCuerdas4
            // 
            this.btnCerrarCuerdas4.Location = new System.Drawing.Point(649, 12);
            this.btnCerrarCuerdas4.Name = "btnCerrarCuerdas4";
            this.btnCerrarCuerdas4.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarCuerdas4.TabIndex = 1;
            this.btnCerrarCuerdas4.Text = "X";
            this.btnCerrarCuerdas4.UseVisualStyleBackColor = true;
            this.btnCerrarCuerdas4.Click += new System.EventHandler(this.btnCerrarCuerdas4_Click);
            // 
            // lblArpas
            // 
            this.lblArpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArpas.Location = new System.Drawing.Point(303, 12);
            this.lblArpas.Name = "lblArpas";
            this.lblArpas.Size = new System.Drawing.Size(108, 42);
            this.lblArpas.TabIndex = 4;
            this.lblArpas.Text = "Arpas";
            // 
            // lblArpaSelvi
            // 
            this.lblArpaSelvi.AutoSize = true;
            this.lblArpaSelvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArpaSelvi.Location = new System.Drawing.Point(144, 362);
            this.lblArpaSelvi.Name = "lblArpaSelvi";
            this.lblArpaSelvi.Size = new System.Drawing.Size(80, 20);
            this.lblArpaSelvi.TabIndex = 6;
            this.lblArpaSelvi.Text = "Arpa Selvi";
            // 
            // nudArpaSelvi
            // 
            this.nudArpaSelvi.Location = new System.Drawing.Point(114, 385);
            this.nudArpaSelvi.Name = "nudArpaSelvi";
            this.nudArpaSelvi.Size = new System.Drawing.Size(156, 20);
            this.nudArpaSelvi.TabIndex = 7;
            // 
            // lblArpaSelta
            // 
            this.lblArpaSelta.AutoSize = true;
            this.lblArpaSelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArpaSelta.Location = new System.Drawing.Point(471, 362);
            this.lblArpaSelta.Name = "lblArpaSelta";
            this.lblArpaSelta.Size = new System.Drawing.Size(84, 20);
            this.lblArpaSelta.TabIndex = 9;
            this.lblArpaSelta.Text = "Arpa Selta";
            // 
            // nudArpaSelta
            // 
            this.nudArpaSelta.Location = new System.Drawing.Point(434, 385);
            this.nudArpaSelta.Name = "nudArpaSelta";
            this.nudArpaSelta.Size = new System.Drawing.Size(156, 20);
            this.nudArpaSelta.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Segundo_Semestre.Properties.Resources.Arpa_Selta;
            this.pictureBox2.Location = new System.Drawing.Point(434, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 288);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Segundo_Semestre.Properties.Resources.Arpa_Salvi;
            this.pictureBox1.Location = new System.Drawing.Point(114, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 288);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Cuerdas4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 749);
            this.Controls.Add(this.nudArpaSelta);
            this.Controls.Add(this.lblArpaSelta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nudArpaSelvi);
            this.Controls.Add(this.lblArpaSelvi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblArpas);
            this.Controls.Add(this.btnCerrarCuerdas4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(440, 30);
            this.Name = "Cuerdas4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cuerdas4";
            this.Load += new System.EventHandler(this.Cuerdas4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudArpaSelvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArpaSelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarCuerdas4;
        private System.Windows.Forms.Label lblArpas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblArpaSelvi;
        private System.Windows.Forms.NumericUpDown nudArpaSelvi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblArpaSelta;
        private System.Windows.Forms.NumericUpDown nudArpaSelta;
    }
}