## Iterator

### When to use iterator pattern?

- Use the Iterator pattern when your collection has a complex
  data structure under the hood, but you want to hide its complexity from clients (either for convenience or security
  reasons).
- Use the pattern to reduce duplication of the traversal code
  across your app.
- Use the Iterator when you want your code to be able to traverse different data structures or when types of these structures are unknown beforehand.

### How to implement?

1. Declare the iterator interface. At the very least, it must have a
method for fetching the next element from a collection. But for
the sake of convenience you can add a couple of other methods, such as fetching the previous element, tracking the current position, and checking the end of the iteration.
2. Declare the collection interface and describe a method for
   fetching iterators. The return type should be equal to that of the iterator interface. You may declare similar methods if you
   plan to have several distinct groups of iterators.
3. Implement concrete iterator classes for the collections that
   you want to be traversable with iterators. An iterator object
   must be linked with a single collection instance. Usually, this
   link is established via the iterator’s constructor.
4. Implement the collection interface in your collection classes.
   The main idea is to provide the client with a shortcut for creating iterators, tailored for a particular collection class. The collection object must pass itself to the iterator’s constructor to establish a link between them.
5. Go over the client code to replace all the collection traversal
   code with the use of iterators. The client fetches a new iterator object each time it needs to iterate over the collection elements.