using System.Collections.Generic;

namespace Example_1912
{
    class Keeper
    {
        private Stack<State> states = new Stack<State>();
        //private List<State> states = new List<State>();
        public void Add(State CurrentState) => states.Push(CurrentState);
        public State Get() => states.Pop();
        //public State Get(int i) => states[i];
    }
}
