using System;
using System.Windows.Forms;

public class HandDrawnClass : Form
{
	private System.Windows.Forms.Label lblOutput;
	private System.Windows.Forms.Button btnCancel;

	HandDrawnClass()
	{
		this.lblOutput = new System.Windows.Forms.Label( );
		this.btnCancel = new System.Windows.Forms.Button( );
		this.Text = "Hello, World!";

		lblOutput.Location = new System.Drawing.Point(16,24);
		lblOutput.Text = "Hello, World!";
		lblOutput.Size = new System.Drawing.Size(216,24);
		btnCancel.Location = new System.Drawing.Point (150,200);
		btnCancel.Size = new System.Drawing.Size(112,32);
		btnCancel.Text = "&Cancel";

		btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
		this.AutoScaleBaseSize = new System.Drawing.Size(5,13);
		this.ClientSize = new System.Drawing.Size(300,300);
		this.Controls.Add(this.btnCancel);
		this.Controls.Add(this.lblOutput);
	}
	protected void btnCancel_Click(object sender, System.EventArgs e)
	{
		Application.Exit();
	}
	public static void Main()
	{
		Application.Run(new HandDrawnClass());
	}
}
