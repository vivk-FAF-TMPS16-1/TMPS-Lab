# TMPS Laboratory work nr. 1

## Author: `Volcov Oleg`
## Topic: `Creational Design Patterns`

## Objectives
****
1. Study about **Creational Design Patterns**
2. Implement some of them in a computer program
## Theory
****
In software engineering, **creational design patterns** are design patterns that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation
Creational design patterns are composed of two dominant ideas. One is encapsulating knowledge about which concrete classes the system uses. Another is hiding how instances of these concrete classes are created and combined

The most known creational patterns include:
* **Abstract Factory**
* **Builder**
* **Factory**
* **Singleton**

## Implemetation
****
4 creational designs were made(Factory, Abstract Factory, Singleton, Builder), with objects of type **Cookware**:Pan, Pot and Casserole. All of them have 3 attributes(price, name and material type) and toString method to output all attributes.
**Singleton** is implemented in **SteelCookwareFactory**, **IronCookwareFactory**, **GlassCookwareFacotory**. All instances of these classes are **private static** and their constructors are private as well, so they could only be instantiated by get() methods.
```csharp
private GlassCookwareFactory() { }

..........................

public static GlassCookwareFactory Instance
{
    get
    {
        if (_instance == null)
            _instance = new GlassCookwareFactory();
        return _instance;
    }
}
```
For the **builder**, there are two stages to create the objects. First, the factory is chosen by the material type(glass, steel, iron) and then in the factory, a corresponding builder is chosen.

Factory methods are in builder package. There are multiple classes to implement the ICookwareBuilder, which are chosen based on input parameter.

There are multiple factories for each material type. These factories implement IBaseFactory interface