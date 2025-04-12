namespace appEscritorio
{
    partial class FormAgendarCita
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
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPaciente
            // 
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(12, 12);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(244, 24);
            this.cbPaciente.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 42);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(244, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(12, 87);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(81, 29);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Menú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbPaciente);
            this.Name = "FormAgendarCita";
            this.Text = "AgendarCita";
            this.Load += new System.EventHandler(this.FormAgendarCita_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button button1;
    }
}