using OOP_5.Enums;

namespace OOP_5.Models
{
    public static class Task2Model
    {
        public static AgeCategories DefineAge(int age)
        {
            if(age < 13)
            {
                return AgeCategories.Child;
            }
            else if (age < 20){
                return AgeCategories.Teenager;
            }
            else
            {
                return AgeCategories.Adult;
            }
        }
    }
}
