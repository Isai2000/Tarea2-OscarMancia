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
    public partial class FrmDesc : Form
    {
        public FrmDesc()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtCant.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese los datos");
                TxtCant.Focus();
                return;
            }


            if (TxtPrecu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese los datos");
                TxtPrecu.Focus();
                return;
            }

            double cant, precu, desc, totalp, tp;
            cant = Convert.ToDouble(TxtCant.Text.Trim());
            precu = Convert.ToDouble(TxtPrecu.Text.Trim());

            totalp = cant * precu;

            if (cant >= 3)
            {
                desc = totalp * 0.2;
            }else
            {
                desc = 0;
            }

            tp = totalp - desc;
            TxtdDesc.Text = TxtdDesc.Text + desc;
            TxtTotalp.Text = TxtTotalp.Text + tp;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCant.Clear();
            TxtPrecu.Clear();
            TxtdDesc.Clear();
            TxtTotalp.Clear();
            TxtCant.Focus();
        }
    }
}
