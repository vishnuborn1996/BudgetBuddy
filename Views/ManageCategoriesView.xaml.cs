using System.Windows.Controls;
using BudgetBuddy.ViewModels;

namespace BudgetBuddy.Views
{
	public partial class ManageCategoriesView : UserControl
	{
		public ManageCategoriesView()
		{
			InitializeComponent();
			DataContext = new ManageCategoriesViewModel();
		}
	}
}
