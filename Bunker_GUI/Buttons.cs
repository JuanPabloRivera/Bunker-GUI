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
            currentChannel = 1;
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            textBox37.Text = "CH 1";
            updateTrackbars();
            updateBoxes();
            resetButtonColors();
            resetTextboxColors();
            button1.BackColor = System.Drawing.Color.SteelBlue;
            button1.ForeColor = System.Drawing.Color.White;
            updatePlot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentChannel = 2;
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            textBox37.Text = "CH 2";
            updateTrackbars();
            updateBoxes();
            resetButtonColors();
            resetTextboxColors();
            button2.BackColor = System.Drawing.Color.SteelBlue;
            button2.ForeColor = System.Drawing.Color.White;
            updatePlot();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentChannel = 3;
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            textBox37.Text = "CH 3";
            updateTrackbars();
            updateBoxes();
            resetButtonColors();
            resetTextboxColors();
            button3.BackColor = System.Drawing.Color.SteelBlue;
            button3.ForeColor = System.Drawing.Color.White;
            updatePlot();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(phase))
            {
                button5.Text = "Phase-";
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button5.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                button5.Text = "Phase+";
                button5.BackColor = System.Drawing.Color.White;
                button5.ForeColor = System.Drawing.Color.Black;
            }
            phase ^= 1;
        }
    }
}
