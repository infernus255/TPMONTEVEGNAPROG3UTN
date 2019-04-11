using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ventanaObj : Form
    {
        public ventanaObj()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNomObj.Text != "" && stringMatchList(txtBoxNomObj.Text, listBoxIzq) == -1) /// SI NO ESTA VACIO
                {
                    listBoxIzq.Items.Add(txtBoxNomObj.Text); ///ANADIR UN ITEM A LA LISTA
                }
                else
                {
                    MessageBox.Show("AGREGUE UN OBJETO VALIDO"); //MENSAJE DE ERROR
                }

            }

            catch
            {
                MessageBox.Show("AGREGUE UN OBJETO VALIDO"); //MENSAJE DE ERROR
            }


        }

        public int stringMatchList(string x, ListBox l) ///buscar un string en una lista, si es igual devuelve su posicion, si no lo es devuelve -1
        {
            int pos = -1;
            foreach (string obj in l.Items)
            {
                if (obj == x)
                {
                    pos=l.Items.IndexOf(x);
                    return pos;
                }
            }
            return pos;
        }

        public bool listasConRep(ListBox l1, ListBox l2)
        {
            bool rep = false;
            foreach (string obj1 in l1.Items)
            {
                foreach (string obj2 in l2.Items)
                {
                    if (obj1 == obj2)
                    {
                        rep = true;
                        return rep;
                    }
                }
            }
            return rep;
        }

        private void btnAllListaDer_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxIzq.Items.Count > 0 && listasConRep(listBoxIzq, listBoxDer) == false)
                {
                    listBoxDer.Items.AddRange(listBoxIzq.Items);
                    listBoxIzq.Items.Clear();
                }
                else { MessageBox.Show("NO ES POSIBLE TRASLADAR TODOS LOS ITEMS A LA LISTA DERECHA"); }
            }

            catch
            {
                MessageBox.Show("NO ES POSIBLE TRASLADAR TODOS LOS ITEMS A LA LISTA DERECHA");
            }
        }

        private void btn1ListaDer_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxIzq.SelectedIndex >= 0 && stringMatchList((string)listBoxIzq.SelectedItem, listBoxDer) == -1)
                {
                    listBoxDer.Items.Add(listBoxIzq.SelectedItem);
                    listBoxIzq.Items.Remove(listBoxIzq.SelectedItem);
                }
                else
                {
                    MessageBox.Show("NO ES POSIBLE TRASLADAR EL ITEM SELECCIONADO A LA LISTA DERECHA");
                }

            }
            catch
            {
                MessageBox.Show("NO ES POSIBLE TRASLADAR EL ITEM SELECCIONADO A LA LISTA DERECHA");
            }

        }

        private void btn1ListaIzq_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDer.SelectedIndex >= 0 && stringMatchList((string)listBoxDer.SelectedItem, listBoxIzq) == -1)
                {
                    listBoxIzq.Items.Add(listBoxDer.SelectedItem);
                    listBoxDer.Items.Remove(listBoxDer.SelectedItem);
                }
                else
                {
                    MessageBox.Show("NO ES POSIBLE TRASLADAR EL ITEM SELECCIONADO A LA LISTA IZQUIERDA");
                }

            }

            catch
            {
                MessageBox.Show("NO ES POSIBLE TRASLADAR EL ITEM SELECCIONADO A LA LISTA IZQUIERDA");
            }

        }

        private void btnDelListaIzq_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDer.SelectedIndex >= 0)
                {
                    listBoxDer.Items.Remove(listBoxDer.SelectedItem);
                }

                else
                {
                    MessageBox.Show("NO ES POSIBLE ELIMINAR EL ITEM SELECCIONADO");
                }

            }
            catch
            {
                MessageBox.Show("NO ES POSIBLE ELIMINAR EL ITEM SELECCIONADO");
            }

        }
    }


}
