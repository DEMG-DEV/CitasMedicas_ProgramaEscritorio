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
    public partial class Autor : Form
    {
        private string getAutores()
        {
            return "Autor:\nDavid Enrique Mendez Guardado\nProfesor:\nAntonio Mata Maravilla";
        }
        public Autor()
        {
            InitializeComponent();
            label1.Text = getAutores();
        }
    }
}
