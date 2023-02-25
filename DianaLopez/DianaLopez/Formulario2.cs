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
            //Validaciones de si usuario ingreso lo necesario
            if (Cantidad1TextBox.Text == string.Empty) //si esta vacio
            {
                errorProvider1.SetError(Cantidad1TextBox, "Ingrese cantidad");
                Cantidad1TextBox.Focus();
                return; //cancela la ejecucion del evento click
            }
            errorProvider1.Clear(); //borrar el error
            if (Precio1TextBox.Text == string.Empty) //si esta vacio
            {
                errorProvider1.SetError(Precio1TextBox, "Ingrese Precio");
                Precio1TextBox.Focus();
                return; //cancela la ejecucion del evento click
            }
            errorProvider1.Clear(); //borrar el error
            if (Cantidad2TextBox.Text == string.Empty) //si esta vacio
            {
                errorProvider1.SetError(Cantidad2TextBox, "Ingrese cantidad");
                Cantidad2TextBox.Focus();
                return; //cancela la ejecucion del evento click
            }
            errorProvider1.Clear(); //borrar el error
            if (Precio2TextBox.Text == string.Empty) //si esta vacio
            {
                errorProvider1.SetError(Precio2TextBox, "Ingrese Precio");
                Precio2TextBox.Focus();
                return; //cancela la ejecucion del evento click
            }
            errorProvider1.Clear(); //borrar el error
            if (Cantidad3TextBox.Text == string.Empty) //si esta vacio
            {
                errorProvider1.SetError(Cantidad3TextBox, "Ingrese cantidad");
                Cantidad3TextBox.Focus();
                return; //cancela la ejecucion del evento click
            }
            errorProvider1.Clear(); //borrar el error
            if (Precio3TextBox.Text == string.Empty) //si esta vacio
            {
                errorProvider1.SetError(Precio3TextBox, "Ingrese Precio");
                Precio3TextBox.Focus();
                return; //cancela la ejecucion del evento click
            }
            errorProvider1.Clear(); //borrar el error

            //VARIABLES
            decimal cantidad1 = Convert.ToDecimal(Cantidad1TextBox.Text);
            decimal cantidad2 = Convert.ToDecimal(Cantidad2TextBox.Text);
            decimal cantidad3 = Convert.ToDecimal(Cantidad3TextBox.Text);
            decimal precio1 = Convert.ToDecimal(Precio1TextBox.Text);
            decimal precio2 = Convert.ToDecimal(Precio2TextBox.Text);
            decimal precio3 = Convert.ToDecimal(Precio3TextBox.Text);

            //DECLARACION DE UNA VARIABLES DONDE LLAMAMOS LA FUNCION ASINCRONA
            decimal totalPagar = await TotalAsync(cantidad1, cantidad2, cantidad3, precio1, precio2, precio3);
            TotalLabel.Text = "TOTAL:  Lps. " + totalPagar.ToString(); //MOSTRAR en un lebel el resultado de la función asincrona

        }

        //FUNCION ASINCRONA QUE PERMITE CALCULAR EL TOTAL A PAGAR CON DESCUENTO
        private async Task<decimal> TotalAsync(decimal cant1, decimal cant2, decimal cant3, decimal prec1, decimal prec2, decimal prec3)
        {
            //DECLARAMOS SUMAPRODUCTOS QUE VA A RETORNAR
            decimal sumaProductos = await Task.Run(() =>
            {
                //Variables para calculo total
                decimal suma;
                decimal subtotal;
                double descuento = 0.15;
                suma = (cant1 * prec1) + (cant2 * prec2) + (cant3 * prec3); //suma de subtotal
                subtotal = suma * ((decimal)descuento); //calculo del subtotal por el descuento
                //RETORNA LA OPERACION Y LA ALMACENA EN VARIABLE SUMAPRODUCTOS
                return (suma - subtotal); //restamos el descuento de la suma
            });
            //RETORNA LA TAREA ASINCRONA SUMAPRODUCTOS
            return sumaProductos;
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles(); //Llamado de la funcion para limpiar controles
            Nombre1TextBox.Focus();
        }


        //FUNCION PARA LIMPIAR LOS CONTROLES
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
            Close(); //Cierra el formulario
        }
    }
}
