INVERSION OF CONTROL PRINCIPLE:
		
		The main objective of IOC in C# is to remove the dependencies (remove tight coupling) between the 
		objects of an application which makes the application more decoupled and maintainable.
		The IOC principle suggests the inversion of various types of controls in o-o design to achieve lo-
		ose coupling between the application classes.Here,CONTROL means any extra responsibilities a class
		has other than its main or fundamental responsibility.For example, control over the dependent object
		creation, over the flow of the application ....

		Lets say you have a "repository" class , and that the repo class is responsible for giving data to you
		from a data source.The repo class could establish a connection to the data source by itself without 
		anyone else's input : {SqlConnection myConnection = new SqlConnection(Parameters....);}.But, consider
		the situation in which is is allowed you to pass the connection details about the data source through
		the repository class constructor!

		By allowing the caller to provide the connection details through a class constructor,we have actually 
		decoupled the data source connection Dependency from the repository class,allowing any data source to 
		work with the repository,not only the one which the repository specifies.
		Here, we have inverted the control by handling the responsibility of Creating the Connection details 
		about the data source, from the repository class itself to the CALLER class.
_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

DEPENDENCY INVERSION PRINCIPLE :
		
		DIP states that high-level modules/classes should not depend upon low-level modules/classes.
		Both should depend upon abstractions.
		Secondly, abstractions should not depend upon details.Details should depend upon abtractions.

		We need to keep the High-level module and Low-level module as loosely coupled as possible.
		When a class knows about the design and implementation of another class,it raises the risk that 
		if we do any changes to one class the other class break.So we must keep these high-level and 
		low-level module/classes as loosely coupled as possible.To do that, we need to make both of them
		dependent on abstractions instead of knowing each other.

_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
Dependency : is an object that another object depends on.
_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
DEPENDENCY INJECTION DESIGN PATTERN:

DI : is a technique for achieving Inversion Of Control between classes and their dependencies.
_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-

https://medium.com/@sardar.khan299/understanding-dependency-injection-a-powerful-design-pattern-for-flexible-and-testable-code-5e1161dd37dd











