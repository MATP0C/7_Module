using System;

int num1 = -7;
int num2 = 13;
int num3 = -1;
Console.WriteLine(num1.GetNegative());
Console.WriteLine(num1.GetPositive());
Console.WriteLine(num2.GetNegative());
Console.WriteLine(num2.GetPositive());
Console.WriteLine(num3.GetNegative());
Console.WriteLine(num3.GetPositive());
static class IntExtension
{
    public static int GetNegative(this int number)
    {
        if(number > 0)
        {
            return - number;
        }
        else
        {
            return number;
        }
    }
    public static int GetPositive(this int number)
    {
        if(number < 0)
        {
            return -number;
        }
        else
        {
            return number;
        }
    }
}