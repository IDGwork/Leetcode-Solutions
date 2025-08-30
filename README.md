# Leetcode-Solutions

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)
![Language](https://img.shields.io/badge/Language-C%23-green)
![Platform](https://img.shields.io/badge/IDE-Rider%20%7C%20VS%20Code%20%7C%20Visual%20Studio-orange)
![GitHub Repo stars](https://img.shields.io/github/stars/IDGwork/Leetcode-Solutions?style=social)

A .NET 8.0 Console Application containing my **C# solutions for LeetCode problems**, neatly organized by topic.  
Each problem is placed in a topic-specific folder (`ProblemName - Leetcode <Number>`) and contains a single `Solution.cs` file with a class named `Solution<Number>`.  
The structure ensures consistency, clarity, and quick testing in Rider or Visual Studio.

---

## 📦 What it does

- Stores **topic-based solutions**:
    - Arrays & Hashing
    - Dynamic Programming (1D & 2D)
    - Graphs & Advanced Graphs
    - Backtracking, Greedy, Tries, etc.
- Each problem solution:
    - Lives in its own folder: `ProblemName - Leetcode <Number>/Solution.cs`
    - Namespace reflects topic and problem name
    - Class is always `Solution<Number>`
    - Ends with a reusable **Algorithm template**:

```csharp
//Algorithm:

//Approach - Problem-specific description

//Step 1 - Initialisation:
//    Base case setup
//Step 2 - Core logic (e.g., Fill dp table, Traverse graph)
//Step 3 - Return:
//    Return final computed result

//Time: O(n).
//Space: O(n).
```

- `.gitignore` keeps repo clean (ignores `bin/`, `obj/`, IDE metadata).

---

## 🗂 Project structure

```
Leetcode-Solutions/
├─ 1D Dynamic Programming/
│  ├─ Climbing Stairs - Leetcode 70/
│  │   └─ Solution.cs
│  ├─ Min Cost Climbing Stairs - Leetcode 746/
│  │   └─ Solution.cs
│  └─ …
├─ 2D Dynamic Programming/
├─ Advanced Graphs/
├─ Arrays & Hashing/
├─ Backtracking/
├─ Binary Search/
├─ Bit Manipulation/
├─ Graphs/
├─ Greedy/
├─ Heap & Priority Queue/
├─ Intervals/
├─ Linked List/
├─ Math & Geometry/
├─ Sliding Window/
├─ Stack/
├─ Trees/
├─ Tries/
├─ Two Pointers/
├─ Program.cs
├─ Leetcode-Solutions.csproj
└─ .gitignore
```

> Note: `.gitkeep` files are included so empty topic folders remain visible on GitHub until solutions are added.

---

## ✅ Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download)
- Rider / Visual Studio / VS Code
- Git for version control

---

## ▶️ Run

From the project root:

```bash
dotnet build
dotnet run
```

To test a specific problem:

1. Open `Program.cs`
2. Call the class and method of the solution you want to run:

```csharp
using Leetcode_Solutions._1D_Dynamic_Programming.Climbing_Stairs___Leetcode_70;

var solver = new Solution70();
Console.WriteLine(solver.ClimbStairs(5)); // Output: 8
```

---

## 📌 Topics

- Arrays & Hashing
- Two Pointers
- Sliding Window
- Stack
- Binary Search
- Linked List
- Trees
- Heap & Priority Queue
- Backtracking
- Tries
- Graphs & Advanced Graphs
- 1D / 2D Dynamic Programming
- Greedy
- Intervals
- Math & Geometry
- Bit Manipulation

---

## 🧪 Tests

⚠️ No unit tests yet, but the project supports adding them.  
Future plan:
- Add `Leetcode-Solutions.Tests/`
- Use `xUnit` for problem-level testing
- Automate test runs with GitHub Actions

---

## 💡 Notes

- Solutions follow clean C# conventions and structured namespaces
- Repository organized for interview prep and long-term practice
- Algorithm templates make problem-solving **consistent across topics**
- Can be extended with multi-language support (e.g., Python) if needed

---

## 📄 License

For educational and interview preparation purposes.
