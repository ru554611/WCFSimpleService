using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFSample.ServerSide.Service
{
	[ServiceBehavior(Namespace = "http://WCFSample.ru")]
	public class WCFSampleService : IWCFSampleService
	{
		private Block[] blockStorage;
		private Person[] personeStorage;
		
		public Block[] GetBlocks()
		{
			return blockStorage;
		}

		public Block GetBlock(int id)
		{
			return blockStorage.SingleOrDefault(b => b.id == id);
		}

		public WCFSampleService()
		{
			var rnd = new Random();
			int personsCnt = 10;
			int blockCnt = 5;

			//Generate persons
			personeStorage = new Person[personsCnt];
			for (int ix = 0; ix < personsCnt; ix++)
				personeStorage[ix] = new Person()
				{
					first_name = string.Format("first_name {0}", ix),
					last_name = string.Format("last_name {0}", ix),
					middle_name = string.Format("middle_name {0}", ix),
					parents = new Person[1 + ix & 1]
				};

			//Generate parents for each person
			for (int ix = 0; ix < personsCnt; ix++)
				for (int parentIx = 0; parentIx < personeStorage[ix].parents.Length; parentIx++)
					personeStorage[ix].parents[parentIx] = personeStorage[rnd.Next(personsCnt)];

			//Generate blocks
			blockStorage = new Block[blockCnt];
			for (int ix = 0; ix < blockCnt; ix++)
				blockStorage[ix] = new Block()
				{
					id = ix,
					name = string.Format("{0} block", ix),
					owner = personeStorage[rnd.Next(personsCnt)]
				};
		}
	}
}