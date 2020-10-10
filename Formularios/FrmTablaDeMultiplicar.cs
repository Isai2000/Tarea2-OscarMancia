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
    public partial class FrmTablaDeMultiplicar : Form
    {
        public FrmTablaDeMultiplicar()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            
            if (TxtN .Text .Trim ().Length == 0)
            {
                MessageBox.Show("INGRESE UN DATO");
                TxtN.Focus();
                return;
            }
            int i, n,rest;
            n = Convert.ToInt16(TxtN .Text .Trim ());

            for (i=1;i<=10;i++)
            {
                if (n <= 10)
                {
                    rest = i * n;
                    LstMostrar.Items.Add(i + " * " + n + " = " + i * n);
                }else
                {
                    MessageBox.Show("SOLO SE ADMITEN DATOS ENTRE 1 Y 10");
                    TxtN.Clear();
                    TxtN.Focus();
                    return;
                }
                
               
            }
            

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtN.Clear();
            LstMostrar.Items.Clear();
            TxtN.Focus();
        }
    }
}
