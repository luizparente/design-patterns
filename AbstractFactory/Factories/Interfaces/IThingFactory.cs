using AbstractFactory.Models.Abstract;

namespace AbstractFactory.Factories.Interfaces {
	public interface IThingFactory {
		public Thing Create();
		// ...
	}
}
