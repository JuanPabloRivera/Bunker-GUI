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
using System.IO;

namespace Bunker_GUI
{
    public partial class Form1 : Form
    {
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hasBeenModified)
            {
                DialogResult result = MessageBox.Show("The current file has been modified.\nWould you like you save changes?", "BUNKER AUDIO CONTROLLER", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                }
                else if (result == DialogResult.Cancel) return;
            }
            var fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:";
            fileDialog.Filter = "Bunker Equilizer Configuration | *.eqc";
            fileDialog.RestoreDirectory = true;
            fileDialog.Title = "Open file";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //GETTING VALUES FROM THE OPENED FILE
                byte[] values = new byte[1000];
                fileName = fileDialog.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                fs.Read(values, 0, (int)fs.Length);
                fs.Close();
                setValues(Encoding.UTF8.GetString(values));

                //UPDATING
                updateProgram(1, 1);
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button1.ForeColor = System.Drawing.Color.White;
                fileExists = true;
                hasBeenModified = false;
            }
        }

        private void setValues(string inputValues)
        {
            int i = 0;
            string value;
            for (int ch = 0; ch < 3; ch++)
            {
                //FREQUENCY VALUES
                for (int band = 0; band < 12; band++)
                {
                    value = "";
                    while (inputValues[i] != '\n')
                    {
                        value += inputValues[i];
                        i++;
                    }
                    i++;
                    freqValues[ch][band] = Convert.ToDouble(value);

                }
                //Q VALUES
                for (int band = 0; band < 12; band++)
                {
                    value = "";
                    while (inputValues[i] != '\n')
                    {
                        value += inputValues[i];
                        i++;
                    }
                    i++;
                    qValues[ch][band] = Convert.ToDouble(value);
                }
                //GAIN VALUES
                for (int band = 0; band < 12; band++)
                {
                    value = "";
                    while (inputValues[i] != '\n')
                    {
                        value += inputValues[i];
                        i++;
                    }
                    i++;
                    gainValues[ch][band] = Convert.ToDouble(value);
                }
                //TYPE VALUES
                for (int band = 0; band < 12; band++)
                {
                    value = "";
                    while (inputValues[i] != '\n')
                    {
                        value += inputValues[i];
                        i++;
                    }
                    i++;
                    typeValues[ch][band] = value;
                }
                //VOLUME VALUE
                value = "";
                while (inputValues[i] != '\n')
                {
                    value += inputValues[i];
                    i++;
                }
                i++;
                volValues[ch] = Convert.ToDouble(value);
                //DELAY VALUE
                value = "";
                while (inputValues[i] != '\n')
                {
                    value += inputValues[i];
                    i++;
                }
                i++;
                delayValues[ch] = Convert.ToDouble(value);
            }
        }

        private string getValues()
        {
            string values = "";
            for (int ch = 0; ch < 3; ch++)
            {
                foreach (double freqVal in freqValues[ch]) values += freqVal.ToString() + "\n";
                foreach (double qVal in qValues[ch]) values += qVal.ToString() + "\n";
                foreach (double gainVal in gainValues[ch]) values += gainVal.ToString() + "\n";
                foreach (string typeVal in typeValues[ch]) values += typeVal + "\n";
                values += volValues[ch] + "\n";
                values += delayValues[ch] + "\n";
            }
            return values;
        }

        private void saveFile()
        {
            if (fileExists)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                string values = getValues();
                fs.Write(ASCIIEncoding.ASCII.GetBytes(values), 0, values.Length);
                fs.Close();
            }
            else
            {
                var fileDialog = new SaveFileDialog();
                fileDialog.InitialDirectory = "C:";
                fileDialog.Filter = "Bunker Equilizer Configuration | *.eqc";
                fileDialog.RestoreDirectory = true;
                fileDialog.Title = "Save file as";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    FileStream fs = new FileStream(fileName, FileMode.Create);
                    string values = getValues();
                    fs.Write(ASCIIEncoding.ASCII.GetBytes(values), 0, values.Length);
                    fs.Close();
                }
                fileExists = true;
            }
            hasBeenModified = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileExists = false;
            saveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hasBeenModified)
            {
                DialogResult result = MessageBox.Show("The current file has been modified.\nWould you like you save changes?", "BUNKER AUDIO CONTROLLER", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            else this.Close();
        }

        private void appearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayCustom();
        }
    }
}
