using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEscritorio
{
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text;
            string apellido = txtApellidoUsuario.Text;
            string rolTexto = cbRol.SelectedItem.ToString();
            string usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            int rol = 0;
            if (rolTexto == "Administrador") rol = 1;
            else if (rolTexto == "Médico") rol = 2;
            else if (rolTexto == "Paciente") rol = 3;

            using (SQLiteConnection conn = Form1.ConexionBD.Conectar())
            {
                // Insertar en Usuarios
                string insertUsuario = "INSERT INTO Usuarios (nombreUsuario, apellidoUsuario, rolUsuario) VALUES (@nombre, @apellido, @rol)";
                using (SQLiteCommand cmd = new SQLiteCommand(insertUsuario, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@rol", rol);
                    cmd.ExecuteNonQuery();
                }

                // Obtener ID recién insertado
                long idUsuario = conn.LastInsertRowId;

                // Insertar en Sesion
                string insertSesion = "INSERT INTO Sesion (idUsuario, nombreUsuario, contraUsuario) VALUES (@id, @usuario, @contra)";
                using (SQLiteCommand cmd = new SQLiteCommand(insertSesion, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contra", contraseña);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario creado correctamente.");
            }
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
