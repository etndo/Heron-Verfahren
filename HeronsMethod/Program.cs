Start:
Console.WriteLine("\n--Neue Rechnung--\n");

double A;
InputA:
Console.Write("Wurzel aus n: ");
try { A = Convert.ToDouble(Console.ReadLine()); } catch { Console.WriteLine("Ungültige Eingabe!"); goto InputA; }
double a = A;

double lasta = 0;
double b = 1;
Console.WriteLine("Berechne Wurzel aus: " + a + "...");
while(a-b != 0 /*Dont go on if solved*/ && lasta != a /*Dont loop forever*/)
{
    lasta = a;
    a = (a+b)/2;
    b = A/a;
    Console.WriteLine("a: " + a + " b: " + b);
}
Console.WriteLine("Wurzel: " + a);
goto Start;