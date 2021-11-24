using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_SEM3
{
    class Squaer
    {
		private Dot[] listS = new Dot[4];
		public Squaer(int X, int Y)
		{
			for (int i = 0; i < 4; i++)
			{
				this.listS[i] = new Dot(X, Y);
			}
		}
		public Squaer setSquaer(Squaer T)
		{
			
			for (int i = 0; i < 4; i++)
			{
				T.listS[i].setDot(listS[i]);
			}
			return T;
		}
		public void getSquaer(Squaer T)
		{
			for (int i = 0; i < 4; i++)
			{
				T.listS[i].getDot(listS[i]);
			}
		}

	}
}
