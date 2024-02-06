using System;

namespace Uppgift_6_list_inl
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namn på matvaror");
            string matvaror = Console.ReadLine();
            Console.WriteLine("Skriv in priserna på varorna");
            string priser = Console.ReadLine();

            string[] matvarorsplit = matvaror.Split(" ");
            string[] prisersplit = priser.Split(" ");
            if (matvarorsplit.Length != prisersplit.Length)
            {
                Console.WriteLine("Olika antal priser och varor");
                return;
            }
            Dictionary<string, int> prislista = new Dictionary<string, int>();

            for (int i = 0; i < prisersplit.Length; i++)
            {
                prislista.Add(matvarorsplit[i], int.Parse(prisersplit[i]));
            }

            Console.WriteLine("skriv in din handlingslista");
            string handlingslista = Console.ReadLine();
            string[] handlingslistasplit = handlingslista.Split(" ");
            int totalkostnad = 0;
            foreach (string vara in handlingslistasplit)
            {
                int pris = prislista[vara];
                totalkostnad = totalkostnad + pris;
            }
            Console.WriteLine("Totalkostnaden är " + totalkostnad);
        }
    }
}