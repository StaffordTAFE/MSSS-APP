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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

			results.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		#endregion

		#region Calculation Events
		private void calculate_Click(object sender, EventArgs e)
		{
			if ((string.IsNullOrEmpty(observedWavelength.Text) || string.IsNullOrEmpty(restWavelength.Text)) &&
				string.IsNullOrEmpty(arcsecondsAngle.Text) &&
				(string.IsNullOrEmpty(celsiusTemperature.Text) || celsiusTemperature.Text == "-") &&
				(string.IsNullOrEmpty(blackHoleMassA.Text) || string.IsNullOrEmpty(blackHoleMassB.Text))
				)
			{
				return;
			}

			string time = DateTime.Now.ToString("HH:mm:ss"); ;
			string velocity;
			string distance;
			string temperature;
			string radius;

			if (!string.IsNullOrEmpty(observedWavelength.Text) && !string.IsNullOrEmpty(restWavelength.Text))
			{
				double velocityValue = pipeProxy.CalculateStarVelocity(double.Parse(observedWavelength.Text), double.Parse(restWavelength.Text));
				velocity = velocityValue.ToString("0.###E+0") + " m/s";
			}
			else
			{
				velocity = string.Empty;
			}

			if (!string.IsNullOrEmpty(arcsecondsAngle.Text))
			{
				double distanceValue = pipeProxy.CalculateStarDistance(double.Parse(arcsecondsAngle.Text));
				distance = distanceValue.ToString("0.###E+0") + " pc";
			}
			else
			{
				distance = string.Empty;
			}

			if (!string.IsNullOrEmpty(celsiusTemperature.Text) && celsiusTemperature.Text != "-")
			{
				double temperatureValue = pipeProxy.ConvertToKelvin(double.Parse(celsiusTemperature.Text));
				temperature = temperatureValue.ToString("0.###E+0") + " K";
			}
			else
			{
				temperature = string.Empty;
			}

			if (!string.IsNullOrEmpty(blackHoleMassA.Text) && !string.IsNullOrEmpty(blackHoleMassB.Text))
			{
				double blackHoleMass = double.Parse(blackHoleMassA.Text + "e" + blackHoleMassB.Text);
				double radiusValue = pipeProxy.CalculateSchwarzschildRadius(blackHoleMass);
				radius = radiusValue.ToString("0.###E+0") + " m";
			}
			else
			{
				radius = string.Empty;
			}

			ListViewItem lvi = new ListViewItem(new[] { time, velocity, distance, temperature, radius });
			results.Items.Add(lvi);
			results.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			results.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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


		private void observedWavelength_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void restWavelength_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void arcsecondsAngle_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void celsiusTemperature_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '-') && ((sender as System.Windows.Forms.TextBox).SelectionStart != 0))
			{
				e.Handled = true;
			}
		}

		private void blackHoleMassA_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void blackHoleMassB_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
