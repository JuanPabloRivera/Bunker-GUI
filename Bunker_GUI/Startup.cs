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
        private void initializeValues()
        {
            for (int i = 0; i < 3; i++)
            {
                freqValues[i][0] = 21.7;
                freqValues[i][1] = 38.6;
                freqValues[i][2] = 68.8;
                freqValues[i][3] = 123.0;
                freqValues[i][4] = 218.0;
                freqValues[i][5] = 389.0;
                freqValues[i][6] = 694.0;
                freqValues[i][7] = 1240.0;
                freqValues[i][8] = 2200.0;
                freqValues[i][9] = 3920.0;
                freqValues[i][10] = 6990.0;
                freqValues[i][11] = 12500.0;
                volValues[i] = 0.00;
                delayValues[i] = 0.00;

                for (int j = 0; j < 12; j++)
                {
                    qValues[i][j] = 4.00;
                    gainValues[i][j] = 0.00;
                    typeValues[i][j] = "Parametric";

                    for (int k = 0; k < plotFrequencies.Length; k++)
                    {
                        ObservablePoint point = new ObservablePoint(plotFrequencies[k], 0);
                        channelPoints[k] = point;
                    }
                    plotValues[j].AddRange(channelPoints);
                }
            }
        }

        private void initializeWidgets()
        {
            //CARTESIAN CHART
            {
                cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(35, 35, 35));
                cartesianChart1.DisableAnimations = true;
                cartesianChart1.Hoverable = false;
                cartesianChart1.DataTooltip = null;
            }
            //LABELS
            {
                label1.Text = "Band";
                label1.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label1.BackColor = System.Drawing.Color.Transparent;
                label2.Text = "Freq (Hz)";
                label2.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label2.BackColor = System.Drawing.Color.Transparent;
                label2.Location = new Point(4 * padx, pady);
                label3.Text = "Q Value";
                label3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label3.BackColor = System.Drawing.Color.Transparent;
                label3.Location = new Point(8 * padx, pady);
                label4.Text = "Gain (dB)";
                label4.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label4.BackColor = System.Drawing.Color.Transparent;
                label5.Text = "Bypass";
                label5.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label5.BackColor = System.Drawing.Color.Transparent;
                label6.Text = "Show";
                label6.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label6.BackColor = System.Drawing.Color.Transparent;
                label7.Text = "1";
                label7.BackColor = System.Drawing.Color.Transparent;
                label8.Text = "2";
                label8.BackColor = System.Drawing.Color.Transparent;
                label9.Text = "3";
                label9.BackColor = System.Drawing.Color.Transparent;
                label10.Text = "4";
                label10.BackColor = System.Drawing.Color.Transparent;
                label11.Text = "5";
                label11.BackColor = System.Drawing.Color.Transparent;
                label12.Text = "6";
                label12.BackColor = System.Drawing.Color.Transparent;
                label13.Text = "7";
                label13.BackColor = System.Drawing.Color.Transparent;
                label14.Text = "8";
                label14.BackColor = System.Drawing.Color.Transparent;
                label15.Text = "9";
                label15.BackColor = System.Drawing.Color.Transparent;
                label16.Text = "10";
                label16.BackColor = System.Drawing.Color.Transparent;
                label17.Text = "11";
                label17.BackColor = System.Drawing.Color.Transparent;
                label18.Text = "12";
                label18.BackColor = System.Drawing.Color.Transparent;
                label19.Text = "Type";
                label19.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label19.BackColor = System.Drawing.Color.Transparent;
                label20.Text = "Current EQ Band: 1";
                label20.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label20.BackColor = System.Drawing.Color.Transparent;
                label21.Text = "Frequency (Hz)";
                label21.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label21.BackColor = System.Drawing.Color.Transparent;
                label22.Text = "Q Value";
                label22.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label22.BackColor = System.Drawing.Color.Transparent;
                label23.Text = "Gain (dB)";
                label23.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label23.BackColor = System.Drawing.Color.Transparent;
                label24.Text = "0.00";
                label24.BackColor = System.Drawing.Color.Transparent;
                label25.Text = "0.00";
                label25.BackColor = System.Drawing.Color.Transparent;
                label26.Text = "0.00";
                label26.BackColor = System.Drawing.Color.Transparent;
                label27.Text = "Delay (ms)";
                label27.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label27.BackColor = System.Drawing.Color.Transparent;
                label28.Text = "VPL SET";
                label28.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label28.BackColor = System.Drawing.Color.Transparent;
                label29.Text = "+15";
                label29.BackColor = System.Drawing.Color.Transparent;
                label30.Text = "+10";
                label30.BackColor = System.Drawing.Color.Transparent;
                label31.Text = "0";
                label31.BackColor = System.Drawing.Color.Transparent;
                label32.Text = "-10";
                label32.BackColor = System.Drawing.Color.Transparent;
                label33.Text = "-20";
                label33.BackColor = System.Drawing.Color.Transparent;
                label34.Text = "-30";
                label34.BackColor = System.Drawing.Color.Transparent;
                label35.Text = "-40";
                label35.BackColor = System.Drawing.Color.Transparent;
                label36.Text = "High Pass";
                label36.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label36.BackColor = System.Drawing.Color.Transparent;
                label37.Text = "Low Pass";
                label37.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                label37.BackColor = System.Drawing.Color.Transparent;
                label38.Text = "Type";
                label38.BackColor = System.Drawing.Color.Transparent;
                label39.Text = "Freq (Hz)";
                label39.BackColor = System.Drawing.Color.Transparent;
                label40.Text = "Q Value";
                label40.BackColor = System.Drawing.Color.Transparent;
                label41.Text = "Type";
                label41.BackColor = System.Drawing.Color.Transparent;
                label42.Text = "Freq (Hz)";
                label42.BackColor = System.Drawing.Color.Transparent;
                label43.Text = "Q Value";
                label43.BackColor = System.Drawing.Color.Transparent;
            }
            //PANELS
            {
                panel1.Text = "";
                panel1.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
                panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                panel2.Text = "";
                panel2.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
                panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                panel3.Text = "";
                panel3.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
                panel3.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                panel4.Text = "";
                panel4.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
                panel4.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            }
            //CHECKBOX
            {
                checkBox1.Text = "";
                checkBox2.Text = "";
                checkBox3.Text = "";
                checkBox4.Text = "";
                checkBox5.Text = "";
                checkBox6.Text = "";
                checkBox7.Text = "";
                checkBox8.Text = "";
                checkBox9.Text = "";
                checkBox10.Text = "";
                checkBox11.Text = "";
                checkBox12.Text = "";
                checkBox13.Text = "";
                checkBox14.Text = "";
                checkBox15.Text = "";
                checkBox16.Text = "";
                checkBox17.Text = "";
                checkBox18.Text = "";
                checkBox19.Text = "";
                checkBox20.Text = "";
                checkBox21.Text = "";
                checkBox22.Text = "";
                checkBox23.Text = "";
                checkBox24.Text = "";
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
            }
            //TEXTBOX
            {
                //FREQ TEXTBOX
                textBox1.AcceptsReturn = false;
                textBox1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox1.Text = freqValues[0][0].ToString();
                textBox2.AcceptsReturn = false;
                textBox2.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox2.Text = freqValues[0][1].ToString();
                textBox3.AcceptsReturn = false;
                textBox3.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox3.Text = freqValues[0][2].ToString();
                textBox4.AcceptsReturn = false;
                textBox4.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox4.Text = freqValues[0][3].ToString();
                textBox5.AcceptsReturn = false;
                textBox5.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox5.Text = freqValues[0][4].ToString();
                textBox6.AcceptsReturn = false;
                textBox6.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox6.Text = freqValues[0][5].ToString();
                textBox7.AcceptsReturn = false;
                textBox7.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox7.Text = freqValues[0][6].ToString();
                textBox8.AcceptsReturn = false;
                textBox8.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox8.Text = freqValues[0][7].ToString();
                textBox9.AcceptsReturn = false;
                textBox9.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox9.Text = freqValues[0][8].ToString();
                textBox10.AcceptsReturn = false;
                textBox10.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox10.Text = freqValues[0][9].ToString();
                textBox11.AcceptsReturn = false;
                textBox11.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox11.Text = freqValues[0][10].ToString();
                textBox12.AcceptsReturn = false;
                textBox12.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox12.Text = freqValues[0][11].ToString();
                //Q VALUE TEXTBOX
                textBox13.AcceptsReturn = false;
                textBox13.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox13.Text = qValues[0][0].ToString();
                textBox14.AcceptsReturn = false;
                textBox14.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox14.Text = qValues[0][1].ToString();
                textBox15.AcceptsReturn = false;
                textBox15.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox15.Text = qValues[0][2].ToString();
                textBox16.AcceptsReturn = false;
                textBox16.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox16.Text = qValues[0][3].ToString();
                textBox17.AcceptsReturn = false;
                textBox17.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox17.Text = qValues[0][4].ToString();
                textBox18.AcceptsReturn = false;
                textBox18.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox18.Text = qValues[0][5].ToString();
                textBox19.AcceptsReturn = false;
                textBox19.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox19.Text = qValues[0][6].ToString();
                textBox20.AcceptsReturn = false;
                textBox20.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox20.Text = qValues[0][7].ToString();
                textBox21.AcceptsReturn = false;
                textBox21.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox21.Text = qValues[0][8].ToString();
                textBox22.AcceptsReturn = false;
                textBox22.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox22.Text = qValues[0][9].ToString();
                textBox23.AcceptsReturn = false;
                textBox23.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox23.Text = qValues[0][10].ToString();
                textBox24.AcceptsReturn = false;
                textBox24.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox24.Text = qValues[0][11].ToString();
                //GAIN TEXTBOX
                textBox25.AcceptsReturn = false;
                textBox25.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox25.Text = gainValues[0][0].ToString();
                textBox26.AcceptsReturn = false;
                textBox26.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox26.Text = gainValues[0][1].ToString();
                textBox27.AcceptsReturn = false;
                textBox27.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox27.Text = gainValues[0][2].ToString();
                textBox28.AcceptsReturn = false;
                textBox28.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox28.Text = gainValues[0][3].ToString();
                textBox29.AcceptsReturn = false;
                textBox29.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox29.Text = gainValues[0][4].ToString();
                textBox30.AcceptsReturn = false;
                textBox30.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox30.Text = gainValues[0][5].ToString();
                textBox31.AcceptsReturn = false;
                textBox31.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox31.Text = gainValues[0][6].ToString();
                textBox32.AcceptsReturn = false;
                textBox32.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox32.Text = gainValues[0][7].ToString();
                textBox33.AcceptsReturn = false;
                textBox33.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox33.Text = gainValues[0][8].ToString();
                textBox34.AcceptsReturn = false;
                textBox34.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox34.Text = gainValues[0][9].ToString();
                textBox35.AcceptsReturn = false;
                textBox35.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox35.Text = gainValues[0][10].ToString();
                textBox36.AcceptsReturn = false;
                textBox36.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox36.Text = gainValues[0][11].ToString();
                //OTHER
                textBox37.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox37.Text = "CH " + currentChannel.ToString();
                textBox37.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
                textBox37.ForeColor = System.Drawing.Color.White;
                textBox37.Enabled = false;
                textBox38.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox38.Text = "Mute";
                textBox39.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox39.Text = "0.00";
                textBox40.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox40.Text = "20.1";
                textBox41.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox41.Text = "0.1";
                textBox41.Enabled = false;
                textBox42.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox42.Text = "20200.0";
                textBox43.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox43.Text = "0.1";
                textBox43.Enabled = false;
            }
            //COMBOBOX
            {
                comboBox12.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox12.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox12.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox12.Text = comboBox12.Items[0].ToString();
                comboBox11.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox11.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox11.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox11.Text = comboBox11.Items[0].ToString();
                comboBox10.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox10.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox10.Text = comboBox10.Items[0].ToString();
                comboBox9.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox9.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox9.Text = comboBox9.Items[0].ToString();
                comboBox8.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox8.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox8.Text = comboBox8.Items[0].ToString();
                comboBox7.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox7.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox7.Text = comboBox7.Items[0].ToString();
                comboBox6.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox6.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox6.Text = comboBox6.Items[0].ToString();
                comboBox5.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox5.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox5.Text = comboBox5.Items[0].ToString();
                comboBox4.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox4.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox4.Text = comboBox4.Items[0].ToString();
                comboBox3.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox3.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox3.Text = comboBox3.Items[0].ToString();
                comboBox2.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox2.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox2.Text = comboBox2.Items[0].ToString();
                comboBox1.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.Text = comboBox1.Items[0].ToString();

                comboBox13.Items.AddRange(new object[] { "150V", "121V", "101V", "83V", "70V", "56V", "47V", "38V" });
                comboBox13.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox13.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox13.Text = comboBox13.Items[0].ToString();
                comboBox14.Items.AddRange(new object[] { "OFF", "12dB Besell", "12dB Butterworth", "12dB Link Riley", "24dB Besell", "24dB Butterworth", "24dB Link Riley", "24dB USER" });
                comboBox14.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox14.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox14.Text = comboBox14.Items[0].ToString();
                comboBox15.Items.AddRange(new object[] { "OFF", "12dB Besell", "12dB Butterworth", "12dB Link Riley", "24dB Besell", "24dB Butterworth", "24dB Link Riley", "24dB USER" });
                comboBox15.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox15.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox15.Text = comboBox15.Items[0].ToString();
            }
            //TRACKBARS
            {
                //TRACKBAR 1
                macTrackBar1.TextTickStyle = System.Windows.Forms.TickStyle.None;
                macTrackBar1.Minimum = 0;
                macTrackBar1.Maximum = centralFreq.Length - 1;
                macTrackBar1.Value = Array.IndexOf(centralFreq, 21.7);
                macTrackBar1.TrackLineColor = System.Drawing.Color.Black;
                macTrackBar1.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
                //TRACKBAR 2
                macTrackBar2.TextTickStyle = System.Windows.Forms.TickStyle.None;
                macTrackBar2.Minimum = 0;
                macTrackBar2.Maximum = centralQ.Length - 1;
                macTrackBar2.Value = Array.IndexOf(centralQ, 4);
                macTrackBar2.TrackLineColor = System.Drawing.Color.Black;
                macTrackBar2.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
                //TRACKBAR3
                macTrackBar3.TextTickStyle = System.Windows.Forms.TickStyle.None;
                macTrackBar3.Minimum = 0;
                macTrackBar3.Maximum = centralGain.Length - 1;
                macTrackBar3.Value = Array.IndexOf(centralGain, 0);
                macTrackBar3.TrackLineColor = System.Drawing.Color.Black;
                macTrackBar3.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
                //TRACKBAR 4
                macTrackBar4.Minimum = 0;
                macTrackBar4.Maximum = centralVol.Length;
                macTrackBar4.Value = Array.IndexOf(centralVol, 0) + 1;
                macTrackBar4.TrackLineColor = System.Drawing.Color.Black;
                macTrackBar4.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
                macTrackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
                macTrackBar4.TickFrequency = 25;
                macTrackBar4.TickStyle = System.Windows.Forms.TickStyle.Both;
                macTrackBar4.TickColor = System.Drawing.Color.Black;
                macTrackBar4.ForeColor = System.Drawing.Color.Transparent;
            }
            //BUTTONS
            {
                //BUTTON 1 
                button1.Text = "CH 1";
                button1.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button1.ForeColor = System.Drawing.Color.White;
                //BUTTON 2
                button2.Text = "CH 2";
                button2.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                button2.BackColor = System.Drawing.Color.White;
                //BUTTON 3
                button3.Text = "CH 3";
                button3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                button3.BackColor = System.Drawing.Color.White;
                //BUTTON 4
                button4.Text = "System";
                button4.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                button4.BackColor = System.Drawing.Color.White;
                //BUTTON 5
                button5.Text = "Phase+";
                button5.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                button5.BackColor = System.Drawing.Color.White;
            }
            //MENU STRIP
            {
                menuStrip1.BackColor = System.Drawing.Color.FromArgb(150,150,150);
                menuStrip1.ForeColor = System.Drawing.Color.Black;
            }
        }

        static private double[] generateKeyFrequencies()
        {
            double[] freq = new double[809];
            int cont = 0;
            for (int i = 10; i <= 138; i++) { freq[cont] = i; cont++; }
            for (int i = 140; i <= 296; i += 2) { freq[cont] = i; cont++; }
            for (int i = 300; i <= 554; i += 4) { freq[cont] = i; cont++; }
            for (int i = 560; i <= 1856; i += 8) { freq[cont] = i; cont++; }
            for (int i = 1866; i <= 9600; i += 27) { freq[cont] = i; cont++; }
            for (int i = 9733; i <= 20000; i += 133) { freq[cont] = i; cont++; }
            for (int i = 20000; i <= 24000; i += 500) { freq[cont] = i; cont++; }
            return freq;
        }

        static private double[] generateCentralGain()
        {
            double[] gains = new double[421];
            int counter = 0;
            for (int i = -300; i <= 120; i++)
            {
                gains[counter] = (double)i / 10;
                counter++;
            }
            return gains;
        }

        static private double[] generateCentralVol()
        {
            double[] vol = new double[275];
            int c = 0;
            for (double i = -398; i <= 150; i += 2)
            {
                vol[c] = i / 10;
                c++;
            }
            return vol;
        }

        static private double[] generateCentralDelay()
        {
            double[] delay = new double[10001];
            int c = 0;
            for (int i = 0; i <= 20000; i += 2)
            {
                delay[c] = (double)i / (double)100;
                c++;
            }
            return delay;
        }
    }
}
