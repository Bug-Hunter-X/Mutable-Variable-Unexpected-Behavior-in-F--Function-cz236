# F# Mutable Variable Bug

This repository demonstrates a common error involving mutable variables in F#. The `add` function unexpectedly modifies its input parameters, leading to different results than expected.

## Bug Description

The `add` function, intended to add two numbers, modifies its input parameters using the `<-` operator. This unexpected side effect causes the main program to produce incorrect outputs.

## How to Reproduce

1. Clone the repository.
2. Compile and run `bug.fs`. Observe that the output is not the expected sum of 30. The output is 20 for `result` and 30 20 for `x` and `y` due to the mutation.

## Solution

The solution involves removing mutable variables from the function and using immutable values and return values, ensuring the function's behavior is predictable and has no unexpected side effects.  The `bugSolution.fs` file demonstrates the corrected code.