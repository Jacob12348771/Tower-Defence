namespace  DefenceGame {
    class Path {
        // Map location points private.
        //_ for names of private fields.
        private readonly MapLocation[] _path;
        public int Length => _path.Length;
        public Path(MapLocation[] path) {
            _path = path;
        }
        public MapLocation GetLocationAt(int pathStep) {
            // Ternary if operator used for simplicity.
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}