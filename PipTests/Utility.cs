using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PipTests
{
    [TestClass]
    public class Utility
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void GetStateVerticesForCode()
        {
            var stateNames = new System.Collections.Generic.List<string>
            {
                "Alabama",
                "Alaska",
                "Arizona",
                "Arkansas",
                "California",
                "Colorado",
                "Connecticut",
                "Delaware",
                "Florida",
                "Georgia",
                "Hawaii",
                "Idaho",
                "Illinois",
                "Indiana",
                "Iowa",
                "Kansas",
                "Kentucky",
                "Louisiana",
                "Maine",
                "Maryland",
                "Massachusetts",
                "Michigan",
                "Minnesota",
                "Mississippi",
                "Missouri",
                "Montana",
                "Nebraska",
                "Nevada",
                "New Hampshire",
                "New Jersey",
                "New Mexico",
                "New York",
                "North Carolina",
                "North Dakota",
                "Ohio",
                "Oklahoma",
                "Oregon",
                "Pennsylvania",
                "Rhode Island",
                "South Carolina",
                "South Dakota",
                "Tennessee",
                "Texas",
                "Utah",
                "Vermont",
                "Virginia",
                "Washington",
                "West Virginia",
                "Wisconsin",
                "Wyoming"
            };

            var fileName = @"Files\states.xml";

            var statesXml = XElement.Load(fileName);

            foreach(var stateName in stateNames)
            {
                var state = statesXml.Descendants("state").FirstOrDefault(s => s.Attribute("name").Value == stateName);
                var points = state.Descendants("point");

                TestContext.WriteLine("\tvar "+stateName.Replace(" ", string.Empty).ToLower()+" = new List<IPoint>");
                TestContext.WriteLine("\t\t\t{");
                var pointsArr = points.ToArray();
                for (var i = 0; i < pointsArr.Length; i++)
                {
                    var point = pointsArr[i];
                    var lat = (double)point.Attribute("lat");
                    var lon = (double)point.Attribute("lng");
                    if (i == (pointsArr.Length - 1))
                    {
                        TestContext.WriteLine($"\t\t\t\tnew Coordinate({lat}D,{lon}D)");
                    }
                    else
                    {
                        TestContext.WriteLine($"\t\t\t\tnew Coordinate({lat}D,{lon}D),");
                    }
                }
                TestContext.WriteLine("\t\t\t};");
                TestContext.WriteLine(string.Empty);
            }

            foreach(var stateName in stateNames)
            {
                TestContext.WriteLine($"{stateName.Replace(" ", string.Empty)} = new State(\"{stateName}\",{stateName.Replace(" ", string.Empty).ToLower()});");
            }

            Assert.AreEqual(true, true);
        }
    }
}
