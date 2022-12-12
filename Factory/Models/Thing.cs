using System;

namespace Factory.Models {
	public class Thing {
		public Guid ThingID { get; set; }
		public string Name { get; set; }
		// ...

		public Thing() {
			this.ThingID = Guid.NewGuid();
		}
	}
}
