using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.User
{
    public class MarketUserLogHistory
    {
		public long MarketUserLogHistoryId { get; set; }
		public string MarketuserLogCode { get; set; }
		public DateTime LogDate { get; set; }
		public int MarketUserId { get; set; }
		public DateTime LogInTime { get; set; }
		public DateTime? LogOutTime { get; set; }
	}
}
