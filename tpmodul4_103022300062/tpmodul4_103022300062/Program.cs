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

public enum DoorState
{
    Terkunci,
    Terbuka
}

public class DoorMachine
{
    private DoorState currentState;

    public DoorMachine()
    {
        currentState = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void KunciPintu()
    {
        if (currentState == DoorState.Terbuka)
        {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }

    public void BukaPintu()
    {
        if (currentState == DoorState.Terkunci)
        {
            currentState = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }
}

public class Program
{
    public static void Main()
    {
        DoorMachine door = new DoorMachine();
        Console.WriteLine("\nPerintah: buka / kunci / keluar / kodepos");

        while (true)
        {
            Console.Write("Masukkan perintah: ");
            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "buka":
                    door.BukaPintu();
                    break;
                case "kunci":
                    door.KunciPintu();
                    break;
                case "kodepos":
                    Console.Write("Masukkan nama kelurahan: ");
                    string kelurahan = Console.ReadLine();
                    string kodePos = KodePos.GetKodePos(kelurahan);
                    Console.WriteLine("Kode Pos dari " + kelurahan + " adalah: " + kodePos);
                    break;
                case "keluar":
                    return;
                default:
                    Console.WriteLine("Perintah tidak dikenal.");
                    break;
            }
        }
    }
}
