using OOP_5.ViewModels;
using System.Windows.Controls;

namespace OOP_5.Views
{
    /// <summary>
    /// Interaction logic for Task2.xaml
    /// </summary>
    public partial class Task2 : Page
    {
        public Task2()
        {
            InitializeComponent();
            DataContext = new Task2ViewModel();
        }
    }
}
