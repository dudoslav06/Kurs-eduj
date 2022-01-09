using System;

namespace Klasyiobiekty
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

   
    class Person
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        private string name;

        public string Name
        {
            get { return "Imie:"+ name; }
            set 
            { 
                if (value.Length >2 )
                    name = value; 
            }
        }

        public string getName()
        {
            return name;
        }
        public void setName(string value)
        {
            if (value.Length > 2 )
                name = value;
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value <= 200)
                age = value;
            }
        }

        public string Country { get; set; }
        public void Hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat.");
        }
    }
}
