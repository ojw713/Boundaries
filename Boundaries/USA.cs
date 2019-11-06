using Boundaries.Factories;
using Boundaries.Models;
using System;

namespace Boundaries
{
    public static class Usa
    {
        private static readonly Lazy<State> LazyAlabama = new Lazy<State>(() => StateFactory.GetState(StateName.Alabama));
        private static readonly Lazy<State> LazyAlaska = new Lazy<State>(() => StateFactory.GetState(StateName.Alaska));
        private static readonly Lazy<State> LazyArizona = new Lazy<State>(() => StateFactory.GetState(StateName.Arizona));
        private static readonly Lazy<State> LazyArkansas = new Lazy<State>(() => StateFactory.GetState(StateName.Arkansas));
        private static readonly Lazy<State> LazyCalifornia = new Lazy<State>(() => StateFactory.GetState(StateName.California));
        private static readonly Lazy<State> LazyColorado = new Lazy<State>(() => StateFactory.GetState(StateName.Colorado));
        private static readonly Lazy<State> LazyConnecticut = new Lazy<State>(() => StateFactory.GetState(StateName.Connecticut));
        private static readonly Lazy<State> LazyDelaware = new Lazy<State>(() => StateFactory.GetState(StateName.Delaware));
        private static readonly Lazy<State> LazyFlorida = new Lazy<State>(() => StateFactory.GetState(StateName.Florida));
        private static readonly Lazy<State> LazyGeorgia = new Lazy<State>(() => StateFactory.GetState(StateName.Georgia));
        private static readonly Lazy<State> LazyHawaii = new Lazy<State>(() => StateFactory.GetState(StateName.Hawaii));
        private static readonly Lazy<State> LazyIdaho = new Lazy<State>(() => StateFactory.GetState(StateName.Idaho));
        private static readonly Lazy<State> LazyIllinois = new Lazy<State>(() => StateFactory.GetState(StateName.Illinois));
        private static readonly Lazy<State> LazyIndiana = new Lazy<State>(() => StateFactory.GetState(StateName.Indiana));
        private static readonly Lazy<State> LazyIowa = new Lazy<State>(() => StateFactory.GetState(StateName.Iowa));
        private static readonly Lazy<State> LazyKansas = new Lazy<State>(() => StateFactory.GetState(StateName.Kansas));
        private static readonly Lazy<State> LazyKentucky = new Lazy<State>(() => StateFactory.GetState(StateName.Kentucky));
        private static readonly Lazy<State> LazyLouisiana = new Lazy<State>(() => StateFactory.GetState(StateName.Louisiana));
        private static readonly Lazy<State> LazyMaine = new Lazy<State>(() => StateFactory.GetState(StateName.Maine));
        private static readonly Lazy<State> LazyMaryland = new Lazy<State>(() => StateFactory.GetState(StateName.Maryland));
        private static readonly Lazy<State> LazyMassachusetts = new Lazy<State>(() => StateFactory.GetState(StateName.Massachusetts));
        private static readonly Lazy<State> LazyMichigan = new Lazy<State>(() => StateFactory.GetState(StateName.Michigan));
        private static readonly Lazy<State> LazyMinnesota = new Lazy<State>(() => StateFactory.GetState(StateName.Minnesota));
        private static readonly Lazy<State> LazyMississippi = new Lazy<State>(() => StateFactory.GetState(StateName.Mississippi));
        private static readonly Lazy<State> LazyMissouri = new Lazy<State>(() => StateFactory.GetState(StateName.Missouri));
        private static readonly Lazy<State> LazyMontana = new Lazy<State>(() => StateFactory.GetState(StateName.Montana));
        private static readonly Lazy<State> LazyNebraska = new Lazy<State>(() => StateFactory.GetState(StateName.Nebraska));
        private static readonly Lazy<State> LazyNevada = new Lazy<State>(() => StateFactory.GetState(StateName.Nevada));
        private static readonly Lazy<State> LazyNewHampshire = new Lazy<State>(() => StateFactory.GetState(StateName.NewHampshire));
        private static readonly Lazy<State> LazyNewJersey = new Lazy<State>(() => StateFactory.GetState(StateName.NewJersey));
        private static readonly Lazy<State> LazyNewMexico = new Lazy<State>(() => StateFactory.GetState(StateName.NewMexico));
        private static readonly Lazy<State> LazyNewYork = new Lazy<State>(() => StateFactory.GetState(StateName.NewYork));
        private static readonly Lazy<State> LazyNorthCarolina = new Lazy<State>(() => StateFactory.GetState(StateName.NorthCarolina));
        private static readonly Lazy<State> LazyNorthDakota = new Lazy<State>(() => StateFactory.GetState(StateName.NorthDakota));
        private static readonly Lazy<State> LazyOhio = new Lazy<State>(() => StateFactory.GetState(StateName.Ohio));
        private static readonly Lazy<State> LazyOklahoma = new Lazy<State>(() => StateFactory.GetState(StateName.Oklahoma));
        private static readonly Lazy<State> LazyOregon = new Lazy<State>(() => StateFactory.GetState(StateName.Oregon));
        private static readonly Lazy<State> LazyPennsylvania = new Lazy<State>(() => StateFactory.GetState(StateName.Pennsylvania));
        private static readonly Lazy<State> LazyRhodeIsland = new Lazy<State>(() => StateFactory.GetState(StateName.RhodeIsland));
        private static readonly Lazy<State> LazySouthCarolina = new Lazy<State>(() => StateFactory.GetState(StateName.SouthCarolina));
        private static readonly Lazy<State> LazySouthDakota = new Lazy<State>(() => StateFactory.GetState(StateName.SouthDakota));
        private static readonly Lazy<State> LazyTennessee = new Lazy<State>(() => StateFactory.GetState(StateName.Tennessee));
        private static readonly Lazy<State> LazyTexas = new Lazy<State>(() => StateFactory.GetState(StateName.Texas));
        private static readonly Lazy<State> LazyUtah = new Lazy<State>(() => StateFactory.GetState(StateName.Utah));
        private static readonly Lazy<State> LazyVermont = new Lazy<State>(() => StateFactory.GetState(StateName.Vermont));
        private static readonly Lazy<State> LazyVirginia = new Lazy<State>(() => StateFactory.GetState(StateName.Virginia));
        private static readonly Lazy<State> LazyWashington = new Lazy<State>(() => StateFactory.GetState(StateName.Washington));
        private static readonly Lazy<State> LazyWestVirginia = new Lazy<State>(() => StateFactory.GetState(StateName.WestVirginia));
        private static readonly Lazy<State> LazyWisconsin = new Lazy<State>(() => StateFactory.GetState(StateName.Wisconsin));
        private static readonly Lazy<State> LazyWyoming = new Lazy<State>(() => StateFactory.GetState(StateName.Wyoming));

