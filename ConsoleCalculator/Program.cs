using System;
using System.Linq;

class Calculator
{
    public static void Main()
    {

        Console.WriteLine("Podaj pierwszą liczbę:");
        string pierwsza_liczba = Console.ReadLine();

        bool test_liczby = float.TryParse(pierwsza_liczba, out float n);

        Console.WriteLine("Czy pierwsza liczba jest liczbą?: " + test_liczby);

        Console.WriteLine("Pierwsza liczba to: " + pierwsza_liczba);

        // w razie potrzeby umieszczamy komentarz
        float pierwsza = 0.0F;
        pierwsza = float.Parse(pierwsza_liczba);

        Console.WriteLine("Podaj drugą liczbę:");
        string druga_liczba = Console.ReadLine();
        Console.WriteLine("Druga liczba to: " + druga_liczba);
        float druga = float.Parse(druga_liczba);

        Console.WriteLine("Podaj symbol działania:");
        string operation = Console.ReadLine();
        Console.WriteLine("Znak działania to: " + operation);

        switch(operation)
        {
            case "+":
                Console.WriteLine("Wynik dodawania to: " + add(pierwsza, druga));
                break;

            case "-":
                Console.WriteLine("Wynik odejmowania to: " + subtract(pierwsza, druga));
                break;

            case "*":

                Console.WriteLine("Wynik mnożenia to: " + multiply(pierwsza, druga));
                break;

            case "/":
                Console.WriteLine("Wynik dzielenia: " + divide(pierwsza, druga));
                break;

            default:
                Console.WriteLine("Coś poszło nie tak, wybierz inne działanie");
                break;
        }

        Console.WriteLine("\npress any key to exit the process...");
    }

    static float add(float a, float b)
    {
        return a + b;
    }

    static float multiply(float a, float b)
    {
        return a * b;
    }

    static float divide(float a, float b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Nie dziel cholero przez zero!!!");
            return 0.0F;
        }
    }

    static float subtract(float a, float b)
    {
        return a - b;
    }

    // obsługa znaków innych niż liczby

    // obsługa wyjścia z programu po wciśnięciu klawisza, np. ESC

    // inne działania matematyczne
}
