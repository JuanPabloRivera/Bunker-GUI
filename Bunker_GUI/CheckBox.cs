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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            generateResult();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[0] as LineSeries);
            if (checkBox13.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[1] as LineSeries);
            if (checkBox14.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[2] as LineSeries);
            if (checkBox15.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[3] as LineSeries);
            if (checkBox16.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[4] as LineSeries);
            if (checkBox17.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[5] as LineSeries);
            if (checkBox18.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[6] as LineSeries);
            if (checkBox19.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[7] as LineSeries);
            if (checkBox20.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[8] as LineSeries);
            if (checkBox21.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[9] as LineSeries);
            if (checkBox22.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[10] as LineSeries);
            if (checkBox23.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            var seriesToHide = (cartesianChart1.Series[11] as LineSeries);
            if (checkBox24.Checked) seriesToHide.Visibility = System.Windows.Visibility.Visible;
            else seriesToHide.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
