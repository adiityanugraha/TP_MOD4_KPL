using System;
using System.Collections.Generic;

public class KodePos
{
    private static readonly Dictionary<string, string> kodePosTable = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public static string GetKodePos(string kelurahan)
    {
        if (kodePosTable.TryGetValue(kelurahan, out string kodePos))
        {
            return kodePos;
        }
        else
        {
            return "Kelurahan tidak ditemukan.";
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        string kodePos = KodePos.GetKodePos(kelurahan);
        Console.WriteLine("Kode Pos dari " + kelurahan + " adalah: " + kodePos);
    }
}
