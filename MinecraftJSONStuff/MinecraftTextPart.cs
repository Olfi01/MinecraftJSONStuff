using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MinecraftJSONStuff
{
    /// <summary>
    /// One part of a Minecraft text.
    /// <para>The first of those inherits most of its properties to the others.</para>
    /// <para>To avoid this, leave the first one blank.</para>
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    class MinecraftTextPart
    {

    }
}
