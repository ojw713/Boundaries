using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boundaries.Models
{
    public class State
    {
        public StateName Name { get; }

        public List<Coordinate> Points { get; }

        public State(StateName name, List<Coordinate> points)
        {
            Name = name;
            Points = points;
        }

        public bool IsInside(Coordinate point)
        {
            //https://web.archive.org/web/20161108113341/https://www.ecse.rpi.edu/Homepages/wrf/Research/Short_Notes/pnpoly.html
            var j = Points.Count - 1;
            var isInside = false;

            for (var i = 0; i < Points.Count; j = i++)
            {
                if (Points[i].Latitude > point.Latitude != Points[j].Latitude > point.Latitude && point.Longitude < (Points[j].Longitude - Points[i].Longitude) * (point.Latitude - Points[i].Latitude) / (Points[j].Latitude - Points[i].Latitude) + Points[i].Longitude)
                {
                    isInside = !isInside;
                }
            }

            return isInside;
        }
    }
}
