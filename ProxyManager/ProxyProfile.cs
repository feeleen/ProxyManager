using System;

namespace ProxyManager
{
	[Serializable]
	public class ProxyProfile
	{
		public string Name { get; set; }
		public bool AutoDetect { get; set; }
		public bool UseScript { get; set; }
		public string ScriptUrl { get; set; }
		public bool UseProxy { get; set; }
		public string ProxyAddress { get; set; }
		public string BypassList { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }

		public ProxyProfile()
		{
			Name = string.Empty;
			ScriptUrl = string.Empty;
			ProxyAddress = string.Empty;
			BypassList = string.Empty;
			Created = DateTime.Now;
			Modified = DateTime.Now;
		}

		public ProxyProfile(string name) : this()
		{
			Name = name;
		}
	}
}
