namespace MSSS_APP_Client
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.starVelocityResults = new System.Windows.Forms.ListView();
			this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label3 = new System.Windows.Forms.Label();
			this.calcStarVelocity = new System.Windows.Forms.Button();
			this.restWavelength = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.observedWavelength = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.starDistanceResults = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label4 = new System.Windows.Forms.Label();
			this.calcStarDistance = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.arcsecondsAngle = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.celsiusToKelvinResults = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label7 = new System.Windows.Forms.Label();
			this.convertToKelvin = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.celsiusTemperature = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.schwarzchildRadiusResults = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label10 = new System.Windows.Forms.Label();
			this.calcSchwarzschildRadius = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.blackHoleMass = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customBackgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.Controls.Add(this.groupBox3);
			this.flowLayoutPanel1.Controls.Add(this.groupBox4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.starVelocityResults);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.calcStarVelocity);
			this.groupBox1.Controls.Add(this.restWavelength);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.observedWavelength);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// starVelocityResults
			// 
			resources.ApplyResources(this.starVelocityResults, "starVelocityResults");
			this.starVelocityResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Result});
			this.starVelocityResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.starVelocityResults.HideSelection = false;
			this.starVelocityResults.Name = "starVelocityResults";
			this.starVelocityResults.UseCompatibleStateImageBehavior = false;
			this.starVelocityResults.View = System.Windows.Forms.View.Details;
			// 
			// Time
			// 
			resources.ApplyResources(this.Time, "Time");
			// 
			// Result
			// 
			resources.ApplyResources(this.Result, "Result");
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// calcStarVelocity
			// 
			resources.ApplyResources(this.calcStarVelocity, "calcStarVelocity");
			this.calcStarVelocity.BackColor = System.Drawing.SystemColors.Control;
			this.calcStarVelocity.Name = "calcStarVelocity";
			this.calcStarVelocity.UseVisualStyleBackColor = false;
			this.calcStarVelocity.Click += new System.EventHandler(this.calcStarVelocity_Click);
			// 
			// restWavelength
			// 
			resources.ApplyResources(this.restWavelength, "restWavelength");
			this.restWavelength.BackColor = System.Drawing.SystemColors.Window;
			this.restWavelength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.restWavelength.Name = "restWavelength";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// observedWavelength
			// 
			resources.ApplyResources(this.observedWavelength, "observedWavelength");
			this.observedWavelength.BackColor = System.Drawing.SystemColors.Window;
			this.observedWavelength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.observedWavelength.Name = "observedWavelength";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this.starDistanceResults);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.calcStarDistance);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.arcsecondsAngle);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// starDistanceResults
			// 
			resources.ApplyResources(this.starDistanceResults, "starDistanceResults");
			this.starDistanceResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.starDistanceResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.starDistanceResults.HideSelection = false;
			this.starDistanceResults.Name = "starDistanceResults";
			this.starDistanceResults.UseCompatibleStateImageBehavior = false;
			this.starDistanceResults.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			resources.ApplyResources(this.columnHeader1, "columnHeader1");
			// 
			// columnHeader2
			// 
			resources.ApplyResources(this.columnHeader2, "columnHeader2");
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// calcStarDistance
			// 
			resources.ApplyResources(this.calcStarDistance, "calcStarDistance");
			this.calcStarDistance.BackColor = System.Drawing.SystemColors.Control;
			this.calcStarDistance.Name = "calcStarDistance";
			this.calcStarDistance.UseVisualStyleBackColor = false;
			this.calcStarDistance.Click += new System.EventHandler(this.calcStarDistance_Click);
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// arcsecondsAngle
			// 
			resources.ApplyResources(this.arcsecondsAngle, "arcsecondsAngle");
			this.arcsecondsAngle.BackColor = System.Drawing.SystemColors.Window;
			this.arcsecondsAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.arcsecondsAngle.Name = "arcsecondsAngle";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// groupBox3
			// 
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.Controls.Add(this.celsiusToKelvinResults);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.convertToKelvin);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.celsiusTemperature);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// celsiusToKelvinResults
			// 
			resources.ApplyResources(this.celsiusToKelvinResults, "celsiusToKelvinResults");
			this.celsiusToKelvinResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.celsiusToKelvinResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.celsiusToKelvinResults.HideSelection = false;
			this.celsiusToKelvinResults.Name = "celsiusToKelvinResults";
			this.celsiusToKelvinResults.UseCompatibleStateImageBehavior = false;
			this.celsiusToKelvinResults.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			resources.ApplyResources(this.columnHeader3, "columnHeader3");
			// 
			// columnHeader4
			// 
			resources.ApplyResources(this.columnHeader4, "columnHeader4");
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// convertToKelvin
			// 
			resources.ApplyResources(this.convertToKelvin, "convertToKelvin");
			this.convertToKelvin.BackColor = System.Drawing.SystemColors.Control;
			this.convertToKelvin.Name = "convertToKelvin";
			this.convertToKelvin.UseVisualStyleBackColor = false;
			this.convertToKelvin.Click += new System.EventHandler(this.convertToKelvin_Click);
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// celsiusTemperature
			// 
			resources.ApplyResources(this.celsiusTemperature, "celsiusTemperature");
			this.celsiusTemperature.BackColor = System.Drawing.SystemColors.Window;
			this.celsiusTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.celsiusTemperature.Name = "celsiusTemperature";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// groupBox4
			// 
			resources.ApplyResources(this.groupBox4, "groupBox4");
			this.groupBox4.Controls.Add(this.schwarzchildRadiusResults);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.calcSchwarzschildRadius);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.blackHoleMass);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			// 
			// schwarzchildRadiusResults
			// 
			resources.ApplyResources(this.schwarzchildRadiusResults, "schwarzchildRadiusResults");
			this.schwarzchildRadiusResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
			this.schwarzchildRadiusResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.schwarzchildRadiusResults.HideSelection = false;
			this.schwarzchildRadiusResults.Name = "schwarzchildRadiusResults";
			this.schwarzchildRadiusResults.UseCompatibleStateImageBehavior = false;
			this.schwarzchildRadiusResults.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			resources.ApplyResources(this.columnHeader5, "columnHeader5");
			// 
			// columnHeader6
			// 
			resources.ApplyResources(this.columnHeader6, "columnHeader6");
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			// 
			// calcSchwarzschildRadius
			// 
			resources.ApplyResources(this.calcSchwarzschildRadius, "calcSchwarzschildRadius");
			this.calcSchwarzschildRadius.BackColor = System.Drawing.SystemColors.Control;
			this.calcSchwarzschildRadius.Name = "calcSchwarzschildRadius";
			this.calcSchwarzschildRadius.UseVisualStyleBackColor = false;
			this.calcSchwarzschildRadius.Click += new System.EventHandler(this.calcSchwarzschildRadius_Click);
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// blackHoleMass
			// 
			resources.ApplyResources(this.blackHoleMass, "blackHoleMass");
			this.blackHoleMass.BackColor = System.Drawing.SystemColors.Window;
			this.blackHoleMass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.blackHoleMass.Name = "blackHoleMass";
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// toolStrip1
			// 
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
			this.toolStrip1.Name = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
			this.toolStripLabel1.Name = "toolStripLabel1";
			// 
			// toolStripSeparator1
			// 
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			// 
			// toolStripDropDownButton1
			// 
			resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appearanceToolStripMenuItem,
            this.languageToolStripMenuItem});
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			// 
			// appearanceToolStripMenuItem
			// 
			resources.ApplyResources(this.appearanceToolStripMenuItem, "appearanceToolStripMenuItem");
			this.appearanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.lightModeToolStripMenuItem,
            this.customBackgroundColourToolStripMenuItem,
            this.fontSettingsToolStripMenuItem});
			this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
			// 
			// darkModeToolStripMenuItem
			// 
			resources.ApplyResources(this.darkModeToolStripMenuItem, "darkModeToolStripMenuItem");
			this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
			this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
			// 
			// lightModeToolStripMenuItem
			// 
			resources.ApplyResources(this.lightModeToolStripMenuItem, "lightModeToolStripMenuItem");
			this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
			this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
			// 
			// customBackgroundColourToolStripMenuItem
			// 
			resources.ApplyResources(this.customBackgroundColourToolStripMenuItem, "customBackgroundColourToolStripMenuItem");
			this.customBackgroundColourToolStripMenuItem.Name = "customBackgroundColourToolStripMenuItem";
			this.customBackgroundColourToolStripMenuItem.Click += new System.EventHandler(this.customBackgroundColourToolStripMenuItem_Click);
			// 
			// fontSettingsToolStripMenuItem
			// 
			resources.ApplyResources(this.fontSettingsToolStripMenuItem, "fontSettingsToolStripMenuItem");
			this.fontSettingsToolStripMenuItem.Name = "fontSettingsToolStripMenuItem";
			this.fontSettingsToolStripMenuItem.Click += new System.EventHandler(this.fontSettingsToolStripMenuItem_Click);
			// 
			// languageToolStripMenuItem
			// 
			resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			// 
			// englishToolStripMenuItem
			// 
			resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			// 
			// frenchToolStripMenuItem
			// 
			resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
			this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
			// 
			// germanToolStripMenuItem
			// 
			resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
			this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox observedWavelength;
		private System.Windows.Forms.TextBox restWavelength;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button calcStarVelocity;
		private System.Windows.Forms.ListView starVelocityResults;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button calcStarDistance;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox arcsecondsAngle;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button convertToKelvin;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox celsiusTemperature;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button calcSchwarzschildRadius;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox blackHoleMass;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ColumnHeader Time;
		private System.Windows.Forms.ColumnHeader Result;
		private System.Windows.Forms.ListView starDistanceResults;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ListView celsiusToKelvinResults;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ListView schwarzchildRadiusResults;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ToolStripMenuItem appearanceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customBackgroundColourToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
	}
}

