using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float celsius, Fahrenheit;

            celsius = trackBar1.Value;
            Fahrenheit = (1.8f * trackBar1.Value) + 32.0f;

            lblcelsiusvalue.Text = celsius.ToString();
            lblFahrenheitvalue.Text = Fahrenheit.ToString();
        }

        private void btnFreezing_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 100;
        }

        private void btnboiling_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
        }
    }
}