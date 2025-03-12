// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        KodeProduk kodeProduk = new KodeProduk();
        Console.Write("Kode produk untuk Laptop : ");
        Console.WriteLine(kodeProduk.getKodeProduk("Laptop"));
        Console.Write("Kode produk untuk Smartwatch : ");
        Console.WriteLine(kodeProduk.getKodeProduk("Smartwatch"));
        Console.Write("Kode produk untuk Mouse : ");
        Console.WriteLine(kodeProduk.getKodeProduk("Mouse"));

        FanLaptop fan = new FanLaptop();
        Console.WriteLine("Mode up..");
        fan.modeUp();
        Console.WriteLine("Mode up..");
        fan.modeUp();
        Console.WriteLine("Mode up..");
        fan.modeUp();
        Console.WriteLine("Turbo shortcut");
        fan.turboShortcut();
    }
}

class KodeProduk
{

    public string getKodeProduk(string produk)
    {
        Dictionary<string, string> kodeProduk = new Dictionary<string, string>()
        {
            {"Laptop",  "E100"},
            {"Smartphone",  "E101"},
            {"Tablet",  "E102"},
            {"Hadset",  "E103"},
            {"Keyboard",  "E104"},
            {"Mouse",  "E105"},
            {"Printer",  "E106"},
            {"Monitor",  "E107"},
            {"Smartwatch",  "E108"},
            {"Kamera",  "E109"}
        };

        return kodeProduk.GetValueOrDefault(produk);
    }
}

class FanLaptop
{
    int stateFan = 0;

    string[] modes = { "Quiet", "Balanced", "Performance", "Turbo" };

    public void modeUp()
    {

        if (stateFan < 3)
        {
            string beforeState = modes[stateFan];
            stateFan++;
            Console.WriteLine("Fan " + beforeState + " berubah menjadi " + modes[stateFan]);
        }
    }
    public void modeDown()
    {
        if (stateFan > 0)
        {
            string beforeState = modes[stateFan];
            stateFan--;
            Console.WriteLine("Fan " + beforeState + " berubah menjadi " + modes[stateFan]);
        }
    }
    public void turboShortcut()
    {
        string beforeState = modes[stateFan];
        if (stateFan == 0)
        {
            stateFan = 3;
        } else
        {
            stateFan = 0;
        }
        Console.WriteLine("Fan " + beforeState + " berubah menjadi " + modes[stateFan]);
    }
}
