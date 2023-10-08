using OOP_5.ViewModels;
using System.Windows.Controls;

namespace OOP_5.Views
{
    /// <summary>
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Page
    {
        public Task1()
        {
            InitializeComponent();
            DataContext = new Task1ViewModel();
        }
    }
}
