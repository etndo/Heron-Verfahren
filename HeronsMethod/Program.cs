using static HeronsMethod.Visualisation;

internal class Program
{
    private static void Main(string[] args)
    {
    Console.Title = "Heron-Verfahren";

    Start:
        Console.WriteLine("\n--Neue Rechnung--\n");

        double A;
    InputA:
        Console.Write("Wurzel aus:");
        try { A = Convert.ToDouble(Console.ReadLine()); } catch { Console.WriteLine("Ungültige Eingabe!"); goto InputA; }
        if (A < 0) { Console.WriteLine("Ungültige Eingabe! (Muss größer >0 sein!)"); goto InputA; }
        double a = A;

        double lasta = 0, b = 1;
        setScale(a);
        Console.WriteLine("Berechne Wurzel aus: " + a + "...");
        drawGraph(a, b);
        while (a - b != 0 /*Dont go on if solved*/ && lasta != a /*Dont loop forever*/)
        {
            lasta = a;
            a = (a + b) / 2;
            b = A / a;
            drawGraph(a, b);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Wurzel: " + a);
        Console.ForegroundColor = ConsoleColor.White;
        goto Start;
    }
}