using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramificare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startK= Convert.ToInt32(numericUpDown1.Value);
            int stopK= Convert.ToInt32(numericUpDown2.Value);

            double rambRata = 40.00;            

            if (startK < stopK)
            {
                double rambSuma= (Convert.ToDouble(stopK) - Convert.ToDouble(startK)) * rambRata;
                lbSuma.Text = Convert.ToString(rambSuma);
            }
            else
            {
                MessageBox.Show("Distanta initiala nu poate fi mai mare ca cea finala", "Nu se poate calcula");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int startK = Convert.ToInt32(numericUpDown1.Value);
            int stopK = Convert.ToInt32(numericUpDown2.Value);
            double parcursK = (Convert.ToDouble(stopK) - Convert.ToDouble(startK));

            MessageBox.Show("Distanta este : " + parcursK, "Distanta parcursa");
        }
    }
}
