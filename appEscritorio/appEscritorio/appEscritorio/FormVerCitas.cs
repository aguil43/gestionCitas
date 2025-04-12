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
    public partial class FormVerCitas : Form
    {
        private int idPaciente;

        public FormVerCitas(int id)
        {
            InitializeComponent();
            idPaciente = id;
        }

        private void FormVerCitas_Load(object sender, EventArgs e)
        {
            CargarCitas();
        }
        private void CargarCitas()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=clinica.db"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Citas WHERE idPaciente = @idPaciente";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable tabla = new DataTable();
                            adapter.Fill(tabla);
                            dgvCitas.DataSource = tabla;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
            }
     