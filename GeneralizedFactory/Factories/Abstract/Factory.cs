using GeneralizedFactory.Factories.Interfaces;

namespace GeneralizedFactory.Factories.Abstract {
	public abstract class Factory<T> : IFactory<T> {
		public abstract T Create();
		// ...
	}
}
