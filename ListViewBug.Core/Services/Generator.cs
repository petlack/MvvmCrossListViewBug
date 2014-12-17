using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ListViewBug.Core
{
	public class Generator
	{

		public static List<string> Generate(int fromNumber, int count) {
			var ret = new List<string> ();
			for (int i = fromNumber; i < fromNumber + count; i++) {
				ret.Add(i.ToString ()); 
			}
			return ret;
		}

	}
}

