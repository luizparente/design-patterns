using Factory.Factories.Interfaces;
using Factory.Models;
using Factory.Models.Interfaces;

namespace Factory.Factories {
	public class ThingFactory : IThingFactory {
		public IThing Create(ThingType type) {
			switch (type) {
				case ThingType.Thing:
					return new Thing();
				case ThingType.AnotherThing:
					return new AnotherThing();
				default:
					throw new System.Exception($"Unknown type '{type}'.");
			}
		}

		// ...
	}
}
