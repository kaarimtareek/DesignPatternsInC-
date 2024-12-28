## Factory Method

### When to use factory method?
- Use the Factory Method when you don’t know beforehand the
exact types and dependencies of the objects your code should
work with.
- Use the Factory Method when you want to provide users of
your library or framework with a way to extend its internal
components.

### Example
This example illustrates how the Factory Method can be used
for creating cross-platform UI elements without coupling the
client code to concrete UI classes.

The base Dialog class uses different UI elements to render its window. Under various operating systems, these elements may
look a little bit different, but they should still behave consistently.

When the factory method comes into play, you don’t need to
rewrite the logic of the Dialog class for each operating system. If we declare a factory method that produces buttons
inside the base Dialog class, we can later create a subclass
that returns Windows-styled buttons from the factory method.

The subclass then inherits most of the code from the base
class, but, thanks to the factory method, can render Windows-looking buttons on the screen

With this approach, the client code doesn’t depend on concrete classes of factories and UI elements as long as it works
with these objects via their abstract interfaces. This also lets
the client code support other factories or UI elements that you
might add in the future.