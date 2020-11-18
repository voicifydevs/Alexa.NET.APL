﻿using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{


    public class AlexaGridList:ResponsiveTemplate
    {
        public override string Type => nameof(AlexaGridList);

        [JsonProperty("customLayoutName",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> CustomLayoutName { get; set; }

        [JsonProperty("defaultImnageSource",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> DefaultImnageSource { get; set; }

        [JsonProperty("imageAlignment", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<AlexaImageAlignment>))]
        public APLValue<AlexaImageAlignment?> ImageAlignment { get; set; }

        [JsonProperty("imageAspectRatio", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<AlexaImageAspectRatio>))]
        public APLValue<AlexaImageAspectRatio?> ImageAspectRatio { get; set; }

        [JsonProperty("imageBlurredBackground", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageBlurredBackground { get; set; }

        [JsonProperty("imageHideScim", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageHideScrim { get; set; }

        [JsonProperty("imageMetadataPrimary", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageMetadataPrimary { get; set; }

        [JsonProperty("imageRoundedCorner", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageRoundedCorner { get; set; }

        [JsonProperty("imageScale", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLValueEnumConverter<Scale>))]
        public APLValue<Scale?> Scale { get; set; }

        [JsonProperty("imageShowProgressBar",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ImageShowProgressBar { get; set; }

        [JsonProperty("listItemHeight",NullValueHandling = NullValueHandling.Ignore)]
        public APLDimensionValue ListItemHeight { get; set; }

        [JsonProperty("listItemHorizontalCount",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int> ListItemHorizontalCount { get; set; }

        [JsonProperty("listItems", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(GenericSingleOrListConverter<object>))]
        public APLValue<IList<object>> ListItems { get; set; }

        [JsonProperty("primaryAction", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> PrimaryAction { get; set; }

    }
}
