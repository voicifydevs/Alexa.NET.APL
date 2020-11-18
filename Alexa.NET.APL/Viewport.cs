﻿using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    [JsonConverter(typeof(ViewportConverter))]
    public abstract class Viewport
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("id")]
        public string ID { get; set; }
    }
}
