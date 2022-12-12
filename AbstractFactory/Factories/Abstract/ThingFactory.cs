using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models.Abstract;

namespace AbstractFactory.Factories.Abstract {
	public abstract class ThingFactory : IThingFactory {
		public abstract Thing Create();
		// ...
	}
}
