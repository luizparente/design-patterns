using System;

namespace GeneralizedFactory.Models {
	public class Thing {
		public Guid ThingID { get; private set; }
		public string Name { get; set; }
		// ...

		public Thing() {
			this.ThingID = Guid.NewGuid();
		}
	}
}
