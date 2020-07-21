using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj02
{
    public partial class Form1 : Form
    {
        public string texto;
        public Form1(string [] parametros)
        {
            InitializeComponent();
            texto = parametros[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResultado.Text = texto;
        }
    }
}
