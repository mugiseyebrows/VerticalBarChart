using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace VerticalBarChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlotModel Model { get; set; } = new PlotModel
        {
            Title = "An Example Chart with 1 Bar Series",
            Background = OxyColors.White
        };

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Model.Axes.Add(new CategoryAxis { Position = AxisPosition.Bottom, LabelFormatter = (v) => String.Format("{0:F0}", v) }); ;
            Model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            var barSeries = new StretchyLinearBarSeries { BarWidth = 0.8 };
            Model.Series.Add(barSeries);
            barSeries.Items.Add(new BarItem(0));
            barSeries.Items.Add(new BarItem(18));
            barSeries.Items.Add(new BarItem(12));
            barSeries.Items.Add(new BarItem(8));
            barSeries.Items.Add(new BarItem(15));
        }
    }
}
