using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunker_GUI
{
    public partial class Form1 : Form
    {
        private int padx = 30;
        private int pady = 25;
        private int currentBand = 1;
        private int currentChannel = 1;
        private double[] plotFrequencies = generateKeyFrequencies();
        private double[][] freqValues = new double[3][] 
        {
            new double[12],
            new double[12],
            new double[12]
        };
        private double[][] qValues = new double[3][]
        {
            new double[12],
            new double[12],
            new double[12]
        };
        private double[][] gainValues = new double[3][] 
        {
            new double[12],
            new double[12],
            new double[12]
        };
        private double[] centralFreq = new double[]
        {
            19.7,20.1,20.5,20.9,21.3,21.7,22.1,22.5,23.0,23.4,23.9,24.3,24.8,25.3,25.8,26.3,26.8,27.3,27.8,28.4,28.9,29.5,30.1,30.7,31.3,
            31.9,32.5,33.1,33.8,34.4,35.1,35.8,36.5,37.2,37.9,38.6,39.4,40.1,40.9,41.7,42.5,43.4,44.2,45.1,45.9,46.8,47.7,48.7,49.6,50.6,
            51.6,52.6,53.6,54.6,55.7,56.8,57.9,59.0,60.1,61.3,62.5,63.7,65.0,66.2,67.5,68.8,70.2,71.5,72.9,74.3,75.8,77.2,78.7,80.3,81.8,
            83.4,85.0,86.7,88.4,90.1,91.9,94.0,95.0,97.0,99.0,101.0,103.0,105.0,107.0,109.0,111.0,114.0,116.0,118.0,120.0,123.0,125.0,127.0,
            130.0,132.0,135.0,138.0,140.0,143.0,146.0,149.0,152.0,154.0,157.0,161.0,164.0,167.0,170.0,173.0,177.0,180.0,184.0,187.0,191.0,
            195.0,198.0,202.0,206.0,210.0,214.0,218.0,223.0,227.0,231.0,236.0,241.0,245.0,250.0,255.0,260.0,265.0,270.0,275.0,281.0,286.0,
            292.0,297.0,303.0,309.0,315.0,321.0,327.0,334.0,340.0,347.0,354.0,360.0,367.0,375.0,382.0,389.0,397.0,405.0,412.0,420.0,429.0,
            437.0,445.0,454.0,463.0,472.0,481.0,490.0,500.0,510.0,520.0,530.0,540.0,551.0,561.0,572.0,583.0,595.0,606.0,618.0,630.0,642.0,
            655.0,667.0,680.0,694.0,707.0,721.0,735.0,749.0,764.0,779.0,794.0,809.0,825.0,841.0,857.0,874.0,891.0,908.0,926.0,944.0,962.0,981.0,
            1000.0,1020.0,1040.0,1060.0,1080.0,1100.0,1120.0,1140.0,1170.0,1190.0,1210.0,1240.0,1260.0,1280.0,1310.0,1330.0,1360.0,1390.0,
            1410.0,1440.0,1470.0,1500.0,1530.0,1560.0,1590.0,1620.0,1650.0,1680.0,1710.0,1750.0,1780.0,1820.0,1850.0,1890.0,1920.0,1960.0,
            2000.0,2040.0,2080.0,2120.0,2160.0,2200.0,2240.0,2290.0,2330.0,2380.0,2420.0,2470.0,2520.0,2570.0,2620.0,2670.0,2720.0,2770.0,
            2830.0,2880.0,2940.0,3000.0,3050.0,3110.0,3170.0,3240.0,3300.0,3360.0,3430.0,3500.0,3560.0,3630.0,3700.0,3780.0,3850.0,3920.0,
            4000.0,4080.0,4160.0,4240.0,4320.0,4400.0,4490.0,4580.0,4670.0,4760.0,4850.0,4940.0,5040.0,5140.0,5240.0,5340.0,5440.0,5550.0,
            5660.0,5770.0,5880.0,5990.0,6110.0,6230.0,6350.0,6470.0,6600.0,6730.0,6860.0,6990.0,7130.0,7270.0,7410.0,7550.0,7700.0,7850.0,
            8000.0,8160.0,8310.0,8480.0,8640.0,8810.0,8980.0,9150.0,9330.0,9510.0,9700.0,9890.0,10100.0,10300.0,10500.0,10700.0,10900.0,11100.0,
            11300.0,11500.0,11800.0,12000.0,12200.0,12500.0,12700.0,12900.0,13200.0,13500.0,13700.0,14000.0,14300.0,14500.0,14800.0,15100.0,
            15400.0,15700.0,16000.0,16300.0,16600.0,17000.0,17300.0,17600.0,18000.0,18300.0,18600.0,19000.0,19400.0,19800.0,20200.0,20600.0
        };
        private double[] centralQ = new double[]
        {
            0.10,0.12,0.15,0.18,0.22,0.25,0.29,0.32,0.36,0.40,0.42,0.45,0.47,0.50,0.53,0.56,0.59,0.63,0.67,0.71,0.75,0.79,0.84,0.89,0.94,1.00,1.06,1.12,
            1.19,1.26,1.30,1.40,1.50,1.60,1.70,1.80,1.90,2.00,2.10,2.20,2.30,2.40,2.50,2.60,2.70,2.80,2.90,3.00,3.20,3.40,3.60,3.80,4.00,4.20,4.40,4.60,
            5.00,5.30,5.70,6.00,6.30,6.70,7.10,7.60,8.00,8.50,9.00,9.50,10.10,10.70,11.30,12.00,12.70,13.50,14.00,15.00,16.00,17.00,18.00,19.00,20.00,21.00,
            22.00,23.00,24.00,25.00,26.00,27.00,28.00,29.00,30.00,32.00,34.00,36.00,38.00,40.00,43.00,45.00,48.00,51.00,54.00,57.00,60.00,64.00,68.00,72.00,
            76.00,81.00,85.00,91.00,96.00,102.00,108.00,114.00,121.00,128.00
        };
        private double[] centralGain = generateCentralGain();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
            this.MinimumSize = new Size(1450, 800);
            this.Size = this.MinimumSize;
            initializeValues();
            initializeWidgets();
            updateWidgetsSize();
            updateWidgetsPosition();
        }

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
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    qValues[i][j] = 4.00;
                    gainValues[i][j] = 0.00;
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
            }
            //GROUPBOX
            {
                groupBox1.Text = "";
                groupBox1.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
                groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                groupBox2.Text = "";
                groupBox2.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
                groupBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                groupBox3.Text = "";
                groupBox3.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
                groupBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                groupBox4.Text = "";
                groupBox4.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
                groupBox4.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
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
            }
            //TEXTBOX
            {
                //FREQ TEXTBOX
                textBox1.AcceptsReturn = false;
                textBox1.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox1.Text = freqValues[0][0].ToString();
                textBox2.AcceptsReturn = false;
                textBox2.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox2.Text = freqValues[0][1].ToString();
                textBox3.AcceptsReturn = false;
                textBox3.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox3.Text = freqValues[0][2].ToString();
                textBox4.AcceptsReturn = false;
                textBox4.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox4.Text = freqValues[0][3].ToString();
                textBox5.AcceptsReturn = false;
                textBox5.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox5.Text = freqValues[0][4].ToString();
                textBox6.AcceptsReturn = false;
                textBox6.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox6.Text = freqValues[0][5].ToString();
                textBox7.AcceptsReturn = false;
                textBox7.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox7.Text = freqValues[0][6].ToString();
                textBox8.AcceptsReturn = false;
                textBox8.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox8.Text = freqValues[0][7].ToString();
                textBox9.AcceptsReturn = false;
                textBox9.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox9.Text = freqValues[0][8].ToString();
                textBox10.AcceptsReturn = false;
                textBox10.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox10.Text = freqValues[0][9].ToString();
                textBox11.AcceptsReturn = false;
                textBox11.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox11.Text = freqValues[0][10].ToString();
                textBox12.AcceptsReturn = false;
                textBox12.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox12.Text = freqValues[0][11].ToString();
                //Q VALUE TEXTBOX
                textBox13.AcceptsReturn = false;
                textBox13.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox13.Text = qValues[0][0].ToString();
                textBox14.AcceptsReturn = false;
                textBox14.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox14.Text = qValues[0][1].ToString();
                textBox15.AcceptsReturn = false;
                textBox15.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox15.Text = qValues[0][2].ToString();
                textBox16.AcceptsReturn = false;
                textBox16.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox16.Text = qValues[0][3].ToString();
                textBox17.AcceptsReturn = false;
                textBox17.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox17.Text = qValues[0][4].ToString();
                textBox18.AcceptsReturn = false;
                textBox18.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox18.Text = qValues[0][5].ToString();
                textBox19.AcceptsReturn = false;
                textBox19.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox19.Text = qValues[0][6].ToString();
                textBox20.AcceptsReturn = false;
                textBox20.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox20.Text = qValues[0][7].ToString();
                textBox21.AcceptsReturn = false;
                textBox21.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox21.Text = qValues[0][8].ToString();
                textBox22.AcceptsReturn = false;
                textBox22.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox22.Text = qValues[0][9].ToString();
                textBox23.AcceptsReturn = false;
                textBox23.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox23.Text = qValues[0][10].ToString();
                textBox24.AcceptsReturn = false;
                textBox24.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox24.Text = qValues[0][11].ToString();
                //GAIN TEXTBOX
                textBox25.AcceptsReturn = false;
                textBox25.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox25.Text = gainValues[0][0].ToString();
                textBox26.AcceptsReturn = false;
                textBox26.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox26.Text = gainValues[0][1].ToString();
                textBox27.AcceptsReturn = false;
                textBox27.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox27.Text = gainValues[0][2].ToString();
                textBox28.AcceptsReturn = false;
                textBox28.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox28.Text = gainValues[0][3].ToString();
                textBox29.AcceptsReturn = false;
                textBox29.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox29.Text = gainValues[0][4].ToString();
                textBox30.AcceptsReturn = false;
                textBox30.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox30.Text = gainValues[0][5].ToString();
                textBox31.AcceptsReturn = false;
                textBox31.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox31.Text = gainValues[0][6].ToString();
                textBox32.AcceptsReturn = false;
                textBox32.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox32.Text = gainValues[0][7].ToString();
                textBox33.AcceptsReturn = false;
                textBox33.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox33.Text = gainValues[0][8].ToString();
                textBox34.AcceptsReturn = false;
                textBox34.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox34.Text = gainValues[0][9].ToString();
                textBox35.AcceptsReturn = false;
                textBox35.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox35.Text = gainValues[0][10].ToString();
                textBox36.AcceptsReturn = false;
                textBox36.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                textBox36.Text = gainValues[0][11].ToString();
            }
            //COMBOBOX
            {
                comboBox1.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox1.Width = 100;
                comboBox1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.Text = comboBox1.Items[0].ToString();
                comboBox2.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox2.Width = 100;
                comboBox2.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox2.Text = comboBox2.Items[0].ToString();
                comboBox3.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox3.Width = 100;
                comboBox3.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox3.Text = comboBox3.Items[0].ToString();
                comboBox4.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox4.Width = 100;
                comboBox4.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox4.Text = comboBox1.Items[0].ToString();
                comboBox5.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox5.Width = 100;
                comboBox5.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox5.Text = comboBox2.Items[0].ToString();
                comboBox6.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox6.Width = 100;
                comboBox6.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox6.Text = comboBox3.Items[0].ToString();
                comboBox7.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox7.Width = 100;
                comboBox7.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox7.Text = comboBox1.Items[0].ToString();
                comboBox8.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox8.Width = 100;
                comboBox8.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox8.Text = comboBox2.Items[0].ToString();
                comboBox9.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox9.Width = 100;
                comboBox9.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox9.Text = comboBox3.Items[0].ToString();
                comboBox10.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox10.Width = 100;
                comboBox10.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox10.Text = comboBox1.Items[0].ToString();
                comboBox11.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox11.Width = 100;
                comboBox11.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox11.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox11.Text = comboBox2.Items[0].ToString();
                comboBox12.Items.AddRange(new object[] { "Parametric", "Low Shelf", "High Shelf" });
                comboBox12.Width = 100;
                comboBox12.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                comboBox12.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox12.Text = comboBox3.Items[0].ToString();
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
            }
            //BUTTONS
            {
                //BUTTON 1 
                button1.Text = "CH 1";
                button1.Size = new Size(75, 35);
                button1.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button1.ForeColor = System.Drawing.Color.White;
                //BUTTON 2
                button2.Text = "CH 2";
                button2.Size = new Size(75, 35);
                button2.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                button2.BackColor = System.Drawing.Color.White;
                //BUTTON 3
                button3.Text = "CH 3";
                button3.Size = new Size(75, 35);
                button3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                button3.BackColor = System.Drawing.Color.White;
                button4.Text = "System";
                button4.Size = new Size(75, 35);
                button4.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                button4.BackColor = System.Drawing.Color.White;
            }
        }

        private void updateWidgetsPosition()
        {
            cartesianChart1.Location = new Point(padx / 2, pady / 2);
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
                label7.Location = new Point(label1.Location.X, label1.Location.Y + pady);                 //1
                label8.Location = new Point(label1.Location.X, label7.Location.Y + pady);                 //2
                label9.Location = new Point(label1.Location.X, label8.Location.Y + pady);                 //3
                label10.Location = new Point(label1.Location.X, label9.Location.Y + pady);                //4
                label11.Location = new Point(label1.Location.X, label10.Location.Y + pady);               //5
                label12.Location = new Point(label1.Location.X, label11.Location.Y + pady);               //6
                label13.Location = new Point(label1.Location.X, label12.Location.Y + pady);               //7
                label14.Location = new Point(label1.Location.X, label13.Location.Y + pady);               //8
                label15.Location = new Point(label1.Location.X, label14.Location.Y + pady);               //9
                label16.Location = new Point(label1.Location.X, label15.Location.Y + pady);               //10
                label17.Location = new Point(label1.Location.X, label16.Location.Y + pady);               //11
                label18.Location = new Point(label1.Location.X, label17.Location.Y + pady);               //12
                label20.Location = new Point(groupBox2.Width / 2 - label20.Width / 2, label1.Location.Y);     //EQ BAND
                label21.Location = new Point(padx, 3 * groupBox2.Height / 20);
                label22.Location = new Point(padx, 9 * groupBox2.Height / 20);
                label23.Location = new Point(padx, 15 * groupBox2.Height / 20);
                label24.Location = new Point(groupBox2.Width - (padx + label24.Width), label21.Location.Y);
                label25.Location = new Point(groupBox2.Width - (padx + label25.Width), label22.Location.Y);
                label26.Location = new Point(groupBox2.Width - (padx + label26.Width), label23.Location.Y);
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
            }
            //CHECKBOX
            {
                checkBox1.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label7.Location.Y);
                checkBox2.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label8.Location.Y);
                checkBox3.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label9.Location.Y);
                checkBox4.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label10.Location.Y);
                checkBox5.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label11.Location.Y);
                checkBox6.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label12.Location.Y);
                checkBox7.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label13.Location.Y);
                checkBox8.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label14.Location.Y);
                checkBox9.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label15.Location.Y);
                checkBox10.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label16.Location.Y);
                checkBox11.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label17.Location.Y);
                checkBox12.Location = new Point(comboBox1.Location.X + comboBox1.Width + padx/2, label18.Location.Y);

                checkBox13.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label7.Location.Y);
                checkBox14.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label8.Location.Y);
                checkBox15.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label9.Location.Y);
                checkBox16.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label10.Location.Y);
                checkBox17.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label11.Location.Y);
                checkBox18.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label12.Location.Y);
                checkBox19.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label13.Location.Y);
                checkBox20.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label14.Location.Y);
                checkBox21.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label15.Location.Y);
                checkBox22.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label16.Location.Y);
                checkBox23.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label17.Location.Y);
                checkBox24.Location = new Point(checkBox1.Location.X + checkBox1.Width + padx/2, label18.Location.Y);
            }
            //LABELS PART2
            {
                label2.Location = new Point(textBox1.Location.X, label1.Location.Y);                                   //FREQ
                label3.Location = new Point(textBox13.Location.X, label1.Location.Y);                                  //Q VALUE
                label4.Location = new Point(textBox25.Location.X, label1.Location.Y);                                  //GAIN
                label19.Location = new Point(comboBox1.Location.X, label1.Location.Y);                                 //TYPE
                label5.Location = new Point(checkBox1.Location.X-padx, label1.Location.Y);                                  //BYPASS
                label6.Location = new Point(checkBox13.Location.X-padx/2, label1.Location.Y);                                 //SHOW
            }
            //GROUPBOX
            {
                groupBox1.Location = new Point(cartesianChart1.Location.X, button1.Location.Y + button1.Height + pady / 2);
                groupBox2.Location = new Point(groupBox1.Location.X + groupBox1.Width + padx / 2, button1.Location.Y + button1.Height + pady / 2);
                groupBox3.Location = new Point(groupBox1.Location.X + groupBox1.Width + padx / 2, groupBox2.Location.Y + groupBox2.Height + pady / 2);
                groupBox4.Location = new Point(groupBox2.Location.X + groupBox2.Width + padx / 2, button1.Location.Y + button1.Height + pady / 2);
            }
            //TRACKBARS
            {
                macTrackBar1.Location = new Point(label21.Location.X, label21.Location.Y + pady/2);
                macTrackBar2.Location = new Point(label22.Location.X, label22.Location.Y + pady/2);
                macTrackBar3.Location = new Point(label23.Location.X, label23.Location.Y + pady/2);
            }
        }

        private void updateWidgetsSize()
        {
            //CARTESIAN CHART
            {
                cartesianChart1.Size = new Size(this.Width - 3 * padx / 2, 9 * this.Height / 20 - 2 * pady);
            }
            //GROUPBOX
            {
                groupBox1.Size = new Size(4 * this.Width / 10 - padx, ((this.Height - pady/2) / 2) - pady);
                groupBox2.Size = new Size(4 * this.Width / 10 - padx, 3 * this.Height / 10 - pady);
                groupBox3.Size = new Size(4 * this.Width / 10 - padx, 2 * this.Height / 10 - 3*pady/4);
                groupBox4.Size = new Size(2 * this.Width / 10 - padx / 2, ((this.Height - pady/2) / 2) - pady);
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

                textBox13.Size = new Size(padx * 2, textBox1.Height);
                textBox14.Size = new Size(padx * 2, textBox2.Height);
                textBox15.Size = new Size(padx * 2, textBox3.Height);
                textBox16.Size = new Size(padx * 2, textBox4.Height);
                textBox17.Size = new Size(padx * 2, textBox5.Height);
                textBox18.Size = new Size(padx * 2, textBox6.Height);
                textBox19.Size = new Size(padx * 2, textBox7.Height);
                textBox20.Size = new Size(padx * 2, textBox8.Height);
                textBox21.Size = new Size(padx * 2, textBox9.Height);
                textBox22.Size = new Size(padx * 2, textBox10.Height);
                textBox23.Size = new Size(padx * 2, textBox11.Height);
                textBox24.Size = new Size(padx * 2, textBox12.Height);

                textBox25.Size = new Size(padx * 3, textBox1.Height);
                textBox26.Size = new Size(padx * 3, textBox2.Height);
                textBox27.Size = new Size(padx * 3, textBox3.Height);
                textBox28.Size = new Size(padx * 3, textBox4.Height);
                textBox29.Size = new Size(padx * 3, textBox5.Height);
                textBox30.Size = new Size(padx * 3, textBox6.Height);
                textBox31.Size = new Size(padx * 3, textBox7.Height);
                textBox32.Size = new Size(padx * 3, textBox8.Height);
                textBox33.Size = new Size(padx * 3, textBox9.Height);
                textBox34.Size = new Size(padx * 3, textBox10.Height);
                textBox35.Size = new Size(padx * 3, textBox11.Height);
                textBox36.Size = new Size(padx * 3, textBox12.Height);
            }
            //COMBOBOX
            {
                comboBox1.Size = new Size(padx * 4, textBox1.Height);
                comboBox2.Size = new Size(padx * 4, textBox2.Height);
                comboBox3.Size = new Size(padx * 4, textBox3.Height);
                comboBox4.Size = new Size(padx * 4, textBox4.Height);
                comboBox5.Size = new Size(padx * 4, textBox5.Height);
                comboBox6.Size = new Size(padx * 4, textBox6.Height);
                comboBox7.Size = new Size(padx * 4, textBox7.Height);
                comboBox8.Size = new Size(padx * 4, textBox8.Height);
                comboBox9.Size = new Size(padx * 4, textBox9.Height);
                comboBox10.Size = new Size(padx * 4, textBox10.Height);
                comboBox11.Size = new Size(padx * 4, textBox11.Height);
                comboBox12.Size = new Size(padx * 4, textBox12.Height);
            }
            //TRACKBARS
            {
                macTrackBar1.Size = new Size((label24.Location.X + label24.Width) - label21.Location.X, macTrackBar1.Height);
                macTrackBar2.Size = new Size((label25.Location.X + label25.Width) - label22.Location.X, macTrackBar2.Height);
                macTrackBar3.Size = new Size((label26.Location.X + label26.Width) - label23.Location.X, macTrackBar3.Height);
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

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            resetTextboxColors();
            label24.Text = centralFreq[macTrackBar1.Value].ToString();
            freqValues[currentChannel - 1][currentBand - 1] = centralFreq[macTrackBar1.Value];
            switch (currentBand)
            {
                case 1:
                    textBox1.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 2:
                    textBox2.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 3:
                    textBox3.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 4:
                    textBox4.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 5:
                    textBox5.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 6:
                    textBox6.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 7:
                    textBox7.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 8:
                    textBox8.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 9:
                    textBox9.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 10:
                    textBox10.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 11:
                    textBox11.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                case 12:
                    textBox12.Text = centralFreq[macTrackBar1.Value].ToString();
                    break;
                default:
                    break;
            }
        }

        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            resetTextboxColors();
            label25.Text = centralQ[macTrackBar2.Value].ToString();
            qValues[currentChannel - 1][currentBand - 1] = centralQ[macTrackBar2.Value];
            switch (currentBand)
            {
                case 1:
                    textBox13.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 2:
                    textBox14.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 3:
                    textBox15.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 4:
                    textBox16.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 5:
                    textBox17.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 6:
                    textBox18.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 7:
                    textBox19.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 8:
                    textBox20.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 9:
                    textBox21.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 10:
                    textBox22.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 11:
                    textBox23.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                case 12:
                    textBox24.Text = centralQ[macTrackBar2.Value].ToString();
                    break;
                default:
                    break;
            }
        }

        private void macTrackBar3_ValueChanged(object sender, decimal value)
        {
            resetTextboxColors();
            label26.Text = centralGain[macTrackBar3.Value].ToString();
            gainValues[currentChannel - 1][currentBand - 1] = centralGain[macTrackBar3.Value];
            switch (currentBand)
            {
                case 1:
                    textBox25.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 2:
                    textBox26.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 3:
                    textBox27.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 4:
                    textBox28.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 5:
                    textBox29.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 6:
                    textBox30.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 7:
                    textBox31.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 8:
                    textBox32.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 9:
                    textBox33.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 10:
                    textBox34.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 11:
                    textBox35.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                case 12:
                    textBox36.Text = centralGain[macTrackBar3.Value].ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            padx = this.Width / 48;
            pady = this.Height / 30;
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
        }
        
        private void textBox1_Click(object sender, EventArgs e)
        {
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            resetTextboxColors();
            textBox1.BackColor = System.Drawing.Color.SteelBlue;
            textBox1.ForeColor = System.Drawing.Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            currentBand = 2;
            label20.Text = "Current EQ Band: 2";
            updateTrackbars();
            resetTextboxColors();
            textBox2.BackColor = System.Drawing.Color.SteelBlue;
            textBox2.ForeColor = System.Drawing.Color.White;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            currentBand = 3;
            label20.Text = "Current EQ Band: 3";
            updateTrackbars();
            resetTextboxColors();
            textBox3.BackColor = System.Drawing.Color.SteelBlue;
            textBox3.ForeColor = System.Drawing.Color.White;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            currentBand = 4;
            label20.Text = "Current EQ Band: 4";
            updateTrackbars();
            resetTextboxColors();
            textBox4.BackColor = System.Drawing.Color.SteelBlue;
            textBox4.ForeColor = System.Drawing.Color.White;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            currentBand = 5;
            label20.Text = "Current EQ Band: 5";
            updateTrackbars();
            resetTextboxColors();
            textBox5.BackColor = System.Drawing.Color.SteelBlue;
            textBox5.ForeColor = System.Drawing.Color.White;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            currentBand = 6;
            label20.Text = "Current EQ Band: 6";
            updateTrackbars();
            resetTextboxColors();
            textBox6.BackColor = System.Drawing.Color.SteelBlue;
            textBox6.ForeColor = System.Drawing.Color.White;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            currentBand = 7;
            label20.Text = "Current EQ Band: 7";
            updateTrackbars();
            resetTextboxColors();
            textBox7.BackColor = System.Drawing.Color.SteelBlue;
            textBox7.ForeColor = System.Drawing.Color.White;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            currentBand = 8;
            label20.Text = "Current EQ Band: 8";
            updateTrackbars();
            resetTextboxColors();
            textBox8.BackColor = System.Drawing.Color.SteelBlue;
            textBox8.ForeColor = System.Drawing.Color.White;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            currentBand = 9;
            label20.Text = "Current EQ Band: 9";
            updateTrackbars();
            resetTextboxColors();
            textBox9.BackColor = System.Drawing.Color.SteelBlue;
            textBox9.ForeColor = System.Drawing.Color.White;
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            currentBand = 10;
            label20.Text = "Current EQ Band: 10";
            updateTrackbars();
            resetTextboxColors();
            textBox10.BackColor = System.Drawing.Color.SteelBlue;
            textBox10.ForeColor = System.Drawing.Color.White;
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            currentBand = 11;
            label20.Text = "Current EQ Band: 11";
            updateTrackbars();
            resetTextboxColors();
            textBox11.BackColor = System.Drawing.Color.SteelBlue;
            textBox11.ForeColor = System.Drawing.Color.White;
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            currentBand = 12;
            label20.Text = "Current EQ Band: 12";
            updateTrackbars();
            resetTextboxColors();
            textBox12.BackColor = System.Drawing.Color.SteelBlue;
            textBox12.ForeColor = System.Drawing.Color.White;
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            resetTextboxColors();
            textBox13.BackColor = System.Drawing.Color.SteelBlue;
            textBox13.ForeColor = System.Drawing.Color.White;
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            currentBand = 2;
            label20.Text = "Current EQ Band: 2";
            updateTrackbars();
            resetTextboxColors();
            textBox14.BackColor = System.Drawing.Color.SteelBlue;
            textBox14.ForeColor = System.Drawing.Color.White;
        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            currentBand = 3;
            label20.Text = "Current EQ Band: 3";
            updateTrackbars();
            resetTextboxColors();
            textBox15.BackColor = System.Drawing.Color.SteelBlue;
            textBox15.ForeColor = System.Drawing.Color.White;
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            currentBand = 4;
            label20.Text = "Current EQ Band: 4";
            updateTrackbars();
            resetTextboxColors();
            textBox16.BackColor = System.Drawing.Color.SteelBlue;
            textBox16.ForeColor = System.Drawing.Color.White;
        }

        private void textBox17_Click(object sender, EventArgs e)
        {
            currentBand = 5;
            label20.Text = "Current EQ Band: 5";
            updateTrackbars();
            resetTextboxColors();
            textBox17.BackColor = System.Drawing.Color.SteelBlue;
            textBox17.ForeColor = System.Drawing.Color.White;
        }

        private void textBox18_Click(object sender, EventArgs e)
        {
            currentBand = 6;
            label20.Text = "Current EQ Band: 6";
            updateTrackbars();
            resetTextboxColors();
            textBox18.BackColor = System.Drawing.Color.SteelBlue;
            textBox18.ForeColor = System.Drawing.Color.White;
        }

        private void textBox19_Click(object sender, EventArgs e)
        {
            currentBand = 7;
            label20.Text = "Current EQ Band: 7";
            updateTrackbars();
            resetTextboxColors();
            textBox19.BackColor = System.Drawing.Color.SteelBlue;
            textBox19.ForeColor = System.Drawing.Color.White;
        }

        private void textBox20_Click(object sender, EventArgs e)
        {
            currentBand = 8;
            label20.Text = "Current EQ Band: 8";
            updateTrackbars();
            resetTextboxColors();
            textBox20.BackColor = System.Drawing.Color.SteelBlue;
            textBox20.ForeColor = System.Drawing.Color.White;
        }

        private void textBox21_Click(object sender, EventArgs e)
        {
            currentBand = 9;
            label20.Text = "Current EQ Band: 9";
            updateTrackbars();
            resetTextboxColors();
            textBox21.BackColor = System.Drawing.Color.SteelBlue;
            textBox21.ForeColor = System.Drawing.Color.White;
        }

        private void textBox22_Click(object sender, EventArgs e)
        {
            currentBand = 10;
            label20.Text = "Current EQ Band: 10";
            updateTrackbars();
            resetTextboxColors();
            textBox22.BackColor = System.Drawing.Color.SteelBlue;
            textBox22.ForeColor = System.Drawing.Color.White;
        }

        private void textBox23_Click(object sender, EventArgs e)
        {
            currentBand = 11;
            label20.Text = "Current EQ Band: 11";
            updateTrackbars();
            resetTextboxColors();
            textBox23.BackColor = System.Drawing.Color.SteelBlue;
            textBox23.ForeColor = System.Drawing.Color.White;
        }

        private void textBox24_Click(object sender, EventArgs e)
        {
            currentBand = 12;
            label20.Text = "Current EQ Band: 12";
            updateTrackbars();
            resetTextboxColors();
            textBox24.BackColor = System.Drawing.Color.SteelBlue;
            textBox24.ForeColor = System.Drawing.Color.White;
        }

        private void textBox25_Click(object sender, EventArgs e)
        {
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            resetTextboxColors();
            textBox25.BackColor = System.Drawing.Color.SteelBlue;
            textBox25.ForeColor = System.Drawing.Color.White;
        }

        private void textBox26_Click(object sender, EventArgs e)
        {
            currentBand = 2;
            label20.Text = "Current EQ Band: 2";
            updateTrackbars();
            resetTextboxColors();
            textBox26.BackColor = System.Drawing.Color.SteelBlue;
            textBox26.ForeColor = System.Drawing.Color.White;
        }

        private void textBox27_Click(object sender, EventArgs e)
        {
            currentBand = 3;
            label20.Text = "Current EQ Band: 3";
            updateTrackbars();
            resetTextboxColors();
            textBox27.BackColor = System.Drawing.Color.SteelBlue;
            textBox27.ForeColor = System.Drawing.Color.White;
        }

        private void textBox28_Click(object sender, EventArgs e)
        {
            currentBand = 4;
            label20.Text = "Current EQ Band: 4";
            updateTrackbars();
            resetTextboxColors();
            textBox28.BackColor = System.Drawing.Color.SteelBlue;
            textBox28.ForeColor = System.Drawing.Color.White;
        }

        private void textBox29_Click(object sender, EventArgs e)
        {
            currentBand = 5;
            label20.Text = "Current EQ Band: 5";
            updateTrackbars();
            resetTextboxColors();
            textBox29.BackColor = System.Drawing.Color.SteelBlue;
            textBox29.ForeColor = System.Drawing.Color.White;
        }

        private void textBox30_Click(object sender, EventArgs e)
        {
            currentBand = 6;
            label20.Text = "Current EQ Band: 6";
            updateTrackbars();
            resetTextboxColors();
            textBox30.BackColor = System.Drawing.Color.SteelBlue;
            textBox30.ForeColor = System.Drawing.Color.White;
        }

        private void textBox31_Click(object sender, EventArgs e)
        {
            currentBand = 7;
            label20.Text = "Current EQ Band: 7";
            updateTrackbars();
            resetTextboxColors();
            textBox31.BackColor = System.Drawing.Color.SteelBlue;
            textBox31.ForeColor = System.Drawing.Color.White;
        }

        private void textBox32_Click(object sender, EventArgs e)
        {
            currentBand = 8;
            label20.Text = "Current EQ Band: 8";
            updateTrackbars();
            resetTextboxColors();
            textBox32.BackColor = System.Drawing.Color.SteelBlue;
            textBox32.ForeColor = System.Drawing.Color.White;
        }

        private void textBox33_Click(object sender, EventArgs e)
        {
            currentBand = 9;
            label20.Text = "Current EQ Band: 9";
            updateTrackbars();
            resetTextboxColors();
            textBox33.BackColor = System.Drawing.Color.SteelBlue;
            textBox33.ForeColor = System.Drawing.Color.White;
        }

        private void textBox34_Click(object sender, EventArgs e)
        {
            currentBand = 10;
            label20.Text = "Current EQ Band: 10";
            updateTrackbars();
            resetTextboxColors();
            textBox34.BackColor = System.Drawing.Color.SteelBlue;
            textBox34.ForeColor = System.Drawing.Color.White;
        }

        private void textBox35_Click(object sender, EventArgs e)
        {
            currentBand = 11;
            label20.Text = "Current EQ Band: 11";
            updateTrackbars();
            resetTextboxColors();
            textBox35.BackColor = System.Drawing.Color.SteelBlue;
            textBox35.ForeColor = System.Drawing.Color.White;
        }

        private void textBox36_Click(object sender, EventArgs e)
        {
            currentBand = 12;
            label20.Text = "Current EQ Band: 12";
            updateTrackbars();
            resetTextboxColors();
            textBox36.BackColor = System.Drawing.Color.SteelBlue;
            textBox36.ForeColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentChannel = 1;
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            updateBoxes();
            resetButtonColors();
            resetTextboxColors();
            button1.BackColor = System.Drawing.Color.SteelBlue;
            button1.ForeColor = System.Drawing.Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentChannel = 2;
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            updateBoxes();
            resetButtonColors();
            resetTextboxColors();
            button2.BackColor = System.Drawing.Color.SteelBlue;
            button2.ForeColor = System.Drawing.Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentChannel = 3;
            currentBand = 1;
            label20.Text = "Current EQ Band: 1";
            updateTrackbars();
            updateBoxes();
            resetButtonColors();
            resetTextboxColors();
            button3.BackColor = System.Drawing.Color.SteelBlue;
            button3.ForeColor = System.Drawing.Color.White;
        }
    }
}