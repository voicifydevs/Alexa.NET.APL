﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public class Text:TextBase
    {
        public Text() { }

        public Text(string text)
        {
            Content = new APLValue<string>(text);
        }
        public override string Type => nameof(Text);

        [JsonProperty("text")]
        public APLValue<string> Content { get; set; }
    }
}
