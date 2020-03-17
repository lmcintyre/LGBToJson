using System;
using System.IO;
using System.Net;
using System.Text.Json.Serialization;
using Lumina.Data.Files;
using Newtonsoft.Json;
using Lumina = Lumina.Lumina;

namespace LGBToJson {
    class Program {

        private static string GameDirectory =
            @"C:\Program Files (x86)\SquareEnix\Final Fantasy XIV - A Realm Reborn\game\sqpack\";

        private static string lgbPath = "bg/ffxiv/sea_s1/twn/s1t1/level/bg.lgb";
        
        static void Main(string[] args) {
            var lumina = new global::Lumina.Lumina(GameDirectory);

            LgbFile lgb = lumina.GetFile<LgbFile>(lgbPath);

            var text = JsonConvert.SerializeObject(lgb.Layers, Formatting.Indented);
            
            // Console.WriteLine(text);
            File.WriteAllText(@"C:\Users\Liam\Desktop\test.txt", text);

        }
    }
}