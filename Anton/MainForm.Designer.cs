﻿namespace Anton
{
  partial class MainForm
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
	  if ( disposing && ( components != null ) )
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
	  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
	  this.getAllPrices = new System.Windows.Forms.Button();
	  this.SuspendLayout();
	  // 
	  // getAllPrices
	  // 
	  this.getAllPrices.Location = new System.Drawing.Point(117, 249);
	  this.getAllPrices.Name = "getAllPrices";
	  this.getAllPrices.Size = new System.Drawing.Size(102, 27);
	  this.getAllPrices.TabIndex = 0;
	  this.getAllPrices.Text = "Get All Prices";
	  this.getAllPrices.UseVisualStyleBackColor = true;
	  this.getAllPrices.Click += new System.EventHandler(this.getAllPrices_Click);
	  // 
	  // MainForm
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(337, 306);
	  this.Controls.Add(this.getAllPrices);
	  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
	  this.Name = "MainForm";
	  this.Text = "Anton v1";
	  this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.Button getAllPrices;
  }
}