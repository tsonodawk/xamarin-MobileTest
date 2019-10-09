﻿using System;
using Xamarin.Forms;

namespace MobileTestSyncF.Models
{
    public class MonthCalc
    {
        public string EventName { get; set; }
        public string Organizer { get; set; }
        public string ContactID { get; set; }
        public int Capacity { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Color color { get; set; }
        public bool AllDay { get; set; }
    }
}
