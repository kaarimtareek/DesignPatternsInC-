﻿## Observer

### When to use observer pattern? 

- Use the Observer pattern when changes to the state of one
  object may require changing other objects, and the actual set
  of objects is unknown beforehand or changes dynamically.
- Use the pattern when some objects in your app must observe
  others, but only for a limited time or in specific cases.

### How to implement? 

1. Look over your business logic and try to break it down into two
   parts: the core functionality, independent from other code, will act as the publisher; the rest will turn into a set of subscriber
   classes.
2. Declare the subscriber interface. At a bare minimum, it should
   declare a single update method.
3. Declare the publisher interface and describe a pair of methods
   for adding a subscriber object to and removing it from the list.
   Remember that publishers must work with subscribers only via
   the subscriber interface.
4. Decide where to put the actual subscription list and the implementation of subscription methods. Usually, this code looks
   the same for all types of publishers, so the obvious place to
   put it is in an abstract class derived directly from the publisher
   interface. Concrete publishers extend that class, inheriting the
   subscription behavior.
   However, if you’re applying the pattern to an existing class
   hierarchy, consider an approach based on composition: put the
   subscription logic into a separate object, and make all real
   publishers use it.
5. Create concrete publisher classes. Each time something important happens inside a publisher, it must notify all its
   subscribers.
6. Implement the update notification methods in concrete subscriber classes. Most subscribers would need some context data about the event. It can be passed as an argument of the
   notification method. But there’s another option. Upon receiving a notification, the subscriber can fetch any data directly from the notification. In this case, the publisher must pass itself via the update method. The less flexible option is to link a publisher to the subscriber permanently via the constructor.
7. The client must create all necessary subscribers and register
   them with proper publishers.

