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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        public class ConexionBD
        {
            private static string cadena = "Data Source=clinica.db;Version=3;";

            public static SQLiteConnection Conectar()
            {
                SQLiteConnection conexion = new SQLiteConnection(cadena);
                conexion.Open();
                return conexion;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=clinica.db"))
            {
                conn.Open();

                // Paso 1: Verificar usuario y obtener su ID
                string querySesion = "SELECT idUsuario FROM Sesion WHERE nombreUsuario = @usuario AND contraUsuario = @contra";
                using (SQLiteCommand cmdSesion = new SQLiteCommand(querySesion, conn))
                {
                    cmdSesion.Parameters.AddWithValue("@usuario", usuario);
                    cmdSesion.Parameters.AddWithValue("@contra", contraseña);

                    object result = cmdSesion.ExecuteScalar();

                    if (result != null)
                    {
                        int idUsuario = Convert.ToInt32(result);

                        // Paso 2: Obtener rol desde la tabla usuarios
                        string queryRol = "SELECT rolUsuario FROM Usuarios WHERE id = @idUsuario";
                        using (SQLiteCommand cmdRol = new SQLiteCommand(queryRol, conn))
                        {
                            cmdRol.Parameters.AddWithValue("@idUsuario", idUsuario);
                            object rolObj = cmdRol.ExecuteScalar();

                            if (rolObj != null)
                            {
                                int rol = Convert.ToInt32(rolObj); // 1 = admin, 2 = medico, 3 = paciente

                                // Abrir el MainForm pasando el rol
                                MainForm main = new MainForm(rol, idUsuario);
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo encontrar el rol del usuario.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

