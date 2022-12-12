using Factory.Models.Interfaces;
using System;

namespace Factory.Models {
	public class AnotherThing : IThing {
		public Guid ThingID { get; set; }
		public string Name { get; set; }
		// ...

		public AnotherThing() {
			this.ThingID = Guid.NewGuid();
		}
	}
}
