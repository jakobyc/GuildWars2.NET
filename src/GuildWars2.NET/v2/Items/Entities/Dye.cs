using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class Dye
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_rgb")]
        public int[] BaseRgb { get; set; }

        [JsonProperty("cloth")]
        public Cloth Cloth { get; set; }

        [JsonProperty("leather")]
        public Cloth Leather { get; set; }

        [JsonProperty("metal")]
        public Cloth Metal { get; set; }

        /// <summary>
        /// Item ID for the dye
        /// </summary>
        [JsonProperty("item")]
        public string ItemId { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }
    }

    public class Cloth
    {
        [JsonProperty("brightness")]
        public int Brightness { get; set; }

        [JsonProperty("contrast")]
        public double Contrast { get; set; }

        [JsonProperty("hue")]
        public int Hue { get; set; }

        [JsonProperty("saturation")]
        public double Saturation { get; set; }

        [JsonProperty("lightness")]
        public double Lightness { get; set; }

        [JsonProperty("rgb")]
        public int[] Rgb { get; set; }
    }
}
