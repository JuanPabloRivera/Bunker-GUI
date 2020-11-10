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
        private bool notEnter = true;

        //TEXTBOX 1
        private void textBox1_Click(object sender, EventArgs e)
        {
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            resetTextboxColors();
            textBox1.BackColor = System.Drawing.Color.SteelBlue;
            textBox1.ForeColor = System.Drawing.Color.White;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox1.Text != "" && textBox1.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox1.Text), 'f');
                    textBox1.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox1.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox1.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 2
        private void textBox2_Click(object sender, EventArgs e)
        {
            currentBand = 2;
            label20.Text = "Current EQ Band: 2";
            updateTrackbars();
            resetTextboxColors();
            textBox2.BackColor = System.Drawing.Color.SteelBlue;
            textBox2.ForeColor = System.Drawing.Color.White;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox2.Text != "" && textBox2.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox2.Text), 'f');
                    textBox2.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox2.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox2.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 3
        private void textBox3_Click(object sender, EventArgs e)
        {
            currentBand = 3;
            label20.Text = "Current EQ Band: 3";
            updateTrackbars();
            resetTextboxColors();
            textBox3.BackColor = System.Drawing.Color.SteelBlue;
            textBox3.ForeColor = System.Drawing.Color.White;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox3.Text != "" && textBox3.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox3.Text), 'f');
                    textBox3.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox3.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox3.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 4
        private void textBox4_Click(object sender, EventArgs e)
        {
            currentBand = 4;
            label20.Text = "Current EQ Band: 4";
            updateTrackbars();
            resetTextboxColors();
            textBox4.BackColor = System.Drawing.Color.SteelBlue;
            textBox4.ForeColor = System.Drawing.Color.White;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox4.Text != "" && textBox4.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox4.Text), 'f');
                    textBox4.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox4.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox4.Text = textBox4.Text.Substring(0, textBox4.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox4.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 5
        private void textBox5_Click(object sender, EventArgs e)
        {
            currentBand = 5;
            label20.Text = "Current EQ Band: 5";
            updateTrackbars();
            resetTextboxColors();
            textBox5.BackColor = System.Drawing.Color.SteelBlue;
            textBox5.ForeColor = System.Drawing.Color.White;
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox5.Text != "" && textBox5.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox5.Text), 'f');
                    textBox5.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox5.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox5.Text = textBox5.Text.Substring(0, textBox5.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox5.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 6
        private void textBox6_Click(object sender, EventArgs e)
        {
            currentBand = 6;
            label20.Text = "Current EQ Band: 6";
            updateTrackbars();
            resetTextboxColors();
            textBox6.BackColor = System.Drawing.Color.SteelBlue;
            textBox6.ForeColor = System.Drawing.Color.White;
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox6.Text != "" && textBox6.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox6.Text), 'f');
                    textBox6.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox6.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox6.Text = textBox6.Text.Substring(0, textBox6.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox6.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 7
        private void textBox7_Click(object sender, EventArgs e)
        {
            currentBand = 7;
            label20.Text = "Current EQ Band: 7";
            updateTrackbars();
            resetTextboxColors();
            textBox7.BackColor = System.Drawing.Color.SteelBlue;
            textBox7.ForeColor = System.Drawing.Color.White;
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox7.Text != "" && textBox7.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox7.Text), 'f');
                    textBox7.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox7.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox7.Text = textBox7.Text.Substring(0, textBox7.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox7.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 8
        private void textBox8_Click(object sender, EventArgs e)
        {
            currentBand = 8;
            label20.Text = "Current EQ Band: 8";
            updateTrackbars();
            resetTextboxColors();
            textBox8.BackColor = System.Drawing.Color.SteelBlue;
            textBox8.ForeColor = System.Drawing.Color.White;
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox8.Text != "" && textBox8.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox8.Text), 'f');
                    textBox8.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox8.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox8.Text = textBox8.Text.Substring(0, textBox8.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox8.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 9
        private void textBox9_Click(object sender, EventArgs e)
        {
            currentBand = 9;
            label20.Text = "Current EQ Band: 9";
            updateTrackbars();
            resetTextboxColors();
            textBox9.BackColor = System.Drawing.Color.SteelBlue;
            textBox9.ForeColor = System.Drawing.Color.White;
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox9.Text != "" && textBox9.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox9.Text), 'f');
                    textBox9.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox9.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox9.Text = textBox9.Text.Substring(0, textBox9.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox9.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 10
        private void textBox10_Click(object sender, EventArgs e)
        {
            currentBand = 10;
            label20.Text = "Current EQ Band: 10";
            updateTrackbars();
            resetTextboxColors();
            textBox10.BackColor = System.Drawing.Color.SteelBlue;
            textBox10.ForeColor = System.Drawing.Color.White;
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox10.Text != "" && textBox10.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox10.Text), 'f');
                    textBox10.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox10.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox10.Text = textBox10.Text.Substring(0, textBox10.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox10.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 11
        private void textBox11_Click(object sender, EventArgs e)
        {
            currentBand = 11;
            label20.Text = "Current EQ Band: 11";
            updateTrackbars();
            resetTextboxColors();
            textBox11.BackColor = System.Drawing.Color.SteelBlue;
            textBox11.ForeColor = System.Drawing.Color.White;
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox11.Text != "" && textBox11.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox11.Text), 'f');
                    textBox11.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox11.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox11.Text = textBox11.Text.Substring(0, textBox11.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox11.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 12
        private void textBox12_Click(object sender, EventArgs e)
        {
            currentBand = 12;
            label20.Text = "Current EQ Band: 12";
            updateTrackbars();
            resetTextboxColors();
            textBox12.BackColor = System.Drawing.Color.SteelBlue;
            textBox12.ForeColor = System.Drawing.Color.White;
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox12.Text != "" && textBox12.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox12.Text), 'f');
                    textBox12.Text = closest.ToString();
                    freqValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox12.Text = freqValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar1.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar1.Value++;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox12.Text = textBox12.Text.Substring(0, textBox12.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox12.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 13
        private void textBox13_Click(object sender, EventArgs e)
        {
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            resetTextboxColors();
            textBox13.BackColor = System.Drawing.Color.SteelBlue;
            textBox13.ForeColor = System.Drawing.Color.White;
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox13.Text != "" && textBox13.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox13.Text), 'q');
                    textBox13.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox13.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox13.Text = textBox13.Text.Substring(0, textBox13.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox13.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 14
        private void textBox14_Click(object sender, EventArgs e)
        {
            currentBand = 2;
            label20.Text = "Current EQ Band: 2";
            updateTrackbars();
            resetTextboxColors();
            textBox14.BackColor = System.Drawing.Color.SteelBlue;
            textBox14.ForeColor = System.Drawing.Color.White;
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox14.Text != "" && textBox14.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox14.Text), 'q');
                    textBox14.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox14.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox14.Text = textBox14.Text.Substring(0, textBox14.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox14.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 15
        private void textBox15_Click(object sender, EventArgs e)
        {
            currentBand = 3;
            label20.Text = "Current EQ Band: 3";
            updateTrackbars();
            resetTextboxColors();
            textBox15.BackColor = System.Drawing.Color.SteelBlue;
            textBox15.ForeColor = System.Drawing.Color.White;
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox15.Text != "" && textBox15.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox15.Text), 'q');
                    textBox15.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox15.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox15.Text = textBox15.Text.Substring(0, textBox15.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox15.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 16
        private void textBox16_Click(object sender, EventArgs e)
        {
            currentBand = 4;
            label20.Text = "Current EQ Band: 4";
            updateTrackbars();
            resetTextboxColors();
            textBox16.BackColor = System.Drawing.Color.SteelBlue;
            textBox16.ForeColor = System.Drawing.Color.White;
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox16.Text != "" && textBox16.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox16.Text), 'q');
                    textBox16.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox16.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox16.Text = textBox16.Text.Substring(0, textBox16.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox16.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 17
        private void textBox17_Click(object sender, EventArgs e)
        {
            currentBand = 5;
            label20.Text = "Current EQ Band: 5";
            updateTrackbars();
            resetTextboxColors();
            textBox17.BackColor = System.Drawing.Color.SteelBlue;
            textBox17.ForeColor = System.Drawing.Color.White;
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox17.Text != "" && textBox17.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox17.Text), 'q');
                    textBox17.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox17.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox17.Text = textBox17.Text.Substring(0, textBox17.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox17.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 18
        private void textBox18_Click(object sender, EventArgs e)
        {
            currentBand = 6;
            label20.Text = "Current EQ Band: 6";
            updateTrackbars();
            resetTextboxColors();
            textBox18.BackColor = System.Drawing.Color.SteelBlue;
            textBox18.ForeColor = System.Drawing.Color.White;
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox18.Text != "" && textBox18.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox18.Text), 'q');
                    textBox18.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox18.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox18.Text = textBox18.Text.Substring(0, textBox18.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox18.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 19
        private void textBox19_Click(object sender, EventArgs e)
        {
            currentBand = 7;
            label20.Text = "Current EQ Band: 7";
            updateTrackbars();
            resetTextboxColors();
            textBox19.BackColor = System.Drawing.Color.SteelBlue;
            textBox19.ForeColor = System.Drawing.Color.White;
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox19.Text != "" && textBox19.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox19.Text), 'q');
                    textBox19.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox19.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox19.Text = textBox19.Text.Substring(0, textBox19.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox19.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 20
        private void textBox20_Click(object sender, EventArgs e)
        {
            currentBand = 8;
            label20.Text = "Current EQ Band: 8";
            updateTrackbars();
            resetTextboxColors();
            textBox20.BackColor = System.Drawing.Color.SteelBlue;
            textBox20.ForeColor = System.Drawing.Color.White;
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox20.Text != "" && textBox20.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox20.Text), 'q');
                    textBox20.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox20.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox20.Text = textBox20.Text.Substring(0, textBox20.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox20.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 21
        private void textBox21_Click(object sender, EventArgs e)
        {
            currentBand = 9;
            label20.Text = "Current EQ Band: 9";
            updateTrackbars();
            resetTextboxColors();
            textBox21.BackColor = System.Drawing.Color.SteelBlue;
            textBox21.ForeColor = System.Drawing.Color.White;
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox21.Text != "" && textBox21.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox21.Text), 'q');
                    textBox21.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox21.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox21.Text = textBox21.Text.Substring(0, textBox21.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox21.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 22
        private void textBox22_Click(object sender, EventArgs e)
        {
            currentBand = 10;
            label20.Text = "Current EQ Band: 10";
            updateTrackbars();
            resetTextboxColors();
            textBox22.BackColor = System.Drawing.Color.SteelBlue;
            textBox22.ForeColor = System.Drawing.Color.White;
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox22.Text != "" && textBox22.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox22.Text), 'q');
                    textBox22.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox22.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox22.Text = textBox22.Text.Substring(0, textBox22.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox22.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 23
        private void textBox23_Click(object sender, EventArgs e)
        {
            currentBand = 11;
            label20.Text = "Current EQ Band: 11";
            updateTrackbars();
            resetTextboxColors();
            textBox23.BackColor = System.Drawing.Color.SteelBlue;
            textBox23.ForeColor = System.Drawing.Color.White;
        }

        private void textBox23_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox23.Text != "" && textBox23.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox23.Text), 'q');
                    textBox23.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox23.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox23.Text = textBox23.Text.Substring(0, textBox23.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox23.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 24
        private void textBox24_Click(object sender, EventArgs e)
        {
            currentBand = 12;
            label20.Text = "Current EQ Band: 12";
            updateTrackbars();
            resetTextboxColors();
            textBox24.BackColor = System.Drawing.Color.SteelBlue;
            textBox24.ForeColor = System.Drawing.Color.White;
        }

        private void textBox24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox24.Text != "" && textBox24.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox24.Text), 'q');
                    textBox24.Text = closest.ToString();
                    qValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox24.Text = qValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar2.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar2.Value++;
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox24.Text = textBox24.Text.Substring(0, textBox24.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox24.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 25
        private void textBox25_Click(object sender, EventArgs e)
        {
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            resetTextboxColors();
            textBox25.BackColor = System.Drawing.Color.SteelBlue;
            textBox25.ForeColor = System.Drawing.Color.White;
        }

        private void textBox25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox25.Text != "" && textBox25.Text != "." && textBox25.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox25.Text), 'g');
                    textBox25.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox25.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox25.Text = textBox25.Text.Substring(0, textBox25.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox25.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox25.Text.Any(ch => ch == '-') || (textBox25.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 26
        private void textBox26_Click(object sender, EventArgs e)
        {
            currentBand = 2;
            label20.Text = "Current EQ Band: 2";
            updateTrackbars();
            resetTextboxColors();
            textBox26.BackColor = System.Drawing.Color.SteelBlue;
            textBox26.ForeColor = System.Drawing.Color.White;
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox26.Text != "" && textBox26.Text != "." && textBox26.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox26.Text), 'g');
                    textBox26.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox26.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox26.Text = textBox26.Text.Substring(0, textBox26.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox26.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox26.Text.Any(ch => ch == '-') || (textBox26.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 27
        private void textBox27_Click(object sender, EventArgs e)
        {
            currentBand = 3;
            label20.Text = "Current EQ Band: 3";
            updateTrackbars();
            resetTextboxColors();
            textBox27.BackColor = System.Drawing.Color.SteelBlue;
            textBox27.ForeColor = System.Drawing.Color.White;
        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox27.Text != "" && textBox27.Text != "." && textBox27.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox27.Text), 'g');
                    textBox27.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox27.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox27.Text = textBox27.Text.Substring(0, textBox27.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox27.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox27.Text.Any(ch => ch == '-') || (textBox27.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 28
        private void textBox28_Click(object sender, EventArgs e)
        {
            currentBand = 4;
            label20.Text = "Current EQ Band: 4";
            updateTrackbars();
            resetTextboxColors();
            textBox28.BackColor = System.Drawing.Color.SteelBlue;
            textBox28.ForeColor = System.Drawing.Color.White;
        }

        private void textBox28_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox28.Text != "" && textBox28.Text != "." && textBox28.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox28.Text), 'g');
                    textBox28.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox28.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox28.Text = textBox28.Text.Substring(0, textBox28.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox28.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox28.Text.Any(ch => ch == '-') || (textBox28.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 29
        private void textBox29_Click(object sender, EventArgs e)
        {
            currentBand = 5;
            label20.Text = "Current EQ Band: 5";
            updateTrackbars();
            resetTextboxColors();
            textBox29.BackColor = System.Drawing.Color.SteelBlue;
            textBox29.ForeColor = System.Drawing.Color.White;
        }

        private void textBox29_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox29.Text != "" && textBox29.Text != "." && textBox29.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox29.Text), 'g');
                    textBox29.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox29.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox29.Text = textBox29.Text.Substring(0, textBox29.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox29.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox29.Text.Any(ch => ch == '-') || (textBox29.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 30
        private void textBox30_Click(object sender, EventArgs e)
        {
            currentBand = 6;
            label20.Text = "Current EQ Band: 6";
            updateTrackbars();
            resetTextboxColors();
            textBox30.BackColor = System.Drawing.Color.SteelBlue;
            textBox30.ForeColor = System.Drawing.Color.White;
        }

        private void textBox30_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox30.Text != "" && textBox30.Text != "." && textBox30.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox30.Text), 'g');
                    textBox30.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox30.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox30.Text = textBox30.Text.Substring(0, textBox30.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox30.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox30.Text.Any(ch => ch == '-') || (textBox30.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 31
        private void textBox31_Click(object sender, EventArgs e)
        {
            currentBand = 7;
            label20.Text = "Current EQ Band: 7";
            updateTrackbars();
            resetTextboxColors();
            textBox31.BackColor = System.Drawing.Color.SteelBlue;
            textBox31.ForeColor = System.Drawing.Color.White;
        }

        private void textBox31_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox31.Text != "" && textBox31.Text != "." && textBox31.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox31.Text), 'g');
                    textBox31.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox31.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox31.Text = textBox31.Text.Substring(0, textBox31.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox31.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox31.Text.Any(ch => ch == '-') || (textBox31.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 32
        private void textBox32_Click(object sender, EventArgs e)
        {
            currentBand = 8;
            label20.Text = "Current EQ Band: 8";
            updateTrackbars();
            resetTextboxColors();
            textBox32.BackColor = System.Drawing.Color.SteelBlue;
            textBox32.ForeColor = System.Drawing.Color.White;
        }

        private void textBox32_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox32.Text != "" && textBox32.Text != "." && textBox32.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox32.Text), 'g');
                    textBox32.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox32.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox32.Text = textBox32.Text.Substring(0, textBox32.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox32.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox32.Text.Any(ch => ch == '-') || (textBox32.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 33
        private void textBox33_Click(object sender, EventArgs e)
        {
            currentBand = 9;
            label20.Text = "Current EQ Band: 9";
            updateTrackbars();
            resetTextboxColors();
            textBox33.BackColor = System.Drawing.Color.SteelBlue;
            textBox33.ForeColor = System.Drawing.Color.White;
        }

        private void textBox33_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox33.Text != "" && textBox33.Text != "." && textBox33.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox33.Text), 'g');
                    textBox33.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox33.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox33.Text = textBox33.Text.Substring(0, textBox33.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox33.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox33.Text.Any(ch => ch == '-') || (textBox33.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 34
        private void textBox34_Click(object sender, EventArgs e)
        {
            currentBand = 10;
            label20.Text = "Current EQ Band: 10";
            updateTrackbars();
            resetTextboxColors();
            textBox34.BackColor = System.Drawing.Color.SteelBlue;
            textBox34.ForeColor = System.Drawing.Color.White;
        }

        private void textBox34_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox34.Text != "" && textBox34.Text != "." && textBox34.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox34.Text), 'g');
                    textBox34.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox34.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox34.Text = textBox34.Text.Substring(0, textBox34.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox34.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox34.Text.Any(ch => ch == '-') || (textBox34.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 35
        private void textBox35_Click(object sender, EventArgs e)
        {
            currentBand = 11;
            label20.Text = "Current EQ Band: 11";
            updateTrackbars();
            resetTextboxColors();
            textBox35.BackColor = System.Drawing.Color.SteelBlue;
            textBox35.ForeColor = System.Drawing.Color.White;
        }

        private void textBox35_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox35.Text != "" && textBox35.Text != "." && textBox35.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox35.Text), 'g');
                    textBox35.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox35.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox35.Text = textBox35.Text.Substring(0, textBox35.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox35.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox35.Text.Any(ch => ch == '-') || (textBox35.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 36
        private void textBox36_Click(object sender, EventArgs e)
        {
            currentBand = 12;
            label20.Text = "Current EQ Band: 12";
            updateTrackbars();
            resetTextboxColors();
            textBox36.BackColor = System.Drawing.Color.SteelBlue;
            textBox36.ForeColor = System.Drawing.Color.White;
        }

        private void textBox36_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox36.Text != "" && textBox36.Text != "." && textBox36.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox36.Text), 'g');
                    textBox36.Text = closest.ToString();
                    gainValues[currentChannel - 1][currentBand - 1] = closest;
                    updateTrackbars();
                }
                else textBox36.Text = gainValues[currentChannel - 1][currentBand - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar3.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar3.Value++;
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox36.Text = textBox36.Text.Substring(0, textBox36.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox36.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox36.Text.Any(ch => ch == '-') || (textBox36.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 38
        private void textBox38_Click(object sender, EventArgs e)
        {
            resetTextboxColors();
            textBox38.BackColor = System.Drawing.Color.SteelBlue;
            textBox38.ForeColor = System.Drawing.Color.White;
        }

        private void textBox38_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox38.Text != "" && textBox38.Text != "." && textBox38.Text != "-")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox38.Text), 'v');
                    textBox38.Text = closest.ToString();
                    volValues[currentChannel - 1] = closest;
                    updateTrackbars();
                }
                else textBox38.Text = volValues[currentChannel - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left) macTrackBar4.Value--;
            else if (e.KeyCode == Keys.Right) macTrackBar4.Value++;
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox38.Text = textBox38.Text.Substring(0, textBox38.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox38.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
                else if (e.KeyChar == '-')
                {
                    if (textBox38.Text.Any(ch => ch == '-') || (textBox38.Text != "")) e.Handled = true;    //if there's already a line or string isn't empty
                }
            }
            notEnter = true;
        }

        //TEXTBOX 39
        private void textBox39_Click(object sender, EventArgs e)
        {
            resetTextboxColors();
            textBox39.BackColor = System.Drawing.Color.SteelBlue;
            textBox39.ForeColor = System.Drawing.Color.White;
        }

        private void textBox39_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                notEnter = false;
                if (textBox39.Text != "" && textBox39.Text != ".")
                {
                    double closest = findClosestValue(Convert.ToDouble(textBox39.Text), 'd');
                    textBox39.Text = closest.ToString();
                    delayValues[currentChannel - 1] = closest;
                }
                else textBox39.Text = delayValues[currentChannel - 1].ToString();
            }
            else if (e.KeyCode == Keys.Left)
            {
                int index = Array.IndexOf(centralDelay, Convert.ToDouble(textBox39.Text)) - 1;
                if (index >= 0)
                {
                    delayValues[currentChannel - 1] = centralDelay[index];
                    textBox39.Text = centralDelay[index].ToString();
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                int index = Array.IndexOf(centralDelay, Convert.ToDouble(textBox39.Text)) + 1;
                if (index < centralDelay.Length)
                {
                    delayValues[currentChannel - 1] = centralDelay[index];
                    textBox39.Text = centralDelay[index].ToString();
                }
            }
        }

        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notEnter)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;      //if user presses letters or symbols
                else if (e.KeyChar == '\r') textBox39.Text = textBox39.Text.Substring(0, textBox39.Text.Length - 1);
                else if (e.KeyChar == '.')
                {
                    if (textBox39.Text.Any(ch => ch == '.')) e.Handled = true;    //if there's already a point
                }
            }
            notEnter = true;
        }

        //TEXTBOX 40
        private void textBox40_Click(object sender, EventArgs e)
        {
            resetTextboxColors();
            textBox40.BackColor = System.Drawing.Color.SteelBlue;
            textBox40.ForeColor = System.Drawing.Color.White;
        }

        //TEXTBOX 42
        private void textBox42_Click(object sender, EventArgs e)
        {
            resetTextboxColors();
            textBox42.BackColor = System.Drawing.Color.SteelBlue;
            textBox42.ForeColor = System.Drawing.Color.White;
        }
    }
}
