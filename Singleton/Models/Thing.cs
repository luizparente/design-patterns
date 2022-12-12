using System;

namespace Singleton.Models {
	public class Thing {
		private static Thing _instance;

		public Guid ThingID { get; private set; }
		public string Name { get; set; }
		// ...

		public static Thing Instance {
			get {
				if (_instance == null)
					_instance = new Thing();

				return _instance;
			}
		}

		private Thing() {
			this.ThingID = Guid.NewGuid();
		}
	}
}
