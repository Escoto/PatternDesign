# Factory Pattern
Practicing by example the factory pattern with a Pizza Store simulator.

*The most developed example is California's pizza.*

## NOTES

**The Factory Pattern** defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
* **Factory** relies on inheritance: object creation is delegated to subclasses, which implement the factory method to create objects.

* **Abstract Factory** relies on object composition: object creation is implemented in methods exposed in the factory interface.

### DESIGN PRINCIPLES

* **Dependency Inversion** depend upon abstractions, not upon concrete classes.