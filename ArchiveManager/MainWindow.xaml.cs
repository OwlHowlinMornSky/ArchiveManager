using System.Windows;

namespace ArchiveManager {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Grid_Loaded(object sender, RoutedEventArgs e) {
			string str = "Hello, World!";
			var hash1 = Hash.GetHashOfString(str);
			MessageBox.Show(str + '\n' + hash1);
		}
	}
}