## Proxy

### When to use proxy pattern?

- Lazy initialization (virtual proxy). This is when you have a
heavyweight service object that wastes system resources by
being always up, even though you only need it from time
to time. 
- Access control (protection proxy). This is when you want only
  specific clients to be able to use the service object; for
  instance, when your objects are crucial parts of an operating
  system and clients are various launched applications (including malicious ones). 
- Local execution of a remote service (remote proxy). This is
  when the service object is located on a remote server.
- Logging requests (logging proxy). This is when you want to
  keep a history of requests to the service object 
- Caching request results (caching proxy). This is when you need
  to cache results of client requests and manage the life cycle of
  this cache, especially if results are quite large 
- Smart reference. This is when you need to be able to dismiss a
  heavyweight object once there are no clients that use it.  

### How to implement? 

1. If there’s no pre-existing service interface, create one to make proxy and service objects interchangeable. Extracting the
interface from the service class isn’t always possible, because
you’d need to change all the service’s clients to use that
interface. Plan B is to make the proxy a subclass of the service
class, and this way it’ll inherit the interface of the service.
2. Create the proxy class. It should have a field for storing a reference to the service. Usually, proxies create and manage the
   whole life cycle of their services. On rare occasions, a service is passed to the proxy via a constructor by the client.
3. Implement the proxy methods according to their purposes. In
   most cases, after doing some work, the proxy should delegate
   the work to the service object.
4. Consider introducing a creation method that decides whether
   the client gets a proxy or a real service. This can be a simple static method in the proxy class or a full-blown factory method.
5. Consider implementing lazy initialization for the service
   object.
 
