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
        }
        
        return text;
    }  
}