using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB6_SEM3
{
    class Pentagon
    {
		private Dot[] listP = new Dot[5];
		public Pentagon(int X, int Y)
		{
			for (int i = 0; i < 5; i++)
			{
				this.listP[i] = new Dot(X, Y);
			}
		}
		public Pentagon setPentagon(Pentagon T)
        {
			for (int i = 0; i < 5; i++)
			{
				T.listP[i].setDot(listP[i]);
			}
			return T;
		}
		public void getPentagon(Pentagon T)
		{
			for (int i = 0; i < 5; i++)
			{
				T.listP[i].getDot(listP[i]);
			}
		}

	}
}
