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
            //variables
            decimal capital = 200000;
            double inter = 0.015;
            decimal interes = Convert.ToDecimal(inter);
            decimal tiempo = 30;

            CalculoInteres(capital, interes, tiempo);
        }

        private decimal CalculoInteres(decimal capi, decimal i, decimal tiem)
        {
            tiem = tiem / 360;
            decimal CalInteres;
            CalInteres = capi * i * tiem;
            string convertir = Convert.ToString(CalInteres);
            decimal acum = CalInteres;
            decimal imes = 0;


            for (int fila = 0; fila < 12; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        acum = acum + CalInteres;

                        string acumula = Convert.ToString(acum);

                        String[,] matriz = new String[12, 2]
                            {
                            {"Enero", convertir},
                            { "Febrero", "Interes: "+acumula},
                            {"Marzo", acumula},
                            {"Abril", acumula},
                            {"Mayo", acumula},
                            {"Junio", acumula},
                            {"Jilio", acumula},
                            {"Agosto", acumula},
                            {"Septiembre", acumula},
                            {"Octubre", acumula},
                            {"Noviembre", acumula},
                            {"Diembre", acumula}
                            };

                        //matriz[fila, columna];
                        listBox1.Items.Add(matriz[fila, columna]);
                    }

                }
            }

            return 2 - 2;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}

