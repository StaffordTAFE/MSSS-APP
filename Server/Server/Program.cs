using System;
using System.ServiceModel;

class Program
{
	static void Main(string[] args)
	{
		// Create a ServiceHost for the AstroServer
		using (ServiceHost host = new ServiceHost(typeof(AstroServer)))
		{
			// Define the binding
			NetNamedPipeBinding binding = new NetNamedPipeBinding();

			// Add an endpoint
			host.AddServiceEndpoint(typeof(IAstroContract), binding, "net.pipe://localhost/AstroService");


			// open the service host
			host.Open();

			Console.WriteLine("The AstroService is running...");
			Console.WriteLine("Press any key to stop the service.");
			Console.ReadLine();

			// Close the service host
			host.Close();
		}
	}
}
