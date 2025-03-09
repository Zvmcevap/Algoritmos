
namespace Algoritmos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey goodlookin'");

            while (true)
            {
                int n = 0;
                bool isValidInput = false;

                while (!isValidInput)
                {
                    Console.WriteLine("\nvpiši število naravno število n");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out n))
                    {
                        if (n > 0)
                        {
                            isValidInput = true;
                            Console.WriteLine($"n = {n}");
                        }
                        else
                        {
                            Console.WriteLine("n je manjši od 0 :(");
                        }
                    }
                    else
                    {
                        Console.WriteLine("To ni naravno število, womp womp");
                    }
                }

                Console.WriteLine();

                int kc = KonstantniCas(n);
                Console.WriteLine($"Koraki = {kc} za konstantni čas O(1)");

                int logc = LogaritmicCas(n);
                Console.WriteLine($"Koraki = {logc} za logaritemski čas");

                int lc = LinearniCas(n);
                Console.WriteLine($"Koraki = {lc} za linearni čas");

                int nlogc = linearniKratLogaritmicniCas(n);
                Console.WriteLine($"Koraki = {nlogc} za nlog(n) čas");

                int qc = KvadratniCas(n);
                Console.WriteLine($"Koraki = {qc} za kvadratni čas");

            }
        }

        // O(1)
        public static int KonstantniCas(int n)
        {
            int korak = 0;
            int i = 0;
            // Zanka neodvisna od n, šla bo do 10 vsakič. Lahko bi bilo več zank, vgnezdenih ali ne,
            // ampak ker niso odvisne od n se bo vedno končalo z istim številom korakov
            while (i < 10)
            {
                korak = korak + 1;
                i++; // To je isto kot i = i + 1 bbygirl, povečamo i za 1 ;)
            }

            return korak;
        }

        // O(n)
        public static int LinearniCas(int n)
        {
            int korak = 0;
            int i = 0;
            // Ena zanka odvisna od n, število korakov bo == n-ju na koncu
            while (i < n)
            {
                korak = korak + 1;
                i++;
            }
            return korak;
        }
        // O(n^2)
        public static int KvadratniCas(int n)
        {
            int korak = 0;
            int i = 0;
            while (i < n) // prva zanka, i večamo do n
            {
                int j = 0; // j postavimo na 0 vsakič ko prva zanka začne nov krog

                while (j < n) // druga zanka od j
                {
                    korak = korak + 1; // Korake štejemo v drugi zanki, ker je najbolj notranja se bo zgodila največkrat
                    j++; // j povečamu v drugi zanki
                }

                i++; // i povečam v prvi zanki
            }
            return korak;
        }

        // O(log(n))
        public static int LogaritmicCas(int n)
        {
            // Za log delimo al pa množimo z dva nekaj ki je n velikosti
            int korak = 0;
            while (n > 0) // Dokler je n večji od 0
            {
                n = n / 2; // n delimo z 2 (zadnjič bo 1/2 kar bo zaokrožil na 0 ker je int)
                korak = korak + 1;
            }

            return korak;
        }

        // O(nlog(n))
        public static int linearniKratLogaritmicniCas(int n)
        {
            int korak = 0;
            int i = 0;
            // Da ti dam še en mal bol kompleksn, lahk združmo n in log(n) čas

            while (i < n) // linearna, n
            {
                int j = 1; // kle sem dal 1 ker bom podvajal vsakič

                while (j < n) // logaritemska log(n)
                {
                    korak = korak + 1;
                    j = j * 2; // je bo šel 1, 2, 4, 8, 16, ...
                }

                i++; // i pa bo šel 1, 2, 3, 4, ...
            }

            // skupaj bosta zanki pomnoženi n * log(n), tko kot pri množenju lahk drgač zamenjaš vrstni red, kera je prva kera druga :)

            return korak;
        }

        // O(2^n) - tale še pride na vrsto
        public static int EksponentniCas(int n)
        {
            int korak = 0;


            return korak;
        }
    }
}
