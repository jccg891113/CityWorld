using Core.Tool.Kit;
using System.Collections.Generic;

namespace Core.JOB
{
	public class Job : IMgrKit
	{
		private List<Federation> federations;

		public Job (Root root) : base (root)
		{
			federations = new List<Federation> ();
		}

		#region implemented abstract members of IMgrKit

		public override void Tick (int delta_ms)
		{
			for (int i = 0, imax = federations.Count; i < imax; i++) {
				federations [i].Tick (delta_ms);
			}
		}

		#endregion
	}
}

