using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFSample.ServerSide.Service;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace WCFSample.ClientSide
{
	public class WCFSampleServiceClient:System.ServiceModel.ClientBase<IWCFSampleService>, IWCFSampleService
	{

		public Block[] GetBlocks()
		{
			return base.Channel.GetBlocks();
		}

		public Block GetBlock(int id)
		{
			return base.Channel.GetBlock(id);
		}


		//Constructors

		public WCFSampleServiceClient() : base() { }

		public WCFSampleServiceClient(ServiceEndpoint endpoint) : base(endpoint) { }

		public WCFSampleServiceClient(string endpointConfigurationName) : base(endpointConfigurationName) { }

		public WCFSampleServiceClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }

		public WCFSampleServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress) { }

		public WCFSampleServiceClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress) { }
	}
}