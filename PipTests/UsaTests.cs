using Boundaries;
using Boundaries.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PipTests
{
    [TestClass]
    public class UsaTests
    {
        [TestMethod]
        public void InAlabamaTests()
        {
            //32.462065, -86.450252
            var alabama = new Coordinate(32.462065D, -86.450252D);
            var result1 = Usa.Alabama.IsInside(alabama);
            var result2 = Usa.GetState(alabama);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Alabama, result2);
        }

        [TestMethod]
        public void InAlaskaTests()
        {
            //64.835465, -147.813228
            var alaska = new Coordinate(64.835465D, -147.813228D);
            var result1 = Usa.Alaska.IsInside(alaska);
            var result2 = Usa.GetState(alaska);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Alaska, result2);
        }

        [TestMethod]
        public void InArizonaTests()
        {
            //34.72184, -112.001999
            var arizona = new Coordinate(34.72184D, -112.001999D);
            var result1 = Usa.Arizona.IsInside(arizona);
            var result2 = Usa.GetState(arizona);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Arizona, result2);
        }

        [TestMethod]
        public void InArkansasTests()
        {
            //33.239527, -92.665991
            var arkansas = new Coordinate(33.239527D, -92.665991D);
            var result1 = Usa.Arkansas.IsInside(arkansas);
            var result2 = Usa.GetState(arkansas);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Arkansas, result2);
        }

        [TestMethod]
        public void InCaliforniaTests()
        {
            //38.005984, -121.837694
            var california = new Coordinate(38.005984D, -121.837694D);
            var result1 = Usa.California.IsInside(california);
            var result2 = Usa.GetState(california);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.California, result2);
        }

        [TestMethod]
        public void InColoradoTests()
        {
            //37.349247, -108.589035
            var colorado = new Coordinate(37.349247D, -108.589035D);
            var result1 = Usa.Colorado.IsInside(colorado);
            var result2 = Usa.GetState(colorado);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Colorado, result2);
        }

        [TestMethod]
        public void InConnecticutTests()
        {
            //41.554068, -72.680756
            var connecticut = new Coordinate(41.554068D, -72.680756D);
            var result1 = Usa.Connecticut.IsInside(connecticut);
            var result2 = Usa.GetState(connecticut);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Connecticut, result2);
        }

        [TestMethod]
        public void InDelawareTests()
        {
            //38.729097, -75.131399
            var delaware = new Coordinate(38.729097D, -75.131399D);
            var result1 = Usa.Delaware.IsInside(delaware);
            var result2 = Usa.GetState(delaware);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Delaware, result2);
        }

        [TestMethod]
        public void InFloridaTests()
        {
            //28.381671, -81.503716
            var florida = new Coordinate(28.381671D, -81.503716D);
            var result1 = Usa.Florida.IsInside(florida);
            var result2 = Usa.GetState(florida);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Florida, result2);
        }

        [TestMethod]
        public void InGeorgiaTests()
        {
            //32.042041, -81.063923
            var georgia = new Coordinate(32.042041D, -81.063923D);
            var result1 = Usa.Georgia.IsInside(georgia);
            var result2 = Usa.GetState(georgia);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Georgia, result2);
        }

        [TestMethod]
        public void InHawaiiTests()
        {
            //20.888710, -156.465104
            var hawaii = new Coordinate(20.888710D, -156.465104D);
            var result1 = Usa.Hawaii.IsInside(hawaii);
            var result2 = Usa.GetState(hawaii);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Hawaii, result2);
        }

        [TestMethod]
        public void InIdahoTests()
        {
            //43.650197, -116.667838
            var idaho = new Coordinate(43.650197D, -116.667838D);
            var result1 = Usa.Idaho.IsInside(idaho);
            var result2 = Usa.GetState(idaho);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Idaho, result2);
        }

        [TestMethod]
        public void InIllinoisTests()
        {
            //42.459810, -87.824772
            var illinois = new Coordinate(42.459810D, -87.824772D);
            var result1 = Usa.Illinois.IsInside(illinois);
            var result2 = Usa.GetState(illinois);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Illinois, result2);
        }

        [TestMethod]
        public void InIndianaTests()
        {
            //39.7800859,-86.1737763
            var indiana = new Coordinate(39.7800859D, -86.1737763D);
            var result1 = Usa.Indiana.IsInside(indiana);
            var result2 = Usa.GetState(indiana);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Indiana, result2);
        }

        [TestMethod]
        public void InIowaTests()
        {
            //TODO 41.261620,-95. (Edge case)
            //41.641843,-91.522188
            var iowa = new Coordinate(41.641843D, -91.522188D);
            var result1 = Usa.Iowa.IsInside(iowa);
            var result2 = Usa.GetState(iowa);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Iowa, result2);
        }

        [TestMethod]
        public void InKansasTests()
        {
            //38.874073,-99.317253
            var kansas = new Coordinate(38.874073D, -99.317253D);
            var result1 = Usa.Kansas.IsInside(kansas);
            var result2 = Usa.GetState(kansas);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Kansas, result2);
        }

        [TestMethod]
        public void InKentuckyTests()
        {
            //39.086703,-84.518508
            var kentucky = new Coordinate(39.086703D, -84.518508D);
            var result1 = Usa.Kentucky.IsInside(kentucky);
            var result2 = Usa.GetState(kentucky);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Kentucky, result2);
        }

        [TestMethod]
        public void InLouisianaTests()
        {
            //30.244905,-89.760051
            var louisiana = new Coordinate(30.244905D, -89.760051D);
            var result1 = Usa.Louisiana.IsInside(louisiana);
            var result2 = Usa.GetState(louisiana);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Louisiana, result2);
        }

        [TestMethod]
        public void InMaineTests()
        {
            //43.419819,-70.755700
            var maine = new Coordinate(43.419819D, -70.755700D);
            var result1 = Usa.Maine.IsInside(maine);
            var result2 = Usa.GetState(maine);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Maine, result2);
        }

        [TestMethod]
        public void InMarylandTests()
        {
            //39.025528,-76.690701
            var maryland = new Coordinate(39.025528D, -76.690701D);
            var result1 = Usa.Maryland.IsInside(maryland);
            var result2 = Usa.GetState(maryland);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Maryland, result2);
        }

        [TestMethod]
        public void InMassachusettsTests()
        {
            //42.266834,-71.168516
            var massachusetts = new Coordinate(42.266834D, -71.168516D);
            var result1 = Usa.Massachusetts.IsInside(massachusetts);
            var result2 = Usa.GetState(massachusetts);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Massachusetts, result2);
        }

        [TestMethod]
        public void InMichiganTests()
        {
            //42.0809574,-86.4861351
            var michigan = new Coordinate(42.0809574D, -86.4861351D);
            var result1 = Usa.Michigan.IsInside(michigan);
            var result2 = Usa.GetState(michigan);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Michigan, result2);
        }

        [TestMethod]
        public void InMinnesotaTests()
        {
            //45.104507,-93.457105
            var minnesota = new Coordinate(45.104507D, -93.457105D);
            var result1 = Usa.Minnesota.IsInside(minnesota);
            var result2 = Usa.GetState(minnesota);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Minnesota, result2);
        }

        [TestMethod]
        public void InMississippiTests()
        {
            //30.440100,-88.527086
            var mississippi = new Coordinate(30.440100D, -88.527086D);
            var result1 = Usa.Mississippi.IsInside(mississippi);
            var result2 = Usa.GetState(mississippi);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Mississippi, result2);
        }

        [TestMethod]
        public void InMissouriTests()
        {
            //38.497579,-90.299634
            var missouri = new Coordinate(38.497579D, -90.299634D);
            var result1 = Usa.Missouri.IsInside(missouri);
            var result2 = Usa.GetState(missouri);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Missouri, result2);
        }

        [TestMethod]
        public void InMontanaTests()
        {
            //46.613002,-112.020328
            var montana = new Coordinate(46.613002D, -112.020328D);
            var result1 = Usa.Montana.IsInside(montana);
            var result2 = Usa.GetState(montana);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Montana, result2);
        }

        [TestMethod]
        public void InNebraskaTests()
        {
            //41.873428,-103.674048
            var nebraska = new Coordinate(41.873428D, -103.674048D);
            var result1 = Usa.Nebraska.IsInside(nebraska);
            var result2 = Usa.GetState(nebraska);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Nebraska, result2);
        }

        [TestMethod]
        public void InNevadaTests()
        {
            //35.969722,-114.855663
            var nevada = new Coordinate(35.969722D, -114.855663D);
            var result1 = Usa.Nevada.IsInside(nevada);
            var result2 = Usa.GetState(nevada);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Nevada, result2);
        }

        [TestMethod]
        public void InNewHampshireTests()
        {
            //43.033777,-70.781229
            var newhampshire = new Coordinate(43.033777D, -70.781229D);
            var result1 = Usa.NewHampshire.IsInside(newhampshire);
            var result2 = Usa.GetState(newhampshire);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.NewHampshire, result2);
        }

        [TestMethod]
        public void InNewJerseyTests()
        {
            //40.478350,-74.485434
            var newjersey = new Coordinate(40.478350D, -74.485434D);
            var result1 = Usa.NewJersey.IsInside(newjersey);
            var result2 = Usa.GetState(newjersey);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.NewJersey, result2);
        }

        [TestMethod]
        public void InNewMexicoTests()
        {
            //34.426040,-103.196111
            var newmexico = new Coordinate(34.426040D, -103.196111D);
            var result1 = Usa.NewMexico.IsInside(newmexico);
            var result2 = Usa.GetState(newmexico);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.NewMexico, result2);
        }

        [TestMethod]
        public void InNewYorkTests()
        {
            //40.964062,-73.838745
            var newyork = new Coordinate(40.964062D, -73.838745D);
            var result1 = Usa.NewYork.IsInside(newyork);
            var result2 = Usa.GetState(newyork);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.NewYork, result2);
        }

        [TestMethod]
        public void InNorthCarolinaTests()
        {
            //35.464824,-79.155010
            var northcarolina = new Coordinate(35.464824D, -79.155010D);
            var result1 = Usa.NorthCarolina.IsInside(northcarolina);
            var result2 = Usa.GetState(northcarolina);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.NorthCarolina, result2);
        }

        [TestMethod]
        public void InNorthDakotaTests()
        {
            //TODO 46.845811,-96.799199 (Edge Case)
            //46.842217,-100.773677
            var northdakota = new Coordinate(46.842217D, -100.773677D);
            var result1 = Usa.NorthDakota.IsInside(northdakota);
            var result2 = Usa.GetState(northdakota);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.NorthDakota, result2);
        }

        [TestMethod]
        public void InOhioTests()
        {
            //41.403443,-82.364158
            var ohio = new Coordinate(41.403443D, -82.364158D);
            var result1 = Usa.Ohio.IsInside(ohio);
            var result2 = Usa.GetState(ohio);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Ohio, result2);
        }

        [TestMethod]
        public void InOklahomaTests()
        {
            //36.678490,-101.474060
            var oklahoma = new Coordinate(36.678490D, -101.474060D);
            var result1 = Usa.Oklahoma.IsInside(oklahoma);
            var result2 = Usa.GetState(oklahoma);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Oklahoma, result2);
        }

        [TestMethod]
        public void InOregonTests()
        {
            //44.055152,-121.262823
            var oregon = new Coordinate(44.055152D, -121.262823D);
            var result1 = Usa.Oregon.IsInside(oregon);
            var result2 = Usa.GetState(oregon);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Oregon, result2);
        }

        [TestMethod]
        public void InPennsylvaniaTests()
        {
            //39.950343,-75.158439
            var pennsylvania = new Coordinate(39.950343D, -75.158439D);
            var result1 = Usa.Pennsylvania.IsInside(pennsylvania);
            var result2 = Usa.GetState(pennsylvania);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Pennsylvania, result2);
        }

        [TestMethod]
        public void InRhodeIslandTests()
        {
            //41.520053,-71.299064
            var rhodeisland = new Coordinate(41.520053D, -71.299064D);
            var result1 = Usa.RhodeIsland.IsInside(rhodeisland);
            var result2 = Usa.GetState(rhodeisland);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.RhodeIsland, result2);
        }

        [TestMethod]
        public void InSouthCarolinaTests()
        {
            //34.216879,-82.157902
            var southcarolina = new Coordinate(34.216879D, -82.157902D);
            var result1 = Usa.SouthCarolina.IsInside(southcarolina);
            var result2 = Usa.GetState(southcarolina);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.SouthCarolina, result2);
        }

        [TestMethod]
        public void InSouthDakotaTests()
        {
            //43.513922,-96.770636
            var southdakota = new Coordinate(43.513922D, -96.770636D);
            var result1 = Usa.SouthDakota.IsInside(southdakota);
            var result2 = Usa.GetState(southdakota);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.SouthDakota, result2);
        }

        [TestMethod]
        public void InTennesseeTests()
        {
            //36.488110,-86.881293
            var tennessee = new Coordinate(36.488110D, -86.881293D);
            var result1 = Usa.Tennessee.IsInside(tennessee);
            var result2 = Usa.GetState(tennessee);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Tennessee, result2);
        }

        [TestMethod]
        public void InTexasTests()
        {
            //31.772589,-106.499772
            var texas = new Coordinate(31.772589D, -106.499772D);
            var result1 = Usa.Texas.IsInside(texas);
            var result2 = Usa.GetState(texas);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Texas, result2);
        }

        [TestMethod]
        public void InUtahTests()
        {
            //41.101169,-111.944091
            var utah = new Coordinate(41.101169D, -111.944091D);
            var result1 = Usa.Utah.IsInside(utah);
            var result2 = Usa.GetState(utah);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Utah, result2);
        }

        [TestMethod]
        public void InVermontTests()
        {
            //44.446321,-72.016207
            var vermont = new Coordinate(44.446321D, -72.016207D);
            var result1 = Usa.Vermont.IsInside(vermont);
            var result2 = Usa.GetState(vermont);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Vermont, result2);
        }

        [TestMethod]
        public void InVirginiaTests()
        {
            //36.939721,-82.606858
            var virginia = new Coordinate(36.939721D, -82.606858D);
            var result1 = Usa.Virginia.IsInside(virginia);
            var result2 = Usa.GetState(virginia);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Virginia, result2);
        }

        [TestMethod]
        public void InWashingtonTests()
        {
            //48.054309,-122.176509
            var washington = new Coordinate(48.054309D, -122.176509D);
            var result1 = Usa.Washington.IsInside(washington);
            var result2 = Usa.GetState(washington);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Washington, result2);
        }

        [TestMethod]
        public void InWestVirginiaTests()
        {
            //38.389116,-81.833454
            var westvirginia = new Coordinate(38.389116D, -81.833454D);
            var result1 = Usa.WestVirginia.IsInside(westvirginia);
            var result2 = Usa.GetState(westvirginia);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.WestVirginia, result2);
        }

        [TestMethod]
        public void InWisconsinTests()
        {
            //45.100461,-92.536683
            var wisconsin = new Coordinate(45.100461D, -92.536683D);
            var result1 = Usa.Wisconsin.IsInside(wisconsin);
            var result2 = Usa.GetState(wisconsin);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Wisconsin, result2);
        }

        [TestMethod]
        public void InWyomingTests()
        {
            //41.138792,-104.787246
            var wyoming = new Coordinate(41.138792D, -104.787246D);
            var result1 = Usa.Wyoming.IsInside(wyoming);
            var result2 = Usa.GetState(wyoming);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(StateName.Wyoming, result2);
        }
    }
}
