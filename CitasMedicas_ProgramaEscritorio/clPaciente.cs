using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas_ProgramaEscritorio
{
    class clPaciente
    {
        dsPacienteTableAdapters.pacienteTableAdapter taPaciente = new dsPacienteTableAdapters.pacienteTableAdapter();

        private long idPaciente;
        private string nombrePaciente;
        private string apePaternoPaciente;
        private string apeMaternoPaciente;
        private string fechaNacPaciente;
        private string domicilioPaciente;
        private string telefonoPaciente;
        private string emailPaciente;
        private double estaturaPaciente;
        private double pesoPaciente;
        private string padCronPaciente;
        private string alergiasPaciente;
        private string otraInfoPaciente;

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

        public string NombrePaciente
        {
            get
            {
                return nombrePaciente;
            }

            set
            {
                nombrePaciente = value;
            }
        }

        public string ApePaternoPaciente
        {
            get
            {
                return apePaternoPaciente;
            }

            set
            {
                apePaternoPaciente = value;
            }
        }

        public string ApeMaternoPaciente
        {
            get
            {
                return apeMaternoPaciente;
            }

            set
            {
                apeMaternoPaciente = value;
            }
        }

        public string FechaNacPaciente
        {
            get
            {
                return fechaNacPaciente;
            }

            set
            {
                fechaNacPaciente = value;
            }
        }

        public string DomicilioPaciente
        {
            get
            {
                return domicilioPaciente;
            }

            set
            {
                domicilioPaciente = value;
            }
        }

        public string TelefonoPaciente
        {
            get
            {
                return telefonoPaciente;
            }

            set
            {
                telefonoPaciente = value;
            }
        }

        public string EmailPaciente
        {
            get
            {
                return emailPaciente;
            }

            set
            {
                emailPaciente = value;
            }
        }

        public double EstaturaPaciente
        {
            get
            {
                return estaturaPaciente;
            }

            set
            {
                estaturaPaciente = value;
            }
        }

        public double PesoPaciente
        {
            get
            {
                return pesoPaciente;
            }

            set
            {
                pesoPaciente = value;
            }
        }

        public string PadCronPaciente
        {
            get
            {
                return padCronPaciente;
            }

            set
            {
                padCronPaciente = value;
            }
        }

        public string AlergiasPaciente
        {
            get
            {
                return alergiasPaciente;
            }

            set
            {
                alergiasPaciente = value;
            }
        }

        public string OtraInfoPaciente
        {
            get
            {
                return otraInfoPaciente;
            }

            set
            {
                otraInfoPaciente = value;
            }
        }

        public void insertarPaciente()
        {
            taPaciente.Insert(nombrePaciente, apePaternoPaciente, apeMaternoPaciente, fechaNacPaciente, domicilioPaciente,
                telefonoPaciente, emailPaciente, estaturaPaciente, pesoPaciente, padCronPaciente, alergiasPaciente,
                otraInfoPaciente);
        }

        public void borrarPaciente()
        {
            taPaciente.Delete((int)this.idPaciente);
        }

        public void actualizarPaciente(System.Data.DataRow registro)
        {
            taPaciente.Update(registro);
        }

        public void vaciarRegistro(System.Data.DataRow registro)
        {
            idPaciente = Convert.ToInt64(registro["idPaciente"].ToString());
            nombrePaciente = registro["nombrePaciente"].ToString();
            apePaternoPaciente = registro["apePaternoPaciente"].ToString();
            apeMaternoPaciente = registro["apeMaternoPaciente"].ToString();
            fechaNacPaciente = registro["fechaNacPaciente"].ToString();
            domicilioPaciente = registro["domicilioPaciente"].ToString();
            telefonoPaciente = registro["telefonoPaciente"].ToString();
            emailPaciente = registro["emailPaciente"].ToString();
            estaturaPaciente = Convert.ToDouble(registro["estaturaPaciente"].ToString());
            pesoPaciente = Convert.ToDouble(registro["pesoPaciente"].ToString());
            padCronPaciente = registro["padCronPaciente"].ToString();
            alergiasPaciente = registro["alergiasPaciente"].ToString();
            otraInfoPaciente = registro["otraInfoPaciente"].ToString();
        }
    }
}
