using MSSS_Astronomical_Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSS_APP_Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		IAstroContract pipeProxy;
		protected override void OnLoad(EventArgs e)
		{
			Process.Start("Server.exe");

			Console.WriteLine("Client Started");
			ChannelFactory<IAstroContract> pipeFactory =
			new ChannelFactory<IAstroContract>(
			new NetNamedPipeBinding(),
			new EndpointAddress("net.pipe://localhost/AstroService"));
			pipeProxy = pipeFactory.CreateChannel();
		}

		private void calcStarVelocity_Click(object sender, EventArgs e)
		{
			ListViewItem lvi = new ListViewItem();

			lvi.Text = pipeProxy.CalculateStarVelocity(int.Parse(observedWavelength.Text), int.Parse(restWavelength.Text)).ToString();

			starVelocityResults.Items.Add(lvi);
		}
	}
}
