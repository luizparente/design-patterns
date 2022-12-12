using System;

namespace AbstractFactory.Models.Abstract {
	public abstract class Thing {
		public Guid ThingID { get; set; }
		public string Name { get; set; }
		// ...

		public Thing() {
			this.ThingID = Guid.NewGuid();
		}
	}
}
