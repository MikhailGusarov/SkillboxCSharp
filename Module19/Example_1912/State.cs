namespace Example_1912
{

    public class State
    {
        private Args Arg;

        public State(Args arg)
        {
            this.Arg = arg;
        }

        public Args GetState()
        {
            return this.Arg;
        }
    }
}