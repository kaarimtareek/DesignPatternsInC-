## Singleton 

### When to use singleton?

- Use the Singleton pattern when a class in your program should
have just a single instance available to all clients; for exam
ple, a single database object shared by different parts of the
program.
- Use the Singleton pattern when you need stricter control over
  global variables. 

### How to implement?

1. Add a private static field to the class for storing the singleton
instance.
2. Declare a public static creation method for getting the single
ton instance.
3. Implement “lazy initialization” inside the static method. It
should create a new object on its first call and put it into the
static field. The method should always return that instance on
all subsequent calls.
4. Make the constructor of the class private. The static method of
the class will still be able to call the constructor, but not the
other objects.
5. Go over the client code and replace all direct calls to the singleton’s constructor with calls to its static creation method.


### Example

- We have a "Database" class that defines the "Instance" method that lets the clients
access the same instance of a database connection throughout the program.
- The field for storing the singleton instance should be declared static.
- The singleton's constructor should always be private to prevent direct construction calls with the `new` 10 operator 