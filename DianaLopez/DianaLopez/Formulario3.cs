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
            Numeros();
        }

        public void Numeros()
        {
            //Vectores
            //Inicializamos vector 
            int[] vector = new int[101]; //almacena 100 valores 
            string nombre = "Diana";
            String apellido = "López";
            String completo = "Diana López";

            for (int i = 1; i < vector.Length; i++)
            {
                vector[i] = i;
                //listBox1.Items.Add(vector[i]); //Agregamos al listBox los valores en cada una de las posiciones

                //listBox1.Items.Add(vector[i]);


                if (vector[i] % 3 == 0)
                {
                    //String[] vector = Convert.ToString(vector);
                    //listBox1.Items.Add("Diana");
                    listBox1.Items.Add(nombre);
                    listBox1.Items.Remove(listBox1.Items);
                }
                if (vector[i] % 5 == 0)
                {
                    listBox1.Items.Add("López");
                }
                if ((vector[i] % 3 == 0) && (vector[i] % 5 == 0))
                {
                    listBox1.Items.Add("Diana López");
                }
                else
                {
                    listBox1.Items.Add(vector[i]);
                }




            }
        }
    }
}
