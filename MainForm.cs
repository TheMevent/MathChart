using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Forms;

namespace MathChart
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var minValue = 0;
            int.TryParse(X0Label.Text, out minValue);

            var maxValue = 100;
            int.TryParse(XNLabel.Text, out maxValue);

            var values = new ChartValues<double>();

            for (var x = minValue; x <= maxValue; x++)
            {
                values.Add(Math.Sin(x));
            }

            cartesianChart1.Series.Clear();
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = values
            });


            var values2 = new ChartValues<double>();
            for (var x = minValue; x <= maxValue; x++)
            {
                values2.Add(Math.Pow(x, 2));
            }
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = values2
            });

            cartesianChart1.AxisX[0].MinValue = minValue;
            cartesianChart1.AxisX[0].MaxValue = maxValue;
        }
    }
}
