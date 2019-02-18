# Design of Unity
This topic describes the design goals, the architecture, and the design highlights of Unity. You do not have to understand the design to use Unity; however, this topic will help you to understand how it works and how it interacts with the underlying ObjectBuilder subsystem.
## Design Goals
Unity was designed to achieve the following goals:
* Promote the principles of modular design through aggressive decoupling.
* Raise awareness of the need to maximize testability when designing applications.
* Provide a fast and lightweight dependency injection container mechanism for creating new object instances and managing existing object instances.
* Expose a compact and intuitive API for developers to work with the container.
* Support a wide range of code languages, with method overrides that accept generic parameters where the language supports these.
* Implement attribute-driven injection for constructors, property setters, and methods of target objects.
* Provide extensibility through custom and third-party container extensions.
* Provide the performance required in enterprise-level line of business (LOB) applications.
# Operation
The public methods of the UnityContainer that developers use fall into two main categories:
* **Methods that register mappings or types**. The methods RegisterType and the RegisterInstance create the appropriate entries within the current container context.
* **Methods that retrieve objects**. These include overrides of the `Resolve` and `BuildUp` methods. These methods retrieve the required instances of the objects.