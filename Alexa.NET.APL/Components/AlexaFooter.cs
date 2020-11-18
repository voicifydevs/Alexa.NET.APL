﻿using System.Collections.Generic;
using VoicifyAlexa.NET.APL.Components;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public class AlexaFooter:APLComponent
    {
        public AlexaFooter() { }

        public AlexaFooter(string hintText) : this()
        {
            HintText = hintText;
        }

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }

        [JsonProperty("hintText",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> HintText { get; set; }

        [JsonProperty("type")]
        public override string Type => nameof(AlexaFooter);
    }
}
