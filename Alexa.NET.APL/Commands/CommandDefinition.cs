﻿using System.Collections.Generic;
using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Commands
{
    public class CommandDefinition
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(ParameterListConverter),true)]
        public APLValue<IList<Parameter>> Parameters { get; set; }

        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> Commands { get; set; }
    }
}