
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TimePeriod {

	public TimePeriod() {
	}

	public Date startDate {
		get; set;
	}

	public Date endDate {
		get; set;
	}

	public bool overlapsAny(List<TimePeriod> periods)
	{
		bool overlaps = false;
		foreach (TimePeriod period in periods)
		{
			if (this.overlaps(period))
			{
				overlaps = true;
				break;
			}
		}
		return overlaps;
	}

	public bool overlaps(TimePeriod other)
	{
		// logic to check whether two time periods overlap
		throw new NotImplementedException();
	}

}