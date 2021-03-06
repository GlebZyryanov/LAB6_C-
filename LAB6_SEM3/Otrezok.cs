using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_SEM3
{
    class Otrezok
    {
		 private Dot first;
		 private Dot second;

		public Otrezok()//конструктор без параметров
        {
			this.first = new Dot();
			this.second = new Dot();
        }
		public Otrezok(int Param)//конструктор с параметрами 
        {
			this.first = new Dot(Param);
			this.second = new Dot(Param);
        }
		public Otrezok(int X, int Y)
		{//конструктор отрезка

			this.first = new Dot(X, Y);
			this.second = new Dot(X, Y);
		}
		public Otrezok setOtrezok(Otrezok otrezok)
		{
			
			otrezok.first.setDot(first);
			otrezok.second.setDot(second);
			return otrezok;
		}
		public void getOtrezok(Otrezok O)//распечатка на экран
		{
			O.first.getDot(first);
			O.second.getDot(second);
		}

	}
}
