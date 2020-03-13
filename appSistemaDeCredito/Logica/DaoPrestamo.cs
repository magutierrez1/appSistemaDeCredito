using appSistemaDeCredito.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaDeCredito.Logica
{
    class DaoPrestamo
    {
        private int resultado;
        //creo un objeto de la clase datos para poder acceder a los metodos de la clase
        private datos objDatos = new datos();

        public int registrarPrestamo(Prestamo objPrestamo)
        {
            string consulta = "";

            consulta = "INSERT INTO tblprestamo  values (" + objPrestamo.getIdPrestamo() + ", '" + objPrestamo.getNomBanco() + "'," + objPrestamo.getMonto() + "," +
                       objPrestamo.getnumCoutas() + ")";
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }


        public int asociarUsuarioPrestamo(Estudiante objEstudiante, Prestamo objPrestamo)
        {

            string consulta = "";
            consulta = "INSERT INTO solicitar values (" + objPrestamo.getIdPrestamo() + "," + objEstudiante.getIdEst() + "," + objEstudiante.getobjCodeudor().getIdCod() + ",'" + DateTime.Now.ToString("dd/MM/yy") + "')";
            resultado = objDatos.ejecutarDML(consulta);
            return resultado;
        }

    }
}
