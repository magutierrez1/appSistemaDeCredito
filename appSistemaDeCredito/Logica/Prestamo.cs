﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaDeCredito.Logica
{
    class Prestamo
    {
        private int idprestamo;
        private String nomBanco;
        private int monto;
        private int numCoutas;

        #region constructor
        public Prestamo() { }
        public Prestamo(String nomBanco, int monto, int numCuota)
        {
            Random aux = new Random();
            int idprest = aux.Next(1, 1000000);
            idprestamo = idprest;
            this.nomBanco = nomBanco;
            this.monto = monto;
            numCoutas = numCuota;
        }
        #endregion

        #region get y set
        public int getIdPrestamo()
        {
            return idprestamo;
        }

        public String getNomBanco()
        {
            return nomBanco;
        }
        public int getMonto()
        {
            return monto;
        }
        public int getnumCoutas()
        {
            return numCoutas;
        }
        public void setNomBanco(String NomBanco)
        {
            nomBanco = NomBanco;
        }
        public void setMonto(int monto)
        {
            this.monto = monto;
        }
        public void setnumCoutas(int numCoutas)
        {
            this.numCoutas = numCoutas;
        }
        #endregion



    }
}
