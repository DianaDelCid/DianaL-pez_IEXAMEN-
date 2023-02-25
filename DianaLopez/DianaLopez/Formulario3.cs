using System;
using System.Windows.Forms;

namespace DianaLopez
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void ArregloButton_Click(object sender, EventArgs e)
        {
            //PARA LIMPIAR EL LISTBOX DESPUES DE CADA CLICK
            listBox1.Items.Clear();
            Numeros(); //LLAMADA DE LA FUNCION NUMEROS
        }

        public void Numeros()
        {
            //DECLARACION DE VECTOR E INSTANCIACION 
            int[] vector = new int[101]; //almacena 101 valores 

            //VARIABLES 
            string nombre = "Diana";
            String apellido = "López";


            //RECORRE EL VECTOR HASTA LLEGAR A 101
            for (int i = 1; i < vector.Length; i++)
            {
                //ASIGNACION DE VALORES AL VECTOR
                vector[i] = i;

                //MOSTRAR VALORES EN EL LISTBOX
                listBox1.Items.Add(vector[i]);

                //CONDICIÓN SIMPLE SI VALOR DEL INDICE (I) ES MULTIPLO DE 3
                if (vector[i] % 3 == 0)
                {

                    listBox1.Items.Add(nombre); //Agrega el nombre en este indice en el listbox
                    listBox1.Items.Remove(vector[i]); //Borra el valor del indice

                }
                //CONDICIÓN SIMPLE SI VALOR DEL INDICE (I) ES MULTIPLO DE 5
                if (vector[i] % 5 == 0)
                {
                    listBox1.Items.Add(apellido); //Agrega el nombre en este indice en el listbox
                    listBox1.Items.Remove(vector[i]);  //Borra el valor del indice
                }
                if ((vector[i] % 3 == 0) && (vector[i] % 5 == 0))
                {

                    listBox1.Items.Add(nombre + " " + apellido); //Agrega el nombre en este indice en el listbox
                    listBox1.Items.Remove(vector[i]);  //Borra el valor del indice
                }

            }

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close(); //metodo para que cierre el formulario
        }
    }
}
