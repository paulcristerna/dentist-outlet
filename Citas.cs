using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoConsultorioDental
{
    class Citas
    {
        //atributos
        public string nombrepaciente;
        public string apellidopaciente;
        public string fecha;

        //propiedades
        public string NombrePaciente
        {
            get
            {
                return nombrepaciente;
            }
            set
            {
                nombrepaciente = value;
            }
        }

        public string ApellidoPaciente
        {
            get
            {
                return apellidopaciente;
            }
            set
            {
                apellidopaciente = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        //constructores
        public Citas()
        {
            NombrePaciente = string.Empty;
            Fecha = string.Empty;
        }

        public Citas(string nombrePaciente, string fecha)
        {
            NombrePaciente = nombrePaciente;
            Fecha = fecha;
        }

        //metodos
        public void Guardar()
        {
            string SQL = "insert into Citas (NombrePaciente, Fecha) VALUES ('"
                + NombrePaciente + "', '"
                + Fecha + "');";
            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros de citas.");
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void Actualizar()
        {
            string SQL = "UPDATE Citas SET NombrePaciente = '"
           + NombrePaciente + "', Fecha = '"
           + Fecha + "' WHERE NombrePaciente = '"+ NombrePaciente +"';";

            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros de citas.");
                }
            }
            catch (Exception error)
            {
                throw error;
            }

        }

        public void Eliminar()
        {
            string SQL = "DELETE FROM Citas WHERE NombrePaciente = '" + NombrePaciente + "';";

            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros de citas");
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void Consultar(System.Data.DataTable dt)
        {
            string SQL = "SELECT * FROM Citas;";
            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                bd.EjecutaConsulta(SQL, dt);
            }
            catch (Exception error)
            {
                throw error;
            }

        }        
    }
}
