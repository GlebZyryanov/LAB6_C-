using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_SEM3
{
    class ThePerson
    {
        private String name;
        private String patronymic;
        private String surname;
        private int age;

        public string Name
        {
            set
            {
                if (Name.Length == 0)
                {
                    Console.WriteLine("ThidFieldMustBeFillIN!");
                }
                else name = Name;
            }
            get
            {
                return name;
            }
        }
        public string Patronymic
        {
            set
            {
                if (Patronymic.Length == 0)
                {
                    Console.WriteLine("ThidFieldMustBeFillIN!");
                }
                else patronymic = Patronymic;
            }
            get
            {
                return patronymic;
            }
        }
        public string Surname
        {
            set
            {
                if (Surname.Length == 0)
                {
                    Console.WriteLine("ThidFieldMustBeFillIN!");
                }
                else surname = Surname;
            }
            get
            {
                return surname;
            }
        }

        public int Age
        {
            set
            {
                if (Age <= 0)
                {
                    Console.WriteLine("Check out age!");
                }
                else age = Age;
            }
            get
            {
                return age;
            }
        }

        public ThePerson()
        {
            name = "Unknown";
            patronymic = "Unknown";
            surname = "Unknown";
            age = 0;
        }

        public ThePerson(String name, String patronymic, String surname, int age)
        {
            this.name = name;
            this.patronymic = patronymic;
            this.surname = surname;
            this.age = age;
        }

        public void set()
        {

            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter enter otchestvo: ");
            patronymic = Console.ReadLine();
            Console.Write("Enter syrmane: ");
            surname = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());

        }

        public void printInfo()
        {
            String s_age = Convert.ToString(age);//переводчиславстроку
            String info = name + " " + patronymic + " " + surname + " " + s_age; //строкасфио
            int len = info.Length - 3;//кол-во символов (-3 пробела)
            int res1, res2, res3;

            Console.WriteLine("person: " + info);
            Console.WriteLine("quantity of symbols: " + len);

            res1 = name.CompareTo(patronymic);//сравнениестрок
            res2 = name.CompareTo(surname);
            res3 = surname.CompareTo(patronymic);

            if (res1 == 0 || res2 == 0 || res3 == 0)
            {
                Console.WriteLine("equel string");
            }
            else Console.WriteLine("no equel string");


        }


        public void getFIO()
        {

            char[] fio = new char[3];
            fio[0] = surname[0];
            fio[1] = patronymic[0];
            fio[2] = name[0];

            Console.WriteLine("fio: " + fio[0] + fio[1] + fio[2]);

        }

    }

}
