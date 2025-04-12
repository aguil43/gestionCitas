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
    public partial class FormAgendarCita : Form
    {
        private int idUsuario;
        public FormAgendarCita(int idMedicoLogueado)
        {
            InitializeComponent();
            idUsuario = idMedicoLogueado;
        }


        private void FormAgendarCita_Load(object sender, EventArgs e)
        {
            using (var conn = Form1.ConexionBD.Conectar())
            {
                string query = "SELECT id, nombreUsuario || ' ' || apellidoUsuario AS nombre FROM Usuarios WHERE rolUsuario = 3";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    cbPaciente.DataSource = dt;
                    cbPaciente.DisplayMember = "nombre";
                    cbPaciente.ValueMember = "id";
                }
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            int idPaciente = Convert.ToInt32(cbPaciente.SelectedValue);
            int idMedico = idUsuario;
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd HH:mm:ss");

            using (var conn = Form1.ConexionBD.Conectar())
            {
                string insert = "INSERT INTO Citas (idPaciente, idMedico, fechaCita) VALUES (@paciente, @medico, @fecha)";
                using (var cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@paciente", idPaciente);
                    cmd.Parameters.AddWithValue("@medico", idMedico);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cita agendada con éxito.");
            }
        }

    }
}
