using System;
namespace  DefenceGame {
    class Tower {
        // Power and inst constants make it clearer to see what they are used for below.
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;
        // Because of being static only one of these can occur. Random initialised once and shared by all tower objects.
        private static readonly Random _random = new Random();
        private readonly MapLocation _location;

        public Tower(MapLocation location) {
            _location = location;
        }
        // 75% of the time number generated between 0 and 0.75.
        public bool IsSuccessfulShot() {
            return Tower._random.NextDouble() < _accuracy;
        }
        // Method that passes in all invaders in map.
        public void FireOneInvaders(Invader[] invaders) {
            // For each loop to go through all invaders in array (on map).
            foreach(Invader invader in invaders) {
                // Can only shoot if the invader is in range and has health left.
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range)) {
                    if(IsSuccessfulShot()) {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit invader!");
                        if(invader.IsNeutralized) {
                            Console.WriteLine("Killed invader!");
                        }
                    }
                    else {
                        Console.WriteLine("Shot at and missed invader!");
                    }

                    // Nothing after so returns to the code that calls it.
                    break;
                }
            }
        }
    }
}