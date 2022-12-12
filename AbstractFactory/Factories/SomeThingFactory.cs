using AbstractFactory.Factories.Abstract;
using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models;
using AbstractFactory.Models.Abstract;

namespace AbstractFactory.Factories {
	public class SomeThingFactory : ThingFactory, ISomeThingFactory {
		public override Thing Create() {
			Thing thing = new SomeThing();
			// ...

			return thing;
		}
	}
}
