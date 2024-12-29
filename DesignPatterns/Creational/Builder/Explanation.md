## Builder

### When to use builder pattern?
- Use the Builder pattern to get rid of a “telescoping
constructor”.
- Use the Builder pattern when you want your code to be able to
  create different representations of some product (for example,
 stone and wooden houses). 
- The Builder pattern lets you construct products step-by-step.
  You could defer execution of some steps without breaking the
  final product. You can even call steps recursively, which comes
  in handy when you need to build an object tree.

### How to implement

1. Make sure that you can clearly define the common construction steps for building all available product representations.
   Otherwise, you won’t be able to proceed with implementing
   the pattern.
2. Declare these steps in the base builder interface.
3. Create a concrete builder class for each of the product representations and implement their construction steps.
   Don’t forget about implementing a method for fetching the
   result of the construction. The reason why this method can’t
   be declared inside the builder interface is that various builders
   may construct products that don’t have a common interface.
   Therefore, you don’t know what would be the return type for
   such a method. However, if you’re dealing with products from
   a single hierarchy, the fetching method can be safely added to the base interface.
4. Think about creating a director class. It may encapsulate various ways to construct a product using the same builder object.
5. The client code creates both the builder and the director
   objects. Before construction starts, the client must pass a
   builder object to the director. Usually, the client does this only
   once, via parameters of the director’s class constructor. The
   director uses the builder object in all further construction.
   There’s an alternative approach, where the builder is passed to
   a specific product construction method of the director.
6. The construction result can be obtained directly from the
   director only if all products follow the same interface. Otherwise, the client should fetch the result from the builder.

### Example

A car is a complex object that can be constructed in a hundred
different ways. Instead of bloating the Car class with a huge
constructor, we extracted the car assembly code into a separate car builder class. This class has a set of methods for configuring various parts of a car.
If the client code needs to assemble a special, fine-tuned
model of a car, it can work with the builder directly. On the
other hand, the client can delegate the assembly to the director class, which knows how to use a builder to construct several of the most popular models of cars
You might be shocked, but every car needs a manual (seriously, who reads them?). The manual describes every feature
of the car, so the details in the manuals vary across the different models. That’s why it makes sense to reuse an existing construction process for both real cars and their respective
manuals. Of course, building a manual isn’t the same as building a car, and that’s why we must provide another builder
class that specializes in composing manuals. This class implements the same building methods as its car-building sibling,
but instead of crafting car parts, it describes them. By passing
these builders to the same director object, we can construct
either a car or a manual.
The final part is fetching the resulting object. A metal car and a
paper manual, although related, are still very different things.
We can’t place a method for fetching results in the director without coupling the director to concrete product classes. Hence, we obtain the result of the construction from the
builder which performed the job.