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
    public partial class FrmBoleteria : Form
    {
        public FrmBoleteria()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtCant.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingres calificacion 1");
                TxtCant.Focus();
                return;
            }
            
            double cant, totalp, precu;
            cant = Convert.ToDouble(TxtCant.Text.Trim());

            if (cant >= 10)
            {
                precu = 80.00;
                totalp = cant * precu;
                TxtTotalp.Text = TxtTotalp.Text + totalp;
            }else
            {
                precu = 100.00;
                totalp = cant * precu;
                TxtTotalp.Text = TxtTotalp.Text + totalp;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCant.Clear();
            TxtTotalp.Clear();
            TxtCant.Focus();
        }
    }
}
