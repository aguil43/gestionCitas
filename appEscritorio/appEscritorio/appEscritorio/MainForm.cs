using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    namespace appEscritorio
    {
        public partial class MainForm : Form
        {
        private int idUsuario;
        private int rolUsuario;

        public MainForm(int rol, int id)
        {
            InitializeComponent();
            rolUsuario = rol;
            idUsuario = id;
            AjustarInterfazSegunRol();
        }


        private void AjustarInterfazSegunRol()
            {
                // Muestra los botones según el rol
                btnCrearUsuario.Visible = (rolUsuario == 1); // admin
                btnAgendarCita.Visible = (rolUsuario == 2);  // medico
                btnVerCitas.Visible = (rolUsuario == 3);     // paciente

                if (rolUsuario == 1)
                    lblBienvenido.Text = "Bienvenido Administrador";
                else if (rolUsuario == 2)
                    lblBienvenido.Text = "Bienvenido Médico";
                else if (rolUsuario == 3)
                    lblBienvenido.Text = "Bienvenido Paciente";
                else
                    lblBienvenido.Text = "Bienvenido";

            }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FormCrearUsuario crearUsuario = new FormCrearUsuario();
            crearUsuario.ShowDialog(); // o .Show() si no quieres bloquear
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            FormAgendarCita agendar = new FormAgendarCita(idUsuario);
            agendar.ShowDialog();
        }

        private void btnVerCitas_Click(object sender, EventArgs e)
        {
            FormVerCitas verCitas = new FormVerCitas(idUsuario);
            verCitas.ShowDialog();
        }

    }
}
