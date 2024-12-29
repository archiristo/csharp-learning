using System;

class Program
{
    static string CaesarCipherEncrypt(string input, int shift)
    {
        string result = "";

        foreach (char c in input)
        {
            if (Char.IsLetter(c))
            {
                char a = Char.IsUpper(c) ? 'A' : 'a';
                result += (char)(((c - a + shift) % 26) + a); 
            }
            else
            {
                result += c; // Harf olmayan karakteri olduğu gibi ekle
            }
        }

        return result;
    }

    static string CaesarCipherDecrypt(string input, int shift)
    {
        return CaesarCipherEncrypt(input, 26 - shift);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Şifrelenecek metni girin:");
        string text = Console.ReadLine();

        Console.WriteLine("Kaydırma miktarını girin (örn. 3):");
        int shift = int.Parse(Console.ReadLine());

        // Şifreleme
        string encryptedText = CaesarCipherEncrypt(text, shift);
        Console.WriteLine("Şifrelenmiş metin: " + encryptedText);

        // Şifreyi çözme
        string decryptedText = CaesarCipherDecrypt(encryptedText, shift);
        Console.WriteLine("Çözülmüş metin: " + decryptedText);
    }
}
