using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFSample.ServerSide.Service
{
	[DataContract]
	public class Block
	{
		[DataMember]
		public int id { get; set; }
		[DataMember]
		public string name { get; set; }
		[DataMember(IsRequired=false)]
		public Person owner { get; set; }
	}
}
