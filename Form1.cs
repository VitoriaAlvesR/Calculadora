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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //if (this.pgrsCarregando.Value < this.pgrsCarregando.Maximum)
            //{
            //    this.pgrsCarregando.Value += 10;
            //}
            //else
            //{
               
            //}

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgrsCarregando.Value += 1;
            if(pgrsCarregando.Value == 10)
            {
                timer1.Enabled = false;
                FrmCalculadora frmCalculadora = new FrmCalculadora();
                frmCalculadora.Show();
                this.Hide();
            }
        }
    }
}
