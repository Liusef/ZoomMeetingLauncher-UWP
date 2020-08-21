using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace z_uwp
{
	[DataContractAttribute()]
	public class dateTime
	{
		[DataMember]
		char day;
		[DataMember]
		int hr;
		[DataMember]
		int min;
		[DataMember]
		char ap;

		dateTime(char dayOfWeek, int hour12hr, int minute, char AMPM)
		{
			day = dayOfWeek;
			hr = hour12hr;
			min = minute;
			ap = AMPM;
		}
	}
}
