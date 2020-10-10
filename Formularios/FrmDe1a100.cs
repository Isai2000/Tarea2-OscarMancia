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
    public partial class FrmDe1a100 : Form
    {
        public FrmDe1a100()
        {
            InitializeComponent();
        }

        private void FrmDe1a100_Load(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (TxtInicio .Text .Trim ().Length == 0)
            {
                MessageBox.Show("INGRESE UN DATO");
                TxtInicio.Focus();
                return;
            }
            if (TxtFinal.Text.Trim().Length == 0)
            {
                MessageBox.Show("INGRESE UN DATO");
                TxtFinal.Focus();
                return;
            }

            int i, nin, nf, rest = 0;
            nin = Convert.ToInt16(TxtInicio .Text );
            nf = Convert.ToInt16(TxtFinal .Text );

                        
            for (i=nin;i<=nf;i++)
            {
                rest += i;
            }

            TxtRest.Text = rest.ToString();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtInicio.Clear();
            TxtFinal.Clear();
            TxtRest.Clear();
            TxtInicio.Focus();
        }
    }
}
