namespace Proyecto_Segundo_Semestre
{
    partial class Iniciar_Sesión
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
            this.lblCorreoIS = new System.Windows.Forms.Label();
            this.txbCorreoIS = new System.Windows.Forms.TextBox();
            this.lblContraseñaIS = new System.Windows.Forms.Label();
            this.txbContraseñaIS = new System.Windows.Forms.TextBox();
            this.lblIS = new System.Windows.Forms.Label();
            this.lblMensajeIS = new System.Windows.Forms.Label();
            this.btnConfirmarIS = new System.Windows.Forms.Button();
            this.btnCerrarIS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCorreoIS
            // 
            this.lblCorreoIS.AutoSize = true;
            this.lblCorreoIS.Location = new System.Drawing.Point(204, 82);
            this.lblCorreoIS.Name = "lblCorreoIS";
            this.lblCorreoIS.Size = new System.Drawing.Size(94, 13);
            this.lblCorreoIS.TabIndex = 0;
            this.lblCorreoIS.Text = "Correo Eléctronico";
            // 
            // txbCorreoIS
            // 
            this.txbCorreoIS.Location = new System.Drawing.Point(304, 79);
            this.txbCorreoIS.Name = "txbCorreoIS";
            this.txbCorreoIS.Size = new System.Drawing.Size(100, 20);
            this.txbCorreoIS.TabIndex = 1;
            // 
            // lblContraseñaIS
            // 
            this.lblContraseñaIS.AutoSize = true;
            this.lblContraseñaIS.Location = new System.Drawing.Point(233, 140);
            this.lblContraseñaIS.Name = "lblContraseñaIS";
            this.lblContraseñaIS.Size = new System.Drawing.Size(61, 13);
            this.lblContraseñaIS.TabIndex = 2;
            this.lblContraseñaIS.Text = "Contraseña";
            // 
            // txbContraseñaIS
            // 
            this.txbContraseñaIS.Location = new System.Drawing.Point(304, 140);
            this.txbContraseñaIS.Name = "txbContraseñaIS";
            this.txbContraseñaIS.Size = new System.Drawing.Size(100, 20);
            this.txbContraseñaIS.TabIndex = 3;
            // 
            // lblIS
            // 
            this.lblIS.AutoSize = true;
            this.lblIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIS.Location = new System.Drawing.Point(229, 9);
            this.lblIS.Name = "lblIS";
            this.lblIS.Size = new System.Drawing.Size(261, 37);
            this.lblIS.TabIndex = 4;
            this.lblIS.Text = "INICIAR SESIÓN";
            // 
            // lblMensajeIS
            // 
            this.lblMensajeIS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensajeIS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMensajeIS.Location = new System.Drawing.Point(204, 189);
            this.lblMensajeIS.Name = "lblMensajeIS";
            this.lblMensajeIS.Size = new System.Drawing.Size(200, 49);
            this.lblMensajeIS.TabIndex = 17;
            // 
            // btnConfirmarIS
            // 
            this.btnConfirmarIS.Location = new System.Drawing.Point(450, 204);
            this.btnConfirmarIS.Name = "btnConfirmarIS";
            this.btnConfirmarIS.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarIS.TabIndex = 16;
            this.btnConfirmarIS.Text = "Confirmar";
            this.btnConfirmarIS.UseVisualStyleBackColor = true;
            this.btnConfirmarIS.Click += new System.EventHandler(this.btnConfirmarIS_Click);
            // 
            // btnCerrarIS
            // 
            this.btnCerrarIS.Location = new System.Drawing.Point(649, 12);
            this.btnCerrarIS.Name = "btnCerrarIS";
            this.btnCerrarIS.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarIS.TabIndex = 18;
            this.btnCerrarIS.Text = "X";
            this.btnCerrarIS.UseVisualStyleBackColor = true;
            this.btnCerrarIS.Click += new System.EventHandler(this.btnCerrarIS_Click);
            // 
            // Iniciar_Sesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 749);
            this.Controls.Add(this.btnCerrarIS);
            this.Controls.Add(this.lblMensajeIS);
            this.Controls.Add(this.btnConfirmarIS);
            this.Controls.Add(this.lblIS);
            this.Controls.Add(this.txbContraseñaIS);
            this.Controls.Add(this.lblContraseñaIS);
            this.Controls.Add(this.txbCorreoIS);
            this.Controls.Add(this.lblCorreoIS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(440, 30);
            this.Name = "Iniciar_Sesión";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Iniciar_Sesión";
            this.Load += new System.EventHandler(this.Iniciar_Sesión_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreoIS;
        private System.Windows.Forms.TextBox txbCorreoIS;
        private System.Windows.Forms.Label lblContraseñaIS;
        private System.Windows.Forms.TextBox txbContraseñaIS;
        private System.Windows.Forms.Label lblIS;
        private System.Windows.Forms.Label lblMensajeIS;
        private System.Windows.Forms.Button btnConfirmarIS;
        private System.Windows.Forms.Button btnCerrarIS;
    }
}