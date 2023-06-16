using ProjektMetro;

string[] poleLinkaA = { "Nemocnine Motol", "Petříny", "Nádraží Veleslavín", "Bořislavka", "Dejvcická", "Hradčanská", "Malostranská", "Staroměstská", "Můstek", "Muzeum", "Náměstí Míru", "Jířího z Poděbrad", "Flora", "Želivského", "Strašnická", "Skalka", "Depo Hostivař" };
string[] poleLinkaB = { "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice", "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí", "Národní Třída", "Můstek", "Náměstí Republiky", "Florenc", "Křižíkova", "Invalidovna", "Palmovka", "Českomoravská", "Vysočanská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý most"};
string[] poleLinkaC = { "Letňany", "Prosek", "Střižíkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum", "I. P. Pavlova", "Vyšehrad", "Pražského Povstání", "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje" };
string[] poleLinkaD = { "Náměstí Míru", "Náměstí Bří synků", "Pankrác", "Olbrachtova", "Nádraží Krč", "Nemocnice Krč", "Nové Dvory", "Libuš", "Písnice", "Depo Písnice"};

Console.WriteLine("Zadej název linky (A-D)");
string volbaLinky = Console.ReadLine().ToUpper();
if (volbaLinky == "A")
{
    LinkaMetra linkaA = new LinkaMetra()
    {
        nazev = "A",
        barva = "zelená",
        aktivni = true,
        poleStanice = poleLinkaA
    };
    linkaA.NastavLinku();

    Console.WriteLine("1 - Vypsat všechny stanice \n2 - Vypsat jenom první a poslední \n3 - Zjistit čas mezi stanicemi");
    string volbaVypsani = Console.ReadLine();
    if (volbaVypsani == "1")
    {
        linkaA.VypisStanice();
    }
    else if (volbaVypsani == "2")
    {
        linkaA.VypisPrvniPosledni();
    }
    else if (volbaVypsani == "3")
    {
        linkaA.CasCesty();
    }
}
else if (volbaLinky == "B")
{
    LinkaMetra linkaB = new LinkaMetra()
    {
        nazev = "B",
        barva = "žlutá",
        aktivni = true,
        poleStanice = poleLinkaB
    };
    linkaB.NastavLinku();

    Console.WriteLine("1 - Vypsat všechny stanice \n2 - Vypsat jenom první a poslední \n3 - Zjistit čas mezi stanicemi");
    string volbaVypsani = Console.ReadLine();
    if (volbaVypsani == "1")
    {
        linkaB.VypisStanice();
    }
    else if (volbaVypsani == "2")
    {
        linkaB.VypisPrvniPosledni();
    }
    else if (volbaVypsani == "3")
    {
        linkaB.CasCesty();
    }
}
else if (volbaLinky == "C")
{
    LinkaMetra linkaC = new LinkaMetra()
    {
        nazev = "C",
        barva = "červená",
        aktivni = true,
        poleStanice = poleLinkaC
    };
    linkaC.NastavLinku();

    Console.WriteLine("1 - Vypsat všechny stanice \n2 - Vypsat jenom první a poslední \n3 - Zjistit čas mezi stanicemi");
    string volbaVypsani = Console.ReadLine();
    if (volbaVypsani == "1")
    {
        linkaC.VypisStanice();
    }
    else if (volbaVypsani == "2")
    {
        linkaC.VypisPrvniPosledni();
    }
    else if (volbaVypsani == "3")
    {
        linkaC.CasCesty();
    }
}
else if (volbaLinky == "D")
{
    LinkaMetra linkaD = new LinkaMetra()
    {
        nazev = "D",
        barva = "modrá",
        aktivni = false,
        poleStanice = poleLinkaD
    };
    linkaD.NastavLinku();

    Console.WriteLine("1 - Vypsat všechny stanice \n2 - Vypsat jenom první a poslední \n3 - Zjistit čas mezi stanicemi");
    string volbaVypsani = Console.ReadLine();
    if (volbaVypsani == "1")
    {
        linkaD.VypisStanice();
    }
    else if (volbaVypsani == "2")
    {
        linkaD.VypisPrvniPosledni();
    }
    else if (volbaVypsani == "3")
    {
        linkaD.CasCesty();
    }
}
