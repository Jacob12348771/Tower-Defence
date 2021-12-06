namespace  DefenceGame {
    class Invader {
        private readonly Path _path;
        private int _pathStep = 0;
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        // Health variable declared with getter and setter in order for other classes to change it.
        public int Health {get;private set;} = 2;
        // True if invader has reached end of the path.
        public bool HasScored { get { return _pathStep >= _path.Length;}}
        //True if all health is gone.
        public bool IsNeutralized => Health <= 0;
        // True if player still has health.
        public bool IsActive => !(IsNeutralized || HasScored);
        // Constructor sets location to first location on the path so path is passed it.
        public Invader(Path path) {
            _path = path;
        }
        // Can move simple like this on one line to make it more precise.
        // Properties always return a value unlike this method below.
        public void Move() => _pathStep += 1;
        //Individual method to decrease health means that code is easier to alter and see for other progammers.
        public void DecreaseHealth(int factor) {
            Health -= factor;
        }
        }
    }
    