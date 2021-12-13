﻿using System;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class Viewport
    {
        [JsonPropertyName("northeast")]
        public Location NorthEast { get; set; }
        [JsonPropertyName("southwest")]
        public Location SouthWest { get; set; }
        [JsonIgnore]
        public double Area
        {
            get
            {
                var width = Math.Abs(NorthEast.Latitude - SouthWest.Latitude);
                var height = Math.Abs(NorthEast.Longitude - SouthWest.Longitude);
                return width * height;
            }
        }
        public override string ToString() => $"NorthEast={NorthEast},SouthWest={SouthWest}";
    }
}