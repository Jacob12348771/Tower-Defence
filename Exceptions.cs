namespace DefenceGame {
    // Subclass of System.excpetion.
    class DefenceGameException : System.Exception {
        public DefenceGameException() {

        }
        //Excepts string for message.
        public DefenceGameException(string message) : base(message) {

        }
    }
    // Subclass of TDE.
    class OutOfBoundsException : DefenceGameException {
        public OutOfBoundsException() {
            
        }
        public OutOfBoundsException(string message) : base(message) {

        }
    }
}