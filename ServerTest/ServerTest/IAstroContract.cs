using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace ServerTest
{
	[ServiceContract]
	public interface IAstroContract
	{
		[OperationContract]
		double CalculateStarVelocity(double observedWavelength, double restWavelength);

		[OperationContract]
		double CalculateStarDistance(double arcsecondsAngle);

		[OperationContract]
		double ConvertToKelvin(double celsiusTemperature);

		[OperationContract]
		double CalculateSchwarzschildRadius(double mass);
	}
}
