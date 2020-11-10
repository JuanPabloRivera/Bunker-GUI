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
        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            resetTextboxColors();
            label24.Text = centralFreq[macTrackBar1.Value].ToString();
            freqValues[currentChannel - 1][currentBand - 1] = centralFreq[macTrackBar1.Value];
            updateBoxes();
            generateValues(currentBand);
            cartesianChart1.VisualElements[currentBand - 1].X = Math.Log10(freqValues[currentChannel - 1][currentBand - 1]);
        }

        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            resetTextboxColors();
            if (typeValues[currentChannel - 1][currentBand - 1] == "Low Shelf" || typeValues[currentChannel - 1][currentBand - 1] == "High Shelf")
                if (centralQ[macTrackBar2.Value] > 1.30) macTrackBar2.Value = Array.IndexOf(centralQ, 1.30);
            label25.Text = centralQ[macTrackBar2.Value].ToString();
            qValues[currentChannel - 1][currentBand - 1] = centralQ[macTrackBar2.Value];
            updateBoxes();
            generateValues(currentBand);
        }

        private void macTrackBar3_ValueChanged(object sender, decimal value)
        {
            resetTextboxColors();
            label26.Text = centralGain[macTrackBar3.Value].ToString();
            gainValues[currentChannel - 1][currentBand - 1] = centralGain[macTrackBar3.Value];
            updateBoxes();
            generateValues(currentBand);
            cartesianChart1.VisualElements[currentBand - 1].Y = gainValues[currentChannel - 1][currentBand - 1] + 2;
        }

        private void macTrackBar4_ValueChanged(object sender, decimal value)
        {
            if (macTrackBar4.Value == 0) textBox38.Text = "Mute";
            else
            {
                volValues[currentChannel - 1] = centralVol[macTrackBar4.Value - 1];
                textBox38.Text = centralVol[macTrackBar4.Value - 1].ToString() + "dB";
            }
        }
    }
}
