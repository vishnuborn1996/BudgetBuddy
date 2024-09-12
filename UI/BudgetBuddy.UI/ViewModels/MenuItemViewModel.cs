using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy
{
	public class MenuItemViewModel : INotifyPropertyChanged
	{
		private bool _isActive;
		public bool IsActive
		{
			get => _isActive;
			set
			{
				_isActive = value;
				OnPropertyChanged(nameof(IsActive));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public class MainViewModel
	{
		public MenuItemViewModel HomeTab { get; set; }
		public MenuItemViewModel TrackExpenseTab { get; set; }
		public MenuItemViewModel ManageCategoriesTab { get; set; }

		public MainViewModel()
		{
			HomeTab = new MenuItemViewModel { IsActive = true }; // Set Home as default active
			TrackExpenseTab = new MenuItemViewModel { IsActive = false };
			ManageCategoriesTab = new MenuItemViewModel { IsActive = false };
		}

		public void SetActiveTab(MenuItemViewModel activeTab)
		{
			// Reset all tabs
			HomeTab.IsActive = false;
			TrackExpenseTab.IsActive = false;
			ManageCategoriesTab.IsActive = false;

			// Set active tab
			activeTab.IsActive = true;
		}
	}

}
