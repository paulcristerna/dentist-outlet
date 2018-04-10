using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoConsultorioDental
{
    class Expedientes
    {
        //metodos
        public void Consultar(System.Data.DataTable dt)
        {
            string SQL = "SELECT * FROM Cobros, Pacientes WHERE Cobros.NombrePaciente = concat(Pacientes.Nombre , ' ' , Pacientes.Apellido);";
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
