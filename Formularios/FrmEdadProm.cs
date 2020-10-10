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
    public partial class FrmEdadProm : Form
    {
        int i,edad,sum=0;
        double edadprom;
        public FrmEdadProm()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 10; i++)
            {
                sum += edad;
                edadprom = sum / 10;

            }

            LstMostrar.Items.Add(TxtEdad.Text .Trim ());
            TxtEdad.Clear();
            TxtEdad.Focus();
            edad = Convert.ToInt32(LstMostrar.Items.Add (TxtEdad.Text));

           
            TxtEdProm.Text = edadprom.ToString();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            
            

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtEdad.Clear();
            TxtEdProm.Clear();
            
            LstMostrar.Items.Clear();
            
        }
    }
}
