using AutoMapper.Configuration.Annotations;
using Newtonsoft.Json;
using System;

namespace SyncPrime.Application.ViewModel
{
    public class LineViewModel
    {               
        public string layer { get; set; }
        public double startPtX { get; set; }
        public double startPtY { get; set; }
        public double endPtX { get; set; }
        public double endPtY { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime? deletedAt { get; set; }
    }
}
