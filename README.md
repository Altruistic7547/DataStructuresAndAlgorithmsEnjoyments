# DSAEnjoyment Solution

This solution is designed to explore and enjoy a variety of Data Structures and Algorithms (DSA). 

The intension of this project is to explore all the data structures and algorithms in a way that ensures i follow best practices and one stop for all my DSA enjoyments. 

To enjoy furthermore, I have written unit test cases for developed data structures and algorithms. 

## Solution contnet

This solution contains two main projects:

1. **DSAEnjoyment**: A console application that demonstrates various data structures and algorithms.
2. **DSAEnjoyment.UnitTest**: Unit tests to validate and explore the implementations in `DSAEnjoyment`.

## Projects Overview

### 1. DSAEnjoyment

This project is a console application that implements a wide variety of fundamental data structures and algorithms. The goal is to explore these topics in an interactive way by running various examples, providing implementations, and observing their behaviors. The following features are included in this project:

#### Data Structures Implemented:
- **StackLinkedList**
- **StackArray**
- **QueueLinkedList**
- **SingleLinkedList**
- **DoubleLinkedList**
- **HashTableBinarySearch**
- **HashTableLinearProbing**
- **HashTableSepChaining**
- **HashTableBinarySearch**
- **StackKV**
- **BinarySearchTreeKeyValue**
- **RedBlackBST**
- **BST**

#### Algorithms Implemented:
- **TimSort**
- **ShellSort**
- **SelectionSort**
- **RadixSort**
- **DualPivotQuickSort**
- **QuickSortBentleyMclroy**
- **QuickSortHoare**
- **QuickSortLomuto**
- **QuickSortPartition3Way**
- **ThreePivotPartition**
- **MergeSort**
- **InsertionSort**
- **HeapSort**
- **CountingSort**
- **CombSort**
- **CocktailSort**
- **BucketSort**
- **BubbleSort**
- **BitonicSort**
- **Fibonacci**
- **Knapsack**
- **EggDropProblem**

#### Searching Algorithms:
- **BinarySearch**
- **LinearSearch**
- **SequentialSearch**
- **SearchBruteForce**
- **SearchSubstringKMP**
- **SearchSubstringRabinKarp**

#### Other Utilities:
- **Factorial**
- **GreatestCommonDenominator**
- **PerfectNumber**
- **FindPrimeNumbers**

#### Linked List Utilities:
- **BreakCycleLinkedList**
- **CheckLinkedListIsPalindrome**
- **DetectCycleInLinkedList**
- **DetectCycleStartNode**

#### Miscellaneous:
- **KeyValuePair**
- **RadixSort_2D_Array**
- **Node**
- **DNode**
- **Direction**
- **TraversalMethod**

### 2. DSAEnjoyment.UnitTest

This project contains unit tests written to validate the functionality and correctness of the various data structures and algorithms in the `DSAEnjoyment` console app. 

The goal is to ensure that each data structure and algorithm **works as expected, handling edge cases** and verifying expected outcomes.

The unit tests are implemented using **MSTest** and aim to cover as many aspects of the functionalities as possible.
- Correctness of basic operations 
- Performance with larger datasets
- Edge cases

## How to really enjoy this repository

1. **Run the Console App (DSAEnjoyment)**:
   - Open the solution in Visual Studio or a compatible IDE.
   - Set `DSAEnjoyment` as the startup project.
   - Run the project to see the various algorithms and data structures in action.

You can explore and enjoy all given data structure and algorithms in their own `Main` method and for result exploration, call that main method in `Program.cs`.



2. **Run Unit Tests (DSAEnjoyment.UnitTest)**:
   - Open the solution in Visual Studio or a compatible IDE.
   - Set `DSAEnjoyment.UnitTest` as the startup project.
   - Use the test explorer or run the tests from the command line to ensure everything works correctly.

### Example Usage

#### Console App Example

In the `DSAEnjoyment` console app, running the program will demonstrate various algorithms and data structures in action. For example, you will see operations like adding and removing elements from stacks and queues, sorting arrays using different sorting algorithms, and performing search operations on arrays.

#### Unit Test Example

In the `DSAEnjoyment.UnitTest` project, unit tests for algorithms like sorting, searching, and data structures like stacks and hash tables are written. Here's an example of how a unit test for a sorting algorithm might look:

```csharp
[TestMethod]
public void TestBubbleSort()
{
    var input = new int[] { 5, 2, 9, 1, 5, 6 };
    var expected = new int[] { 1, 2, 5, 5, 6, 9 };
    
    var result = SortingAlgorithms.BubbleSort(input);
    
    CollectionAssert.AreEqual(expected, result);
}
