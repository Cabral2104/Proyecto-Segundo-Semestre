namespace Proyecto_Segundo_Semestre
{
    partial class Extras1
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
            this.btnCerrarExtras1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrarExtras1
            // 
            this.btnCerrarExtras1.Location = new System.Drawing.Point(13, 13);
            this.btnCerrarExtras1.Name = "btnCerrarExtras1";
            this.btnCerrarExtras1.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarExtras1.TabIndex = 0;
            this.btnCerrarExtras1.Text = "X";
            this.btnCerrarExtras1.UseVisualStyleBackColor = true;
            this.btnCerrarExtras1.Click += new System.EventHandler(this.btnCerrarExtras1_Click);
            // 
            // Extras1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 749);
            this.Controls.Add(this.btnCerrarExtras1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(440, 30);
            this.Name = "Extras1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Extras1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarExtras1;
    }
}