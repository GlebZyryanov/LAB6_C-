using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_SEM3
{
    class Dot
    {
		private int CordX;
		private int CordY;
		private static int s_count=0;
		public static int s_counter()
        {
			return s_count;
        }

		public Dot(int initCordX, int initCordY)//this используется в классе dot
		{

			s_count++;
			this.CordX = initCordX;
			this.CordY = initCordY;

		}
		public Dot setDot(Dot point)
		{

			this.CordX = Convert.ToInt32(Console.ReadLine());

			this.CordY = Convert.ToInt32(Console.ReadLine());
			return point;
		}
		public void getDot(Dot point)
		{
			Console.WriteLine($"({this.CordX},{this.CordY})");
		}
		//перегрузка бинарного оператора +
		public static Dot operator+(Dot a, Dot b)
        {
            Dot result = new Dot(0,0);
		result.CordX = a.CordX + b.CordX;
        result.CordY = a.CordY + b.CordY;

		return result;
        }

		//перегрузка бинарного оператора ++
		public static Dot operator ++(Dot a)
		{
		Dot result = new Dot(0,0);
		result.CordX = a.CordX++;
		result.CordY = a.CordY++;
		

		return result;
		}


}
}
