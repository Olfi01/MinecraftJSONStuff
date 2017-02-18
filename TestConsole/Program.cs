using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftJSONStuff;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace TestConsole
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Book b = new Book("Tets", "Rowling");
            Page p = new Page();
            p.Add(new MinecraftTextPart());
            b.AddPage(p);
            string result = b.ToString();
            Console.WriteLine(result);
            Console.WriteLine("Copy to clipboard? (y/n)");
            string read = Console.ReadLine();
            if (read == "y" || read == "Y")
            {
                Clipboard.SetText(result);
                Console.WriteLine("Text copied to clipboard");
            }
        }
    }
}