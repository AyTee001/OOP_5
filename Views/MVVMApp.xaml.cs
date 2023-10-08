using System;
using System.Windows;

namespace OOP_5.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MVVMApp : Window
    {
        private readonly Uri _task1Uri = new ("/Views/Task1.xaml", UriKind.Relative);
        private readonly Uri _task2Uri = new ("/Views/Task2.xaml", UriKind.Relative);
        private readonly Uri _task3Uri = new ("/Views/Task3.xaml", UriKind.Relative);
        private Uri _currentUri;

        public MVVMApp()
        {
            InitializeComponent();
            _currentUri = _task1Uri;  // Set the initial source page
            MainFrame.Source = _currentUri;
        }

        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            if (_currentUri != _task1Uri)
            {
                MainFrame.Navigate(_task1Uri);
                _currentUri = _task1Uri;
            }
        }

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            if (_currentUri != _task2Uri)
            {
                MainFrame.Navigate(_task2Uri);
                _currentUri = _task2Uri;
            }
        }

        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            if (_currentUri != _task3Uri)
            {
                MainFrame.Navigate(_task3Uri);
                _currentUri = _task3Uri;
            }
        }
    }
}
