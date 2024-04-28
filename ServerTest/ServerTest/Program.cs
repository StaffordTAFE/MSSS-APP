using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Process.Start("Server.exe");

			Thread.Sleep(3000); // Pause code execution for three seconds to allow server time to start

			Console.WriteLine("Client Started");

			ChannelFactory<IAstroContract> pipeFactory =
			new ChannelFactory<IAstroContract>(
			new NetNamedPipeBinding(),
			new EndpointAddress("net.pipe://localhost/AstroService"));
			var pipeProxy = pipeFactory.CreateChannel();


			var starVelocity = pipeProxy.CalculateStarVelocity(500.1, 500.0);
			Console.WriteLine("Star Velocity: Input Observed 500.1nm; Rest 500.0nm. Output 60000 m/s");
			Console.WriteLine("Calculated test result: " + starVelocity);
			Console.WriteLine("Error:" + (((starVelocity - 60000) / 60000) * 100) + "%");
			Console.WriteLine("");

			var starDistance = pipeProxy.CalculateStarDistance(0.547);
			Console.WriteLine("Star Distance: Input Parallax Angle 0.547 arcseconds. Output 1.83 parsecs");
			Console.WriteLine("Calculated test result: " + starDistance);
			Console.WriteLine("Error:" + (((starDistance - 1.83) / 1.83) * 100) + "%");
			Console.WriteLine("");

			var temperatureKelvin = pipeProxy.ConvertToKelvin(27);
			Console.WriteLine("Temperature Conversion: Input Celsius 27°C. Output 300 K");
			Console.WriteLine("Calculated test result: " + temperatureKelvin);
			Console.WriteLine("Error:" + (((temperatureKelvin - 300) / 300) * 100) + "%");
			Console.WriteLine("");

			var eventHorizonSize = pipeProxy.CalculateSchwarzschildRadius(8.2e36);
			Console.WriteLine("Event Horizon: Input Mass 8.2 x 10^36 kg. Output 1.2 x 10^10 meters");
			Console.WriteLine("Calculated test result: " + eventHorizonSize);
			Console.WriteLine("Error:" + (((eventHorizonSize - 1.2e10) / 1.2e10) * 100) + "%");
			Console.WriteLine("");

			Console.WriteLine("Press Enter to close");
			Console.ReadLine();
		}
	}
}
