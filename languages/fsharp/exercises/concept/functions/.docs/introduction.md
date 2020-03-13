As F# is a _functional-first_ programming language, functions are at the heart of the language. To make working with functions as easy as possible, functions are first-class citizens. This means that functions can be passed as arguments to other functions, returned from functions and assigned to identifiers.

Due to functions being regular values like strings, booleans and integers, associating them with a name is done in the same way using the `let` keyword. A function is different from other values by the fact that they have one or more parameters. The parameters of a function are separated by spaces.

Invoking a function is done by specifying its name and passing arguments for each of the function's parameters, separated by spaces.

A function's type can be made explicit by specifying the return type and the type of each parameter. That said, in most cases the type can be automatically inferred by the compiler by analyzing what values the function is called with and what value the function returns.

F# uses significant whitespace to define scope. This means that the code in a function's body has to be indented relative to the line declaring the function and its parameters. The default convention is to use four spaces for indentation.
