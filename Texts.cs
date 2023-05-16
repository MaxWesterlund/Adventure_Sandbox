// Kopplar events till textstycken. Klassen är statisk då det inte ska finnas fler instanser av den.
public static class Texts {
    // Beskrivning: Funktionen omvandlar ett event till en ny bit text med alternativ.
    // Argument 1: Värde i Event enumen som representerar var man är i spelet.
    // Return: Ny Text klass med fortsättningen på storyn.
    // Exempel: Input: GaGenomDorr Output: "Du gick genom dörren", Gå tillbaka, Stäng dörren.
    public static Text GetTextFromEvent(Event Ev) {
        Text text = new Text("", new Option[0]);
        switch (Ev) {
            case (Event.NewGame):
                text = new Text("Du är en arbetare på fabriken där Carls nötterTM tillverkas. Du jobbar långa timmar för en liten lön eftersom Carl är en girig kapitalist som bara bryr sig om att tjäna mer pengar. Medan du och dina kollegor jobbar hårt går han alltid runt i fabriken och beklagar sig på er ineffektivitet. Men idag har du fått nog, det har blivit dags för dig att mörda Carl och ta över hans fabrik. \nDitt äventyr börjar vid din maskin i fabriken (Den som sätter på skalen på nötterna). Den ligger vid entren till fabriken vilket irriterande nog ligger längst bort från Carls kontor där han sitter och röker en asbestoscigarr. Hur vill du börja ta dig mot kontoret?",
                new Option[] {
                    new("Åk på rullbandet", Event.AkRullband),
                    new("Gå upp för trappan", Event.GaUppforTrappa),
                    new("Använd din Carls nötterTM nöt-jetpack", Event.AkJetpack),
                    new("Gör ett bra jobb", Event.NewEvent)
                });
                break;
            case (Event.AkRullband):
                text = new Text("Du hoppar upp på rullbandet och omedelbart när du kliver på det detekterar din egen maskin din närvaro och låser in dig i ett gigantiskt nötskal. Du försöker desperat bryta dig fri men förgäves då Carls nötterTM har en software-lock som gör att de endast kan brytas av Carls nötterTM nötknäppare. Genom ett litet hål i nötskalet kan du se att rullbandet delar sig några meter framför dig. Den ena vägen är skyltad för \"Små Nötter\" och den andra är skyltad för \"Stora Nötter\". Vilken väg väljer du?", new Option[] {
                    new("Stora Nötter", Event.StoraNotter),
                    new("Små Nötter", Event.SmaNotter)
                });
                break;
            case (Event.GaUppforTrappa):
                text = new Text("Du tar ett steg uppför trappan men snubblar, stukar handleden och dör. L", new Option[] {
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.AkJetpack):
                text = new Text("Du sätter på dig nöt-jetpacken och när du trycker på knappen märkt med “upp” så skjuts Carls nötter ut under dig och propellerar dig uppåt, mot Carls kontor.\n Plötsligt flyger en gigantisk Carls nötterTM zeppelinare in mellan dig och Carls kontor, du måste agera snabbt!", new Option[]{
                    new("Gira!", Event.JetpackGira),
                    new("Kasta din Carls nötterTM handgranat", Event.NotterHandgranat),
                    new("Aktivera katapultstolen", Event.Katapultstol)
                });
                break;
            case (Event.Katapultstol):
                text = new Text("Du aktiverar jetpackens inbygda katapultstol och du slungas iväg med enorm kraft rakt mot ett kar med Carls nötterTM nötkräm. Du landar mjukt med ett schwuuph och uppslukas av krämen. När du ställer dig upp ser du att din chef och ärkefiende Carl går förbi under karet med sina tre väktare, det här är din chans!", new Option[]{
                    new("Skräm Carl", Event.SkramCarl),
                    new("Läs bibeln för honom", Event.LasBibleln),
                    new("Kasta nötkräm på honom", Event.KastaNotKram)
                });
                break;
            case (Event.SmaNotter):
                text = new Text("Du väljer att rulla mot skylten för små nötter, rullbandet för dig till Carls nötterTM nöt-komprimerare. Nöt-komprimeraren komprimerar dig ner till en centimeterstor kub, det dödar dig.", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.NotterHandgranat):
                text = new Text("Du slänger din Carls nötterTM handgranat mot zeppelinaren och precis som granaten lämnar din hand kommer du ihåg att zeppelinare är fyllda med väte. Det resulterande eldhavet skonar ingen.", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.JetpackGira):
                text = new Text("Du slänger dig åt sidan för att undvika zeppelinaren men du förlorar kontrollen över jetpacken och flyger rakt ner i marken. Det enda som finns kvar av dig är en liten röd fläck.", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.SkramCarl):
                text = new Text("Du hoppar ut ur karet och skriker, Carls vakter skjuter dig. Vilken fruktansvärd ide.", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.StoraNotter):
                text = new Text("Du väljer att rulla mot skylten för stora nötter. Rullbandet för dig till nöt-expanderaren som förstorar nötskalet som du sitter i samt installerar diverse maskiner och mojänger som du säkert kan använda.", new Option[]{
                    new("Aktivera katapultstolen", Event.Katapultstol),
                    new("Sätt på radion", Event.SattPaRadion)
                });
                break;
            case (Event.SattPaRadion):
                text = new Text("Den spelar let it go, du dör av cringe.", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.MalsokandeRaket):
                text = new Text("Du använder nötens inbyggda google home och säger \"Hej Google, skjut raketer på den där äckliga gubben!\". Google säger tillbaka: \"Ok, självförstör\". Du dör.", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.LasBibleln):
                text = new Text("Du tar fram din bibel från innerfickan på din rock och börjar predika för Carl. Vid hörandet av guds ord inser Carl sina många fel. \"Jag lovar att jag ska betala mina arbetare bättre\". Du har lyckats, nu kan du återgå till att sätta skal på nötter.", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.KastaNotKram):
                text = new Text("Du kastar en handfull med nötkräm ner mot Carl. Hans vakter skjuter dig. Vilken fruktansvärd ide.", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
            case (Event.NewEvent):
                text = new Text("Bra Jobbat!", new Option[]{
                    new("Börja Om", Event.NewGame)
                });
                break;
        }
        return text;
    }  
}