using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WCFSample.ServerSide.Service;

namespace WCFSample.Server
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting");

			var host = new ServiceHost(typeof(WCFSampleService));
			try
			{
				host.Open();
			}
			catch (Exception ex)
			{
				var color = Console.ForegroundColor;
				Console.ForegroundColor = ConsoleColor.Red;

				Console.WriteLine("Somthing wrong. See error text for details:");
				Console.WriteLine(ex.Message);
				Console.WriteLine("Stack trace:");
				Console.WriteLine(ex.StackTrace);

				Console.ForegroundColor = color;
				Console.WriteLine("Press 'Enter' for exit");
				Console.ReadLine();
				return;
			}

			Console.WriteLine("Started");
			Console.WriteLine("Press 'Enter' for stop program");

			Console.ReadLine();
			Console.WriteLine("Stopping");
			host.Close();
			Console.WriteLine("Stopped");
		}
	}
}
