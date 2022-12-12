using Syncfusion.Maui.Charts;

namespace SolarManager;

public partial class Graphs : ContentPage
{
	public Graphs()
	{
        this.BindingContext = new ViewModel();
        InitializeComponent();
        SfCartesianChart chart = new SfCartesianChart();

        DateTimeAxis primaryAxis = new DateTimeAxis();
        chart.XAxes.Add(primaryAxis);

        NumericalAxis secondaryAxis = new NumericalAxis();
        chart.YAxes.Add(secondaryAxis);

        ColumnSeries series = new ColumnSeries();
        series.Label = "KW";
        series.ShowDataLabels = true;
        series.ItemsSource = (new ViewModel()).Data;
        series.XBindingPath = "Time";
        series.YBindingPath = "KW";

        chart.Series.Add(series);
    }
}