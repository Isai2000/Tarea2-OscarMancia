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
    public partial class FrmTotalP : Form
    {
        double sumpt = 0, cant, precu, totalp;
        public FrmTotalP()
        {
            InitializeComponent();
        }

        private void BtbAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmTotalP_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtDescrip .Text .Trim ().Length == 0)
            {
                MessageBox.Show("INGRESE UN DATO");
                TxtDescrip.Focus();
                return;
            }
            if (TxtCant.Text.Trim().Length == 0)
            {
                MessageBox.Show("INGRESE UN DATO");
                TxtCant.Focus();
                return;
            }
            if (TxtPrecu.Text.Trim().Length == 0)
            {
                MessageBox.Show("INGRESE UN DATO");
                TxtPrecu.Focus();
                return;
            }
            cant = Convert.ToDouble(TxtCant .Text );
            precu = Convert.ToDouble(TxtPrecu .Text);
            LstMostrar.Items.Add(TxtDescrip .Text .Trim ());
            LstCatn.Items.Add(TxtCant .Text .Trim ());
            LstPrecu.Items.Add(TxtPrecu .Text .Trim ());
            LstTotal.Items.Add(cant * precu );

            TxtCant.Clear();
            TxtDescrip.Clear();
            TxtPrecu.Clear();
            TxtDescrip.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (TextBox limp in this .Controls .OfType <TextBox >())
            {
                limp.Clear();
            }


            LstMostrar.Items.Clear();
            LstCatn.Items.Clear();
            LstPrecu.Items.Clear();
            LstPrecu.Items.Clear();
            LstTotal.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             //Dar click en calcular despues de agregar un producto

            totalp= cant * precu;
            sumpt += totalp;
            TxtTotalP.Text = sumpt.ToString();
        }
    }
}
