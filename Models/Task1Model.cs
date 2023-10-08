using OOP_5.Enums;
using System;
using System.ComponentModel;

namespace OOP_5.Models
{
    public static class Task1Model
    {
        public static double ActionWithToNums(double num1, double num2, ArithmeticOperators numOperator)
        {
            return numOperator switch
            {
                ArithmeticOperators.Addition => num1 + num2,
                ArithmeticOperators.Division => num1 / num2,
                ArithmeticOperators.Multiplication => num1 * num2,
                ArithmeticOperators.Subtraction => num1 - num2,
                _ => throw new InvalidEnumArgumentException("No such operator exists on target enum: " + nameof(ArithmeticOperators))
            };
        }
    }
}
