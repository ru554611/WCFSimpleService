using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFSample.ServerSide.Service
{
	[ServiceContract(Namespace="http://WCFSample.ru")]
	public interface IWCFSampleService
	{
		[OperationContract]
		Block[] GetBlocks();

		[OperationContract]
		Block GetBlock(int id);
	}
}
