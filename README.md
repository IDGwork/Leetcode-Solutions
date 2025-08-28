# Leetcode-Solutions

A .NET 8.0 Console Application containing my **C# solutions for LeetCode problems**, neatly organized by topic.  
Each problem is placed in a topic-specific folder and can be run via `Program.cs`.  
The structure is designed for clarity, easy navigation, and quick testing inside Rider or Visual Studio.

---

## 📦 What it does

- Stores **topic-based solutions**:
    - Arrays & Hashing
    - Dynamic Programming (1D & 2D)
    - Graphs & Advanced Graphs
    - Backtracking, Greedy, Tries, etc.
- Each folder contains problem solutions named:  
  `ProblemName - Leetcode <Number>.cs`
- `Program.cs` acts as the entry point for testing
- `.gitignore` ensures clean version control (ignores `bin/`, `obj/`, IDE files)

---

## 🗂 Project structure

Leetcode-Solutions/  
├─ 1D Dynamic Programming/  
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

> Note: `.gitkeep` files are used in empty topic folders so GitHub displays them until real solutions are added.

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

To test a specific problem:
	•	Open Program.cs
	•	Call the class and method of the solution you want to run:

var solver = new Solution1();
var result = solver.TwoSum(new[] {2,7,11,15}, 9);
Console.WriteLine($"[{string.Join(", ", result)}]");



⸻

📌 Topics
	•	Arrays & Hashing
	•	Two Pointers
	•	Sliding Window
	•	Stack
	•	Binary Search
	•	Linked List
	•	Trees
	•	Heap & Priority Queue
	•	Backtracking
	•	Tries
	•	Graphs & Advanced Graphs
	•	1D / 2D Dynamic Programming
	•	Greedy
	•	Intervals
	•	Math & Geometry
	•	Bit Manipulation

⸻

🧪 Tests

⚠️ No unit tests yet, but the project supports adding them.
Future plan:
	•	Add Leetcode-Solutions.Tests/
	•	Use xUnit for problem-level testing
	•	Automate test runs with GitHub Actions

⸻

💡 Notes
	•	Solutions follow clean C# conventions and structured namespaces
	•	Repository organized for interview prep and long-term practice
	•	Can be extended with multi-language support (e.g., Python) if needed

⸻

📄 License

For educational and interview preparation purposes.