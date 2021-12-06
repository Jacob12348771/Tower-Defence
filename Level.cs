namespace DefenceGame {
    class Level {
        private readonly Invader[] _invaders;
        // Players can set array after level is created.
        public Tower[] Towers {get; set;}
        public Level(Invader[] invaders) {
            _invaders = invaders;
        }
        // Returns true if the player wins, false otherwise.
        public bool Play() {
            // Run until all invaders are neutralized or an invader reaches the end of the path.
            int remainingInvaders = _invaders.Length;
            while(remainingInvaders > 0) {
                 // Each tower has opportunity to fire on invaders.
                 foreach (Tower tower in Towers) {
                     tower.FireOneInvaders(_invaders);
                 }
                 // Count and move invaders that are still active.
                remainingInvaders = 0;
                foreach(Invader invader in _invaders) {
                    if(invader.IsActive) {
                        invader.Move();
                        if(invader.HasScored) {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
    }
}