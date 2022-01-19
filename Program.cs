using System;

namespace turkcell
{
    class MainClass
    {
        //string icerisinde verilen kelimeler ayristirilip asagidaki kosullara gore duzenlenecek ve tekrar string olarak verilecektir.
        // - eger kelime 4 harften daha kucukse ilk harf kucuk olacak sekilde kucuk-buyuk olarak harfler duzenlenecek
        // - eger kelime 3-7 harf araligindaysa tum harfler kucuk olacak
        // - eger kelime 7 ve daha cok harf iceriyorsa tum harfler buyuk olacak
        // - eger kelimenin icerisinde bir rakam geciyorsa kelime oldugu gibi kalacak

        public static void Main(string[] args)
        {
            string deger = "ab,abCDeFg,aHdV2,ABCdkNjUk,aBc,AbcD,aYnxhCNA,Ab9C";
            string result = donustur(deger);
            Console.WriteLine(result);
        }


        public static string donustur(string kelimegrubu)
        {
            string[] words = kelimegrubu.Split(',');
            string words2 = string.Empty;

            foreach (var word in words)
            {
                if (word.Contains("1") || word.Contains("2") || word.Contains("3") || word.Contains("4") || word.Contains("5") ||
                    word.Contains("6") || word.Contains("7") || word.Contains("8") || word.Contains("9") || word.Contains("0"))
                {
                    words2 += word + ",";
                }
                else
                {
                    if (word.Length>3 && word.Length<7)
                    {
                        string a = word.ToLower();
                        words2 += a + ",";
                    }
                    else if (word.Length>=7)
                    {
                        string a = word.ToUpper();
                        words2 += a + ",";
                    }
                    else if (word.Length<4)
                    {
                        string b = "";
                        for (var i = 2; i < word.Length+2; i++)
                        {
                            string a = word[i - 2].ToString();
                            if (i%2==0)
                            {
                                b += "" + a.ToLower();
                            }
                            else
                            {
                                b += a.ToUpper();
                            }
                        }
                        words2 += b + ",";
                    }
                }
            }
            return words2.Remove(words2.Length - 1);
        }
    }
}
