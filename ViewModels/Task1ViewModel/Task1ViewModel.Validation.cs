using System.ComponentModel;

namespace OOP_5.ViewModels
{
    public partial class Task1ViewModel : IDataErrorInfo
    {
        public string Error
        {
            get { return null!; }
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Number1":
                        if (!double.TryParse(Number1, out _) && _hasUserInteractedNumber1)
                        {
                            CanExecute = false;
                            return "No that was not a double";
                        }
                        break;

                    case "Number2":
                        if (!double.TryParse(Number2, out _) && _hasUserInteractedNumber2)
                        {
                            CanExecute = false;
                            return "No that was not a double";
                        }
                        break;
                }
                CanExecute = true && _hasUserInteractedNumber1 && _hasUserInteractedNumber2;
                return null!;
            }

        }
    }
}
