namespace SyncPrime.Domain.Models
{
    public  class LineModel : EntityModel
    {      
        public string layer { get; set; }
        public double startPtX { get; set; }
        public double startPtY { get; set; }
        public double endPtX { get; set; }
        public double endPtY { get; set; }
    }
}
