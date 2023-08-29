Console.WriteLine("Iveskite valiuta: ");
string currency = Console.ReadLine();
Console.WriteLine("Iveskite suma: ");
Console.WriteLine("____________________");
float sum = Convert.ToSingle(Console.ReadLine());

switch (currency.ToUpper())
{
    case "USD":
        Console.WriteLine(sum + " USD");
        Console.WriteLine(sum * 0.93 + " EUR");
        Console.WriteLine(sum * 0.73 + " GBP");
        Console.WriteLine(sum * 146.51 + " JPY");
        break;

    case "EUR":
        Console.WriteLine(sum * 1.08 + " USD");
        Console.WriteLine(sum + " EUR");
        Console.WriteLine(sum * 0.86 + " GBP");
        Console.WriteLine(sum * 158.39 + " JPY");
        break;

    case "GBP":
        Console.WriteLine(sum * 1.26 + " USD");
        Console.WriteLine(sum * 1.17 + " EUR");
        Console.WriteLine(sum + " GBP");
        Console.WriteLine(sum * 184.59 + " JPY");
        break;

    case "JPY":
        Console.WriteLine(sum * 0.0068 + " USB");
        Console.WriteLine(sum * 0.0063 + "EUR");
        Console.WriteLine(sum * 0.0054 + "GBP");
        Console.WriteLine(sum + "JPY");
        break;

    default: Console.WriteLine("Something wrong");
        break;
}