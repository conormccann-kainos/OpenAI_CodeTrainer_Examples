
# Objects Training Material

This training material covers the basics of objects in C#.

## File Structure

The project has the following file structure:

```
├── src
│   └── Objects
│       └── Person.cs
│       └── Rectangle.cs
└── tests
    └── Objects
        └── PersonTests.cs
        └── RectangleTests.cs
```

The `src` directory contains the source code for the `Person` and `Rectangle` classes. The `tests` directory contains the unit tests for these classes.

## Running the Code

To run the code, you will need to have the .NET Core SDK installed on your machine. You can download it from the official website: https://dotnet.microsoft.com/download

Once you have the .NET Core SDK installed, you can run the unit tests by navigating to the `tests` directory and running the following command:

```
dotnet test
```

This will compile the code and run the unit tests. If everything is working correctly, you should see output similar to the following:

```
Test Run Successful.
Total tests: 2
     Passed: 2
 Total time: 0.1234 Seconds
```

If any of the tests fail, you will see output indicating which tests failed and why.

## Conclusion

This training material covers the basics of objects in C#. By studying the code and running the unit tests, you should gain a solid understanding of how to create and use objects in C#.
