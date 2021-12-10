using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LAB6_SEM3
{
    class Program
    {
        static void Main(string[] args)
        {	///////свойства для полей
			ThePerson ThePerson = new ThePerson();
			ThePerson.set();
			ThePerson.printInfo();
			ThePerson.getFIO();

			Console.WriteLine("Set the coordinates of Dot:");
			Dot dot = new Dot(1, 10);
			dot.setDot(dot);
			Console.WriteLine("The coordinates of Dot is: ");
			dot.getDot(dot);
			//массив обьектов класса dot используется во всех классах кроме класса dot и класса Theperson
			Console.WriteLine("\nSet the coordinates of Otrezok:");
			Otrezok O = new Otrezok(0, 0);
			O.setOtrezok(O);
			Console.WriteLine("The coordinates of Otrezok is: ");
			O.getOtrezok(O);
			Console.WriteLine("\nSet the coordinates of Triangle:");
			Triangle T = new Triangle(0, 0);
			T.setTriangle(T);
			Console.WriteLine("The coordinates of Triangle is: ");
			T.getTriangle(T);
			Console.WriteLine("\nSet the coordinates of Squaer:");
			Squaer S = new Squaer(0, 0);
			S.setSquaer(S);
			Console.WriteLine("The coordinates of Squaer is: ");
			S.getSquaer(S);
			Console.WriteLine("\nSet the coordinates of Pentagon:");
			Pentagon P = new Pentagon(0, 0);
			P.setPentagon(P);
			Console.WriteLine("The coordinates of Pentagon is: ");
			P.getPentagon(P);
			Console.ReadLine();
			
		}
	}
}
