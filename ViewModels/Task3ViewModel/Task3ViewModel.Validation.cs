using System.ComponentModel;

namespace OOP_5.ViewModels
{
    partial class Task3ViewModel : IDataErrorInfo
    {
        public string Error
        {
            get { return null!; }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Number")
                {
                    if (!double.TryParse(Number, out _))
                    {
                        return "No that was not a valid number";
                    }
                }

                return null!;
            }
        }
    }
}
