using System.IO;
using System.Text;

// Beskrivning: Har funktioner som krävs för att spara och att använda sparad data. Är statisk så att man inte kan göra nya instanser av den.
public static class Saving {
    // Beskrvning: Kollar i sparfilen och hittar sparad data för var man är i spelet.
    // Return: Ett Event som representerar var man är i spelet
    // Exempel: Input: - Output: Event.Intro
    // Exempel: Input: - Output: Event.AkJetpack
    static public Event LoadData() {
        if (Directory.GetFiles("save files/", "save.asd", SearchOption.TopDirectoryOnly).Length > 0) {
            FileStream fStream = File.Open("save files/save.asd", FileMode.Open);
            BinaryReader reader = new BinaryReader(fStream, Encoding.UTF8, false);
            int index = reader.Read();
            reader.Close();
            return (Event)index;   
        }
        else {
            Console.WriteLine("file not found");
            return Event.NewGame;
        }
    }

    // Beskrivning: Skriver över sparfilen med ny data utifrån given integer.
    // Argument 1: En Integer som representerar vilket index i Event enumen som spelaren har kommit till.
    static public void SaveData(int index) {
        FileStream fStream = File.Open("save files/save.asd", FileMode.Create);
        BinaryWriter writer = new BinaryWriter(fStream, Encoding.UTF8, false);
        writer.Write(index);
        writer.Close();
    }
}