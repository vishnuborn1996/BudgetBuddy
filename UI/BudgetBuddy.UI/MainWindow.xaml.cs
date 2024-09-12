using System.Windows;
using System.Windows.Controls;
using BudgetBuddy.Views; // Ensure that HomeView is included in this namespace

namespace BudgetBuddy
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		// Event handler for the Home button click
		private void HomeButton_Click(object sender, RoutedEventArgs e)
		{
			// Load HomeView into the ContentControl
			MainContent.Content = new HomeView();
		}

		// Event handler for the profile section click
		private void ProfileSection_Click(object sender, RoutedEventArgs e)
		{
			// Show the context menu when the profile section is clicked
			StackPanel profileSection = sender as StackPanel;
			if (profileSection != null)
			{
				profileSection.ContextMenu.IsOpen = true;
			}
		}

		// Handlers for context menu options
		private void ViewProfile_Click(object sender, RoutedEventArgs e)
		{
			// Code to open the View Profile screen
			MessageBox.Show("View Profile clicked");
		}

		private void Settings_Click(object sender, RoutedEventArgs e)
		{
			// Code to open the Settings screen
			MessageBox.Show("Settings clicked");
		}

		private void Support_Click(object sender, RoutedEventArgs e)
		{
			// Code to open the Support screen
			MessageBox.Show("Support clicked");
		}

		private void SignOut_Click(object sender, RoutedEventArgs e)
		{
			// Code to sign out
			MessageBox.Show("Sign Out clicked");
		}
	}
}
