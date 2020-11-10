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
        private void chartConfig()
        {
            var mapper = Mappers.Xy<ObservablePoint>()
                .X(point => Math.Log10(point.X))
                .Y(point => point.Y);

            cartesianChart1.Series = new SeriesCollection(mapper)
            {
                new LineSeries     //BAND1
                {
                    Values = plotValues[0],
                    Stroke = System.Windows.Media.Brushes.Red,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries    //BAND2
                {
                    Values = plotValues[1],
                    Stroke = System.Windows.Media.Brushes.Blue,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries     //BAND3
                {
                    Values = plotValues[2],
                    Stroke = System.Windows.Media.Brushes.Yellow,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries     //BAND4
                {
                    Values = plotValues[3],
                    Stroke = System.Windows.Media.Brushes.Green,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries     //BAND5
                {
                    Values = plotValues[4],
                    Stroke = System.Windows.Media.Brushes.Orange,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries      //BAND6
                {
                    Values = plotValues[5],
                    Stroke = System.Windows.Media.Brushes.Brown,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries      //BAND7
                {
                    Values = plotValues[6],
                    Stroke = System.Windows.Media.Brushes.Pink,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries      //BAND8
                {
                    Values = plotValues[7],
                    Stroke = System.Windows.Media.Brushes.Purple,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries      //BAND9
                {
                    Values = plotValues[8],
                    Stroke = System.Windows.Media.Brushes.CornflowerBlue,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries      //BAND10
                {
                    Values = plotValues[9],
                    Stroke = System.Windows.Media.Brushes.DarkGreen,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries      //BAND11
                {
                    Values = plotValues[10],
                    Stroke = System.Windows.Media.Brushes.Crimson,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries      //BAND12
                {
                    Values = plotValues[11],
                    Stroke = System.Windows.Media.Brushes.BlanchedAlmond,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
                new LineSeries      //RESULT
                {
                    Values = plotValues[12],
                    Stroke = System.Windows.Media.Brushes.White,
                    StrokeThickness = 3,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    DataLabels = false,
                    PointGeometry = null
                },
            };

            var xAxis = new LogarithmicAxis()
            {
                Base = 10,
                LabelFormatter = value => Math.Pow(10, value).ToString("N"),
                Separator = new Separator
                {
                    Stroke = System.Windows.Media.Brushes.LightGray,
                    StrokeThickness = 0.5
                }
            };

            var yAxis = new Axis()
            {
                MinValue = -30,
                MaxValue = 15,
                Separator = new Separator
                {
                    Stroke = System.Windows.Media.Brushes.LightGray,
                    StrokeThickness = 0.5
                }
            };

            cartesianChart1.AxisX.Add(xAxis);
            cartesianChart1.AxisY.Add(yAxis);

            var uri1 = new Uri("D:/THOR/Assets/circle_1.png", UriKind.Relative);
            var uri2 = new Uri("D:/THOR/Assets/circle_2.png", UriKind.Relative);
            var uri3 = new Uri("D:/THOR/Assets/circle_3.png", UriKind.Relative);
            var uri4 = new Uri("D:/THOR/Assets/circle_4.png", UriKind.Relative);
            var uri5 = new Uri("D:/THOR/Assets/circle_5.png", UriKind.Relative);
            var uri6 = new Uri("D:/THOR/Assets/circle_6.png", UriKind.Relative);
            var uri7 = new Uri("D:/THOR/Assets/circle_7.png", UriKind.Relative);
            var uri8 = new Uri("D:/THOR/Assets/circle_8.png", UriKind.Relative);
            var uri9 = new Uri("D:/THOR/Assets/circle_9.png", UriKind.Relative);
            var uri10 = new Uri("D:/THOR/Assets/circle_10.png", UriKind.Relative);
            var uri11 = new Uri("D:/THOR/Assets/circle_11.png", UriKind.Relative);
            var uri12 = new Uri("D:/THOR/Assets/circle_12.png", UriKind.Relative);

            var element1 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][0]),
                Y = gainValues[currentChannel - 1][0] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri1),
                    Width = 20,
                    Height = 20
                }
            };

            var element2 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][1]),
                Y = gainValues[currentChannel - 1][1] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri2),
                    Width = 20,
                    Height = 20
                }
            };

            var element3 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][2]),
                Y = gainValues[currentChannel - 1][2] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri3),
                    Width = 20,
                    Height = 20
                }
            };

            var element4 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][3]),
                Y = gainValues[currentChannel - 1][3] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri4),
                    Width = 20,
                    Height = 20
                }
            };

            var element5 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][4]),
                Y = gainValues[currentChannel - 1][4] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri5),
                    Width = 20,
                    Height = 20
                }
            };

            var element6 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][5]),
                Y = gainValues[currentChannel - 1][5] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri6),
                    Width = 20,
                    Height = 20
                }
            };

            var element7 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][6]),
                Y = gainValues[currentChannel - 1][6] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri7),
                    Width = 20,
                    Height = 20
                }
            };

            var element8 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][7]),
                Y = gainValues[currentChannel - 1][7] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri8),
                    Width = 20,
                    Height = 20
                }
            };

            var element9 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][8]),
                Y = gainValues[currentChannel - 1][8] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri9),
                    Width = 20,
                    Height = 20
                }
            };

            var element10 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][9]),
                Y = gainValues[currentChannel - 1][9] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri10),
                    Width = 20,
                    Height = 20
                }
            };

            var element11 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][10]),
                Y = gainValues[currentChannel - 1][10] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri11),
                    Width = 20,
                    Height = 20
                }
            };

            var element12 = new VisualElement
            {
                X = Math.Log10(freqValues[currentChannel - 1][11]),
                Y = gainValues[currentChannel - 1][11] + 2,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri12),
                    Width = 20,
                    Height = 20
                }
            };

            cartesianChart1.VisualElements.Add(element1);
            cartesianChart1.VisualElements.Add(element2);
            cartesianChart1.VisualElements.Add(element3);
            cartesianChart1.VisualElements.Add(element4);
            cartesianChart1.VisualElements.Add(element5);
            cartesianChart1.VisualElements.Add(element6);
            cartesianChart1.VisualElements.Add(element7);
            cartesianChart1.VisualElements.Add(element8);
            cartesianChart1.VisualElements.Add(element9);
            cartesianChart1.VisualElements.Add(element10);
            cartesianChart1.VisualElements.Add(element11);
            cartesianChart1.VisualElements.Add(element12);
        }

        private void generateValues(int band)
        {
            double Q = qValues[currentChannel - 1][band - 1];
            double G = gainValues[currentChannel - 1][band - 1];
            double A = Math.Pow(10, G / 40);
            double B = Math.Sqrt(A) / Q;
            double num = 0, den = 0;
            String type;
            switch (currentBand)
            {
                case 1:
                    type = comboBox1.Text;
                    break;
                case 2:
                    type = comboBox2.Text;
                    break;
                case 3:
                    type = comboBox3.Text;
                    break;
                case 4:
                    type = comboBox4.Text;
                    break;
                case 5:
                    type = comboBox5.Text;
                    break;
                case 6:
                    type = comboBox6.Text;
                    break;
                case 7:
                    type = comboBox7.Text;
                    break;
                case 8:
                    type = comboBox8.Text;
                    break;
                case 9:
                    type = comboBox9.Text;
                    break;
                case 10:
                    type = comboBox10.Text;
                    break;
                case 11:
                    type = comboBox11.Text;
                    break;
                case 12:
                    type = comboBox12.Text;
                    break;
                default:
                    type = "Parametric";
                    break;
            }
            for (int i = 0; i < plotFrequencies.Length; i++)
            {
                double W = plotFrequencies[i] / freqValues[currentChannel - 1][band - 1];
                switch (type)
                {
                    case "Parametric":
                        num = Math.Sqrt(Math.Pow(Q - Q * Math.Pow(W, 2), 2) + Math.Pow(W * A, 2));
                        den = Math.Sqrt(Math.Pow(Q - Q * Math.Pow(W, 2), 2) + Math.Pow(W / A, 2));
                        break;
                    case "Low Shelf":
                        num = A * Math.Sqrt(Math.Pow(A - Math.Pow(W, 2), 2) + Math.Pow(B * W, 2));
                        den = Math.Sqrt(Math.Pow(1 - A * Math.Pow(W, 2), 2) + Math.Pow(B * W, 2));
                        break;
                    case "High Shelf":
                        num = A * Math.Sqrt(Math.Pow(1 - A * Math.Pow(W, 2), 2) + Math.Pow(B * W, 2));
                        den = Math.Sqrt(Math.Pow(A - Math.Pow(W, 2), 2) + Math.Pow(B * W, 2));
                        break;
                }
                var point = new ObservablePoint(plotFrequencies[i], 20 * Math.Log10(num / den));
                //magnitudeValues[channel - 1][i] = num / den;
                channelPoints[i] = point;
            }

            plotValues[band - 1].Clear();
            plotValues[band - 1].AddRange(channelPoints);
            generateResult();
        }

        private void generateResult()
        {
            for (int i = 0; i < plotFrequencies.Length; i++)
            {
                double sum = Convert.ToInt32(!checkBox1.Checked) * plotValues[0][i].Y
                            + Convert.ToInt32(!checkBox2.Checked) * plotValues[1][i].Y
                            + Convert.ToInt32(!checkBox3.Checked) * plotValues[2][i].Y
                            + Convert.ToInt32(!checkBox4.Checked) * plotValues[3][i].Y
                            + Convert.ToInt32(!checkBox5.Checked) * plotValues[4][i].Y
                            + Convert.ToInt32(!checkBox6.Checked) * plotValues[5][i].Y
                            + Convert.ToInt32(!checkBox7.Checked) * plotValues[6][i].Y
                            + Convert.ToInt32(!checkBox8.Checked) * plotValues[7][i].Y
                            + Convert.ToInt32(!checkBox9.Checked) * plotValues[8][i].Y
                            + Convert.ToInt32(!checkBox10.Checked) * plotValues[9][i].Y
                            + Convert.ToInt32(!checkBox11.Checked) * plotValues[10][i].Y
                            + Convert.ToInt32(!checkBox12.Checked) * plotValues[11][i].Y;

                var point = new ObservablePoint(plotFrequencies[i], sum);
                channelPoints[i] = point;
            }
            plotValues[12].Clear();
            plotValues[12].AddRange(channelPoints);
        }
    }
}
