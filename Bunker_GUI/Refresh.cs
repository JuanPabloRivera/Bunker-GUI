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
        private void updateWidgetsPosition()
        {
            //MENU STRIP
            menuStrip1.Location = new Point(0, 0);
            //CARTESIAN CHART
            cartesianChart1.Location = new Point(padx / 2, menuStrip1.Height + pady / 2);
            //BUTTONS
            {
                button1.Location = new Point(cartesianChart1.Location.X, cartesianChart1.Location.Y + cartesianChart1.Height + pady / 2);
                button2.Location = new Point(button1.Location.X + button1.Width + padx / 2, button1.Location.Y);
                button3.Location = new Point(button2.Location.X + button2.Width + padx / 2, button1.Location.Y);
                button4.Location = new Point(button3.Location.X + button3.Width + padx / 2, button1.Location.Y);
            }
            //LABELS
            {
                label1.Location = new Point(20, pady / 2);                                                    //BAND
                label7.Location = new Point(label1.Location.X, label1.Location.Y + 11 * pady / 10);                 //1
                label8.Location = new Point(label1.Location.X, label7.Location.Y + 11 * pady / 10);                 //2
                label9.Location = new Point(label1.Location.X, label8.Location.Y + 11 * pady / 10);                 //3
                label10.Location = new Point(label1.Location.X, label9.Location.Y + 11 * pady / 10);                //4
                label11.Location = new Point(label1.Location.X, label10.Location.Y + 11 * pady / 10);               //5
                label12.Location = new Point(label1.Location.X, label11.Location.Y + 11 * pady / 10);               //6
                label13.Location = new Point(label1.Location.X, label12.Location.Y + 11 * pady / 10);               //7
                label14.Location = new Point(label1.Location.X, label13.Location.Y + 11 * pady / 10);               //8
                label15.Location = new Point(label1.Location.X, label14.Location.Y + 11 * pady / 10);               //9
                label16.Location = new Point(label1.Location.X, label15.Location.Y + 11 * pady / 10);               //10
                label17.Location = new Point(label1.Location.X, label16.Location.Y + 11 * pady / 10);               //11
                label18.Location = new Point(label1.Location.X, label17.Location.Y + 11 * pady / 10);               //12
                label20.Location = new Point(panel2.Width / 2 - label20.Width / 2, label1.Location.Y);     //EQ BAND
                label21.Location = new Point(padx, 3 * panel2.Height / 20);
                label22.Location = new Point(padx, 9 * panel2.Height / 20);
                label23.Location = new Point(padx, 15 * panel2.Height / 20);
                label24.Location = new Point(panel2.Width - (padx + label24.Width), label21.Location.Y);
                label25.Location = new Point(panel2.Width - (padx + label25.Width), label22.Location.Y);
                label26.Location = new Point(panel2.Width - (padx + label26.Width), label23.Location.Y);
                label27.Location = new Point(panel4.Width - (label27.Width + 3 * padx / 2), 2 * pady);
                label28.Location = new Point(panel4.Width - (label28.Width + 3 * padx / 2), panel4.Height - 6 * pady);
                label36.Location = new Point(padx, pady);
                label37.Location = new Point(panel2.Width / 2, pady);
                label38.Location = new Point(padx, label36.Location.Y + pady);
                label39.Location = new Point(padx, label38.Location.Y + pady);
                label40.Location = new Point(padx, label39.Location.Y + pady);
                label41.Location = new Point(label37.Location.X, label37.Location.Y + pady);
                label42.Location = new Point(label37.Location.X, label41.Location.Y + pady);
                label43.Location = new Point(label37.Location.X, label42.Location.Y + pady);
            }
            //TEXTBOX
            {
                textBox1.Location = new Point(label7.Location.X + label7.Width + padx, label7.Location.Y);
                textBox2.Location = new Point(label7.Location.X + label7.Width + padx, label8.Location.Y);
                textBox3.Location = new Point(label7.Location.X + label7.Width + padx, label9.Location.Y);
                textBox4.Location = new Point(label7.Location.X + label7.Width + padx, label10.Location.Y);
                textBox5.Location = new Point(label7.Location.X + label7.Width + padx, label11.Location.Y);
                textBox6.Location = new Point(label7.Location.X + label7.Width + padx, label12.Location.Y);
                textBox7.Location = new Point(label7.Location.X + label7.Width + padx, label13.Location.Y);
                textBox8.Location = new Point(label7.Location.X + label7.Width + padx, label14.Location.Y);
                textBox9.Location = new Point(label7.Location.X + label7.Width + padx, label15.Location.Y);
                textBox10.Location = new Point(label7.Location.X + label7.Width + padx, label16.Location.Y);
                textBox11.Location = new Point(label7.Location.X + label7.Width + padx, label17.Location.Y);
                textBox12.Location = new Point(label7.Location.X + label7.Width + padx, label18.Location.Y);

                textBox13.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label7.Location.Y);
                textBox14.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label8.Location.Y);
                textBox15.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label9.Location.Y);
                textBox16.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label10.Location.Y);
                textBox17.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label11.Location.Y);
                textBox18.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label12.Location.Y);
                textBox19.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label13.Location.Y);
                textBox20.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label14.Location.Y);
                textBox21.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label15.Location.Y);
                textBox22.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label16.Location.Y);
                textBox23.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label17.Location.Y);
                textBox24.Location = new Point(textBox1.Location.X + textBox1.Width + padx / 2, label18.Location.Y);

                textBox25.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label7.Location.Y);
                textBox26.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label8.Location.Y);
                textBox27.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label9.Location.Y);
                textBox28.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label10.Location.Y);
                textBox29.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label11.Location.Y);
                textBox30.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label12.Location.Y);
                textBox31.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label13.Location.Y);
                textBox32.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label14.Location.Y);
                textBox33.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label15.Location.Y);
                textBox34.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label16.Location.Y);
                textBox35.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label17.Location.Y);
                textBox36.Location = new Point(textBox13.Location.X + textBox13.Width + padx / 2, label18.Location.Y);
                textBox37.Location = new Point(padx, 3 * pady / 2);
                textBox38.Location = new Point(padx, panel4.Height - 2 * pady);
                textBox39.Location = new Point(label28.Location.X - padx / 4, label27.Location.Y + pady);
                textBox40.Location = new Point(label39.Location.X + label39.Width + padx, label39.Location.Y);
                textBox41.Location = new Point(textBox40.Location.X, label40.Location.Y);
                textBox42.Location = new Point(label42.Location.X + label42.Width + padx, label42.Location.Y);
                textBox43.Location = new Point(textBox42.Location.X, label43.Location.Y);
            }
            //COMBOBOX
            {
                comboBox1.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label7.Location.Y);
                comboBox2.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label8.Location.Y);
                comboBox3.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label9.Location.Y);
                comboBox4.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label10.Location.Y);
                comboBox5.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label11.Location.Y);
                comboBox6.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label12.Location.Y);
                comboBox7.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label13.Location.Y);
                comboBox8.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label14.Location.Y);
                comboBox9.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label15.Location.Y);
                comboBox10.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label16.Location.Y);
                comboBox11.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label17.Location.Y);
                comboBox12.Location = new Point(textBox25.Location.X + textBox25.Width + padx / 2, label18.Location.Y);
                comboBox13.Location = new Point(textBox39.Location.X, label28.Location.Y + pady);
                comboBox14.Location = new Point(textBox40.Location.X, label38.Location.Y);
                comboBox15.Location = new Point(textBox42.Location.X, label41.Location.Y);
            }
            //CHECKBOX
            {
                checkBox1.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label7.Location.Y);
                checkBox2.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label8.Location.Y);
                checkBox3.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label9.Location.Y);
                checkBox4.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label10.Location.Y);
                checkBox5.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label11.Location.Y);
                checkBox6.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label12.Location.Y);
                checkBox7.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label13.Location.Y);
                checkBox8.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label14.Location.Y);
                checkBox9.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label15.Location.Y);
                checkBox10.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label16.Location.Y);
                checkBox11.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label17.Location.Y);
                checkBox12.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx / 2, label18.Location.Y);

                checkBox13.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label7.Location.Y);
                checkBox14.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label8.Location.Y);
                checkBox15.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label9.Location.Y);
                checkBox16.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label10.Location.Y);
                checkBox17.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label11.Location.Y);
                checkBox18.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label12.Location.Y);
                checkBox19.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label13.Location.Y);
                checkBox20.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label14.Location.Y);
                checkBox21.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label15.Location.Y);
                checkBox22.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label16.Location.Y);
                checkBox23.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label17.Location.Y);
                checkBox24.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx / 2, label18.Location.Y);
            }
            //TRACKBARS
            {
                macTrackBar1.Location = new Point(label21.Location.X, label21.Location.Y + pady / 2);
                macTrackBar2.Location = new Point(label22.Location.X, label22.Location.Y + pady / 2);
                macTrackBar3.Location = new Point(label23.Location.X, label23.Location.Y + pady / 2);
                macTrackBar4.Location = new Point(textBox37.Location.X + textBox37.Width / 4, textBox37.Location.Y + 3 * pady / 2);
            }
            //LABELS PART2
            {
                label2.Location = new Point(textBox1.Location.X, label1.Location.Y);                                   //FREQ
                label3.Location = new Point(textBox13.Location.X, label1.Location.Y);                                  //Q VALUE
                label4.Location = new Point(textBox25.Location.X, label1.Location.Y);                                  //GAIN
                label19.Location = new Point(comboBox1.Location.X, label1.Location.Y);                                 //TYPE
                label5.Location = new Point(checkBox1.Location.X - padx, label1.Location.Y);                                  //BYPASS
                label6.Location = new Point(checkBox13.Location.X - padx / 2, label1.Location.Y);                                 //SHOW

                label29.Location = new Point(macTrackBar4.Location.X - padx, macTrackBar4.Location.Y + pady / 3);      //+15
                label30.Location = new Point(macTrackBar4.Location.X - padx, label29.Location.Y + 3 * pady / 4);           //+10
                label31.Location = new Point(macTrackBar4.Location.X - padx, label30.Location.Y + 5 * pady / 4);           //0
                label32.Location = new Point(macTrackBar4.Location.X - padx, label31.Location.Y + 6 * pady / 4);           //-10
                label33.Location = new Point(macTrackBar4.Location.X - padx, label32.Location.Y + 6 * pady / 4);           //-20
                label34.Location = new Point(macTrackBar4.Location.X - padx, label33.Location.Y + 5 * pady / 4);           //-30
                label35.Location = new Point(macTrackBar4.Location.X - padx, label34.Location.Y + 5 * pady / 4);           //-40
            }
            //PANELS
            {
                panel1.Location = new Point(cartesianChart1.Location.X, button1.Location.Y + button1.Height + pady / 2);
                panel2.Location = new Point(panel1.Location.X + panel1.Width + padx / 2, button1.Location.Y + button1.Height + pady / 2);
                panel3.Location = new Point(panel1.Location.X + panel1.Width + padx / 2, panel2.Location.Y + panel2.Height + pady / 2);
                panel4.Location = new Point(panel2.Location.X + panel2.Width + padx / 2, button1.Location.Y + button1.Height + pady / 2);
            }
            //BUTTONS PART 2
            {
                button5.Location = new Point(textBox39.Location.X, textBox39.Location.Y + pady);
            }
        }

        private void updateWidgetsSize()
        {
            //CARTESIAN CHART
            {
                cartesianChart1.Size = new Size(this.Width - 3 * padx / 2, 9 * this.Height / 20 - 2 * pady);
            }
            //PANELS
            {
                panel1.Size = new Size(4 * this.Width / 10 - padx,  this.Height / 2 - 2 * pady);
                panel2.Size = new Size(4 * this.Width / 10 - padx,  3 * this.Height / 10 - pady);
                panel3.Size = new Size(4 * this.Width / 10 - padx, this.Height / 4 - 19 * pady / 6);
                panel4.Size = new Size(2 * this.Width / 10 - padx / 2, this.Height / 2 - 2 * pady);
            }
            //TEXTBOX
            {
                textBox1.Size = new Size(padx * 3, textBox1.Height);
                textBox2.Size = new Size(padx * 3, textBox2.Height);
                textBox3.Size = new Size(padx * 3, textBox3.Height);
                textBox4.Size = new Size(padx * 3, textBox4.Height);
                textBox5.Size = new Size(padx * 3, textBox5.Height);
                textBox6.Size = new Size(padx * 3, textBox6.Height);
                textBox7.Size = new Size(padx * 3, textBox7.Height);
                textBox8.Size = new Size(padx * 3, textBox8.Height);
                textBox9.Size = new Size(padx * 3, textBox9.Height);
                textBox10.Size = new Size(padx * 3, textBox10.Height);
                textBox11.Size = new Size(padx * 3, textBox11.Height);
                textBox12.Size = new Size(padx * 3, textBox12.Height);

                textBox13.Size = new Size(padx * 2, textBox13.Height);
                textBox14.Size = new Size(padx * 2, textBox14.Height);
                textBox15.Size = new Size(padx * 2, textBox15.Height);
                textBox16.Size = new Size(padx * 2, textBox16.Height);
                textBox17.Size = new Size(padx * 2, textBox17.Height);
                textBox18.Size = new Size(padx * 2, textBox18.Height);
                textBox19.Size = new Size(padx * 2, textBox19.Height);
                textBox20.Size = new Size(padx * 2, textBox20.Height);
                textBox21.Size = new Size(padx * 2, textBox21.Height);
                textBox22.Size = new Size(padx * 2, textBox22.Height);
                textBox23.Size = new Size(padx * 2, textBox23.Height);
                textBox24.Size = new Size(padx * 2, textBox24.Height);

                textBox25.Size = new Size(padx * 3, textBox25.Height);
                textBox26.Size = new Size(padx * 3, textBox26.Height);
                textBox27.Size = new Size(padx * 3, textBox27.Height);
                textBox28.Size = new Size(padx * 3, textBox28.Height);
                textBox29.Size = new Size(padx * 3, textBox29.Height);
                textBox30.Size = new Size(padx * 3, textBox30.Height);
                textBox31.Size = new Size(padx * 3, textBox31.Height);
                textBox32.Size = new Size(padx * 3, textBox32.Height);
                textBox33.Size = new Size(padx * 3, textBox33.Height);
                textBox34.Size = new Size(padx * 3, textBox34.Height);
                textBox35.Size = new Size(padx * 3, textBox35.Height);
                textBox36.Size = new Size(padx * 3, textBox36.Height);

                textBox37.Size = new Size(padx * 3, textBox37.Height);
                textBox38.Size = new Size(padx * 2, textBox38.Height);
                textBox39.Size = new Size(padx * 3, textBox39.Height);
                textBox40.Size = new Size(padx * 3, textBox40.Height);
                textBox41.Size = new Size(padx * 3, textBox41.Height);
                textBox42.Size = new Size(padx * 3, textBox42.Height);
                textBox43.Size = new Size(padx * 3, textBox43.Height);
            }
            //COMBOBOX
            {
                comboBox1.Size = new Size(padx * 4, comboBox1.Height);
                comboBox2.Size = new Size(padx * 4, comboBox2.Height);
                comboBox3.Size = new Size(padx * 4, comboBox3.Height);
                comboBox4.Size = new Size(padx * 4, comboBox4.Height);
                comboBox5.Size = new Size(padx * 4, comboBox5.Height);
                comboBox6.Size = new Size(padx * 4, comboBox6.Height);
                comboBox7.Size = new Size(padx * 4, comboBox7.Height);
                comboBox8.Size = new Size(padx * 4, comboBox8.Height);
                comboBox9.Size = new Size(padx * 4, comboBox9.Height);
                comboBox10.Size = new Size(padx * 4, comboBox10.Height);
                comboBox11.Size = new Size(padx * 4, comboBox11.Height);
                comboBox12.Size = new Size(padx * 4, comboBox12.Height);
                comboBox13.Size = new Size(padx * 3, comboBox13.Height);
                comboBox14.Size = new Size(padx * 4, comboBox14.Height);
                comboBox15.Size = new Size(padx * 4, comboBox15.Height);
            }
            //TRACKBARS
            {
                macTrackBar1.Size = new Size((label24.Location.X + label24.Width) - label21.Location.X, macTrackBar1.Height);
                macTrackBar2.Size = new Size((label25.Location.X + label25.Width) - label22.Location.X, macTrackBar2.Height);
                macTrackBar3.Size = new Size((label26.Location.X + label26.Width) - label23.Location.X, macTrackBar3.Height);
                macTrackBar4.Size = new Size(macTrackBar4.Width, (textBox38.Location.Y - pady / 2) - macTrackBar4.Location.Y);
            }
            //BUTTONS
            {
                button1.Size = new Size(75, 35);
                button2.Size = new Size(75, 35);
                button3.Size = new Size(75, 35);
                button4.Size = new Size(75, 35);
                button5.Size = new Size(textBox39.Width, button5.Height);
            }
        }

        private void updatePlot()
        {
            for (int i = 0; i < 12; i++)
            {
                generateValues(i + 1);
                cartesianChart1.VisualElements[i].X = Math.Log10(freqValues[currentChannel - 1][i]);
                cartesianChart1.VisualElements[i].Y = gainValues[currentChannel - 1][i] + 2;
            }
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            padx = this.Width / 48;
            pady = this.Height / 34;
            updateWidgetsSize();
            updateWidgetsPosition();
        }

        private void resetTextboxColors()
        {
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.ForeColor = System.Drawing.Color.Black;
            textBox2.BackColor = System.Drawing.Color.White;
            textBox2.ForeColor = System.Drawing.Color.Black;
            textBox3.BackColor = System.Drawing.Color.White;
            textBox3.ForeColor = System.Drawing.Color.Black;
            textBox4.BackColor = System.Drawing.Color.White;
            textBox4.ForeColor = System.Drawing.Color.Black;
            textBox5.BackColor = System.Drawing.Color.White;
            textBox5.ForeColor = System.Drawing.Color.Black;
            textBox6.BackColor = System.Drawing.Color.White;
            textBox6.ForeColor = System.Drawing.Color.Black;
            textBox7.BackColor = System.Drawing.Color.White;
            textBox7.ForeColor = System.Drawing.Color.Black;
            textBox8.BackColor = System.Drawing.Color.White;
            textBox8.ForeColor = System.Drawing.Color.Black;
            textBox9.BackColor = System.Drawing.Color.White;
            textBox9.ForeColor = System.Drawing.Color.Black;
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.ForeColor = System.Drawing.Color.Black;
            textBox2.BackColor = System.Drawing.Color.White;
            textBox2.ForeColor = System.Drawing.Color.Black;
            textBox3.BackColor = System.Drawing.Color.White;
            textBox3.ForeColor = System.Drawing.Color.Black;
            textBox4.BackColor = System.Drawing.Color.White;
            textBox4.ForeColor = System.Drawing.Color.Black;
            textBox5.BackColor = System.Drawing.Color.White;
            textBox5.ForeColor = System.Drawing.Color.Black;
            textBox6.BackColor = System.Drawing.Color.White;
            textBox6.ForeColor = System.Drawing.Color.Black;
            textBox7.BackColor = System.Drawing.Color.White;
            textBox7.ForeColor = System.Drawing.Color.Black;
            textBox8.BackColor = System.Drawing.Color.White;
            textBox8.ForeColor = System.Drawing.Color.Black;
            textBox9.BackColor = System.Drawing.Color.White;
            textBox9.ForeColor = System.Drawing.Color.Black;
            textBox10.BackColor = System.Drawing.Color.White;
            textBox10.ForeColor = System.Drawing.Color.Black;
            textBox11.BackColor = System.Drawing.Color.White;
            textBox11.ForeColor = System.Drawing.Color.Black;
            textBox12.BackColor = System.Drawing.Color.White;
            textBox12.ForeColor = System.Drawing.Color.Black;
            textBox13.BackColor = System.Drawing.Color.White;
            textBox13.ForeColor = System.Drawing.Color.Black;
            textBox14.BackColor = System.Drawing.Color.White;
            textBox14.ForeColor = System.Drawing.Color.Black;
            textBox15.BackColor = System.Drawing.Color.White;
            textBox15.ForeColor = System.Drawing.Color.Black;
            textBox16.BackColor = System.Drawing.Color.White;
            textBox16.ForeColor = System.Drawing.Color.Black;
            textBox17.BackColor = System.Drawing.Color.White;
            textBox17.ForeColor = System.Drawing.Color.Black;
            textBox18.BackColor = System.Drawing.Color.White;
            textBox18.ForeColor = System.Drawing.Color.Black;
            textBox19.BackColor = System.Drawing.Color.White;
            textBox19.ForeColor = System.Drawing.Color.Black;
            textBox20.BackColor = System.Drawing.Color.White;
            textBox20.ForeColor = System.Drawing.Color.Black;
            textBox21.BackColor = System.Drawing.Color.White;
            textBox21.ForeColor = System.Drawing.Color.Black;
            textBox22.BackColor = System.Drawing.Color.White;
            textBox22.ForeColor = System.Drawing.Color.Black;
            textBox23.BackColor = System.Drawing.Color.White;
            textBox23.ForeColor = System.Drawing.Color.Black;
            textBox24.BackColor = System.Drawing.Color.White;
            textBox24.ForeColor = System.Drawing.Color.Black;
            textBox25.BackColor = System.Drawing.Color.White;
            textBox25.ForeColor = System.Drawing.Color.Black;
            textBox26.BackColor = System.Drawing.Color.White;
            textBox26.ForeColor = System.Drawing.Color.Black;
            textBox27.BackColor = System.Drawing.Color.White;
            textBox27.ForeColor = System.Drawing.Color.Black;
            textBox28.BackColor = System.Drawing.Color.White;
            textBox28.ForeColor = System.Drawing.Color.Black;
            textBox29.BackColor = System.Drawing.Color.White;
            textBox29.ForeColor = System.Drawing.Color.Black;
            textBox30.BackColor = System.Drawing.Color.White;
            textBox30.ForeColor = System.Drawing.Color.Black;
            textBox31.BackColor = System.Drawing.Color.White;
            textBox31.ForeColor = System.Drawing.Color.Black;
            textBox32.BackColor = System.Drawing.Color.White;
            textBox32.ForeColor = System.Drawing.Color.Black;
            textBox33.BackColor = System.Drawing.Color.White;
            textBox33.ForeColor = System.Drawing.Color.Black;
            textBox34.BackColor = System.Drawing.Color.White;
            textBox34.ForeColor = System.Drawing.Color.Black;
            textBox35.BackColor = System.Drawing.Color.White;
            textBox35.ForeColor = System.Drawing.Color.Black;
            textBox36.BackColor = System.Drawing.Color.White;
            textBox36.ForeColor = System.Drawing.Color.Black;
            textBox38.BackColor = System.Drawing.Color.White;
            textBox38.ForeColor = System.Drawing.Color.Black;
            textBox39.BackColor = System.Drawing.Color.White;
            textBox39.ForeColor = System.Drawing.Color.Black;
            textBox40.BackColor = System.Drawing.Color.White;
            textBox40.ForeColor = System.Drawing.Color.Black;
            textBox42.BackColor = System.Drawing.Color.White;
            textBox42.ForeColor = System.Drawing.Color.Black;
        }

        private void resetButtonColors()
        {
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
            button3.BackColor = System.Drawing.Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
        }

        private void updateTrackbars()
        {
            macTrackBar1.Value = Array.IndexOf(centralFreq, freqValues[currentChannel - 1][currentBand - 1]);
            macTrackBar2.Value = Array.IndexOf(centralQ, qValues[currentChannel - 1][currentBand - 1]);
            macTrackBar3.Value = Array.IndexOf(centralGain, gainValues[currentChannel - 1][currentBand - 1]);
            macTrackBar4.Value = Array.IndexOf(centralVol, volValues[currentChannel - 1]) + 1;
        }

        private void updateBoxes()
        {
            textBox1.Text = freqValues[currentChannel - 1][0].ToString();
            textBox2.Text = freqValues[currentChannel - 1][1].ToString();
            textBox3.Text = freqValues[currentChannel - 1][2].ToString();
            textBox4.Text = freqValues[currentChannel - 1][3].ToString();
            textBox5.Text = freqValues[currentChannel - 1][4].ToString();
            textBox6.Text = freqValues[currentChannel - 1][5].ToString();
            textBox7.Text = freqValues[currentChannel - 1][6].ToString();
            textBox8.Text = freqValues[currentChannel - 1][7].ToString();
            textBox9.Text = freqValues[currentChannel - 1][8].ToString();
            textBox10.Text = freqValues[currentChannel - 1][9].ToString();
            textBox11.Text = freqValues[currentChannel - 1][10].ToString();
            textBox12.Text = freqValues[currentChannel - 1][11].ToString();
            textBox13.Text = qValues[currentChannel - 1][0].ToString();
            textBox14.Text = qValues[currentChannel - 1][1].ToString();
            textBox15.Text = qValues[currentChannel - 1][2].ToString();
            textBox16.Text = qValues[currentChannel - 1][3].ToString();
            textBox17.Text = qValues[currentChannel - 1][4].ToString();
            textBox18.Text = qValues[currentChannel - 1][5].ToString();
            textBox19.Text = qValues[currentChannel - 1][6].ToString();
            textBox20.Text = qValues[currentChannel - 1][7].ToString();
            textBox21.Text = qValues[currentChannel - 1][8].ToString();
            textBox22.Text = qValues[currentChannel - 1][9].ToString();
            textBox23.Text = qValues[currentChannel - 1][10].ToString();
            textBox24.Text = qValues[currentChannel - 1][11].ToString();
            textBox25.Text = gainValues[currentChannel - 1][0].ToString();
            textBox26.Text = gainValues[currentChannel - 1][1].ToString();
            textBox27.Text = gainValues[currentChannel - 1][2].ToString();
            textBox28.Text = gainValues[currentChannel - 1][3].ToString();
            textBox29.Text = gainValues[currentChannel - 1][4].ToString();
            textBox30.Text = gainValues[currentChannel - 1][5].ToString();
            textBox31.Text = gainValues[currentChannel - 1][6].ToString();
            textBox32.Text = gainValues[currentChannel - 1][7].ToString();
            textBox33.Text = gainValues[currentChannel - 1][8].ToString();
            textBox34.Text = gainValues[currentChannel - 1][9].ToString();
            textBox35.Text = gainValues[currentChannel - 1][10].ToString();
            textBox36.Text = gainValues[currentChannel - 1][11].ToString();
            textBox38.Text = volValues[currentChannel - 1].ToString();
            textBox39.Text = delayValues[currentChannel - 1].ToString();
            comboBox1.SelectedItem = typeValues[currentChannel - 1][0];
            comboBox2.SelectedItem = typeValues[currentChannel - 1][1];
            comboBox3.SelectedItem = typeValues[currentChannel - 1][2];
            comboBox4.SelectedItem = typeValues[currentChannel - 1][3];
            comboBox5.SelectedItem = typeValues[currentChannel - 1][4];
            comboBox6.SelectedItem = typeValues[currentChannel - 1][5];
            comboBox7.SelectedItem = typeValues[currentChannel - 1][6];
            comboBox8.SelectedItem = typeValues[currentChannel - 1][7];
            comboBox9.SelectedItem = typeValues[currentChannel - 1][8];
            comboBox10.SelectedItem = typeValues[currentChannel - 1][9];
            comboBox11.SelectedItem = typeValues[currentChannel - 1][10];
            comboBox12.SelectedItem = typeValues[currentChannel - 1][11];
        }

        private double findClosestValue(double value, char c)
        {
            double[] container;
            switch (c)
            {
                case 'f':    //frequency
                    container = centralFreq;
                    break;
                case 'q':    //q value
                    container = centralQ;
                    break;
                case 'g':    //gain value
                    container = centralGain;
                    break;
                case 'v':    //volume
                    container = centralVol;
                    break;
                case 'd':    //delay
                    container = centralDelay;
                    break;
                default:
                    container = new double[] { 0 };
                    break;
            }
            double min = container[0], max = container[container.Length - 1], result = 0;
            for (int i = 0; i < container.Length; i++)
            {
                if (value == container[i]) return container[i];
                if (value < container[i]) { max = container[i]; break; }
                else min = container[i];
            }
            result = (Math.Abs(max - value) < Math.Abs(min - value)) ? max : min;
            return result;
        }

        private void updateProgram(int band = 1, int channel = 1)
        {
            currentChannel = channel;
            label20.Text = "Current EQ Band: " + band.ToString();
            textBox37.Text = "CH " + channel.ToString();
            resetButtonColors();
            updateBoxes();
            updatePlot();
            currentBand = band;
            updateTrackbars();
        }
    }
}
