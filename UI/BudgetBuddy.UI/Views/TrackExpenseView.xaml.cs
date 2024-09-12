using System.Windows.Controls;
using BudgetBuddy.ViewModels;

namespace BudgetBuddy.Views
{
	public partial class TrackExpenseView : UserControl
	{
		public TrackExpenseView()
		{
			InitializeComponent();
			DataContext = new TrackExpenseViewModel();
		}
	}
}
