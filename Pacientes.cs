using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace ProyectoConsultorioDental
{
    public class Pacientes
    {
        //atributos
        private string nombrepaciente;
        private string apellido;
        private string fechanacimiento;
        private string sexo;
        private string domicilio;
        private string telefono;

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

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return fechanacimiento;
            }
            set
            {
                fechanacimiento = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return domicilio;
            }
            set
            {
                domicilio = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        //constructores
        public Pacientes()
        {
            NombrePaciente = string.Empty;
            Apellido = string.Empty;
        }

        public Pacientes(string nombrePaciente, string apellido, string fechanacimiento, string sexo, string domicilio, string telefono)
        {
            NombrePaciente = nombrePaciente;
            Apellido = apellido;
            FechaNacimiento = fechanacimiento;
            Sexo = sexo;
            Domicilio = domicilio;
            Telefono = telefono;
        }
 
        //metodos
        public void Guardar()
        {
            string SQL = "insert into Pacientes (Nombre, Apellido, FechaNacimiento, Sexo, Domicilio, Telefono) VALUES ('" 
                        + NombrePaciente + "', '"
                        + Apellido + "', '"
                        + FechaNacimiento + "', '"
                        + Sexo + "', '"
                        + Domicilio + "', '"
                        + Telefono + "');";

            AccesoBaseDatos bd = new AccesoBaseDatos();

            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros de pacientes.");
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void Actualizar()
        {
            string SQL = "UPDATE Pacientes SET Nombre = '"
           + NombrePaciente + "', Apellido = '"
           + Apellido + "', FechaNacimiento = '"
           + FechaNacimiento + "', Sexo = '"
           + Sexo + "', Domicilio = '"
           + Domicilio + "', Telefono = '"
           + Telefono
           + "' WHERE Nombre = '" + NombrePaciente + "' AND Apellido = '"+ Apellido +"';";

            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros de pacientes.");
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void Eliminar()
        {
            string SQL = "DELETE FROM Pacientes WHERE Nombre = '" + NombrePaciente + "' AND Apellido = '"+ Apellido +"';";

            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros de pacientes.");
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        } 

        public void Consultar(System.Data.DataTable dt)
        {
            string SQL = "SELECT * FROM Pacientes ORDER BY IdPaciente ASC;";
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
