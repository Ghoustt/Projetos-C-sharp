using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtValor.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.dado = txtValor.Text;
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string parametros = txtValor.Text;
            System.Diagnostics.Process.Start(@"Prj02\Prj02\Prj02\bin\Debug\Prj02.exe", parametros);
        }
    }
}
