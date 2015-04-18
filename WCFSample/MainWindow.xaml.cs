using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WCFSample.ClientSide
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		WCFSampleServiceClient client;

		List<WCFSample.ServerSide.Service.Block> Blocks { get; set; }

		public MainWindow()
		{
			InitializeComponent();

			client = new WCFSampleServiceClient("WCFSampleService");
		}

		private void btnGetBlocksClick(object sender, EventArgs e)
		{
            lstBlocks.Items.Clear();
            foreach (var block in client.GetBlocks())
                lstBlocks.Items.Add(block);
            Blocks = client.GetBlocks().ToList();
			SendChanged("Blocks");
		}

		private void SendChanged(string propName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
