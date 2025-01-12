## Visitor

### When to use visitor pattern? 
- Use the Visitor when you need to perform an operation on
  all elements of a complex object structure (for example, an
  object tree).
- Use the Visitor to clean up the business logic of auxiliary
  behaviors.
- Use the pattern when a behavior makes sense only in some
  classes of a class hierarchy, but not in others.

### How to implement?

1. Declare the visitor interface with a set of “visiting” methods, one per each concrete element class that exists in the program.
2. Declare the element interface. If you’re working with an existing element class hierarchy, add the abstract “acceptance” method to the base class of the hierarchy. This method should accept a visitor object as an argument.
3. Implement the acceptance methods in all concrete element
   classes. These methods must simply redirect the call to a visiting method on the incoming visitor object which matches the class of the current element.
4. The element classes should only work with visitors via the visitor interface. Visitors, however, must be aware of all concrete element classes, referenced as parameter types of the visiting methods.
5. For each behavior that can’t be implemented inside the element hierarchy, create a new concrete visitor class and implement all of the visiting methods. You might encounter a situation where the visitor will need
   access to some private members of the element class. In this
   case, you can either make these fields or methods public, violating the element’s encapsulation, or nest the visitor class in the element class. The latter is only possible if you’re lucky to work with a programming language that supports nested classes.
6. The client must create visitor objects and pass them into elements via “acceptance” methods.
