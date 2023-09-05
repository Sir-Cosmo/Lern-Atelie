using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace ILA_1_Projekt__Namen_Datenbank_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> infos = new Dictionary<string, string>();
            string filePath = "NamenDatenbank.txt";


            if (File.Exists(filePath))
            {
                LoadDictionaryFromFile(filePath, infos);
            }
            else
            {

                File.Create(filePath).Dispose();
            }

            string janein = "ja";
            string masterpassword = "123";
            string ninfos = "123";

            while (janein == "ja")
            {
                Console.WriteLine("Über wen hättest du gerne Infos?");
                string Name = Console.ReadLine().ToLower();

                if (Name == "loeschen")

                {
                    DeleteAllInfos(infos, filePath);
                    Console.WriteLine("Alle Infos wurden gelöscht.");
                    Environment.Exit(0);
                }

                try
                {
                    Console.WriteLine(infos[Name]);

                }
                catch
                {
                    Console.WriteLine("Ich habe keine Infos über diese Person ");
                    Console.WriteLine("Wollen sie Infos Hinzufügen ?");
                    string Antwort = Console.ReadLine();

                    if (Antwort == "Nein" || Antwort == "nein")
                    {
                        Console.WriteLine("Ok :(");
                        Environment.Exit(0);
                    }

                    if (Antwort == "Ja" || Antwort == "ja")
                    {
                        Console.WriteLine("Bitte geben sie das Masterpassword ein.");
                        string passwordversuch = Console.ReadLine();

                        if (passwordversuch == masterpassword)
                        {
                            Console.WriteLine("Bitte geben Sie das Alter und den Wohnort ein:");
                            ninfos = Console.ReadLine();

                            infos.Add(Name, ninfos);


                            SaveDictionaryToFile(filePath, infos);
                        }
                        else
                        {
                            Console.WriteLine("Das war leider das falsche Passwort.");
                            Task.Delay(2000).Wait();
                            Environment.Exit(0);
                        }


                    }



                }

                Console.WriteLine("Willst du mehr Infos?");
                janein = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Danke fürs benutzen!");
        }

        static void SaveDictionaryToFile(string filePath, Dictionary<string, string> dictionary)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var kvp in dictionary)
                {
                    writer.WriteLine($"{kvp.Key}:{kvp.Value}");
                }
            }
        }

        static void LoadDictionaryFromFile(string filePath, Dictionary<string, string> dictionary) 
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    dictionary[parts[0]] = parts[1];
                }
            }
        }
        static void DeleteAllInfos(Dictionary<string, string> dictionary, string filePath)
        {
            dictionary.Clear();


            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        } 

    }
}

