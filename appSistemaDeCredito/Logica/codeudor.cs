using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaDeCredito.Logica
{
    public class codeudor
    {

        private String tipoDocCod;
        private int idCod;
        private String nombresCod;
        private String apellidosCod;
        private String generoCod;
        private String emailCod;
        private String direccionCod;
        private int telefonoCod;


        public codeudor() { }

        public codeudor(String tipoDocCod, int idCod, String nombresCod, String apellidosCod, String generoCod, String emailCod, String direccionCod, int telefonoCod)
        {
            this.tipoDocCod = tipoDocCod;
            this.idCod = idCod;
            this.nombresCod = nombresCod;
            this.apellidosCod = apellidosCod;
            this.generoCod = generoCod;
            this.emailCod = emailCod;
            this.direccionCod = direccionCod;
            this.telefonoCod = telefonoCod;
        }

        public String getTipoDocCod()
        {
            return tipoDocCod;
        }

        public void setTipoDocCod(String tipoDocCod)
        {
            this.tipoDocCod = tipoDocCod;
        }

        public int getIdCod()
        {
            return idCod;
        }

        public void setIdCod(int idCod)
        {
            this.idCod = idCod;
        }

        public String getNombresCod()
        {
            return nombresCod;
        }

        public void setNombresCod(String nombresCod)
        {
            this.nombresCod = nombresCod;
        }

        public String getApellidosCod()
        {
            return apellidosCod;
        }

        public void setApellidosCod(String apellidosCod)
        {
            this.apellidosCod = apellidosCod;
        }

        public String getGeneroCod()
        {
            return generoCod;
        }

        public void setGeneroCod(String generoCod)
        {
            this.generoCod = generoCod;
        }

        public String getEmailCod()
        {
            return emailCod;
        }

        public void setEmailCod(String emailCod)
        {
            this.emailCod = emailCod;
        }

        public String getDireccionCod()
        {
            return direccionCod;
        }

        public void setDireccionCod(String direccionCod)
        {
            this.direccionCod = direccionCod;
        }

        public int getTelefonoCod()
        {
            return telefonoCod;
        }

        public void setTelefonoCod(int telefonoCod)
        {
            this.telefonoCod = telefonoCod;
        }


    }
}

