using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creature
{
 //Класс существа
    class Creature
    {
// Поля класса
        public string name { get; set; }
        public string species { get; set; }
        public int age { get; set; }
        public int height { get; set; }
        public string eyeColor = "blue";

        //Конструктор по умолчанию
        public Creature()
        {
            name = "Geralt";
            species = "elf";
            age = 38;
            height = 185;
        }
        //Конструктор копирования
        public Creature(Creature obj)
        {
            this.name = obj.name;
            this.species = obj.species;
            this.age = obj.age;
            this.height = obj.height;
            this.eyeColor = obj.eyeColor;
        }
        //Конструктор с параметрами
        public Creature(string name,string species,int age, int height)
        {
            this.name = name;
            this.species = species;
            this.age = age;
            this.height = height;
        }
        // Открытый метод класса
        public void Relax()
        {
            Console.WriteLine("The {0} is resting after riding.", name);
        }

        public void Reflect()
        {
            if(age > 0 && age < 14)
            {
                Console.WriteLine("The {0} wondered: 'Why a corgi has a peach instead of a priest?'", name);
            }
            else if(age >= 14 && age < 22)
            {
                Console.WriteLine("The {0} is thinking about how to solve urgent problems.", name);
            }
            else if (age >= 22 && age < 63)
            {
                Console.WriteLine("The {0} remembered the good moments.", name);
            }
            else if (age >= 63)
            {
                Console.WriteLine("The {0} is tired of living...", name);
            }
            else
            {

            }
        }

        public void Riding()
        {
            Random randGen = new Random();
            int rndNum = randGen.Next(7);
            if (rndNum == 2)
            {
                this.Fiasco();
            }
            else
            {
                Console.WriteLine("{0} is a good horseman!", name);
            }
        }
        // Закрытый метод класса
        private int Fiasco()
        {
            Console.WriteLine("The {0} fell from a horse.", name);
            Random randGen = new Random();
            int num = randGen.Next(1, 9);
            return num;
        }

        public void EatSmth(int num)
        {
            Random gen = new Random();
            int rand = gen.Next(15);
            string food = "";
            if(num == 1)
            {
                if (rand < 4)
                {
                    food = "gammon";
                }
                else if (rand > 4 && rand < 7)
                {
                    food = "chicken leg";
                }
                else if (rand > 7 && rand < 11)
                {
                    food = "duck";
                }
                else
                {
                    string[] vars = { "ham", "meat brisket", "bacon", "rabbit" };
                    rand = gen.Next(vars.Length);
                    food = vars[rand];
                }
                Console.WriteLine(food);
            }
            else if (num == 2)
            {
                if (rand < 4)
                {
                    food = "apple";

                }
                else if (rand > 4 && rand < 7)
                {
                    food = "raspberry";

                }
                else if (rand > 7 && rand < 11)
                {
                    food = "pear";

                }
                else
                {

                    string[] vars1 = { "cherry", "plum", "blackberry", "blueberry" };
                    rand = gen.Next(vars1.Length);
                    food = vars1[rand];
                }
                Console.WriteLine(food);
            }
            
        }
        public void EatSmth(int num, int count)
        {
            string[] foods = new string[count];
            string food = "";

            Console.Write("{0} ate today ", name);

            for (int i=0; i < count; i++)   
            {
                Random gen = new Random();
                int rand = gen.Next(10);

                if (rand < 3)
                {
                    this.EatSmth(num);
                    
                    
                }
                else if (rand > 3 && rand < 5)
                {
                    this.EatSmth(num);

                }
                else if (rand > 5 && rand < 8)
                {
                    this.EatSmth(num);

                }
                else
                {
                  
                    this.EatSmth(num);
                }
                foods[i] = food;

            }
            

        }
        public void GetInfo()
        {
            Console.WriteLine($"This is a {species} {age}-year-old {name} {height} cm tall with {eyeColor} eyes.");
        }
        ~Creature()   
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} dead", name);
            Console.Beep();
        }


    }
    class Program
    {
        protected static void Comparison(int h1, int h2)
        {
            if (h1 > h2)
            {
                Console.WriteLine("The first is higher than the second.");
            }
            else if (h1 < h2)
            {
                Console.WriteLine("The first is lower than the second.");
            }
            else
            {
                Console.WriteLine("They have the same height.");
            }
        }
        static void Main(string[] args)
        {
            Creature cr1 = new Creature();
            cr1.GetInfo();

            Creature cr2 = new Creature { name = "D'Alen", species = "kajit", age = 12, height = 156 };
            cr2.GetInfo();
            cr2.Reflect();
            Console.WriteLine("Let's compare the growth {0} and {1}...", cr1.name, cr2.name);
            Comparison(cr1.height,cr2.height);

            Console.WriteLine("");

            Creature cr4 = new Creature(cr1);
            cr4.GetInfo();

            Console.WriteLine("{0} prefers? Write number" + '\n' + "1.meat" + '\n' + "2.vegetation", cr4.name);
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нow many times does {0} eat?", cr4.name);
            int count = Convert.ToInt32(Console.ReadLine());
            cr4.EatSmth(num2, count);

            Creature cr3 = new Creature();
            Console.WriteLine("What is the name of the creature?");
            cr3.name = Console.ReadLine();
            Console.WriteLine("What race is {0} ?", cr3.name);
            cr3.species = Console.ReadLine();
            Console.WriteLine("How old is {0} ?", cr3.name);
            cr3.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} has {1} eyes", cr3.name, cr3.eyeColor);

            cr3.Riding();
            cr3.Relax();

            Console.WriteLine("{0} prefers? Write number"+ '\n' +"1.meat" + '\n'+ "2.vegetation", cr3.name);
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} ate ", cr3.name);
            cr3.EatSmth(num1);
            cr3.Reflect();

            Creature[] obj = new Creature[3];
            for (int i = 0; i < 3; i++) 
                obj[i] = new Creature();


            Console.ReadKey();
        }
    }
}
