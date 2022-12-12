using Factory.Models;
using Factory.Models.Interfaces;

namespace Factory.Factories.Interfaces {
	public interface IThingFactory {
		public IThing Create(ThingType type);
		// ...
	}
}
