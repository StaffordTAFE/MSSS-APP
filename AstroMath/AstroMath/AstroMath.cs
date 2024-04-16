using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
	internal class AstroMath
	{
		const int c = 299792458; // Speed of light
		const double g = 6.674e-11; // Gravitational constant
		const double mSol = 1.989e30; // Solar mass in kilograms

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

		public double SchwarzschildRadius(double solarMasses)
		{
			double massKilograms = (solarMasses * mSol); // convernt from solar mass to kg

			return (2 * g * massKilograms) / Math.Pow(c, 2);
		}
	}
}
