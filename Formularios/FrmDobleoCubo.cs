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
    public partial class FrmDobleoCubo : Form
    {
        public FrmDobleoCubo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtN1.Focus();
                return;
            }

            double n1, rest;
            n1 = Convert.ToDouble(TxtN1.Text.Trim());

            if (n1 >= 10)
            {
                rest = n1 * n1;
                TxtRest.Text = TxtRest.Text + rest;
            }else
            {
                rest = n1 * n1 * n1;
                TxtRest.Text = TxtRest.Text + rest;
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtRest.Clear();
            TxtN1.Focus();
        }
    }
}
