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


    public partial class ventanaPersonas : Form
    {

        private List<Persona> listaPersonas = new List<Persona>(8);
        private BindingList<Persona> listaBindeable;

        public ventanaPersonas()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {

                if (validarAceptar() == true)
                {
                    Persona x = new Persona(txtBoxNombre.Text, txtBoxApellido.Text, dateTimePicker1.Text, txtSex(), txtGen(), combBoxColor.Text, calcularEdad());
                    listaPersonas.Add(x);
                    refrescarGrilla();
                }
                else
                {
                    MessageBox.Show("VERIFIQUE LOS DATOS INGRESADOS E INTENTE NUEVAMENTE");
                    return;
                }

            }

            catch
            {
                MessageBox.Show("VERIFIQUE LOS DATOS INGRESADOS E INTENTE NUEVAMENTE");
                return;
            }

        }

        public bool validarAceptar()
        {
            bool validar = false;

            if (validarLetras(txtBoxNombre.Text) == true)
            {

                validar = true;
            }
            else { validar = false; }
            if (validarLetras(txtBoxApellido.Text) == true && validar == true)
            {

                validar = true;
            }
            else { validar = false; }
            if (validarSexo() == true && validar == true)
            {
                validar = true;
            }
            else { validar = false; }
            if (validarGenMus() == true && validar == true)
            {
                validar = true;
            }
            else { validar = false; }
            if (validarLetras(combBoxColor.Text) == true && validar == true && validarColor()==true)
            {
                validar = true;
            }
            else { validar = false; }
            if (calcularEdad() >= 0 && validar == true)
            {
                validar = true;
            }
            else { validar = false; }

            return validar;
        }

        public void refrescarGrilla()
        {
            listaBindeable.ResetBindings();
        }

        public string txtSex()
        {
            string text = "";
            if (radBtnMasc.Checked == true)
            { text = radBtnMasc.Text; }
            if (radBtnFem.Checked == true)
            { text = radBtnFem.Text; }
            if (radBtnOtro.Checked == true)
            { text = radBtnOtro.Text; }
            return text;

        }

        public bool validarColor()
        {
            
            if(combBoxColor.Text== "ROJO" || combBoxColor.Text == "AZUL" || combBoxColor.Text == "VERDE" || combBoxColor.Text == "AMARILLO" || combBoxColor.Text == "VIOLETA" || combBoxColor.Text == "NEGRO")
                {
                return true;
                }
            else
            { return false; }
        }

        public string txtGen()
        {
            string texto = "";
            if (chkBoxPop.Checked == true)
            { texto+= chkBoxPop.Text; }
            if (chkBoxJazz.Checked == true)
            { texto+=" "+chkBoxJazz.Text; }
            if (chkBoxCountry.Checked == true)
            { texto+=" "+ chkBoxCountry.Text; }
            if (chkBoxRock.Checked == true)
            { texto += " " + chkBoxRock.Text; }
            return texto;
        }



        private void ventanaPersonas_Load(object sender, EventArgs e)
        {
            combBoxColor.Items.Add("ROJO");
            combBoxColor.Items.Add("AZUL");
            combBoxColor.Items.Add("VERDE");
            combBoxColor.Items.Add("AMARILLO");
            combBoxColor.Items.Add("VIOLETA");
            combBoxColor.Items.Add("NEGRO");

            listaBindeable = new BindingList<Persona>(listaPersonas);
            dgvPersonas.DataSource = listaBindeable;
        }

        public int calcularEdad() ///calcula la edad mediante la fecha de nac y la actual
        {
            int edad = -1;
            if (dateTimePicker1.Value.Year < DateTime.Now.Year)
            {
                edad =  DateTime.Now.Year - dateTimePicker1.Value.Year;
                if (dateTimePicker1.Value.Month > DateTime.Now.Month)
                {
                    edad = edad - 1;
                }
                else if (dateTimePicker1.Value.Month == DateTime.Now.Month)
                    {
                    if(DateTime.Now.Day < dateTimePicker1.Value.Day )
                    {
                        edad = edad - 1;
                    }

                    }
            }

            return edad;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblEdad.Text = "Edad: " + calcularEdad().ToString();
        }

        public bool validarLetras(string x) ///valida el ingreso solo de letras 
        {

                bool valido = false;
                for (int i=0;i<x.Length; i++)
            {
                if (x[i] >= 65 && x[i] <= 90 || x[i] >= 97 && x[i] <= 122)
                    {
                        valido = true;
                    }
                    else { valido = false; }

                    if (valido == false)
                    {

                    return valido;
                    }
                }

            return valido;

        }

        public bool validarSexo()
        {
            bool validar = false;
            if (radBtnMasc.Checked == true || radBtnFem.Checked == true || radBtnOtro.Checked == true)
            {
                return validar = true;
            }

            return validar;
        }

        public bool validarGenMus()
        {
            bool validar = false;
            if (chkBoxPop.Checked == true || chkBoxRock.Checked == true || chkBoxJazz.Checked == true || chkBoxCountry.Checked==true)
            {
                return validar = true;
            }

            return validar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = "";
            txtBoxApellido.Text = "";
            lblEdad.Text = "Edad: ";
            radBtnMasc.Checked = false;
            radBtnFem.Checked = false;
            radBtnOtro.Checked = false;
            chkBoxCountry.Checked = false;
            chkBoxJazz.Checked = false;
            chkBoxPop.Checked = false;
            chkBoxRock.Checked = false;
            combBoxColor.Text = "";

        }

        public void ModificarPersona(object x)
        {
            Persona p = (Persona)x;
            //object objSeleccionado;
            //objSeleccionado = dgvPersonas.CurrentRow.DataBoundItem;
            //Persona personaSeleccionada = (Persona)objSeleccionado;
                p.Nombre = txtBoxNombre.Text;
                p.Apellido = txtBoxApellido.Text;
                p.FechaNac = dateTimePicker1.Text;
                p.Sexo = txtSex();
                p.EstiloMus = txtGen();
                p.Color = combBoxColor.Text;
                p.Edad=calcularEdad();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Persona x = new Persona();
            ModificarPersona(x);

            try
            {
                if (dgvPersonas.Rows.Count > 0 && validarAceptar() == true)
                {

                    dgvPersonas.Rows.Remove(dgvPersonas.CurrentRow);
                    listaPersonas.Add(x);
                    refrescarGrilla();

                }
                else
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR LA PERSONA SELECCIONADA, POR FAVOR RELLENE TODOS LOS CAMPOS DEL FORMULARIO ANTES DE MODIFICAR");
                }
            }

            catch
            {
                MessageBox.Show("NO SE PUEDE MODIFICAR LA PERSONA SELECCIONADA, POR FAVOR RELLENE TODOS LOS CAMPOS DEL FORMULARIO ANTES DE MODIFICAR");
            }




            
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.Rows.Count > 0)
                {
                    dgvPersonas.Rows.Remove(dgvPersonas.CurrentRow);
                }
                else
                {
                    MessageBox.Show("NO ES POSIBLE ELIMINAR LA FILA SELECCIONADA");
                }
                //refrescarGrilla();
            }
            catch
            {
                MessageBox.Show("NO ES POSIBLE ELIMINAR LA FILA SELECCIONADA");
            }
        }


    }
}
