using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_22_Predavanje
{
     abstract class GeometrijskiLik
    {
		protected int visina;

		public int Visina
		{
			get { return visina; }
			set 
			{ 
				visina = value;
				RacunajPovrsinu();
			}
		}

		protected int sirina;

		public int Sirina
		{
			get { return sirina; }
			set { 

				sirina = value;
				RacunajPovrsinu();
			}
		}

		protected double povrsina;

		public double Povrsina
		{
			get { return povrsina; }
			
		}

		public GeometrijskiLik(int v, int s)
		{
			Visina = v;
			Sirina = s;
		}

		public abstract void RacunajPovrsinu();
	}
	class Pravokutnik : GeometrijskiLik
	{
		public Pravokutnik(int v, int s) :base(v, s)
		{
		}
		public override void RacunajPovrsinu()
		{
			 povrsina = Visina * Sirina;
		}
	}

	class Kvadrat : Pravokutnik
	{
		public Kvadrat(int v, int s) : base(v, v)
		{
		}
        public Kvadrat(int v) :base(v, v)
        {
        }
		new public int Visina
		{
			get { return visina;  }
			set
			{
				visina = value;
				sirina = visina;
				RacunajPovrsinu();
			}
		}
		new public int Sirina
		{
			get { return sirina; }
			set 
			{
				sirina = value;
				visina = sirina;
				RacunajPovrsinu();
			}

		}
		
	}
	class Trokut : GeometrijskiLik
	{
		public Trokut(int v, int s) :base(v, s)
		{
		}
		public override void RacunajPovrsinu()
		{
			 povrsina = Sirina * Visina / 2;
		}
	}
}
