using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BudgetBuddy.ViewModels
{
	public class TrackExpenseViewModel : INotifyPropertyChanged
	{
		public ObservableCollection<Expense> Expenses { get; set; }

		public TrackExpenseViewModel()
		{
			Expenses = new ObservableCollection<Expense>
			{
				new Expense { Name = "Groceries", Amount = 150, Category = "Groceries" },
				new Expense { Name = "Transport", Amount = 100, Category = "Transport" }
			};
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public class Expense
	{
		public string Name { get; set; }
		public double Amount { get; set; }
		public string Category { get; set; }
	}
}
