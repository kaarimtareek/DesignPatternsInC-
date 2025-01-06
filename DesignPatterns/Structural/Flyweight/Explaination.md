## Flyweight

### When to use Flyweight pattern?
- Use the Flyweight pattern only when your program must support a huge number of objects which barely fit into available RAM

### How to implement?

1. Divide fields of a class that will become a flyweight into two parts:
   - the intrinsic state: the fields that contain unchanging data duplicated across many objects
   -  the extrinsic state: the fields that contain contextual data unique to each object
2. Leave the fields that represent the intrinsic state in the class, but make sure they’re immutable. They should take their initial values only inside the constructor. 
3. Go over methods that use fields of the extrinsic state. For each field used in the method, introduce a new parameter and use it instead of the field.
4. Optionally, create a factory class to manage the pool of flyweights. It should check for an existing flyweight before creating a new one. Once the factory is in place, clients must
   only request flyweights through it. They should describe the desired flyweight by passing its intrinsic state to the factory.
5. The client must store or calculate values of the extrinsic state (context) to be able to call methods of flyweight objects. For the sake of convenience, the extrinsic state along with the flyweight-referencing field may be moved to a separate context class 

