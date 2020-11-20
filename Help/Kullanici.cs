using Newtonsoft.Json;
using System;
using System.IO;

namespace HelpClass
{
    public class Kullanici
    {


        public static Entity.HelpClass.Kullanici KullaniciBilgisiGetir()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string _path = currentDirectory + "\\Kullanici.json";
            if (File.Exists(_path))
            {
                string json = File.ReadAllText(_path);
                var kullanici = JsonConvert.DeserializeObject<Entity.HelpClass.Kullanici>(json);
                return kullanici;
            }
            else
            {
                throw new Exception("Kullanici.json dosyası bulunamıyor.");
            }


            
        }
    }
}
