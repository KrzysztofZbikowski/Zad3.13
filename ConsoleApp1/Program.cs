class Zad
{
    static void Main(string[] args)
    {
        int n, suma=0, start=1;
        Console.WriteLine("Podaj liczbę naturalną");
        n = int.Parse(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            if (start%2!=0)
            {
                suma = suma + start;
                start++;
            }
            else
            {
                suma = suma - start;
                start++;
            }
        }
        Console.WriteLine("Suma twojego ciągu wynosi: " + suma);
        Console.ReadKey();
    }
}