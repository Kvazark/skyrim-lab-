using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creature
{
    abstract class Creature
    {
        //Абстрактне свойства
        public abstract string Name { get; set; }
        public abstract string Sex { get; protected set; }
        private int age { get; set; }
        //Обыкновенное поле со свойством
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        //Абстрактный метод без реавлизации
        public abstract bool Hunt();
        //Виртуальный метод
        public virtual void Riding()
        {
            Random randGen = new Random();
            int rndNum = randGen.Next(7);
            if (rndNum == 2)
            {
                this.Fiasco();
            }
            else
            {
                Console.WriteLine("{0} is a good horseman!", Name);
            }
        }
        
        private int Fiasco()
        {
            Console.WriteLine("The {0} fell from a horse.", Name);
            Random randGen = new Random();
            int num = randGen.Next(1, 9);
            return num;
        }
        //Обыкновенный метод
        public virtual void InfOutput()
        {
            Console.WriteLine("My name is {0} I am a {1}-year-old {2}.",Name, Age, Sex);
        }
        

    }
    //Производный класс от класса Существо- класс Каджит
    class Kajit : Creature
    {
        //Новое свойство
        public string CoatColor { get; set; }
        //Реализация абстрактынх свойств базового класса
        private string sex;
        public override string Sex
        {
            get
            {
                return sex;
            }
            protected set
            {
                if (string.Compare(value, "man", true) == 0 ||
                    string.Compare(value, "woman", true) == 0)
                {
                    sex = value;
                }
            }
        }
                    
        public override string Name { get; set; }
        public Kajit(string name, string sex, int age, string coatColor) : base()
        {
            Name = name;
            Sex = sex;
            Age = age;
            CoatColor = coatColor;
        }
           
        
        //Реализация абстрактного метода базового класса
        public override bool Hunt()
        {
            var randomGenerator = new Random();
            int randInt = randomGenerator.Next(3);
            if (randInt == 0)
            {
                Console.WriteLine("{0} killed a wild boar", Name);
                return false;
            }
            else
            {
                Console.WriteLine("{0} couldn't catch anyone on the hunt.", Name);
                return true;
            }
        }
        //Новый метод
        public void Steal()
        {
            Random gen = new Random();
            int rand = gen.Next(50);
            string thing = "";
            if (rand < 23)
            {
                thing = "detected";
            }
            else if (rand > 23 && rand < 38)
            {
                thing = "note";
            }
            else if (rand > 38 && rand < 47)
            {
                thing = "coin";
            }
            else
            {
                string[] vars = { "necklace", "ring", "sapphire", "the soul stone", "the dagger", "book" };
                rand = gen.Next(vars.Length);
                thing = vars[rand];
            }
            if (rand < 23)
            {
                Console.WriteLine("{0} didn't steal anything." ,Name);
            }
            else
            {
                Console.WriteLine("{0} stol a " + thing, Name);
            }
            
            
        }
        public void Growl()
        {
            Console.WriteLine("{0}: 'R-r-r'"+'\n'+ "*The {1} fur stood on end*", Name, CoatColor);
            Console.Beep();
        }
        //Новый метод, переопределяющий метод базового класса Creature
        public override void Riding()
        {
            Random randGen = new Random();
            int rndNum = randGen.Next(7);
            if (rndNum != 2)
            {
                Console.WriteLine("{0} couldn't saddle the horse and said: 'Kajit doesn't like this horse, Kajit would rather eat it.'", Name);
            }
            else
            {
                Console.WriteLine("{0} is a good horseman!", Name);
            }
        }

    }
    class Ogre : Creature
    {
        //Новое свойство
        public int CaninesSize { get; set; }
        //Реализация абстрактынх свойств базового класса
        private string sex;
        public override string Sex
        {
            get
            {
                return sex;
            }
            protected set
            {
                if (string.Compare(value, "man", true) == 0 ||
                    string.Compare(value, "woman", true) == 0)
                {
                    sex = value;
                }
            }
        }
        public Ogre(string name, string sex, int age, int caninesSize) : base()
        {
            Name = name;
            Sex = sex;
            Age = age;
            CaninesSize = caninesSize;
        }
        public override string Name { get; set; }
        //Реализация абстрактного метода базового класса
        public override bool Hunt()
        {
            var randomGenerator = new Random();
            int randInt = randomGenerator.Next(3);
            if (randInt == 0)
            {
                Console.WriteLine("{0} killed a wild bear.", Name);
                return false;
            }
            else
            {
                Console.WriteLine("{0} couldn't catch anyone on the hunt.", Name);
                return true;
            }
        }
        public void ThrowingStones()
        {
            Console.WriteLine("{0} threw {1} stones, because the length of his fangs is so much cm", Name, CaninesSize);
        }
    }
    class Elf : Creature
    {
        //Новое свойство
        public string Occupation { get; set; }
        //Реализация абстрактынх свойств базового класса
        private string sex;
        public override string Sex
        {
            get
            {
                return sex;
            }
            protected set
            {
                if (string.Compare(value, "man", true) == 0 ||
                    string.Compare(value, "woman", true) == 0)
                {
                    sex = value;
                }
            }
        }
        public override string Name { get; set; }
        public Elf(string name, string sex, int age, string occupation) : base()
        {
            Name = name;
            Sex = sex;
            Age = age;
            Occupation = occupation;
        }
        //Реализация абстрактного метода базового класса
        public override bool Hunt()
        {
            var randomGenerator = new Random();
            int randInt = randomGenerator.Next(3);
            if (randInt == 0)
            {
                Console.WriteLine("{0} killed a deer.", Name);
                return false;
            }
            else
            {
                Console.WriteLine("{0} couldn't catch anyone on the hunt.", Name);
                return true;
            }
        }
        //Новый метод
        public virtual void CastASpell()
        {
            Random gen = new Random();
            int rand = gen.Next(10);
            string spell = "";
            string[] spells = { "Arvak's Challenge", "Quick treatment", "Chain lightning"};
            if (rand > 5)
            {
                Console.WriteLine("Now the {0} will conjure.", Name);
                Console.WriteLine("And....");
                Console.WriteLine("It's a spell {0}.", spell);
            }
            else
            {
                Console.WriteLine("Now the {0} will conjure.", Name);
                Console.WriteLine("And....");
                Console.WriteLine("{0} didn't succeed.", Name);
            }
        }
        public override void InfOutput()
        {
            Console.WriteLine("Hi, my name is {0}, I am a {1} of {2} years old and I am {3}.", Name, Sex, Age, Occupation);
        }


    }
    class ForestElf : Elf
    {
        //Новое свойство
        public string Forest { get; set; }
        public ForestElf(string name, string sex, int age, string occupation, string Forest) : base(name, sex, age, occupation)
        {
        }
        
        //Новый метод
        public void MakeJoke()
        {
            Console.WriteLine("Once {0} says: 'Если моя собака прыгнула в воду, можно ли сказачать что она бульdog?'", Name);
        }
    }
    class HighElf : Elf
    {
        //Новое свойство
        public int height { get; set; }
        public HighElf(string name, string sex, int age, string occupation, int height) : base(name, sex, age, occupation)
        {
        }

        //Новый метод
        public void MakeWeapons()
        {
            Random gen = new Random();
            int rand = gen.Next(15);
            string weapons = "";
            string[] vars = { "sword", "spear", "bow", "tomahawk" };
            rand = gen.Next(vars.Length);
            weapons = vars[rand];
            Console.WriteLine("{0} made a "+ weapons, Name);
        }
    }
    class DarkElf : Elf
    {
        //Новое свойство
        public string eyeColor { get; set; }
        public DarkElf(string name, string sex, int age, string occupation, string eyeColor) : base(name, sex, age, occupation)
        {
        }
        //Новый метод, переопределяющий метод CastASpell класса Elf
        public override void CastASpell()
        {
            Random gen = new Random();
            int rand = gen.Next(10);
            string spell = "";
            string[] spells = { "freezing", "firestorm", "chain lightning", "ice spike", "thunder wall" };
            if (rand != 1 || rand !=8)
            {
                Console.WriteLine("{0} casts a spell of destruction.", Name);
                rand = gen.Next(spells.Length);
                spell = spells[rand];
                Console.WriteLine("And....");
                Console.WriteLine("Now the spell '{0}' has killed the robber.", spell);
            }
            else
            {
                Console.WriteLine("{0} casts a spell of destruction.", Name);
                Console.WriteLine("And....");
                Console.WriteLine("{0} didn't succeed.", Name);
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Creature kjCr = new Kajit("K'Amobus", "man", 25, "brown");
            Creature elfCr = new Elf("Kella", "woman", 21, "hunter");
            Creature ogreCr = new Ogre("Trall", "man", 43, 19);
            Creature fstElfCr = new ForestElf("Nill", "man", 58, "the bard", "Oak forest");

            kjCr.InfOutput();

            elfCr.Riding();
            elfCr.Hunt();

            fstElfCr.Hunt();
            fstElfCr.Riding();

            ogreCr.Hunt();

            Kajit kajit = new Kajit("D'Abobus", "man", 31, "black");
            kajit.Steal();
            kajit.Riding();
            kajit.Growl();

            Console.WriteLine("");

            //Демонстация методов
            Ogre ogre = new Ogre("Shrek", "man", 38, 15);
            ogre.ThrowingStones();
            
            Elf elf = new Elf("Din", "man", 26, "hunter");
            elf.CastASpell();

            ForestElf foresrElf = new ForestElf("Nill", "man", 58, "the bard", "Oak forest");
            foresrElf.MakeJoke();

            HighElf highElf = new HighElf("Bon", "man", 32, "trader", 215);
            highElf.MakeWeapons();

            DarkElf darkElf = new DarkElf("Eva", "woman", 19, "magician", "red");
            darkElf.InfOutput();
            darkElf.CastASpell();



            Console.ReadKey();
        }
    }
}
