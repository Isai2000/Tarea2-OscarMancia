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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnProm_Click(object sender, EventArgs e)
        {
            Formularios.FrmPromedio Promedio = new Formularios.FrmPromedio();
            Promedio.ShowDialog();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnNumeroMenor_Click(object sender, EventArgs e)
        {
            Formularios.FrmNumeroMenor menor = new Formularios.FrmNumeroMenor();
            menor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmPoN mapex = new Formularios.FrmPoN();
            mapex.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmDobleoCubo dorico = new Formularios.FrmDobleoCubo();
            dorico.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FrmDesc eolico = new Formularios.FrmDesc();
            eolico.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmBoleteria lluvia = new Formularios.FrmBoleteria();
            lluvia.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.FrmAscendente ascendente = new Formularios.FrmAscendente();
            ascendente.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formularios.FrmMultiplos multiplos = new Formularios.FrmMultiplos();
            multiplos.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formularios.FrmProm10 onix = new Formularios.FrmProm10();
            onix.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formularios.FrmTotalP cat = new Formularios.FrmTotalP();
            cat.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formularios.FrmEdadProm cow = new Formularios.FrmEdadProm();
            cow.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formularios.FrmNotaProgramacion horse = new Formularios.FrmNotaProgramacion();
            horse.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formularios.FrmTablaDeMultiplicar steel = new Formularios.FrmTablaDeMultiplicar();
            steel.ShowDialog();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            Formularios.FrmDe1a100 olimpia = new Formularios.FrmDe1a100();
            olimpia.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Formularios.FrmMostrarnumeros luz = new Formularios.FrmMostrarnumeros();
            luz.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
