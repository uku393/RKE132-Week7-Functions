﻿//total < 10 - 1%
//total >= 10 && total < 20
//total >= 20 - 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculatorDiscount(userInput);

Console.WriteLine($"Your discount is: {discount} %");

double newTotal = CalculatedNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculatorDiscount( int total )
{
    if (total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;

    }
    else
    {
        return 10;
    }
}


static double CalculatedNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}

























