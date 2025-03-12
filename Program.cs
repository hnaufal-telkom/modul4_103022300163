// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        KodeProduk kodeProduk = new KodeProduk();
        Console.Out.WriteLine(kodeProduk.getKodeProduk("Laptop"));
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
