using System;

namespace Factory.Models.Interfaces {
	public interface IThing {
		public Guid ThingID { get; set; }
		public string Name { get; set; }
		// ...
	}
}
