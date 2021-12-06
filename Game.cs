using System;
namespace DefenceGame {
    class Game {
        public static void Main() {
            // Creates new variable map with type Map, and assigns it a newly created Map object.
            Map map = new Map(8, 5);
            // Most generic exceptions caught last.
            try {
                Path path = new Path(
                new [] {
                    // New array being created and passed into constructor of path class above.
                   new MapLocation(0, 2, map),
                   new MapLocation(1, 2, map),
                   new MapLocation(2, 2, map),
                   new MapLocation(3, 2, map),
                   new MapLocation(4, 2, map),
                   new MapLocation(5, 2, map),
                   new MapLocation(6, 2, map),
                   new MapLocation(7, 2, map)
                }
            );
            Invader[] invaders = {
                new Invader(path),
                new Invader(path),
                new Invader(path),
                new Invader(path)
            };
            Tower[] towers = {
                new Tower(new MapLocation(1, 3, map)),
                new Tower(new MapLocation(3, 3, map)),
                new Tower(new MapLocation(5, 3, map))
            };
            Level level = new Level(invaders) {
                Towers = towers
            };
            bool playerWon = level.Play();
            Console.WriteLine("Player " + (playerWon? "won" : "lost"));
            }
            catch (OutOfBoundsException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (DefenceGameException) {
                Console.WriteLine("Unhandled DefenceGameException");
            }// Converts exception to string to get more info.
            catch(Exception ex) {
                Console.WriteLine("Unhandled Exception " + ex);
            }
        }
    }
}