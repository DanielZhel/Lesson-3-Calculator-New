using LIbrary;
using System;

Console.Title = "Calculator";

double firstValue;
double secondValue;
double res = 0;

string cont= "+";

Queue <double> fiveLast = new Queue <double>(5);

while (cont == "+")
{
    Console.Clear();
    try
    {
        firstValue = calculator.firstValue();

        secondValue = calculator.secondValue();
    }
    catch (Exception)
    {
        Console.WriteLine("Not valid action.Try again");
        continue;
    }
    string repeat = calculator.chooseAction();

    switch (repeat)
    {
        case "div":
            Console.WriteLine($"REsult is {firstValue / secondValue}");
            res = firstValue/ secondValue;
            break;
        case "add":
            Console.WriteLine($"REsult is {firstValue + secondValue}");
            res = firstValue + secondValue;
            break;
        case "sub":
            Console.WriteLine($"REsult is {firstValue - secondValue}");
            res = firstValue - secondValue;
            break;
        case "mult":
            Console.WriteLine($"REsult is {firstValue * secondValue}");
            res = firstValue *secondValue;
            break;
            default:
            Console.WriteLine("Try again");
            Console.ReadLine();
            continue;
    }

    fiveLast.Enqueue(res);

    if (fiveLast.Count > 5)
    {
        fiveLast.Dequeue();
    }

    string resultString = "";
    foreach (var item in fiveLast)
    {
        resultString += item;
    }

    switch (calculator.Menu())
    {
        case "1":
            cont = "+";
            break;
        case "2":
            Console.WriteLine($"Five last element of the queue is {resultString}");
            Console.ReadLine();
            break;

        case "3":
            firstValue = calculator.firstValue();
            secondValue = calculator.secondValue();
            switch (repeat)
            {
                case "div":
                    Console.WriteLine($"REsult is {firstValue / secondValue}");
                    res = firstValue / secondValue;
                    break;
                case "add":
                    Console.WriteLine($"REsult is {firstValue + secondValue}");
                    res = firstValue + secondValue;
                    break;
                case "sub":
                    Console.WriteLine($"REsult is {firstValue - secondValue}");
                    res = firstValue - secondValue;
                    break;
                case "mult":
                    Console.WriteLine($"REsult is {firstValue * secondValue}");
                    res = firstValue * secondValue;
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
            Console.ReadLine ();
            break;

        case "4":
            cont = "-";
            break;
        default:
            Console.WriteLine("Something wrong.Try again!");
            continue;

    }

}


