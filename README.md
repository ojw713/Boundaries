# Boundaries
Point in polygon testing for coordinates in the 50 US states

Point in Polygon - Algorithm based on article [here](https://web.archive.org/web/20161108113341/https://www.ecse.rpi.edu/Homepages/wrf/Research/Short_Notes/pnpoly.html)

[50 States Boundaries XML](http://econym.org.uk/gmap/states.xml)

## Usage
**IsInside**
```c#
var point = new Coordinate(63.1148002D,-151.1926057D);
bool result = Usa.Alaska.IsInside(point);
```

**GetState**
```c#
var point = new Coordinate(36.1069652D,-112.1129972D);
string result = Usa.GetState(point);
```
Returns "None" if the point is outside of USA.
