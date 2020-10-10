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
    public partial class FrmProm10 : Form
    {
        public FrmProm10()
        {
            InitializeComponent();
        }

        private void FrmProm10_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtProm .Text .Trim ().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtProm.Focus();
                return;
            }

            int i;
            double prom;
            prom = Convert.ToDouble(TxtProm.Text.Trim());

            
            for (i=1;i<=10;i++)
            {
             
                if (prom >= 65)
                {
                    LstMostrar.Items.Add (TxtProm .Text .Trim ());
                    LstObs.Items.Add("APROBADO");                    
                    TxtProm.Clear();
                    TxtProm.Focus();
                    return;
                }
                else
                {
                    LstMostrar.Items.Add(TxtProm .Text .Trim ());
                    LstObs.Items.Add("REPROBADO");
                    TxtProm.Clear();
                    TxtProm.Focus();
                    return;
                    
                }              
             
            }
              
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtProm.Clear();
            LstMostrar.Items.Clear();
            LstObs.Items.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
