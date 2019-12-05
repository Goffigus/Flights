using static System.Console;
using System;
class Flights
{
    static void Main()
    {
        int[] flightNumbers = { 201, 321, 510, 633 };
        string[] codes = { "AUS", "CRP", "DWF", "HOU" };
        string[] names = { "Austin", "Corpus Christi", "Dallas Fort Worth", "Houston" };
        string[] times = { "0710", "0830", "0915", "1140" };

        WriteLine("Enter Flight number or aiport code");
        string input = ReadLine();
        int flight;
        if(Int32.TryParse(input, out flight))
        {
            WriteLine(GetFlightInfo(flight, flightNumbers, codes, names, times));
        }
        else
        {
            WriteLine(GetFlightInfo(input, flightNumbers, codes, names, times));
        }
    }

    public static string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
        string message;

        int post = Array.BinarySearch(flightNumbers, flight);

        if(post > -1)
        {
            message = String.Format("Flight #{0} {1} {2}  Scheduled at: {3}",flight,codes[post],names[post],times[post]);
        }
        else
        {
            message = String.Format("Flight #{0} was not found.", flight);
        }

        return message;
    }

    public static string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
        string message = "We don't take code";

        return message;
    }

}