        public static readonly State Alabama = LazyAlabama.Value;
        public static readonly State Alaska = LazyAlaska.Value;
        public static readonly State Arizona = LazyArizona.Value;
        public static readonly State Arkansas = LazyArkansas.Value;
        public static readonly State California = LazyCalifornia.Value;
        public static readonly State Colorado = LazyColorado.Value;
        public static readonly State Connecticut = LazyConnecticut.Value;
        public static readonly State Delaware = LazyDelaware.Value;
        public static readonly State Florida = LazyFlorida.Value;
        public static readonly State Georgia = LazyGeorgia.Value;
        public static readonly State Hawaii = LazyHawaii.Value;
        public static readonly State Idaho = LazyIdaho.Value;
        public static readonly State Illinois = LazyIllinois.Value;
        public static readonly State Indiana = LazyIndiana.Value;
        public static readonly State Iowa = LazyIowa.Value;
        public static readonly State Kansas = LazyKansas.Value;
        public static readonly State Kentucky = LazyKentucky.Value;
        public static readonly State Louisiana = LazyLouisiana.Value;
        public static readonly State Maine = LazyMaine.Value;
        public static readonly State Maryland = LazyMaryland.Value;
        public static readonly State Massachusetts = LazyMassachusetts.Value;
        public static readonly State Michigan = LazyMichigan.Value;
        public static readonly State Minnesota = LazyMinnesota.Value;
        public static readonly State Mississippi = LazyMississippi.Value;
        public static readonly State Missouri = LazyMissouri.Value;
        public static readonly State Montana = LazyMontana.Value;
        public static readonly State Nebraska = LazyNebraska.Value;
        public static readonly State Nevada = LazyNevada.Value;
        public static readonly State NewHampshire = LazyNewHampshire.Value;
        public static readonly State NewJersey = LazyNewJersey.Value;
        public static readonly State NewMexico = LazyNewMexico.Value;
        public static readonly State NewYork = LazyNewYork.Value;
        public static readonly State NorthCarolina = LazyNorthCarolina.Value;
        public static readonly State NorthDakota = LazyNorthDakota.Value;
        public static readonly State Ohio = LazyOhio.Value;
        public static readonly State Oklahoma = LazyOklahoma.Value;
        public static readonly State Oregon = LazyOregon.Value;
        public static readonly State Pennsylvania = LazyPennsylvania.Value;
        public static readonly State RhodeIsland = LazyRhodeIsland.Value;
        public static readonly State SouthCarolina = LazySouthCarolina.Value;
        public static readonly State SouthDakota = LazySouthDakota.Value;
        public static readonly State Tennessee = LazyTennessee.Value;
        public static readonly State Texas = LazyTexas.Value;
        public static readonly State Utah = LazyUtah.Value;
        public static readonly State Vermont = LazyVermont.Value;
        public static readonly State Virginia = LazyVirginia.Value;
        public static readonly State Washington = LazyWashington.Value;
        public static readonly State WestVirginia = LazyWestVirginia.Value;
        public static readonly State Wisconsin = LazyWisconsin.Value;
        public static readonly State Wyoming = LazyWyoming.Value;

