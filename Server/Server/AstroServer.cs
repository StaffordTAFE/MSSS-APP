using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

public class AstroServer : IAstroContract
{
	private AstroMath.AstroMath astroMath = new AstroMath.AstroMath();

	public double CalculateStarVelocity(double observedWavelength, double restWavelength)
	{
		return astroMath.StarVelocity(observedWavelength, restWavelength);
	}

	public double CalculateStarDistance(double arcsecondsAngle)
	{
		return astroMath.StarDistance(arcsecondsAngle);
	}

	public double ConvertToKelvin(double celsiusTemperature)
	{
		return astroMath.ConvertToKelvin(celsiusTemperature);
	}

	public double CalculateSchwarzschildRadius(double mass)
	{
		return astroMath.SchwarzschildRadius(mass);
	}
}
