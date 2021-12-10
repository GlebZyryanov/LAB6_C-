using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_SEM3
{
    struct Dot
    {/// <summary>
	 /// отличие структур и классов: структуры, указываемые в списке параметров метода, передаются по значению 
	 /// (то есть копируются), объекты классов — по ссылке.
	 /// </summary>
		int CordX;
		 int CordY;


		public Dot(int initCordX, int initCordY)
		{


			CordX = initCordX;
			CordY = initCordY;

		}
		public Dot setDot(Dot point)
		{

			point.CordX = Convert.ToInt32(Console.ReadLine());

			point.CordY = Convert.ToInt32(Console.ReadLine());
			return point;
		}
		public void getDot(Dot point)
		{
			Console.WriteLine($"({point.CordX},{point.CordY})");
		}

	}
}
