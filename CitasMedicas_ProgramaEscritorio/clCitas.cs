using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas_ProgramaEscritorio
{
    class clCitas
    {
        dsCitasTableAdapters.citasTableAdapter taCitas = new dsCitasTableAdapters.citasTableAdapter();

        private long idCita;
        private long idPaciente;
        private string fechaCita;
        private string horaCita;
        private string consultorioCita;
        private string hospitalCita;

        public long IdCita
        {
            get
            {
                return idCita;
            }

            set
            {
                idCita = value;
            }
        }

        public long IdPaciente
        {
            get
            {
                return idPaciente;
            }

            set
            {
                idPaciente = value;
            }
        }

        public string FechaCita
        {
            get
            {
                return fechaCita;
            }

            set
            {
                fechaCita = value;
            }
        }

        public string HoraCita
        {
            get
            {
                return horaCita;
            }

            set
            {
                horaCita = value;
            }
        }

        public string ConsultorioCita
        {
            get
            {
                return consultorioCita;
            }

            set
            {
                consultorioCita = value;
            }
        }

        public string HospitalCita
        {
            get
            {
                return hospitalCita;
            }

            set
            {
                hospitalCita = value;
            }
        }

        public void altaCita()
        {
            taCitas.Insert((int)idPaciente, fechaCita, horaCita, consultorioCita, hospitalCita);
        }

        public void bajaCita()
        {
            taCitas.Delete((int)idCita);
        }

        public void actualizarCita()
        {
            taCitas.Update((int)idPaciente, fechaCita, horaCita, consultorioCita, hospitalCita, (int)idCita);
        }

        public void vaciarRegistro(System.Data.DataRow registro)
        {
            idCita = Convert.ToInt64(registro["idCita"].ToString());
            idPaciente = Convert.ToInt64(registro["idPaciente"].ToString());
            fechaCita = registro["fechaCita"].ToString();
            horaCita = registro["horaCita"].ToString();
            consultorioCita = registro["consultorioCita"].ToString();
            hospitalCita = registro["hospitalCita"].ToString();
        }
    }
}
