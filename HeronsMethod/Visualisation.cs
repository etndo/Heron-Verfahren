namespace HeronsMethod
{
    internal class Visualisation
    {
        static double scale;
        public static void setScale(double Scale)
        {
            if (Scale < 1) { Scale++; }
            scale = Scale;
        }
        public static void drawGraph(double a, double b)
        {
            double aLocation = (a / scale) * 60; //Sets location of values on the graph
            double bLocation = (b / scale) * 60; //*60 because of the graphs length of 60

            bool drawA;
            bool drawB;
            for (int i = 0; i < 61; i++)
            {
                if (i < aLocation + 0.5 && i > aLocation - 0.5) //Determines wether to draw graph for A
                {
                    drawA = true;
                }
                else drawA = false;

                if (i < bLocation + 0.5 && i > bLocation - 0.5) //Determines wether to draw graph for B
                {
                    drawB = true;
                }
                else drawB = false;

                if (drawA) //Draws Graph
                {
                    if (drawB)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("█");
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("█");
                    continue;
                }
                if (drawB)
                {
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("█");
                    continue;
                }
                Console.Write(" ");
            }
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("a: " + a);

            string aString = a + ""; //Buffer so its all alligned, 19 == max double string length
            int bufferLength = 19 - aString.Length;

            for (int i = 0; i < bufferLength; i++) //Writes buffer
            {
                Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" b: " + b);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
