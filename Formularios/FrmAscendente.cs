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
    public partial class FrmAscendente : Form
    {
        public FrmAscendente()
        {
            InitializeComponent();
        }

        private void FrmAscendente_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingres los datos");
                TxtN1.Focus();
                return;
            }


            if (TxtN2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingres los datos");
                TxtN2.Focus();
                return;
            }

            double n1, n2, rest;
            n1 = Convert.ToDouble(TxtN1.Text.Trim());
            n2 = Convert.ToDouble(TxtN2.Text.Trim());

            if (n1 < n2 )
            {
                Txtrest.Text = Txtrest.Text + n1 + " " + n2;
            }else
            {
                Txtrest.Text = Txtrest.Text + n2 + " " + n1;
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN2.Clear();
            Txtrest.Clear();
            TxtN1.Focus();
        }
    }
}
