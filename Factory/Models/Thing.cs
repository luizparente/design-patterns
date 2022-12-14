using Factory.Models.Interfaces;
using System;

namespace Factory.Models {
	public class Thing : IThing {
		public Guid ThingID { get; set; }
		public string Name { get; set; }
		// ...

		public Thing() {
			this.ThingID = Guid.NewGuid();
		}
	}
}
