﻿namespace MSSS_APP_Client
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
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.Controls.Add(this.groupBox3);
			this.flowLayoutPanel1.Controls.Add(this.groupBox4);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 37);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1166, 694);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.starVelocityResults);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.calcStarVelocity);
			this.groupBox1.Controls.Add(this.restWavelength);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.observedWavelength);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 688);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Star Velocity";
			// 
			// starVelocityResults
			// 
			this.starVelocityResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Result});
			this.starVelocityResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.starVelocityResults.HideSelection = false;
			this.starVelocityResults.Location = new System.Drawing.Point(9, 185);
			this.starVelocityResults.Name = "starVelocityResults";
			this.starVelocityResults.Size = new System.Drawing.Size(266, 496);
			this.starVelocityResults.TabIndex = 6;
			this.starVelocityResults.UseCompatibleStateImageBehavior = false;
			this.starVelocityResults.View = System.Windows.Forms.View.Details;
			// 
			// Time
			// 
			this.Time.Text = "Time";
			this.Time.Width = 82;
			// 
			// Result
			// 
			this.Result.Text = "Result";
			this.Result.Width = 91;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(267, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Calculation Results (Metres/Second)";
			// 
			// calcStarVelocity
			// 
			this.calcStarVelocity.BackColor = System.Drawing.SystemColors.Control;
			this.calcStarVelocity.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calcStarVelocity.Location = new System.Drawing.Point(9, 129);
			this.calcStarVelocity.Name = "calcStarVelocity";
			this.calcStarVelocity.Size = new System.Drawing.Size(268, 31);
			this.calcStarVelocity.TabIndex = 4;
			this.calcStarVelocity.Text = "Calculate";
			this.calcStarVelocity.UseVisualStyleBackColor = false;
			this.calcStarVelocity.Click += new System.EventHandler(this.calcStarVelocity_Click);
			// 
			// restWavelength
			// 
			this.restWavelength.BackColor = System.Drawing.SystemColors.Window;
			this.restWavelength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.restWavelength.Location = new System.Drawing.Point(9, 97);
			this.restWavelength.Name = "restWavelength";
			this.restWavelength.Size = new System.Drawing.Size(268, 26);
			this.restWavelength.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Rest Wavelength (Nanometres)";
			// 
			// observedWavelength
			// 
			this.observedWavelength.BackColor = System.Drawing.SystemColors.Window;
			this.observedWavelength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.observedWavelength.Location = new System.Drawing.Point(9, 45);
			this.observedWavelength.Name = "observedWavelength";
			this.observedWavelength.Size = new System.Drawing.Size(268, 26);
			this.observedWavelength.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Observed Wavelength (Nanometres)";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.starDistanceResults);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.calcStarDistance);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.arcsecondsAngle);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(293, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(284, 688);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Star Distance";
			// 
			// starDistanceResults
			// 
			this.starDistanceResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.starDistanceResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.starDistanceResults.HideSelection = false;
			this.starDistanceResults.Location = new System.Drawing.Point(9, 134);
			this.starDistanceResults.Name = "starDistanceResults";
			this.starDistanceResults.Size = new System.Drawing.Size(268, 547);
			this.starDistanceResults.TabIndex = 7;
			this.starDistanceResults.UseCompatibleStateImageBehavior = false;
			this.starDistanceResults.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Time";
			this.columnHeader1.Width = 82;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Result";
			this.columnHeader2.Width = 91;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Calculation Results (Parsecs)";
			// 
			// calcStarDistance
			// 
			this.calcStarDistance.BackColor = System.Drawing.SystemColors.Control;
			this.calcStarDistance.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calcStarDistance.Location = new System.Drawing.Point(9, 77);
			this.calcStarDistance.Name = "calcStarDistance";
			this.calcStarDistance.Size = new System.Drawing.Size(268, 31);
			this.calcStarDistance.TabIndex = 4;
			this.calcStarDistance.Text = "Calculate";
			this.calcStarDistance.UseVisualStyleBackColor = false;
			this.calcStarDistance.Click += new System.EventHandler(this.calcStarDistance_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 20);
			this.label5.TabIndex = 2;
			// 
			// arcsecondsAngle
			// 
			this.arcsecondsAngle.BackColor = System.Drawing.SystemColors.Window;
			this.arcsecondsAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.arcsecondsAngle.Location = new System.Drawing.Point(9, 45);
			this.arcsecondsAngle.Name = "arcsecondsAngle";
			this.arcsecondsAngle.Size = new System.Drawing.Size(268, 26);
			this.arcsecondsAngle.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(236, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Arcseconds Angle (Arcseconds)";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.celsiusToKelvinResults);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.convertToKelvin);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.celsiusTemperature);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Location = new System.Drawing.Point(583, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(284, 688);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Celsius to Kelvin";
			// 
			// celsiusToKelvinResults
			// 
			this.celsiusToKelvinResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.celsiusToKelvinResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.celsiusToKelvinResults.HideSelection = false;
			this.celsiusToKelvinResults.Location = new System.Drawing.Point(9, 134);
			this.celsiusToKelvinResults.Name = "celsiusToKelvinResults";
			this.celsiusToKelvinResults.Size = new System.Drawing.Size(268, 547);
			this.celsiusToKelvinResults.TabIndex = 8;
			this.celsiusToKelvinResults.UseCompatibleStateImageBehavior = false;
			this.celsiusToKelvinResults.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Time";
			this.columnHeader3.Width = 82;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Result";
			this.columnHeader4.Width = 91;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 111);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(200, 20);
			this.label7.TabIndex = 5;
			this.label7.Text = "Calculation Results (Kelvin)";
			// 
			// convertToKelvin
			// 
			this.convertToKelvin.BackColor = System.Drawing.SystemColors.Control;
			this.convertToKelvin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.convertToKelvin.Location = new System.Drawing.Point(9, 77);
			this.convertToKelvin.Name = "convertToKelvin";
			this.convertToKelvin.Size = new System.Drawing.Size(268, 31);
			this.convertToKelvin.TabIndex = 4;
			this.convertToKelvin.Text = "Calculate";
			this.convertToKelvin.UseVisualStyleBackColor = false;
			this.convertToKelvin.Click += new System.EventHandler(this.convertToKelvin_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 20);
			this.label8.TabIndex = 2;
			// 
			// celsiusTemperature
			// 
			this.celsiusTemperature.BackColor = System.Drawing.SystemColors.Window;
			this.celsiusTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.celsiusTemperature.Location = new System.Drawing.Point(9, 45);
			this.celsiusTemperature.Name = "celsiusTemperature";
			this.celsiusTemperature.Size = new System.Drawing.Size(268, 26);
			this.celsiusTemperature.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(165, 20);
			this.label9.TabIndex = 0;
			this.label9.Text = "Temperature (Celsius)";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.schwarzchildRadiusResults);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.calcSchwarzschildRadius);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.blackHoleMass);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Location = new System.Drawing.Point(873, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(284, 688);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Schwarzschild Radius ";
			// 
			// schwarzchildRadiusResults
			// 
			this.schwarzchildRadiusResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
			this.schwarzchildRadiusResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.schwarzchildRadiusResults.HideSelection = false;
			this.schwarzchildRadiusResults.Location = new System.Drawing.Point(9, 134);
			this.schwarzchildRadiusResults.Name = "schwarzchildRadiusResults";
			this.schwarzchildRadiusResults.Size = new System.Drawing.Size(268, 547);
			this.schwarzchildRadiusResults.TabIndex = 9;
			this.schwarzchildRadiusResults.UseCompatibleStateImageBehavior = false;
			this.schwarzchildRadiusResults.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Time";
			this.columnHeader5.Width = 82;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Result";
			this.columnHeader6.Width = 91;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 111);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(208, 20);
			this.label10.TabIndex = 5;
			this.label10.Text = "Calculation Results (Metres)";
			// 
			// calcSchwarzschildRadius
			// 
			this.calcSchwarzschildRadius.BackColor = System.Drawing.SystemColors.Control;
			this.calcSchwarzschildRadius.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calcSchwarzschildRadius.Location = new System.Drawing.Point(9, 77);
			this.calcSchwarzschildRadius.Name = "calcSchwarzschildRadius";
			this.calcSchwarzschildRadius.Size = new System.Drawing.Size(268, 31);
			this.calcSchwarzschildRadius.TabIndex = 4;
			this.calcSchwarzschildRadius.Text = "Calculate";
			this.calcSchwarzschildRadius.UseVisualStyleBackColor = false;
			this.calcSchwarzschildRadius.Click += new System.EventHandler(this.calcSchwarzschildRadius_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(9, 74);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(0, 20);
			this.label11.TabIndex = 2;
			// 
			// blackHoleMass
			// 
			this.blackHoleMass.BackColor = System.Drawing.SystemColors.Window;
			this.blackHoleMass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.blackHoleMass.Location = new System.Drawing.Point(9, 45);
			this.blackHoleMass.Name = "blackHoleMass";
			this.blackHoleMass.Size = new System.Drawing.Size(268, 26);
			this.blackHoleMass.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(9, 22);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(210, 20);
			this.label12.TabIndex = 0;
			this.label12.Text = "Black Hole Mass (Kilograms)";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip1.Size = new System.Drawing.Size(1166, 34);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(258, 29);
			this.toolStripLabel1.Text = "MSSS Astronomical Processing";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appearanceToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(120, 29);
			this.toolStripDropDownButton1.Text = "Preferences";
			// 
			// appearanceToolStripMenuItem
			// 
			this.appearanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.lightModeToolStripMenuItem,
            this.customBackgroundColourToolStripMenuItem,
            this.fontSettingsToolStripMenuItem});
			this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
			this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
			this.appearanceToolStripMenuItem.Text = "Appearance";
			// 
			// darkModeToolStripMenuItem
			// 
			this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
			this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
			this.darkModeToolStripMenuItem.Text = "Dark Mode";
			this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
			// 
			// lightModeToolStripMenuItem
			// 
			this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
			this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
			this.lightModeToolStripMenuItem.Text = "Light Mode";
			this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
			// 
			// customBackgroundColourToolStripMenuItem
			// 
			this.customBackgroundColourToolStripMenuItem.Name = "customBackgroundColourToolStripMenuItem";
			this.customBackgroundColourToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
			this.customBackgroundColourToolStripMenuItem.Text = "Custom Background Colour";
			this.customBackgroundColourToolStripMenuItem.Click += new System.EventHandler(this.customBackgroundColourToolStripMenuItem_Click);
			// 
			// fontSettingsToolStripMenuItem
			// 
			this.fontSettingsToolStripMenuItem.Name = "fontSettingsToolStripMenuItem";
			this.fontSettingsToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
			this.fontSettingsToolStripMenuItem.Text = "Font Settings";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1166, 734);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "MSSS Astronomical Processing Client";
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
	}
}

