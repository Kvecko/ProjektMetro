using ProjektMetro;
using Spectre.Console;

string[] poleLinkaA = { "Nemocnine Motol", "Petříny", "Nádraží Veleslavín", "Bořislavka", "Dejvcická", "Hradčanská", "Malostranská", "Staroměstská", "Můstek", "Muzeum", "Náměstí Míru", "Jířího z Poděbrad", "Flora", "Želivského", "Strašnická", "Skalka", "Depo Hostivař" };
string[] poleLinkaB = { "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jinonice", "Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí", "Národní Třída", "Můstek", "Náměstí Republiky", "Florenc", "Křižíkova", "Invalidovna", "Palmovka", "Českomoravská", "Vysočanská", "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý most"};
string[] poleLinkaC = { "Letňany", "Prosek", "Střižíkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum", "I. P. Pavlova", "Vyšehrad", "Pražského Povstání", "Pankrác", "Budějovická", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje" };
string[] poleLinkaD = { "Náměstí Míru", "Náměstí Bří synků", "Pankrác", "Olbrachtova", "Nádraží Krč", "Nemocnice Krč", "Nové Dvory", "Libuš", "Písnice", "Depo Písnice"};

var volbaLinky = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Vyber si linku")
        .PageSize(10)
        .AddChoices(new[] {
            "A", "B", "C", "D"
        }));

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

    var volbaVypsani = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .PageSize(10)
        .HighlightStyle(Color.Green3)
        .AddChoices(new[] {
            "Vypsat všechny stanice", "Vypsat jenom první a poslední", "Zjistit čas mezi stanicemi"
        }));

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

    var volbaVypsani = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .PageSize(10)
        .HighlightStyle(Color.Yellow1)
        .AddChoices(new[] {
            "Vypsat všechny stanice", "Vypsat jenom první a poslední", "Zjistit čas mezi stanicemi"
        }));

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

    var volbaVypsani = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .PageSize(10)
        .HighlightStyle(Color.Red1)
        .AddChoices(new[] {
            "Vypsat všechny stanice", "Vypsat jenom první a poslední", "Zjistit čas mezi stanicemi"
        }));

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

    var volbaVypsani = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .PageSize(10)
        .HighlightStyle(Color.Blue1)
        .AddChoices(new[] {
            "Vypsat všechny stanice", "Vypsat jenom první a poslední", "Zjistit čas mezi stanicemi"
        }));

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
