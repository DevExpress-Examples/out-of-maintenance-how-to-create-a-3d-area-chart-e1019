using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_3DAreaChart {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl areaChart3D = new ChartControl();

            // Add an area series to it.
            Series series1 = new Series("Series 1", ViewType.Area3D);
            
            // Add points to the series.
            series1.Points.Add(new SeriesPoint("A", 10));
            series1.Points.Add(new SeriesPoint("B", 2));
            series1.Points.Add(new SeriesPoint("C", 14));
            series1.Points.Add(new SeriesPoint("D", 7));

            // Add the series to the chart.
            areaChart3D.Series.Add(series1);

            // Access the series labels, to hide them.
            series1.Label.Visible = false;
            
            // Customize the view-type-specific properties of the series.
            ((Area3DSeriesView)series1.View).AreaWidth = 5;

            // Access the diagram's options.
            ((XYDiagram3D)areaChart3D.Diagram).ZoomPercent = 110;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Area Chart";
            areaChart3D.Titles.Add(chartTitle1);
            areaChart3D.Legend.Visible = false;

            // Add the chart to the form.
            areaChart3D.Dock = DockStyle.Fill;
            this.Controls.Add(areaChart3D);
        }

    }
}