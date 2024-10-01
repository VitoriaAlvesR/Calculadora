using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bttnNum2_Click(object sender, EventArgs e)
        {

        }

        private void converteCelciusParaConverterCelciusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConversor frmConversor = new FrmConversor();
            frmConversor.ShowDialog();
        }
    }
}
