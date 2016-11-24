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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Paciente pa = new Paciente();
            pa.MdiParent = this;
            pa.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor a = new Autor();
            a.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AllCitas allc = new AllCitas();
            allc.MdiParent = this;
            allc.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            EditarCita ec = new EditarCita();
            ec.MdiParent = this;
            ec.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BajaCita bc = new BajaCita();
            bc.MdiParent = this;
            bc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AltaCita ac = new AltaCita();
            ac.MdiParent = this;
            ac.Show();
        }
    }
}
