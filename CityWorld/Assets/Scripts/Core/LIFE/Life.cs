using Core.Tool.Kit;

namespace Core.LIFE
{
	public class Life : IMgrKit
	{
		public Life (Root root) : base (root)
		{
		}

		#region implemented abstract members of IMgrKit

		public override void Tick (int delta_ms)
		{
		}

		#endregion
	}
}

