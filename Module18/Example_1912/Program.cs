using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_1912
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine(game);
            Thread.Sleep(1000);

            Keeper keeper = new Keeper();
            keeper.Add(game.SaveCurrentState());
            Thread.Sleep(1000);
            game.LevelUp();
            Console.WriteLine(game);
            Thread.Sleep(1000);

            keeper.Add(game.SaveCurrentState());
            game.SetMessage("Следующая стадия");

            game.LevelUp(); game.LevelUp(); game.LevelUp();

            game.SetMessage("Новая стадия");

            keeper.Add(game.SaveCurrentState());


            Console.WriteLine(game);

            game.GetStateFromStorage(keeper.Get());
            Console.WriteLine(game);

            Thread.Sleep(5000);

            Console.WriteLine(game);

            game.GetStateFromStorage(keeper.Get());
            Console.WriteLine(game);

            Thread.Sleep(5000);
            Console.WriteLine(game);

            game.GetStateFromStorage(keeper.Get());
            Console.WriteLine(game);



        }


    }
}
