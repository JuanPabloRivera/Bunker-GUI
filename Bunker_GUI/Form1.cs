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
using System.Windows.Media;

namespace Bunker_GUI
{
    public partial class Form1 : Form
    {
        private int currentBand = 1;
        private int currentChannel = 1;
        //FILE CREATION
        bool fileExists = false;
        bool hasBeenModified;
        string fileName = "";
        //WIDGET LOCATION AND SIZE
        private int padx = 30;
        private int pady = 25;
        private int phase = 1;
        //INFORMATION STORING
        private double[] plotFrequencies = generateKeyFrequencies();
        private ChartValues<ObservablePoint>[] plotValues = new ChartValues<ObservablePoint>[13]
        {
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>(),
            new ChartValues<ObservablePoint>()
        };
        private ObservablePoint[] channelPoints = new ObservablePoint[809];
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
        private string[][] typeValues = new string[3][]
        {
            new string[12],
            new string[12],
            new string[12]
        };
        private double[] volValues = new double[3];
        private double[] delayValues = new double[3];
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
        private double[] centralVol = generateCentralVol();
        private double[] centralDelay = generateCentralDelay();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "BUNKER AUDIO CONTROLLER";
            this.BackColor = backgroundColorDark;
            this.MinimumSize = new Size(1450, 850);
            this.Size = this.MinimumSize;
            initializeValues();
            chartConfig();
            initializeWidgets();
            updateWidgetsSize();
            updateWidgetsPosition();
            updatePlot();
            hasBeenModified = false;
        }
    }
}