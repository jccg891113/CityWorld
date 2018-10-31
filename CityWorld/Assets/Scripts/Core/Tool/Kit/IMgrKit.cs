using Core;
using Core.GOV;
using Core.JOB;
using Core.LIFE;

namespace Core.Tool.Kit
{
	public abstract class IMgrKit : ITick
	{
		protected Root root;

		protected Gov gov{ get { return root.getGov (); } }

		protected Life life{ get { return root.getLife (); } }

		protected Job job{ get { return root.getJob (); } }

		public IMgrKit (Root root)
		{
			this.root = root;
		}

		#region ITick implementation

		public abstract void Tick (int delta_ms);

		#endregion
	}
}

