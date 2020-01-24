using System;
using System.Collections.Generic;

namespace ITEAHub.Math
{
    class Game
    {
        private List<IMenu> Menu = new List<IMenu>();


        public Game(List<IMenu> menu)
        {
            Menu.AddRange(menu);
        }

        internal void Start()
        {
            while (true)
            {
                foreach (var item in Menu)
                {
                    System.Console.WriteLine(item.Name);

                }
                var i = Convert.ToInt32(Console.ReadLine());
                Menu[i - 1].Action();
            }
        }


    }



    class AddMenu : IMenu
    {
        public string Name
        {
            get
            {
                return "Add Question";
            }
        }

        public void Action()
        {
            var addQuestion = new AddQuestion();
            addQuestion.Add();
        }
    }

    class ASatrtenu : IMenu
    {
        public string Name
        {
            get
            {
                return "Start";
            }
        }

        public void Action()
        {
            Console.WriteLine("Game");
            // TODO Create your class with logic of add class    
        }
    }

    class ExitMenu : IMenu
    {
        public string Name => "Exit";

        public void Action()
        {
            Environment.Exit(0);
        }
    }
}
