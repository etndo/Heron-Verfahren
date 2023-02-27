Start:
Console.WriteLine("\n--Neue Rechnung--\n");

double A;
InputA:
Console.Write("Wurzel aus n: ");
try { A = Convert.ToDouble(Console.ReadLine()); } catch { Console.WriteLine("Ungültige Eingabe!"); goto InputA; }
double a = A;

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
if(b > a) { double c = a; a = b; b = c;}
Console.WriteLine("Berechne Wurzel aus: " + a + "...");
while(a-b > diff && attempt < attempts)
{
    a += b; a/= 2;
    b = A/a;
    if (b > a) { double c = a; a = b; b = c; }
    attempt++;
    Console.WriteLine("#" + attempt + ": " + "a: " + a + " b: " + b);
}
Console.WriteLine("Wurzel: " + a);
goto Start;