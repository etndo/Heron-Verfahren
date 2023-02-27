Start:
Console.WriteLine();
Console.WriteLine("--Neue Rechnung--");
Console.WriteLine();

double A;
double a;
InputA:
Console.Write("FlächenInhalt: ");
try { A = Convert.ToDouble(Console.ReadLine()); } catch { Console.WriteLine("Ungültige Eingabe!"); goto InputA; }
a = A;

double diff;
InputDiff:
Console.Write("Differenz: ");
try { diff = Convert.ToDouble(Console.ReadLine()); } catch { Console.WriteLine("Ungültige Eingabe!"); goto InputDiff; }

int attempts;
InputAttempts:
Console.Write("Max. Versuche: ");
try { attempts = Convert.ToInt32(Console.ReadLine()); } catch { Console.WriteLine("Ungültige Eingabe!"); goto InputAttempts; }

double b = 1;
int attempt = 0;
Console.WriteLine("Berechne Wurzel aus: " + a + "...");
while(a-b > diff && attempt < attempts)
{
    a = a+b; a/= 2;
    b = A/a;
    attempt++;
    Console.WriteLine("#" + attempt + ": " + "a: " + a + " b: " + b);
}
Console.WriteLine("Wurzel: " + a);
goto Start;