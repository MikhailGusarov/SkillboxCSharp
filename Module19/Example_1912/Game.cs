using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_1912
{
    class Game
    {
        public Game()
        {
            this.Level = 1;
            this.Hp = 200;
            this.Gold = 1000;
            this.Message = "Начало";
            new Thread(() =>
            {
                while (true)
                {
                    if(this.Gold<int.MaxValue)
                    {
                        this.Gold += 2;
                        Thread.Sleep(200);
                    }
                }
            }).Start();
        }
        public int Level { get; set; }
        public int Hp { get; set; }

        public void LevelUp() => this.Level++;
        public void SetMessage(string Msg) => this.Message = Msg;
        public int Gold { get; set; }
        public string Message { get; set; }

        public State SaveCurrentState() => new State(new Args(this.Level, this.Hp, this.Gold, this.Message));

        public void GetStateFromStorage(State LastState)
        {
            this.Level = LastState.GetState().Level;
            this.Hp = LastState.GetState().Hp;
            this.Gold = LastState.GetState().Gold;
            this.Message = LastState.GetState().Message;
        }

        public override string ToString()
        {
            return $"Level: {this.Level} Hp: {this.Hp} Gold: {this.Gold} Message: {this.Message}";
        }
    }
}
