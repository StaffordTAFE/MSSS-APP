using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
	public class AstroMath
	{
		const int c = 299792458; // Speed of light
		const double g = 6.674e-11; // Gravitational constant

		public double StarVelocity(double observedWavelength, double restWavelength)
		{
			return c * ((observedWavelength - restWavelength) / restWavelength);
		}

		public double StarDistance(double arcsecondsAngle)
		{
			return 1 / arcsecondsAngle;
		}

		public double ConvertToKelvin(double celsius)
		{
			return celsius + 273;
		}

		public double SchwarzschildRadius(double mass)
		{
			
			return (2 * g * mass) / Math.Pow(c, 2);
		}
	}
}
