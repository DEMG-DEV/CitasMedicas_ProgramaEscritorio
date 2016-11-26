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
    public partial class BajaCita : Form
    {
        public BajaCita()
        {
            InitializeComponent();
        }

        private void BajaCita_Load(object sender, EventArgs e)
        {
            this.clCitasBindingSource.Add(new clCitas());
            this.citasTableAdapter1.Fill(this.dsCitas1.citas);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                clCitas cita = new clCitas();

                cita.vaciarRegistro(((DataRowView)this.dataGridView1.SelectedRows[0].DataBoundItem).Row);

                this.clCitasBindingSource.Clear();
                this.clCitasBindingSource.Add(cita);
                //DataGridViewRow row = dataGridView1.CurrentRow;            

                //btnAñadir.Enabled = false;
                //btnEditar.Enabled = false;
                //btnEliminar.Enabled = false;

                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((clCitas)this.clCitasBindingSource[0]).bajaCita();
            this.citasTableAdapter1.Fill(this.dsCitas1.citas);

        }
    }
}
