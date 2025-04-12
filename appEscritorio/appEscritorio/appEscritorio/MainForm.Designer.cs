namespace appEscritorio
{
    partial class MainForm
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnVerCitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(13, 33);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(75, 16);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(16, 71);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(153, 28);
            this.btnCrearUsuario.TabIndex = 2;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(16, 107);
            this.btnAgendarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(153, 28);
            this.btnAgendarCita.TabIndex = 3;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnVerCitas
            // 
            this.btnVerCitas.Location = new System.Drawing.Point(16, 143);
            this.btnVerCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Size = new System.Drawing.Size(153, 28);
            this.btnVerCitas.TabIndex = 4;
            this.btnVerCitas.Text = "Ver Mis Citas";
            this.btnVerCitas.UseVisualStyleBackColor = true;
            this.btnVerCitas.Click += new System.EventHandler(this.btnVerCitas_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 187);
            this.Controls.Add(this.btnVerCitas);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.lblBienvenido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnVerCitas;
    }
}