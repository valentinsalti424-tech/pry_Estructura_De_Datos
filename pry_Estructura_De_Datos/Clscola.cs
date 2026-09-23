using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Estructura_De_Datos
{
    //internal es el medioentre public y private, tiene cierta privacidad para que no puedan entrar todos pero puedo usar
    //public en los métodos
    internal class clsCola
    {

        //Atributos de la clase cola, cualidades de la clase nodo
        private clsNodo primero;
        private clsNodo ultimo;

        internal clsNodo Primero { get => primero; set => primero = value; }
        internal clsNodo Ultimo { get => ultimo; set => ultimo = value; }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        //ListBox es el tipo de obj que recibo, lbLista es el nombre que le voy a dar al obj que recibo
        public void Recorrer(ListBox lbListado)
        {
            clsNodo aux = Primero;

            lbListado.Items.Clear();

            while (aux != null)
            {
                lbListado.Items.Add(aux.Codigo + " " + aux.Nombre + ", " + aux.Tramite);
                aux = aux.siguiente;
            }
        }

        public void RecorrerDGV(DataGridView dgvListado)
        {
            clsNodo aux = Primero;

            dgvListado.Rows.Clear();

            while (aux != null)
            {
                dgvListado.Rows.Add(
                    aux.Codigo,
                    aux.Nombre,
                    aux.Tramite
                    );
                aux = aux.siguiente;
            }
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.siguiente;

                if (Primero == null)
                {
                    Ultimo = null;
                }
            }

        }
    }
}





