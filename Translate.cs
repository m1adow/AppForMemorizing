using System;
using System.Text.Json.Serialization;

namespace AppForMemorizing
{
    class Translate
    {        
        public string ForeignWord { get; set; }
        public string NativeWord { get; set; }

        public Translate(string foreignWord, string nativeWord)
        {
            ForeignWord = foreignWord;
            NativeWord = nativeWord;
        }

        public override string ToString()
        {
            return ForeignWord + " - " + NativeWord;
        }
    }

    class Settings
    {
        [JsonIgnore]
        public static string Path = $@"{Environment.CurrentDirectory}\translate.json";
    }
}
