﻿using System.Collections.Generic;
using com.strava.api.Gear;
using com.strava.api.Segments;
using Newtonsoft.Json;

namespace com.strava.api.Activities
{
    /// <summary>
    /// Represents a Strava activity.
    /// </summary>
    public class Activity : ActivitySummary
    {
        /// <summary>
        /// A list of segment effort objects.
        /// </summary>
        [JsonProperty("segment_efforts")]
        public List<SegmentEffort> SegmentEfforts { get; set; }

        /// <summary>
        /// A summary of the gear used.
        /// </summary>
        [JsonProperty("gear")]
        public GearSummary Gear { get; set; }
    }
}
