using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"\@\#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])\@\#+";

            for (int i = 0; i < n; i++)
            {
                string currentBarcode = Console.ReadLine();

                string productGroup = string.Empty;

                Match match = Regex.Match(currentBarcode, pattern);

                if (match.Success)
                {
                    string barcodeInfo = match.Groups["barcode"].Value;

                    foreach (var symbol in barcodeInfo)
                    {
                        if (char.IsDigit(symbol))
                        {
                            productGroup += symbol;
                        }
                    }

                    if (productGroup.Length == 0)
                    {
                        Console.WriteLine($"Product group: {productGroup.Length}0");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid barcode");
                }
            }
        }
    }
}
