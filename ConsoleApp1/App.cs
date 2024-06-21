using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFrankAlbert
{
    internal class App
    {
        bool hasLegs;
        bool hasWings;
        bool doesBite;
        bool doesSting;
        List<Bug> bugs = new List<Bug>();
        Wasp wasp = new Wasp();
        Spider spider = new Spider();
        Tick tick = new Tick();
        Musquito musquito = new Musquito();
        bool bugsAddedToList = false;
        
        public void Run()
        {
            bool con = true;
            if (!bugsAddedToList)
            {
                AddBugsToList();
            }

            Console.WriteLine("Welcome to the bug collection!");
            while (con)
            {
                Console.WriteLine("1. Display bugs\n2. Add bugs");
                var answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Hub1();
                        break;

                    case 2:
                        Hub2();
                        break;

                    default:
                        Run();
                        break;    
                }
                Console.WriteLine("Press any key to go back!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void Hub1() 
        {
            Console.Clear();
            DisplayBugs();
        }

        public void Hub2()
        {
            Console.Clear();
            bugs.Add(AddNewBug());
        }

        public void DisplayBugs()
        {
            var index = 1;
            Console.WriteLine("Bugs:");
            
            foreach (var bug in bugs)
            {
                Console.WriteLine(index + "." + bug.Name);
                index++;
            }
            var answer = Console.ReadLine();

            if (int.TryParse(answer, out int output) && output > 0 && output <= bugs.Count)
            {
                var selectedBug = bugs[output - 1];
                selectedBug.ShowInfo();
            }



        }

        public Bug AddNewBug()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Has legs?\n1. Yes\n2. No");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    hasLegs = true;
                    break;
                case "2":
                    hasLegs = false;
                    break;
            }
            Console.WriteLine("Has wings?\n1. Yes\n2. No");
            var input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    hasWings = true;
                    break;
                case "2":
                    hasWings = false;
                    break;
            }
            Console.WriteLine("Does bite?\n1. Yes\n2. No");
            var input3 = Console.ReadLine();
            switch (input3)
            {
                case "1":
                    doesBite = true;
                    break;
                case "2":
                    doesBite = false;
                    break;
            }
            Console.WriteLine("Does sting?\n1. Yes\n2. No");
            var input4 = Console.ReadLine();
            switch (input4)
            {
                case "1":
                    doesSting = true;
                    break;
                case "2":
                    doesSting = false;
                    break;
            }
            return new Bug(name, hasLegs, hasWings, doesBite, doesSting);
        }

        public void AddBugsToList()
        {
            bugs.Add(wasp);
            bugs.Add(spider);
            bugs.Add(tick);
            bugs.Add(musquito);

            bugsAddedToList = true;
        }
    }
}
