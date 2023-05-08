using System.IO;
using System.Text;

public static class Saving {
    static public Events LoadData() {
        if (Directory.GetFiles("save files/", "save.asd", SearchOption.TopDirectoryOnly).Length > 0) {
            Console.WriteLine("file found");
            FileStream fStream = File.Open("save files/save.asd", FileMode.Open);
            BinaryReader reader = new BinaryReader(fStream, Encoding.UTF8, false);
            int index = reader.Read();
            reader.Close();
            return (Events)index;   
        }
        else {
            Console.WriteLine("file not found");
            return Events.NewGame;
        }
    }

    static public void SaveData(int index) {
        FileStream fStream = File.Open("save files/save.asd", FileMode.Create);
        BinaryWriter writer = new BinaryWriter(fStream, Encoding.UTF8, false);
        writer.Write(index);
        writer.Close();
    }
}