﻿using System;

namespace Pinch.SDK.Plans
{
    public class PlanFreePeriodSaveOptions
    {
        public DateTime? StartDate { get; set; }
        public int DurationOffset { get; set; }
        public string DurationInterval { get; set; }
        public string Metadata { get; set; }
    }
}