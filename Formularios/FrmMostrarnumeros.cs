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
    public partial class FrmMostrarnumeros : Form
    {
        public FrmMostrarnumeros()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (TxtInicio.Text .Trim ().Length == 0)
            {
                MessageBox.Show("Ingrese un valor");
                TxtInicio.Focus();
                return;

            }
            if (TxtFinal.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un valor");
                TxtFinal.Focus();
                return;

            }
            int i, ni, nf;
            ni = Convert.ToInt16(TxtInicio .Text .Trim ());
            nf = Convert.ToInt16(TxtFinal .Text .Trim ());

            for (i=ni;i<=nf;i++)
            {
                TxtMostrar.Text = TxtMostrar.Text + i.ToString() + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtInicio.Clear();
            TxtFinal.Clear();
            TxtMostrar.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
