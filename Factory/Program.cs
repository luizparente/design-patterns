namespace Factory {
	class Program {
		static void Main(string[] args) {
			/*
			 
			FACTORY:
			
			Factory Method is a creational design pattern 
			that provides an interface for creating instances
			of a class.

			There are many examples online that implement this
			pattern by defining the Create method with a parameter
			that defines a subtype to return. I find it very
			disturbing an unwise, since it would break the Open-Closed
			Principle. Any extensions to Create would necessarily
			require a new if statement for the newly added type.

			Instead, I prefer to define the Factory Pattern as
			a simpler implementation of the Generalized Factory, also
			included in this product. With this approach, the pattern
			aims exclusively on one mission: Provide strict control as
			to how classes are instantiated.

			Use the Factory Pattern when you need to
			control how instances of a class are created.
			 
			*/
		}
	}
}
