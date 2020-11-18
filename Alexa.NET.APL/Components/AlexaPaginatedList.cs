﻿using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public class AlexaPaginatedList:ResponsiveTemplate
    {
        public override string Type => nameof(AlexaPaginatedList);

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

        [JsonProperty("listItems", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<IList<AlexaPaginatedListItem>> ListItems { get; set; }
    }
}
