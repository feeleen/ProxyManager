using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProxyManager
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}

		private static void SetAutoStart(bool enable)
		{
			var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
			if (enable)
				key.SetValue(Application.ProductName, Application.ExecutablePath);
			else
				key.DeleteValue(Application.ProductName, false);
		}
	}
}