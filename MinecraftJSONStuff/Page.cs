using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftJSONStuff
{
    /// <summary>
    /// An Object that represents a page of a book.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Page : List<MinecraftTextPart>
    {
        public Page()
        {

        }

        public Page(List<MinecraftTextPart> ls)
        {
            foreach(MinecraftTextPart mtp in ls)
            {
                Add(mtp);
            }
        }
    }
}
