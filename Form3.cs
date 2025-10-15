using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaParaVender
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                label1.Text = "Cargando El Sistema";
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Form4 Nose = new Form4();
                Nose.Show();
            }
        }
    }
}