        public static StateName GetState(Coordinate coordinate)
        {
            if (Alabama.IsInside(coordinate)) { return Alabama.Name; }
            else if (Alaska.IsInside(coordinate)) { return Alaska.Name; }
            else if (Arizona.IsInside(coordinate)) { return Arizona.Name; }
            else if (Arkansas.IsInside(coordinate)) { return Arkansas.Name; }
            else if (California.IsInside(coordinate)) { return California.Name; }
            else if (Colorado.IsInside(coordinate)) { return Colorado.Name; }
            else if (Connecticut.IsInside(coordinate)) { return Connecticut.Name; }
            else if (Delaware.IsInside(coordinate)) { return Delaware.Name; }
            else if (Florida.IsInside(coordinate)) { return Florida.Name; }
            else if (Georgia.IsInside(coordinate)) { return Georgia.Name; }
            else if (Hawaii.IsInside(coordinate)) { return Hawaii.Name; }
            else if (Idaho.IsInside(coordinate)) { return Idaho.Name; }
            else if (Illinois.IsInside(coordinate)) { return Illinois.Name; }
            else if (Indiana.IsInside(coordinate)) { return Indiana.Name; }
            else if (Iowa.IsInside(coordinate)) { return Iowa.Name; }
            else if (Kansas.IsInside(coordinate)) { return Kansas.Name; }
            else if (Kentucky.IsInside(coordinate)) { return Kentucky.Name; }
            else if (Louisiana.IsInside(coordinate)) { return Louisiana.Name; }
            else if (Maine.IsInside(coordinate)) { return Maine.Name; }
            else if (Maryland.IsInside(coordinate)) { return Maryland.Name; }
            else if (Massachusetts.IsInside(coordinate)) { return Massachusetts.Name; }
            else if (Michigan.IsInside(coordinate)) { return Michigan.Name; }
            else if (Minnesota.IsInside(coordinate)) { return Minnesota.Name; }
            else if (Mississippi.IsInside(coordinate)) { return Mississippi.Name; }
            else if (Missouri.IsInside(coordinate)) { return Missouri.Name; }
            else if (Montana.IsInside(coordinate)) { return Montana.Name; }
            else if (Nebraska.IsInside(coordinate)) { return Nebraska.Name; }
            else if (Nevada.IsInside(coordinate)) { return Nevada.Name; }
            else if (NewHampshire.IsInside(coordinate)) { return NewHampshire.Name; }
            else if (NewJersey.IsInside(coordinate)) { return NewJersey.Name; }
            else if (NewMexico.IsInside(coordinate)) { return NewMexico.Name; }
            else if (NewYork.IsInside(coordinate)) { return NewYork.Name; }
            else if (NorthCarolina.IsInside(coordinate)) { return NorthCarolina.Name; }
            else if (NorthDakota.IsInside(coordinate)) { return NorthDakota.Name; }
            else if (Ohio.IsInside(coordinate)) { return Ohio.Name; }
            else if (Oklahoma.IsInside(coordinate)) { return Oklahoma.Name; }
            else if (Oregon.IsInside(coordinate)) { return Oregon.Name; }
            else if (Pennsylvania.IsInside(coordinate)) { return Pennsylvania.Name; }
            else if (RhodeIsland.IsInside(coordinate)) { return RhodeIsland.Name; }
            else if (SouthCarolina.IsInside(coordinate)) { return SouthCarolina.Name; }
            else if (SouthDakota.IsInside(coordinate)) { return SouthDakota.Name; }
            else if (Tennessee.IsInside(coordinate)) { return Tennessee.Name; }
            else if (Texas.IsInside(coordinate)) { return Texas.Name; }
            else if (Utah.IsInside(coordinate)) { return Utah.Name; }
            else if (Vermont.IsInside(coordinate)) { return Vermont.Name; }
            else if (Virginia.IsInside(coordinate)) { return Virginia.Name; }
            else if (Washington.IsInside(coordinate)) { return Washington.Name; }
            else if (WestVirginia.IsInside(coordinate)) { return WestVirginia.Name; }
            else if (Wisconsin.IsInside(coordinate)) { return Wisconsin.Name; }
            else if (Wyoming.IsInside(coordinate)) { return Wyoming.Name; }
            else { return StateName.None; }
        }
    }
}
