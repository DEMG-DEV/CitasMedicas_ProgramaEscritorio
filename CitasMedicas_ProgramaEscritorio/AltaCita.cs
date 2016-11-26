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
    public partial class AltaCita : Form
    {
        public AltaCita()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((clCitas)this.clCitasBindingSource[0]).altaCita();
            this.citasTableAdapter1.Fill(dsCitas1.citas);

            limpiarAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obtenerFolio();
        }

        private void obtenerFolio()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            try
            {
                string Query = "SELECT idPaciente,nombrePaciente,apePaternoPaciente,apeMaternoPaciente FROM paciente WHERE idPaciente=" + textBox1.Text + ";";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                DataTable datos = new DataTable();
                adapter.Fill(datos);

                textBox1.Text = Convert.ToString(datos.Rows[0][0].ToString());
                textBox2.Text = Convert.ToString(datos.Rows[0][1].ToString());
                textBox3.Text = Convert.ToString(datos.Rows[0][2].ToString());
                textBox4.Text = Convert.ToString(datos.Rows[0][3].ToString());

                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";

                conexion.conexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button3.Enabled = false;
                textBox1.ReadOnly = true;

                button1.Enabled = true;
                button2.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void limpiarAll()
        {
            button3.Enabled = true;
            textBox1.ReadOnly = false;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            button1.Enabled = false;
            button2.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarAll();
        }

        private void AltaCita_Load(object sender, EventArgs e)
        {
            this.clCitasBindingSource.Add(new clCitas());
        }
    }
}
