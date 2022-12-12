using Factory.Factories.Interfaces;
using Factory.Models;

namespace Factory.Factories {
	public class ThingFactory : IThingFactory {
		public Thing Create() {
			Thing thing = new Thing();
			// ...

			return thing;
		}
	}
}
