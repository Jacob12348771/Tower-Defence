namespace DefenceGame {
    class MapLocation : Point {
        // Any map location class objects created will be point objects.
        public MapLocation(int x, int y, Map map) : base(x, y) {
            if (!map.OnMap(this)) {
                // Throws exception for OutOfBoundsExcpetion.
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of map.");
            }
        }
        // Calls distance method and checks if it is <= range.
        public bool InRangeOf (MapLocation location, int range) {
            return DistanceTo(location) <= range;
        }
    }
}