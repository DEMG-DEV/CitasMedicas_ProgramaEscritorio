using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMedicas_ProgramaEscritorio
{
    public partial class AllCitas : Form
    {
        public AllCitas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            cargarAllCitas();
        }

        private void cargarAllCitas()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            try
            {
                string Query = "SELECT citas.idCita,citas.fechaCita,citas.horaCita,citas.consultorioCita,citas.hospitalCita,paciente.nombrePaciente,paciente.apePaternoPaciente,paciente.apeMaternoPaciente FROM citas,paciente WHERE citas.idPaciente=paciente.idPaciente;";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                DataTable datos = new DataTable();
                adapter.Fill(datos);
                dataGridView1.DataSource = datos;
                conexion.conexionClose();

                dataGridView1.Columns[0].HeaderText = "Id Cita";
                dataGridView1.Columns[1].HeaderText = "Fecha";
                dataGridView1.Columns[2].HeaderText = "Hora";
                dataGridView1.Columns[3].HeaderText = "Consultorio";
                dataGridView1.Columns[4].HeaderText = "Hospital";
                dataGridView1.Columns[5].HeaderText = "Nombre";
                dataGridView1.Columns[6].HeaderText = "Apellido Paterno";
                dataGridView1.Columns[7].HeaderText = "Apellido Materno";

                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].Width = 200;
                dataGridView1.Columns[6].Width = 200;
                dataGridView1.Columns[7].Width = 200;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
