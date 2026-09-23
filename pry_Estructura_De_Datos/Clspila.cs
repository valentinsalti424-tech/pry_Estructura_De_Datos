using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Estructura_De_Datos
{
    internal class clsPila
    {

        private clsNodo primero;
        private clsNodo ultimo;

        internal clsNodo Primero { get => primero; set => primero = value; }
        internal clsNodo Ultimo { get => ultimo; set => ultimo = value; }


        public void AgregarPila(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                //Señalo al nuevo nodo
                Nuevo.siguiente = Primero;
                //Asigno el nuevo nodo a Primero
                Primero = Nuevo;
            }

        }

        public void AgregarPilaAnterior(clsNodo Nuevo)
        {

            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Primero.Anterior = Nuevo;
                Primero = Nuevo;
            }
        }

        public void Recorrer(ListBox lbListado)
        {
            clsNodo aux = Primero;

            lbListado.Items.Clear();

            while (aux != null)
            {
                lbListado.Items.Add(aux.Codigo.ToString() + " | " + aux.Nombre + ", " + aux.Tramite);
                aux = aux.siguiente;
            }
        }

        public void RecorrerDgv(DataGridView dgvListado)
        {
            clsNodo aux = Primero;

            dgvListado.Rows.Clear();

            while (aux != null)
            {
                dgvListado.Rows.Add(
                    aux.Codigo.ToString(),
                    aux.Nombre,
                    aux.Tramite
                    );

                aux = aux.siguiente;
            }
        }
    }
}





