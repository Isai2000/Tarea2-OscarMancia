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
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNot1 .Text .Trim ().Length == 0)
            {
                MessageBox.Show("Ingres calificacion 1");
                TxtNot1.Focus();
                return;
            }


            if (TxtNot2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingres calificacion 1");
                TxtNot2.Focus();
                return;
            }

            if (TxtNot3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingres calificacion 1");
                TxtNot3.Focus();
                return;
            }

            double n1, n2, n3, prom;
            n1 = Convert.ToDouble(TxtNot1.Text);
            n2 = Convert.ToDouble(TxtNot2.Text);
            n3 = Convert.ToDouble(TxtNot2.Text);

            prom = (n1 + n2 + n3) / 3;

            TxtProm.Text = prom.ToString();

            if (prom >= 65)
            {
               TxtEstado .Text = TxtEstado .Text + "El estudiante aprobo";
            }else
            {
                TxtEstado.Text = TxtEstado.Text + "El estudiante reprobo";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNot1.Clear();
            TxtNot2.Clear();
            TxtNot3.Clear();
            TxtProm.Clear();
            TxtEstado.Clear();
            TxtNot1.Focus();
        }
    }
}
