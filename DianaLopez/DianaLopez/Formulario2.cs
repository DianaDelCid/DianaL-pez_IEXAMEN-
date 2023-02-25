using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DianaLopez
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private async void CalcularTotalButton_ClickAsync(object sender, EventArgs e)
        {
            //Variables
            decimal cantidad1 = Convert.ToDecimal(Cantidad1TextBox.Text);
            decimal cantidad2 = Convert.ToDecimal(Cantidad2TextBox.Text);
            decimal cantidad3 = Convert.ToDecimal(Cantidad3TextBox.Text);
            decimal precio1 = Convert.ToDecimal(Precio1TextBox.Text);
            decimal precio2 = Convert.ToDecimal(Precio2TextBox.Text);
            decimal precio3 = Convert.ToDecimal(Precio3TextBox.Text);


            //Llamada de la funcion Asincrona
            decimal totalPagar = await TotalAsync(cantidad1, cantidad2, cantidad3, precio1, precio2, precio3);
            TotalLabel.Text = totalPagar.ToString();
            //MessageBox.Show($"La Suma es: {totalPagar}");
        }

        //Metodo asincrono que permita calcular la suma de los dos textbox
        private async Task<decimal> TotalAsync(decimal cant1, decimal cant2, decimal cant3, decimal prec1, decimal prec2, decimal prec3)
        {
            decimal sumaProductos = await Task.Run(() =>
            {
                decimal suma;
                decimal subtotal;
                double descuento = 0.15;
                suma = (cant1 * prec1) + (cant2 * prec2) + (cant3 * prec3);
                subtotal = suma * ((decimal)descuento);
                return (suma - subtotal);
            });
            return sumaProductos;
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            Nombre1TextBox.Focus();
        }

        private void LimpiarControles()
        {
            Nombre1TextBox.Text = "";
            Nombre2TextBox.Text = "";
            Nombre3TextBox.Text = "";
            Cantidad1TextBox.Text = "";
            Cantidad2TextBox.Text = "";
            Cantidad3TextBox.Text = "";
            Precio1TextBox.Text = "";
            Precio2TextBox.Text = "";
            Precio3TextBox.Text = "";
            TotalLabel.Text = "";
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
