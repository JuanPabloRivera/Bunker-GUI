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
        private ComboBox themeSelector = new ComboBox();
        private ComboBox fontSelector = new ComboBox();
        private System.Drawing.Color selectedBackColor = System.Drawing.Color.SteelBlue;
        private System.Drawing.Color selectedForeColor = System.Drawing.Color.White;
        private System.Drawing.Color backColor = System.Drawing.Color.White;
        private System.Drawing.Color foreColor = System.Drawing.Color.Black;
        private System.Drawing.Color backgroundColorDark = System.Drawing.Color.Black;
        private System.Drawing.Color backgroundColorLight = System.Drawing.Color.FromArgb(150, 150, 150);
        private SolidColorBrush separatorColor = System.Windows.Media.Brushes.LightGray;

        private void displayCustom()
        {
            //NEW FORM
            Form customForm = new Form();
            customForm.Text = "Appearance";
            customForm.BackColor = backgroundColorDark;
            customForm.Icon = new System.Drawing.Icon("D:/THOR/Assets/thor_icon_inverted.ico");
            customForm.MinimumSize = new Size(300, 250);
            customForm.MaximumSize = new Size(300, 250);

            //NEW PANEL
            Panel container = new Panel();
            container.Text = "";
            container.BackColor = backgroundColorLight;

            customForm.Controls.Add(container);
            container.Location = new Point(10, 10);
            container.Size = new Size(customForm.Width - 35, customForm.Height - 58);

            //LABELS AND COMBOBOXES
            Label theme = new Label();
            theme.Text = "Theme";
            theme.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            theme.BackColor = System.Drawing.Color.Transparent;

            Label font = new Label();
            font.Text = "Font";
            font.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            font.BackColor = System.Drawing.Color.Transparent;

            themeSelector.Items.AddRange(new object[] { "Midnight Blue", "Fire Red", "Forest Green", "THOR Yellow" });
            themeSelector.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            themeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            themeSelector.Text = themeSelector.Items[0].ToString();
            themeSelector.SelectedIndexChanged += new EventHandler(themeSelector_SelectedIndexChanged);

            fontSelector.Items.AddRange(new object[] { "Microsoft Sans Serif", "Helvetica", "Arial" });
            fontSelector.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            fontSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            fontSelector.Text = fontSelector.Items[0].ToString();
            fontSelector.SelectedIndexChanged += new EventHandler(fontSelector_SelectedIndexChanged);

            container.Controls.Add(theme);
            container.Controls.Add(themeSelector);
            container.Controls.Add(font);
            container.Controls.Add(fontSelector);

            theme.Location = new Point(25, 25);
            themeSelector.Location = new Point(75, 50);
            font.Location = new Point(25, 90);
            fontSelector.Location = new Point(75, 115);

            customForm.Show();
        }

        private void themeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themeSelector.SelectedItem.ToString())
            {
                case "Midnight Blue":
                    selectedBackColor = System.Drawing.Color.SteelBlue;
                    selectedForeColor = System.Drawing.Color.White;
                    backColor = System.Drawing.Color.White;
                    foreColor = System.Drawing.Color.Black;
                    backgroundColorDark = System.Drawing.Color.Black;
                    backgroundColorLight = System.Drawing.Color.FromArgb(150, 150, 150);
                    separatorColor = System.Windows.Media.Brushes.LightGray;
                    cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(35, 35, 35));
                    break;
                case "Fire Red":
                    selectedBackColor = System.Drawing.Color.Crimson;
                    selectedForeColor = System.Drawing.Color.White;
                    backColor = System.Drawing.Color.White;
                    foreColor = System.Drawing.Color.Black;
                    backgroundColorDark = System.Drawing.Color.LightGray;
                    backgroundColorLight = System.Drawing.Color.Gray;
                    separatorColor = System.Windows.Media.Brushes.LightGray;
                    cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(35, 35, 35));
                    break;
                case "Forest Green":
                    selectedBackColor = System.Drawing.Color.GreenYellow;
                    selectedForeColor = System.Drawing.Color.White;
                    backColor = System.Drawing.Color.White;
                    foreColor = System.Drawing.Color.Black;
                    backgroundColorDark = System.Drawing.Color.Black;
                    backgroundColorLight = System.Drawing.Color.DarkGreen;
                    separatorColor = System.Windows.Media.Brushes.LightGray;
                    cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(35, 35, 35));
                    break;
                case "THOR Yellow":
                    selectedBackColor = System.Drawing.Color.FromArgb(255,203,30);
                    selectedForeColor = System.Drawing.Color.Black;
                    backColor = System.Drawing.Color.White;
                    foreColor = System.Drawing.Color.Black;
                    backgroundColorDark = System.Drawing.Color.Black;
                    backgroundColorLight = System.Drawing.Color.Gray;
                    separatorColor = System.Windows.Media.Brushes.LightGray;
                    cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(35, 35, 35));
                    break;
            }
            resetProgramColors();
        }

        private void fontSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            return;
        }

        private void resetTextboxColors()
        {
            textBox1.BackColor = backColor;
            textBox1.ForeColor = foreColor;
            textBox2.BackColor = backColor;
            textBox2.ForeColor = foreColor;
            textBox3.BackColor = backColor;
            textBox3.ForeColor = foreColor;
            textBox4.BackColor = backColor;
            textBox4.ForeColor = foreColor;
            textBox5.BackColor = backColor;
            textBox5.ForeColor = foreColor;
            textBox6.BackColor = backColor;
            textBox6.ForeColor = foreColor;
            textBox7.BackColor = backColor;
            textBox7.ForeColor = foreColor;
            textBox8.BackColor = backColor;
            textBox8.ForeColor = foreColor;
            textBox9.BackColor = backColor;
            textBox9.ForeColor = foreColor;
            textBox1.BackColor = backColor;
            textBox1.ForeColor = foreColor;
            textBox2.BackColor = backColor;
            textBox2.ForeColor = foreColor;
            textBox3.BackColor = backColor;
            textBox3.ForeColor = foreColor;
            textBox4.BackColor = backColor;
            textBox4.ForeColor = foreColor;
            textBox5.BackColor = backColor;
            textBox5.ForeColor = foreColor;
            textBox6.BackColor = backColor;
            textBox6.ForeColor = foreColor;
            textBox7.BackColor = backColor;
            textBox7.ForeColor = foreColor;
            textBox8.BackColor = backColor;
            textBox8.ForeColor = foreColor;
            textBox9.BackColor = backColor;
            textBox9.ForeColor = foreColor;
            textBox10.BackColor = backColor;
            textBox10.ForeColor = foreColor;
            textBox11.BackColor = backColor;
            textBox11.ForeColor = foreColor;
            textBox12.BackColor = backColor;
            textBox12.ForeColor = foreColor;
            textBox13.BackColor = backColor;
            textBox13.ForeColor = foreColor;
            textBox14.BackColor = backColor;
            textBox14.ForeColor = foreColor;
            textBox15.BackColor = backColor;
            textBox15.ForeColor = foreColor;
            textBox16.BackColor = backColor;
            textBox16.ForeColor = foreColor;
            textBox17.BackColor = backColor;
            textBox17.ForeColor = foreColor;
            textBox18.BackColor = backColor;
            textBox18.ForeColor = foreColor;
            textBox19.BackColor = backColor;
            textBox19.ForeColor = foreColor;
            textBox20.BackColor = backColor;
            textBox20.ForeColor = foreColor;
            textBox21.BackColor = backColor;
            textBox21.ForeColor = foreColor;
            textBox22.BackColor = backColor;
            textBox22.ForeColor = foreColor;
            textBox23.BackColor = backColor;
            textBox23.ForeColor = foreColor;
            textBox24.BackColor = backColor;
            textBox24.ForeColor = foreColor;
            textBox25.BackColor = backColor;
            textBox25.ForeColor = foreColor;
            textBox26.BackColor = backColor;
            textBox26.ForeColor = foreColor;
            textBox27.BackColor = backColor;
            textBox27.ForeColor = foreColor;
            textBox28.BackColor = backColor;
            textBox28.ForeColor = foreColor;
            textBox29.BackColor = backColor;
            textBox29.ForeColor = foreColor;
            textBox30.BackColor = backColor;
            textBox30.ForeColor = foreColor;
            textBox31.BackColor = backColor;
            textBox31.ForeColor = foreColor;
            textBox32.BackColor = backColor;
            textBox32.ForeColor = foreColor;
            textBox33.BackColor = backColor;
            textBox33.ForeColor = foreColor;
            textBox34.BackColor = backColor;
            textBox34.ForeColor = foreColor;
            textBox35.BackColor = backColor;
            textBox35.ForeColor = foreColor;
            textBox36.BackColor = backColor;
            textBox36.ForeColor = foreColor;
            textBox38.BackColor = backColor;
            textBox38.ForeColor = foreColor;
            textBox39.BackColor = backColor;
            textBox39.ForeColor = foreColor;
            textBox40.BackColor = backColor;
            textBox40.ForeColor = foreColor;
            textBox42.BackColor = backColor;
            textBox42.ForeColor = foreColor;
        }

        private void resetButtonColors()
        {
            button1.BackColor = backColor;
            button1.ForeColor = foreColor;
            button2.BackColor = backColor;
            button2.ForeColor = foreColor;
            button3.BackColor = backColor;
            button3.ForeColor = foreColor;
        }
    
        private void resetProgramColors()
        {
            resetTextboxColors();
            resetButtonColors();
            this.BackColor = backgroundColorDark;
            panel1.BackColor = backgroundColorLight;
            panel2.BackColor = backgroundColorLight;
            panel3.BackColor = backgroundColorLight;
            panel4.BackColor = backgroundColorLight;
            macTrackBar1.TrackerColor = selectedBackColor;
            macTrackBar1.TrackLineColor = backgroundColorDark;
            macTrackBar1.TrackLineSelectedColor = selectedBackColor;
            macTrackBar2.TrackerColor = selectedBackColor;
            macTrackBar2.TrackLineColor = backgroundColorDark;
            macTrackBar2.TrackLineSelectedColor = selectedBackColor;
            macTrackBar3.TrackerColor = selectedBackColor;
            macTrackBar3.TrackLineColor = backgroundColorDark;
            macTrackBar3.TrackLineSelectedColor = selectedBackColor;
            macTrackBar4.TrackerColor = selectedBackColor;
            macTrackBar4.TrackLineColor = backgroundColorDark;
            macTrackBar4.TrackLineSelectedColor = selectedBackColor;
            button1.PerformClick();
        }
    }
}
