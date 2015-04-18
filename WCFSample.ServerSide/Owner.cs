using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WCFSample.ServerSide.Service
{
	[DataContract]
	public class Person
	{
		[DataMember]
		public string first_name { get; set; }
		[DataMember]
		public string middle_name { get; set; }
		[DataMember]
		public string last_name { get; set; }

		[IgnoreDataMember]
		public Person[] parents { get; set; }
	}
}
