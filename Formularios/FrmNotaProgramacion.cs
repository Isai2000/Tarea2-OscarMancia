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
    public partial class FrmNotaProgramacion : Form
    {
        int ap = 0, rp = 0;
        double cal;
        public FrmNotaProgramacion()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            if (TxtCalificacion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese calificacion");
                TxtCalificacion.Focus();
                return;
            }
            
            cal = Convert.ToDouble(TxtCalificacion.Text.Trim());

            if (cal >= 65)
            {
                ap++;
            }
            else
            {
                rp++;
            }

            LstCalificaion.Items.Add(TxtCalificacion.Text.Trim());
            TxtCalificacion.Clear();
            TxtCalificacion.Focus();

            TxtAprobado.Text = ap.ToString();
            TxtReprobado.Text = rp.ToString();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LblArpobado_Click(object sender, EventArgs e)
        {
            

        }

        private void LstCalificaion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void FrmNotaProgramacion_Load(object sender, EventArgs e)
        {

        }

        private void LblAprobado_Click(object sender, EventArgs e)
        {

        }
    }
}
