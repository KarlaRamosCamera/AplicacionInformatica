using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionInformatica
{
    internal class Pdestajo
    
    {
        private string v1;
        private long v2;
        private string v3;
        private string v4;
        private int v5;

        public string Nombre { get; set; }
            public decimal ID { get; set; }
            public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string FechaIngreso { get; set; }

        public Pdestajo(string nombre, decimal id, string apaterno, string amaterno, string fechaingreso)
            {
                Nombre = nombre;
                ID = id;
                APaterno = apaterno;
            AMaterno = amaterno;
            FechaIngreso = fechaingreso;
            }

        public Pdestajo(string v1, long v2, string v3, string v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }
    }
    }
