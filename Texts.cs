public static class Texts {
    public static Text GetTextFromEvent(Events events) {
        Text text = new Text("", new Option[0]);
        switch (events) {
            case (Events.RideRollband):
                text = new Text("Du hoppar upp på rullbandet och omedelbart när du kliver på det detekterar din egen maskin din närvaro och låser in dig i ett gigantiskt nötskal. Du försöker desperat bryta dig fri men förgäves då Carls nötterTM har en software-lock som gör att de endast kan brytas av Carls nötterTM nötknäppare. Genom ett litet hål i nötskalet kan du se att rullbandet delar sig några meter framför dig. Den ena vägen är skyltad för “små nötter” och den andra är skyltad för “stora nötter”. Vilken väg väljer du?", new Option[] {
                    new("Stora Nötter", Events.BigNuts),
                    new("Små Nötter", Events.SmallNuts)
                });
                break;
            case (Events.GoUpStairs):
                text = new Text("Du tar ett steg uppför trappan men snubblar, stukar handleden och dör. L", new Option[] {
                    new("", Events.Empty)
                });
                break;
            case (Events.RideJetpack):
                text = new Text("Du sätter på dig nöt-jetpacken och när du trycker på knappen märkt med “upp” så skjuts Carls nötter ut under dig och propellerar dig uppåt, mot Carls kontor.\n Plötsligt flyger en gigantisk Carls nötterTM zeppelinare in mellan dig och Carls kontor, du måste agera snabbt!", new Option[]{
                    new("Gira!", Events.JetpackGira),
                    new("Kasta din Carls nötterTM handgranat", Events.NotterHandgranat),
                    new("Aktivera katapultstolen", Events.Katapultstol)
                });
                break;
            case (Events.Katapultstol):
                text = new Text("Du aktiverar jetpackens inbygda katapultstol och du slungas iväg med enorm kraft rakt mot ett kar med Carls nötterTM nötkräm. Du landar mjukt med ett schwuuph och uppslukas av krämen. När du ställer dig upp ser du att din chef och ärkefiende Carl går förbi under karet med sina tre väktare, det här är din chans!", new Option[]{
                    new("Skräm Carl", Events.SkramCarl),
                    new("Läs bibeln för honom", Events.LasBibleln),
                    new("Kasta nötkräm på honom", Events.KastaNotKram)
                });
                break;
            case (Events.SmallNuts):
                text = new Text("Du väljer att rulla mot skylten för små nötter (vad passande haha), rullbandet för dig till Carls nötterTM nöt-komprimerare. Nöt-komprimeraren komprimerar dig ner till en centimeterstor kub, det dödar dig.", new Option[]{
                    new("", Events.Empty)
                });
                break;
            case (Events.NotterHandgranat):
                text = new Text("Du slänger din Carls nötterTM handgranat mot zeppelinaren och precis som granaten lämnar din hand kommer du ihåg att zeppelinare är fyllda med väte. Det resulterande eldhavet skonar ingen.", new Option[]{
                    new("", Events.Empty)
                });
                break;
            case (Events.JetpackGira):
                text = new Text("Du slänger dig åt sidan för att undvika zeppelinaren men du förlorar kontrollen över jetpacken och flyger rakt ner i marken. Det enda som finns kvar av dig är en liten röd fläck.", new Option[]{
                    new("", Events.Empty)
                });
                break;
            case (Events.SkramCarl):
                text = new Text("Du hoppar ut ur karet och skriker, Carls vakter skjuter dig. Vilken fruktansvärd ide.", new Option[]{
                    new("", Events.Empty)
                });
                break;
            case (Events.BigNuts):
                text = new Text("Du väljer att rulla mot skylten för stora nötter. Rullbandet för dig till nöt-expanderaren som förstorar nötskalet som du sitter i samt installerar diverse maskiner och mojänger som du säkert kan använda.", new Option[]{
                    new("Aktivera katapultstolen", Events.Katapultstol),
                    new("Sätt på radion", Events.SattPaRadion)
                });
                break;
            case (Events.SattPaRadion):
                text = new Text("Den spelar let it go, du dör av cringe.", new Option[]{
                    new("", Events.Empty)
                });
                break;
            case (Events.MalsokandeRaket):
                text = new Text("Du använder nötens inbyggda google home och säger \"Hej Google, skjut raketer på den där äckliga gubben!\". Google säger tillbaka: \"Ok, självförstör\". Du dör.", new Option[]{
                    new("", Events.Empty)
                });
                break;
            case (Events.LasBibleln):
                text = new Text("Du tar fram din bibel från innerfickan på din rock och börjar predika för Carl. Vid hörandet av guds ord inser Carl sina många fel. \"Jag lovar att jag ska betala mina arbetare bättre\". Du har lyckats, nu kan du återgå till att sätta skal på nötter.", new Option[]{
                    new("", Events.Empty)
                });
                break;
            case (Events.KastaNotKram):
                text = new Text("Du kastar en handfull med nötkräm ner mot Carl. Hans vakter skjuter dig. Vilken fruktansvärd ide.", new Option[]{
                    new("", Events.Empty)
                });
                break;
        }
        return text;
    }  
}