namespace _5._3
{
    enum seme
    {
        cuori = 0,
        picche = 1,
        fiori = 2,
        quadri = 3,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scegliere un seme");
            string scelta = Console.ReadLine();
            seme numCarta = (seme)Enum.Parse(typeof(seme), scelta);
            Console.WriteLine((int)numCarta);
        }
    }
}
