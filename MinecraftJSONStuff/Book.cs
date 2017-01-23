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
    class Book
    {
        /// <summary>
        /// Title of the book, can be an empty string.
        /// </summary>
        [JsonProperty("title", Required = Required.Always)]
        public string Title { get; set; }
        /// <summary>
        /// Author of the book, can be an empty string
        /// </summary>
        [JsonProperty("author", Required = Required.Always)]
        public string Author { get; set; }
        /// <summary>
        /// List of strings, which are JSON-encoded MinecraftTextParts
        /// </summary>
        [JsonProperty("pages", Required = Required.Default)]
        public List<string> Pages { get; set; } = new List<string>();
    }
}
