using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

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
