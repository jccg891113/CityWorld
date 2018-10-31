using Core.Tool.Kit;

namespace Core.JOB
{
	/// <summary>
	/// 行业联合会
	/// </summary>
	public class Federation : ITick
	{
		/// <summary>
		/// 行业性质
		/// </summary>
		public JobType jobType;

		/// <summary>
		/// 行业类型ID
		/// </summary>
		public int jopClass;

		#region Constrctors

		public Federation (JobType jobType, int jopClass)
		{
			this.jobType = jobType;
			this.jopClass = jopClass;
		}

		#endregion

		#region ITick implementation

		public void Tick (int delta_ms)
		{
		}

		#endregion
	}
}

