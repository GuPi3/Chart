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
using ScottPlot;
namespace Chart
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random rand = new Random(6);
            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            double[] dataX1 = new double[] { 1, 2, 3, 7, 10 };
            double[] dataY2 = new double[] { 1, 3, 6, 9, 15 };
            Chart.Plot.AddScatter(dataX, dataY);
            Chart.Plot.AddScatter(dataX1, dataY2);



            Chart.Plot.Title($"Scatter Plot (points per group)");
            Chart.Plot.XLabel("Horizontal Axis Label");
            Chart.Plot.YLabel("Vertical Axis Label");
            Chart.Refresh();
        }
    }
}
