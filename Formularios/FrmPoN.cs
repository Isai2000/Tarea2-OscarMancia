using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasdeControl_OscarMancia.Formularios
{
    public partial class FrmPoN : Form
    {
        public FrmPoN()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtN1.Focus();
                return;
            }

            double n1;
            n1 = Convert.ToDouble(TxtN1.Text);

            if (n1 >= 0)
            {
               TxtRest .Text = TxtRest .Text + "El numero es positivo";
            }else
            {
                TxtRest .Text = TxtRest .Text + "El numero es negativo";
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtRest.Clear();
            TxtN1.Focus();
        }
    }
}
