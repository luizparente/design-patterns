using AbstractFactory.Factories.Abstract;
using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models;
using AbstractFactory.Models.Abstract;

namespace AbstractFactory.Factories {
	public class AnotherThingFactory : ThingFactory, IAnotherThingFactory {
		public override Thing Create() {
			Thing thing = new AnotherThing();
			// ...

			return thing;
		}
	}
}
