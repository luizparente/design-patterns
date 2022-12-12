using GeneralizedFactory.Factories.Interfaces;
using GeneralizedFactory.Models;

namespace GeneralizedFactory.Factories {
	public class ThingFactory : Abstract.Factory<Thing>, IThingFactory {
		public override Thing Create() {
			Thing thing = new Thing();
			// ...

			return thing;
		}
	}
}
