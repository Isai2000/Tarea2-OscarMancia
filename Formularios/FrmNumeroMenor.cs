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
    public partial class FrmNumeroMenor : Form
    {
        public FrmNumeroMenor()
        {
            InitializeComponent();
        }

        private void TxtNot2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingres calificacion 1");
                TxtN1.Focus();
                return;
            }


            if (TxtN2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingres calificacion 1");
                TxtN2.Focus();
                return;
            }

            double n1, n2;
            n1 = Convert.ToDouble(TxtN1.Text);
            n2 = Convert.ToDouble(TxtN2.Text);

            if (n1 < n2 )
            {
                TxtRest .Text = TxtRest .Text + n1;
                
            }else
            {
                TxtRest .Text = TxtRest .Text + n2 ;
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
            TxtRest.Clear();
            TxtN1.Focus();
        }
    }
}
