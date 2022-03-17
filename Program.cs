using System;
using System.Collections.Generic;

namespace Dict

{
    class Diction
    {
        string rus;
        string eng;
        public string Rus
        {
            get
            {
                return rus;
            }
            set
            {
                rus = value;
            }
        }
        public string Eng
        {
            get
            {
                return eng;
            }
            set
            {
                eng = value;
            }
        }
        public Diction(string Rus1, string Eng1)
        {
            Rus = Rus1;
            Eng = Eng1;
        }

        public override string ToString()
        {
            return string.Format("Перевод:" + Eng);
        }
    }
    class Program

    {
        static void Nahod(Diction d1, string s1)
        {
            if (s1 == d1.Rus)
                Console.WriteLine(d1.ToString());
        }
        static void Main(string[] args)
        {
            List<Diction> Dict = new List<Diction>();
            string s1;
            string s2;
            do
            {
                Console.WriteLine("Введите русское слово или 'exit' для выхода из режима добавления слов");
                s1 = Console.ReadLine();
                if (s1 == "exit") break;
                Console.WriteLine("Введите английское значение слова");
                s2 = Console.ReadLine();
                Dict.Add(new Diction(s1, s2));
            } while (s1 != "");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите русское слово для перевода");
            string s3 = Console.ReadLine();
            foreach (Diction dic in Dict)
            {
                Nahod(dic, s3);
            }
            Console.ReadKey();
        }


    }
}
