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
        {   ///////свойства для полей
			
			Console.WriteLine("1 - DEMO STRING\n2 - main prog\n3-ref and out func\n4 - Работа со статическими методами и полями\n5-Вызов всех конструкторов\n");
			int flag = Convert.ToInt32(Console.ReadLine());
			if (flag == 1)
			{
				ThePerson ThePerson = new ThePerson();
				ThePerson.set();
				ThePerson.printInfo();
				ThePerson.getFIO();
				Console.ReadLine();
			}
			if (flag == 2)
			{
				Console.WriteLine("Set the coordinates of Dot:");
				Dot dot = new Dot(0, 0);
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
			if(flag == 3)
            {
				void demoRef(ref int n)//ref передача параметрво по ссылке
				{
					n++;
				}
				void demoOut(int n,out int res)//out передача выходных параметров 
                {
					n++;
					res = n;
                }
				int numb = 0;
				demoRef(ref numb);
				Console.WriteLine($"Число после метода с ref: {numb}");
				demoOut(numb, out numb);
				Console.WriteLine($"Число после метода с out: {numb}");
				Console.ReadLine();
			}
			if (flag == 4)
			{//демонстрация работы со статическими методами и полями
				int numberofmethoddot = Dot.s_counter();
				Console.WriteLine($"Количество вызовов метода initDot: { numberofmethoddot}");
				Console.ReadLine();
			}
			if(flag == 5)
            {
				//Демонстрация работы конструкторов
				Dot dot;
				dot = new Dot();
				dot.getDot(dot);
				dot = new Dot(99);
				dot.getDot(dot);
				dot = new Dot(1,1);
				dot.getDot(dot);
				Otrezok  o;
				o = new Otrezok();
				o.getOtrezok(o);
				o = new Otrezok(99);
				o.getOtrezok(o);
				o = new Otrezok(1,1);
				o.getOtrezok(o);
				
				Triangle T;
				T = new Triangle();
				T.getTriangle(T);
				T = new Triangle(9);
				T.getTriangle(T);
				T = new Triangle(1,1);
				T.getTriangle(T);

				Squaer S;
				S = new Squaer();
				S.getSquaer(S);
				S = new Squaer(99);
				S.getSquaer(S);
				S = new Squaer(1,1);
				S.getSquaer(S);

				Pentagon P;
				P = new Pentagon();
				P.getPentagon(P);
				P = new Pentagon(99);
				P.getPentagon(P);
				P = new Pentagon(1, 1);
				P.getPentagon(P);
			}
		}
	}
}
