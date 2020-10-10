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
    public partial class FrmMultiplos : Form
    {
        public FrmMultiplos()
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
            int i, n;
            n = Convert.ToInt32(TxtN1.Text.Trim());

            for (i=0; i<=60;i++)
            {
                TxtRest.Text = TxtRest.Text + i * n + " ";
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtRest.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
