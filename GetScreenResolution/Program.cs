using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace GetScreenResolution
{
	class Program
	{

		private static void Main(string[] args)
		{
			Console.WriteLine(Program.GetResolution());
			System.Windows.Forms.Application.Exit();
		}

		public static string GetResolution()
		{
			double primaryScreenHeight = SystemParameters.PrimaryScreenHeight;
			string str = Screen.PrimaryScreen.Bounds.Width.ToString();
			string str2 = Screen.PrimaryScreen.Bounds.Height.ToString();
			return str + "x" + str2;
		}
	}
}

