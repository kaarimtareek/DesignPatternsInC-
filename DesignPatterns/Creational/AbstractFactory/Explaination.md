## Abstract Factory

### When to use Abstract Factory?

- Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand, or you simply want to allow for future extensibility.

- Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.

### Example
This example illustrates how the Abstract Factory pattern can
be used for creating cross-platform UI elements without coupling the client code to concrete UI classes, while keeping all
created elements consistent with a selected operating system.
The same UI elements in a cross-platform application are
expected to behave similarly, but look a little bit different
under different operating systems. Moreover, it’s your job to
make sure that the UI elements match the style of the current
operating system. You wouldn’t want your program to render
macOS controls when it’s executed in Windows.
The Abstract Factory interface declares a set of creation methods that the client code can use to produce different types of
UI elements. Concrete factories correspond to specific operating systems and create the UI elements that match that particular OS.
It works like this: when an application launches, it checks the
type of the current operating system. The app us