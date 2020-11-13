using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.Configurations;
using LiveCharts.Helpers;
using System.Windows.Media.Imaging;

namespace Bunker_GUI
{
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            updateProgram(1, 1);
            button1.BackColor = selectedBackColor;
            button1.ForeColor = selectedForeColor;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateProgram(1, 2);
            button2.BackColor = selectedBackColor;
            button2.ForeColor = selectedForeColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateProgram(1, 3);
            button3.BackColor = selectedBackColor;
            button3.ForeColor = selectedForeColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(phase))
            {
                button5.Text = "Phase-";
                button5.BackColor = selectedBackColor;
                button5.ForeColor = selectedForeColor;
            }
            else
            {
                button5.Text = "Phase+";
                button5.BackColor = backColor;
                button5.ForeColor = foreColor;
            }
            phase ^= 1;
        }
    }
}
