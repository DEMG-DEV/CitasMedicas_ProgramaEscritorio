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
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllCitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCitas.citas' table. You can move, or remove it, as needed.
            this.citasTableAdapter.Fill(this.dsCitas.citas);

        }
    }
}
