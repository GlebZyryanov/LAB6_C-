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
			
			//с помощью метода try и catch при передаче не числа будет срабатывать исключение
			try
            {
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
				if (flag == 3)
				{
					void demoRef(ref int n)//ref передача параметрво по ссылке
					{
						n++;
					}
					void demoOut(int n, out int res)//out передача выходных параметров 
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
				if (flag == 5)
				{
					//Демонстрация работы конструкторов
					Dot dot;
					dot = new Dot();
					//c помощью trow выдаем исключение если обьект передающийся методу - пустой
					if (dot == null)
                    {
						throw new ArgumentNullException($"{nameof(dot)}");
					}
					dot.getDot(dot);
					dot = new Dot(99);
					if (dot == null)
					{
						throw new ArgumentNullException($"{nameof(dot)}");
					}
					dot.getDot(dot);
					if (dot == null)
					{
						throw new ArgumentNullException($"{nameof(dot)}");
					}
					dot = new Dot(1, 1);
					dot.getDot(dot);
					Otrezok o;
				
					o = new Otrezok();
					if (o == null)
					{
						throw new ArgumentNullException($"{nameof(o)}");
					}
					o.getOtrezok(o);
					o = new Otrezok(99);
					if (o == null)
					{
						throw new ArgumentNullException($"{nameof(o)}");
					}
					o.getOtrezok(o);
					o = new Otrezok(1, 1);
					if (o == null)
					{
						throw new ArgumentNullException($"{nameof(o)}");
					}
					o.getOtrezok(o);

					Triangle T;
					T = new Triangle();
					if (T == null)
					{
						throw new ArgumentNullException($"{nameof(T)}");
					}
					T.getTriangle(T);
					T = new Triangle(9);
					if (T == null)
					{
						throw new ArgumentNullException($"{nameof(T)}");
					}
					T.getTriangle(T);
					T = new Triangle(1, 1);
					if (T == null)
					{
						throw new ArgumentNullException($"{nameof(T)}");
					}
					T.getTriangle(T);

					Squaer S;
					S = new Squaer();
					if (T == null)
					{
						throw new ArgumentNullException($"{nameof(T)}");
					}
					S.getSquaer(S);
					S = new Squaer(99);
					if (T == null)
					{
						throw new ArgumentNullException($"{nameof(T)}");
					}
					S.getSquaer(S);
					S = new Squaer(1, 1);
					if (T == null)
					{
						throw new ArgumentNullException($"{nameof(T)}");
					}
					S.getSquaer(S);

					Pentagon P;
					P = new Pentagon();
					if (P == null)
					{
						throw new ArgumentNullException($"{nameof(P)}");
					}
					P.getPentagon(P);
					P = new Pentagon(99);
					if (P == null)
					{
						throw new ArgumentNullException($"{nameof(P)}");
					}
					P.getPentagon(P);
					P = new Pentagon(1, 1);
					if (P == null)
					{
						throw new ArgumentNullException($"{nameof(P)}");
					}
					P.getPentagon(P);
					Console.ReadLine();
				}
            }
            catch(FormatException e)
            {
				Console.WriteLine($"{e.Message} Введите число.");
				Console.ReadLine();
			}

		}
	}
}
