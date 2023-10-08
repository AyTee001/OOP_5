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
                        if (!double.TryParse(Number1, out _))
                        {
                            return "No that was not a double";
                        }
                        break;

                    case "Number2":
                        if (!double.TryParse(Number1, out _))
                        {
                            return "No that was not a double";
                        }
                        break;
                }
                return null!;
            }

        }
    }
}
