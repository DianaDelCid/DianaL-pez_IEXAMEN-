using System;
using System.Windows.Forms;

namespace DianaLopez
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario1 formulario1 = new Formulario1();
            formulario1.MdiParent = this;
            formulario1.Show();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario2 formulario2 = new Formulario2();
            formulario2.MdiParent = this;
            formulario2.Show();
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario3 formulario3 = new Formulario3();
            formulario3.MdiParent = this;
            formulario3.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //metodo para que cierre el programa
        }
    }
}