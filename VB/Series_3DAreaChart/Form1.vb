Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_3DAreaChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim areaChart3D As New ChartControl()

            ' Add an area series to it.
            Dim series1 As New Series("Series 1", ViewType.Area3D)

            ' Add points to the series.
            series1.Points.Add(New SeriesPoint("A", 10))
            series1.Points.Add(New SeriesPoint("B", 2))
            series1.Points.Add(New SeriesPoint("C", 14))
            series1.Points.Add(New SeriesPoint("D", 7))

            ' Add the series to the chart.
            areaChart3D.Series.Add(series1)

            ' Customize the view-type-specific properties of the series.
            CType(series1.View, Area3DSeriesView).AreaWidth = 5

            ' Access the diagram's options.
            CType(areaChart3D.Diagram, XYDiagram3D).ZoomPercent = 110

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Area Chart"
            areaChart3D.Titles.Add(chartTitle1)
            areaChart3D.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Add the chart to the form.
            areaChart3D.Dock = DockStyle.Fill
            Me.Controls.Add(areaChart3D)
        End Sub

    End Class
End Namespace