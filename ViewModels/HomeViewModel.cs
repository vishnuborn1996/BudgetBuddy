using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BudgetBuddy.ViewModels
{
	public class HomeViewModel : INotifyPropertyChanged
	{
		public ObservableCollection<string> Expenses { get; set; }
		public SeriesCollection MyPieChart { get; set; }

		public HomeViewModel()
		{
			SetupPieChart();
			Expenses = new ObservableCollection<string>
			{
				"Utility Bills - $200",
				"Groceries - $150",
				"Transport - $100",
				"Entertainment - $75",
				"Miscellaneous - $50"
			};
		}

		private void SetupPieChart()
		{
			MyPieChart = new SeriesCollection
			{
				new PieSeries
				{
					Title = "Income",
					Values = new ChartValues<double> { 5000 }, // Your income value
                    DataLabels = true,
					LabelPoint = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P})"
				},
				new PieSeries
				{
					Title = "Expenditure",
					Values = new ChartValues<double> { 3000 }, // Your expenditure value
                    DataLabels = true,
					LabelPoint = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P})"
				}
			};

			OnPropertyChanged(nameof(MyPieChart));
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
