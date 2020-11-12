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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 1;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem.ToString() == "Low Shelf" || comboBox1.SelectedItem.ToString() == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 2;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox2.Text;
            if (comboBox2.Text == "Low Shelf" || comboBox2.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 3;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox3.Text;
            if (comboBox3.Text == "Low Shelf" || comboBox3.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(3);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 4;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox4.Text;
            if (comboBox4.Text == "Low Shelf" || comboBox4.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(4);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 5;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox5.Text;
            if (comboBox5.Text == "Low Shelf" || comboBox5.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(5);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 6;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox6.Text;
            if (comboBox6.Text == "Low Shelf" || comboBox6.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(6);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 7;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox7.Text;
            if (comboBox7.Text == "Low Shelf" || comboBox7.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(7);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 8;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox8.Text;
            if (comboBox8.Text == "Low Shelf" || comboBox8.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(8);
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 9;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox9.Text;
            if (comboBox9.Text == "Low Shelf" || comboBox9.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(9);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 10;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox10.Text;
            if (comboBox10.Text == "Low Shelf" || comboBox10.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(10);
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 11;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox11.Text;
            if (comboBox11.Text == "Low Shelf" || comboBox11.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(11);
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBand = 12;
            typeValues[currentChannel - 1][currentBand - 1] = comboBox12.Text;
            if (comboBox12.Text == "Low Shelf" || comboBox12.Text == "High Shelf")
            {
                if (qValues[currentChannel - 1][currentBand - 1] > 1.30) qValues[currentChannel - 1][currentBand - 1] = 1.30;
                updateTrackbars();
            }
            generateValues(12);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            currentBand = 2;
            label20.Text = "Current EQ Band: 2";
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            currentBand = 3;
            label20.Text = "Current EQ Band: 3";
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            currentBand = 4;
            label20.Text = "Current EQ Band: 4";
        }

        private void comboBox5_DropDown(object sender, EventArgs e)
        {
            currentBand = 5;
            label20.Text = "Current EQ Band: 5";
        }

        private void comboBox6_DropDown(object sender, EventArgs e)
        {
            currentBand = 6;
            label20.Text = "Current EQ Band: 6";
        }

        private void comboBox7_DropDown(object sender, EventArgs e)
        {
            currentBand = 7;
            label20.Text = "Current EQ Band: 7";
        }

        private void comboBox8_DropDown(object sender, EventArgs e)
        {
            currentBand = 8;
            label20.Text = "Current EQ Band: 8";
        }

        private void comboBox9_DropDown(object sender, EventArgs e)
        {
            currentBand = 9;
            label20.Text = "Current EQ Band: 9";
        }

        private void comboBox10_DropDown(object sender, EventArgs e)
        {
            currentBand = 10;
            label20.Text = "Current EQ Band: 10";
        }

        private void comboBox11_DropDown(object sender, EventArgs e)
        {
            currentBand = 11;
            label20.Text = "Current EQ Band: 11";
        }

        private void comboBox12_DropDown(object sender, EventArgs e)
        {
            currentBand = 12;
            label20.Text = "Current EQ Band: 12";
        }
    }
}
