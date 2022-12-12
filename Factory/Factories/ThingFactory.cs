using Factory.Factories.Interfaces;
using Factory.Models;
using Factory.Models.Interfaces;

namespace Factory.Factories {
	public class ThingFactory : IThingFactory {
		public IThing Create(ThingType type) {
			if (type == ThingType.Thing)
				return new Thing();
			else if (type == ThingType.AnotherThing)
				return new AnotherThing();
			else
				throw new System.Exception($"Unknown type '{type}'.");
		}

		// ...
	}
}
