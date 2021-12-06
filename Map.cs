namespace  DefenceGame {
    class Map {
        // Public variables so other classes can access.
        // Instance variables.
        // Readonly so map can't be changed after creation.
        public readonly int Width;
        public readonly int Height;
        // Constructor Methods - No return.
        public Map(int width, int height) {
            // Method variables.
            Width = width;
            Height = height;
        }
        public bool OnMap(Point point) {
            // Expression to check if player is on map. If conditions are false point is outside map.
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height;
        }
    }
}