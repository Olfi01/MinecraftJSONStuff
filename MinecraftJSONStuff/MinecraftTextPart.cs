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
    /// <para>The first of those inherits most of its properties to the others.
    /// To avoid this, leave the first one blank.</para>
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MinecraftTextPart
    {
        /// <summary>
        /// Text in this textpart. Is needed if neither of translate and selector is present.
        /// </summary>
        [JsonProperty("text", Required = Required.Default)]
        public string Text { get; set; }
        /// <summary>
        /// Variable name of s string to be translated.
        /// Is needed if neither of selector and text is present.
        /// </summary>
        [JsonProperty("translate", Required = Required.Default)]
        public string Translate { get; set; }
        /// <summary>
        /// A List of textParts to replace %s with. Only works with translate.
        /// </summary>
        [JsonProperty("with", Required = Required.Default)]
        public List<MinecraftTextPart> With { get; set; }
        /// <summary>
        /// A selector. Will be replaced by the selected names.
        /// Is needed if neither of translate and text is present.
        /// <para>For example, @a gives the names of all players.</para>
        /// </summary>
        [JsonProperty("selector", Required = Required.Default)]
        public string Selector { get; set; }
        /// <summary>
        /// A ScoreObject
        /// </summary>
        [JsonProperty("score", Required = Required.Default)]
        public ScoreObject Score { get; set; }
        /// <summary>
        /// Color of the text. See <see cref="Values.Colors"/> for the applicable colors. 
        /// </summary>
        [JsonProperty("color", Required = Required.Default)]
        public string Color { get; set; }
        /// <summary>
        /// Sets whether the text is bold or not.
        /// </summary>
        [JsonProperty("bold", Required = Required.Default)]
        public bool Bold { get; set; }
        /// <summary>
        /// Sets whether the text is italic or not.
        /// </summary>
        [JsonProperty("italic", Required = Required.Default)]
        public bool Italic { get; set; }
        /// <summary>
        /// Sets whether the text is underlined or not.
        /// </summary>
        [JsonProperty("underlined", Required = Required.Default)]
        public bool Underlined { get; set; }
        /// <summary>
        /// Sets whether the text is striked through or not.
        /// </summary>
        [JsonProperty("strikethrough", Required = Required.Default)]
        public bool Strikethrough { get; set; }
        /// <summary>
        /// Sets whether the text is obfuscated or not.
        /// </summary>
        [JsonProperty("obfuscated", Required = Required.Default)]
        public bool Obfuscated { get; set; }
    }

    #region Custom Objects
    /// <summary>
    /// A custom ScoreObject.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ScoreObject
    {
        /// <summary>
        /// Name of the target player. Can be a selector, but must return exactly one object.
        /// Will not be shown.
        /// </summary>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
        /// <summary>
        /// Name of the target object. Will not be shown.
        /// </summary>
        [JsonProperty("objective", Required = Required.Always)]
        public string Objective { get; set; }
        /// <summary>
        /// Will be created automatically.
        /// </summary>
        [JsonProperty("value", Required = Required.Default)]
        public string Value { get; set; }
    }
    /// <summary>
    /// Will toggle an event when the mouse hovers over the text.
    /// Won't work with signs and /title.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class hoverEvent
    {
        /// <summary>
        /// An action to perform. See <see cref="ActionType"/> for possible actions
        /// </summary>
        [JsonProperty("action", Required = Required.Always)]
        public string Action { get; set; }
        static class ActionType
        {
            public const string ShowText = "show_text";
            public const string ShowItem = "show_item";
            public const string ShowAchievement = "show_achievement";
            public const string ShowEntity = "show_entity";
        }
        /// <summary>
        /// Value for the action. Free text for show_text, JSON-serialized item for show_item,
        /// reference of the target for show_achievement, JSON-serialized entity for show_entity
        /// </summary>
        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }
    /// <summary>
    /// Will toggle when the text is clicked.
    /// Won't work with /title.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class clickEvent
    {

    }
    #endregion
}
