using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry_Estructura_De_Datos
{
    internal class clsNodo
    {
        private Int32 codigo;
        private string nombre;
        private string tramite;
        private clsNodo sig;
        private clsNodo ant;

        //Creamos las felchas del siguiente y anterior
        public clsNodo siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tramite { get => tramite; set => tramite = value; }
    }
}

