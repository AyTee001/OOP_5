using System.ComponentModel;

namespace OOP_5.ViewModels
{
    public partial class Task2ViewModel : IDataErrorInfo
    {
        public string Error
        {
            get { return null!; }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Age")
                {
                    if (_hasUserInteractedAge && (string.IsNullOrEmpty(Age) || !int.TryParse(Age, out int val) || val < 1 || val > 150))
                        return "Age needs to be a positive integer between 1 and 150";
                }

                return null!;
            }
        }
    }
}
