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
using System.Threading;
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

		#region Connection
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
		#endregion

		#region Calculation Events
		private void calcStarVelocity_Click(object sender, EventArgs e)
		{
			if (double.TryParse(observedWavelength.Text, out double observedWavelengthValue) &&
				double.TryParse(restWavelength.Text, out double restWavelengthValue))
			{
				double starVelocity = pipeProxy.CalculateStarVelocity(observedWavelengthValue, restWavelengthValue);

				ListViewItem lvi = new ListViewItem();
				lvi.Text = DateTime.Now.ToString("HH:mm:ss");
				lvi.SubItems.Add(starVelocity.ToString("0.000E+0"));

				starVelocityResults.Items.Add(lvi);
			}
			else
			{
				MessageBox.Show("Invalid input for observed wavelength or rest wavelength. Input must be of type double or valid scientific notation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void calcStarDistance_Click(object sender, EventArgs e)
		{
			if (double.TryParse(arcsecondsAngle.Text, out double arcsecondsAngleValue))
			{
				double starDistance = pipeProxy.CalculateStarDistance(arcsecondsAngleValue);

				ListViewItem lvi = new ListViewItem();
				lvi.Text = DateTime.Now.ToString("HH:mm:ss");
				lvi.SubItems.Add(starDistance.ToString("0.000E+0"));
				starDistanceResults.Items.Insert(0, lvi);
			}
			else
			{
				MessageBox.Show("Invalid input for arcseconds angle. Input must be of type double or valid scientific notation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void convertToKelvin_Click(object sender, EventArgs e)
		{
			if (double.TryParse(celsiusTemperature.Text, out double celsiusTemperatureValue))
			{
				double kelvinTemperature = pipeProxy.ConvertToKelvin(celsiusTemperatureValue);

				ListViewItem lvi = new ListViewItem();
				lvi.Text = DateTime.Now.ToString("HH:mm:ss");
				lvi.SubItems.Add(kelvinTemperature.ToString("0.000E+0"));
				celsiusToKelvinResults.Items.Insert(0, lvi);
			}
			else
			{
				MessageBox.Show("Invalid input for Celsius temperature. Input must be of type double or valid scientific notation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void calcSchwarzschildRadius_Click(object sender, EventArgs e)
		{
			if (double.TryParse(blackHoleMass.Text, out double blackHoleMassValue))
			{
				double schwarzschildRadius = pipeProxy.CalculateSchwarzschildRadius(blackHoleMassValue);

				ListViewItem lvi = new ListViewItem();
				lvi.Text = DateTime.Now.ToString("HH:mm:ss");
				lvi.SubItems.Add(schwarzschildRadius.ToString("0.000E+0"));
				schwarzchildRadiusResults.Items.Insert(0, lvi);
			}
			else
			{
				MessageBox.Show("Invalid input for black hole mass. Input must be of type double or valid scientific notation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Appearance
		private void customBackgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();

			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				this.BackColor = colorDialog.Color;
				flowLayoutPanel1.BackColor = colorDialog.Color;
			}
		}

		private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			darkMode(this);
		}

		private void darkMode(Control control)
		{
			Color darkDarkBackground = SystemColors.ControlDarkDark;
			Color darkBackground = SystemColors.ControlDark;
			Color lightForeground = SystemColors.ControlLightLight;

			if (control is GroupBox || control is Label)
			{
				control.BackColor = darkDarkBackground;
				control.ForeColor = lightForeground;
			}
			else
			{
				control.BackColor = darkBackground;
				control.ForeColor = lightForeground;
			}

			foreach (Control childControl in control.Controls)
			{
				darkMode(childControl);
			}
		}

		private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lightMode(this);
		}

		private void lightMode(Control control)
		{
			control.BackColor = SystemColors.Window;
			control.ForeColor = SystemColors.ControlText;

			if (control.HasChildren)
			{
				foreach (Control childControl in control.Controls)
				{
					lightMode(childControl);
				}
			}
		}

		private void fontSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				fontSettings(this, dialog.Font);
			}
		}

		private void fontSettings(Control control, Font font)
		{
			control.Font = font;

			foreach (Control childControl in control.Controls)
			{
				fontSettings(childControl, font);
			}
		}
		#endregion

		#region Language
		private void englishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
			Controls.Clear();
			InitializeComponent();

		}

		private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
			Controls.Clear();
			InitializeComponent();

		}

		private void germanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");
			Controls.Clear();
			InitializeComponent();
		}
		#endregion
	}
}
