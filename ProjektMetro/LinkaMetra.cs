namespace ProjektMetro
{
    public class LinkaMetra
    {
        public string nazev { get; set; }
        public string barva { get; set; }
        public string[] poleStanice { get; set; }
        public bool aktivni { get; set; }

        public void VypisStanice()
        {
            if (poleStanice.Length > 0)
            {
                foreach (var stanice in poleStanice)
                {
                    Console.WriteLine(stanice);
                }
            }
        }

        public void VypisPrvniPosledni()
        {
            if (poleStanice.Length > 0)
            {
                Console.WriteLine(poleStanice[0]);
                Console.WriteLine(poleStanice[poleStanice.Length - 1]);
            }
        }

        public void NastavLinku()
        {
            if (barva == "zelená")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (barva == "červená")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (barva == "žlutá")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (barva == "modrá")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine($"Vítej v lince metra {nazev}");
        }

        public void CasCesty()
        {
            VypisStanice();
            Console.WriteLine("");

            Console.WriteLine("Odkud pojedeš");
            string prvniStanice = Console.ReadLine();
            int indexPrvni = Array.IndexOf(poleStanice, prvniStanice);
            Console.WriteLine("");

            Console.WriteLine("Kam pojedeš");
            string druhaStanice = Console.ReadLine();
            int indexDruha = Array.IndexOf(poleStanice, druhaStanice);
            Console.WriteLine("");

            int dobaCesty = 0;
            dobaCesty = Math.Abs((indexPrvni - indexDruha) * 2);
            if (indexPrvni > indexDruha)
            {
                dobaCesty = (indexPrvni - indexDruha) * 2;
            }
            else if (indexDruha > indexPrvni)
            {
                dobaCesty = (indexDruha - indexPrvni) * 2;
            }

            Console.WriteLine($"Doba cesty bude {Math.Abs(dobaCesty)} minut!");
        }
    }
}
