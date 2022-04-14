using System;

namespace IEXSharp.Model.PremiumData.WallStreetHorizon.Response
{
	public class WallStreetHorizonEventResponse
	{
		public string eventid { get; set; }
        public string announcedate { get; set; }
        public string organizer { get; set; }
        public string eventdesc { get; set; }
        public string eventstatus { get; set; }
        public string sectornames { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public object localtimestart { get; set; }
        public string timezone { get; set; }
        public object venue { get; set; }
        public object venueaddress { get; set; }
        public string venuecity { get; set; }
        public object venuestate { get; set; }
        public string venuecountry { get; set; }
        public string venuecountryiso { get; set; }
        public string purl { get; set; }
        public object inviteurl { get; set; }
        public object scheduleurl { get; set; }
        public object additionalinfourl { get; set; }
        public object externalnote { get; set; }
        public object referencelink { get; set; }
        public decimal updated { get; set; }
        public presenters presenters { get; set; }
        public string symbol { get; set; }
        public string id { get; set; }
        public string source { get; set; }
        public string key { get; set; }
        public string subkey { get; set; }
        public long date { get; set; }
    }

	public class presenters
    {
        public presenter presenter { get; set; }
    }

    public class presenter
    {
        public string eventid { get; set; }
        public string symbol { get; set; }
        public string companyname { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public object time { get; set; }
        public DateTime announcedate { get; set; }
        public string presentername { get; set; }
        public object presentertitle { get; set; }
        public string created { get; set; }
        public DateTime updated { get; set; }
    }
}