using Core.GOV;
using Core.LIFE;
using Core.JOB;
using Core.Tool.Kit;
using System.Collections.Generic;

namespace Core
{
	public class Root : ITick
	{
		protected Gov gov;
		protected Life life;
		protected Job job;

		List<ITick> ticks;

		public Root ()
		{
			gov = new Gov (this);
			life = new Life (this);
			job = new Job (this);

			ticks = new List<ITick> ();
			ticks.Add (gov);
			ticks.Add (life);
			ticks.Add (job);
		}

		public Gov getGov ()
		{
			return gov;
		}

		public Life getLife ()
		{
			return life;
		}

		public Job getJob ()
		{
			return job;
		}

		#region ITick implementation

		public void Tick (int delta_ms)
		{
			for (int i = 0, imax = ticks.Count; i < imax; i++) {
				ticks [i].Tick (delta_ms);
			}
		}

		#endregion
	}
}
