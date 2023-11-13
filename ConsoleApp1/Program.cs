using System.Collections.Generic;
using System.Text.RegularExpressions;
Console.WriteLine("LÜTFEN BİR DOSYA İSMİ GİRİN");
string dosya = Console.ReadLine();
string text = File.ReadAllText(@"C:\Users\HP\Desktop\"+dosya+ ".txt");
string[] kelimeler;
List<string> tekil = new List<string>();
//string result = Regex.Replace(text, @"\r\n?|\n", ""); bunu da öğrendim
text = text.ToLower();
text = text.Replace(",", "").Replace(":", "").Replace(".", "").Replace(";", "").Replace("\n"," ").Replace("\r", " ").Replace("(", "").Replace(")", "");
kelimeler = text.Split(' ');

for (int i = 0; i < kelimeler.Length; i++)
{
    if (tekil.Contains(kelimeler[i]) == false)
    {
        if (kelimeler[i]!= "")
        tekil.Add(kelimeler[i]);
    }
}

foreach (string k in tekil)
{
    int sayac = 0;
    for (int i = 0; i < kelimeler.Length; i++)
    {
        if (kelimeler[i] == k)
        {
            sayac++;
        }
    }
    Console.WriteLine(k + ">>>>> " + sayac + " adet");
}
        