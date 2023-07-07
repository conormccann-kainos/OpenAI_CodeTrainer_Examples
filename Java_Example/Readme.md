
# Data Types Training Material

This project contains examples of incorrect and corrected code for data types in Java.

## Incorrect Code

The `IncorrectCode.java` file in `src/main/java/com/example/datatypes` contains code with errors in data types.

## Unit Test

The `TestIncorrectCode.java` file in `src/test/java/com/example/datatypes` contains a JUnit test that will fail when run against the incorrect code.

## Corrected Code

The `CorrectedCode.java` file in `src/main/java/com/example/datatypes` contains the corrected code for the data types.

## Running the Code

To run the code, compile the `CorrectedCode.java` file and run the resulting class file. For example:

```
javac src/main/java/com/example/datatypes/CorrectedCode.java
java com.example.datatypes.CorrectedCode
```

This should output the following:

```
Hello
```

## Running the Unit Test

To run the unit test, compile the `TestIncorrectCode.java` file and run the resulting class file. For example:

```
javac -cp junit.jar src/test/java/com/example/datatypes/TestIncorrectCode.java
java -cp .:junit.jar org.junit.runner.JUnitCore com.example.datatypes.TestIncorrectCode
```

This should output the following:

```
JUnit version 4.12
.E
Time: 0.005
There was 1 failure:
1) testIncorrectCode(com.example.datatypes.TestIncorrectCode)
java.lang.AssertionError: 
Expected :true
Actual   :"true"
<Click to see difference>

    at org.junit.Assert.fail(Assert.java:88)
    at org.junit.Assert.failNotEquals(Assert.java:743)
    at org.junit.Assert.assertEquals(Assert.java:118)
    at org.junit.Assert.assertEquals(Assert.java:555)
    at org.junit.Assert.assertEquals(Assert.java:542)
    at com.example.datatypes.TestIncorrectCode.testIncorrectCode(TestIncorrectCode.java:10)

FAILURES!!!
Tests run: 1,  Failures: 1
```

This indicates that the unit test failed, as expected when run against the incorrect code.
