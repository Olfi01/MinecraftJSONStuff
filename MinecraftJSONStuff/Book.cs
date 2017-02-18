using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftJSONStuff
{
    ///<summary>
    ///This object represents a Minecraft Book
    ///</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public List<string> PagesList { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            PagesList = new List<string>();
        }

        public override string ToString()
        {
            string str = "{\ntitle:\"" + Title + "\",\nauthor:\"" + Author
                + "\",\npages:" + JsonConvert.SerializeObject(PagesList) + "\n}";
            return str;
        }

        public void AddPage(Page p)
        {
            PagesList.Add(JsonConvert.SerializeObject(p));
        }
    }
}
