# Missing Dog

## Story

### Missing Dog
```DISCLAIMER: no real dogs are missing - do not worry```

Your friend's aunt Clarence runs a dog hotel. Good for her the business grows
and more and more dog owners leave their dogs there going for holidays.
Good for you because when Clarence heard you are good at *computer stuff*
she asked for help with creating a computer registry
that would replace her old notebook registry version.
However, the advantage of a notebook is that is does not break down, so
your code must handle situations when the registry search criteria are not met -
and where there should be a dog, there is none.

In this project, your primary goal is to get familiar with **nullable types** and some null-oriented
syntax, such as **null propagation** or **null coalescing**. These aren't entirely new features
to the C# language, they mostly serve as a shorter way to write some repetitive instructions
(ones that you would normally write as 2-3 lines long `if` statements). Two repository classes
need method implementation, with focus on handling null values.

Run unit tests to see if your implementation is correct.
Focus on handling potential null references in given data and use LINQ to finish this project.


## What are you going to learn?

- basics of nullable types in C#
- usage of member access operators and expressions
- null propagation (? operator)
- null coalescing (?? operator)
- null coalescing compound assignment (??= operator)
- intermediate LINQ
- basics of Repository design pattern


## Tasks

1. Implement all methods in the DogRepository class.
    - The `GetAllDogs()` method returns an `IEnumerable<Dog>` of all `Dog` instances (including null references) from provided data from `DataSource` class.
    - The `GetDogById()` method returns a specific `Dog` instance with given `Id`, if exists. If doesn't, returns `null`.
    - The `GetCountOfDogsForTheOwnerOfDogWithId()` method returns the count of `Dog` instances which are assigned to an `Owner` of a `Dog` with a given `Id`.
    - The `GetOwnerPhoneNoByDogId()` method returns `PhoneNumber` of the `Dog` instance `Owner` with a given `Id`, if exists. If doesn't, returns a `string` "Missing data".
    - The `GetDogsBySociability()` method returns an `IEnumerable<Dog>` of all `Dog` instances with a given `Sociability`.

2. Implement all methods in the OwnerRepository class.
    - The `GetAllOwners()` method returns an `IEnumerable<Owner>` of all `Owner` instances (including null references) from provided data from `DataSource` class.
    - The `GetOwnerById()` method returns a specific `Owner` instance with given `Id`, if exists. If doesn't, returns `null`.
    - The `GetCountOfDogsOfSpecificBreedThisOwnerHas()` method returns the count of 'Dog' instances of specific `Breed` that this `Owner` has.
    - The `CountAverageActivityLevelOfThisOwnersDogs()` method thet returns the count an average `ActivityLevel` of all `Dog` instances that `Owner` with given `Id` has.
    - The `GetOldestDogOfThisOwner()` method returns the oldest `Dog` instance of `Owner` with given `Id`, if exists. If doesn't, returns `null`.
    - The `CountDogsOfThisOwner()` method that returns the count of `Dog` instances of `Owner` with given `Id`.

## General requirements

None

## Hints

- Remember to handle all the nulls in your data, check the references in models to see where you can find them
- Remember that LINQ is your friend ;)
- Feel free to write your own tests as an additional way of checking your code's correctness

## Background materials

- [C# nullable value types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types)
- [C# member access operators and expressions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-)
- [C# ?? and ??= operators](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator)
- [Repository design pattern](https://www.c-sharpcorner.com/UploadFile/b1df45/getting-started-with-repository-pattern-using-C-Sharp/)
- [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/query-syntax-and-method-syntax-in-linq)

