using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMedicas_ProgramaEscritorio
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((clPaciente)this.clPacienteBindingSource[0]).insertarPaciente();
            this.pacienteTableAdapter1.Fill(dsPaciente1.paciente);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            this.clPacienteBindingSource.Add(new clPaciente());
            obtenerFolio();
        }

        private void obtenerFolio()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            try
            {
                string Query = "SELECT MAX(idPaciente) FROM paciente;";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                DataTable datos = new DataTable();
                adapter.Fill(datos);

                textBox1.Text = Convert.ToString((Convert.ToInt32(datos.Rows[0][0].ToString()) + 1));
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
