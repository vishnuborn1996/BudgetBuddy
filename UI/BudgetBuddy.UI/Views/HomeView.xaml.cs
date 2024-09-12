using BudgetBuddy.ViewModels;
using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace BudgetBuddy.Views
{
	public partial class HomeView : UserControl
	{
		public HomeView()
		{
			InitializeComponent();
			DataContext = new HomeViewModel();
		}
	}
}
