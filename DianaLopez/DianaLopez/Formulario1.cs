using System;
using System.Windows.Forms;

namespace DianaLopez
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //variables
            decimal capital = 200000;
            double inter = 0.015;
            decimal interes = Convert.ToDecimal(inter); //Convercion del interes
            decimal tiempo = 1;

            //LLAMAMOS LA FUNCION JUNTO CON LOS PARAMETROS DADOS
            CalculoInteres(capital, interes, tiempo);
        }

        //FUNCION DE CALCULO DEL INTERES CON PARAMETROS 
        private decimal CalculoInteres(decimal capi, decimal i, decimal tiem)
        {
            for (int fila = 0; fila < 13; fila++) //RECORRER FILAS
            {
                decimal CalInteres;
                CalInteres = capi * i * fila;
                string convertir = Convert.ToString(CalInteres);
                decimal acum = CalInteres;
                //acum = CalInteres + acum;
                string acumula = Convert.ToString(acum);

                for (int columna = 0; columna < 2; columna++) //RECORRER COLUMNAS
                {
                    //Declaración de una matriz
                    String[,] matriz = new String[13, 2]
                        {   //Llenar matriz con los resultados obtenidos de cada mes
                            {"Interés de Cada mes"," MES              INTERES"},
                            {"ENERO      Lps."+CalInteres, ""},
                            {"FEBRERO    Lps."+CalInteres, ""},
                            {"MARZO      Lps."+CalInteres, ""},
                            {"ABRIL      Lps."+CalInteres, ""},
                            {"MAYO       Lps."+CalInteres, ""},
                            {"JUNIO      Lps."+CalInteres, ""},
                            {"JULIO      Lps."+CalInteres, ""},
                            {"AGOSTO     Lps."+CalInteres, ""},
                            {"SEPTIEMBRE Lps."+CalInteres, ""},
                            {"OCTUBRE    Lps."+CalInteres, ""},
                            {"NOVIEMBRE  Lps."+CalInteres, ""},
                            {"DICIEMBRE  Lps."+CalInteres, ""}
                        };
                    //LLENAR EL LISTBOX CON LA MATRIZ
                    listBox1.Items.Add(matriz[fila, columna]);
                }

            }
            return tiem;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close(); //metodo cierra el formulario
        }

    }

}

