using System.Collections.Generic;

namespace BaseballCardOrganizer.Business.Models
{
    public class BaseballCardCollection
    {
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public List<BaseballCard> BaseballCards { get; set; }
    }
}
