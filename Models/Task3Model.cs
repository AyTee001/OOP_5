using OOP_5.Models.Helpers;
using System.Collections.Generic;

namespace OOP_5.Models
{
    public static class Task3Model
    {
        public static List<MultiplicationGridItem> GenerateNultiplicationTableData(double num)
        {
            List<MultiplicationGridItem> data = new();
            for(int i = 0; i < 11; i++)
            {
                data.Add(new MultiplicationGridItem
                {
                    Multiplicand = num,
                    Multiplier = i,
                    Result = i * num
                });
            }
            return data;
        }
    }
}
