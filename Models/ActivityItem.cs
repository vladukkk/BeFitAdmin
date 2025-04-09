using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeFitAdmin
{
    public class ActivityItem
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Duration { get; set; }
        public int Sets { get; set; }
        public double Met { get; set; }

        public ActivityItem(string imageUrl, string name, string description, int duration = 30, int sets = 3, double met = 3.0)
        {
            ImageUrl = imageUrl;
            Name = name;
            Description = description;
            Duration = duration;
            Sets = sets;
            Met = met;
        }
    }
}
