# 🚀 Algorithm Problem Solving

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![SPOJ](https://img.shields.io/badge/SPOJ-000000?style=for-the-badge&logo=spoj&logoColor=white)](https://www.spoj.com/)
[![LeetCode](https://img.shields.io/badge/LeetCode-FFA116?style=for-the-badge&logo=LeetCode&logoColor=black)](https://leetcode.com/)

## 📝 About

This repository contains my solutions to various programming challenges from platforms like SPOJ and LeetCode, implemented in C#. Each solution includes:
- A link to the original problem
- A problem description
- A detailed explanation of the implemented solution
- Source code in C#
- Time and space complexity analysis

## 🗂️ Repository Structure

```
├── src/
│   ├── CodingChallenges.LeetCode/          # LeetCode solutions
│   │   ├── Easy/
│   │   │   └── [ProblemName]/
│   │   │       ├── Solution.cs             # Solution implementation
│   │   │       └── README.md               # Problem description and explanation
│   │   ├── Medium/
│   │   └── Hard/
│   │
│   └── CodingChallenges.SPOJ/              # SPOJ solutions
│       ├── Easy/
│       ├── Medium/
│       └── Hard/
│
├── CodingChallenges.sln                    # Solution file
├── Directory.Build.props                   # Common properties for all projects
├── .gitignore
└── README.md
```

## 🎯 Progress

| Platform | 🟢 Easy | 🟡 Medium | 🔴 Hard | Total |
|:---------|:-------:|:---------:|:-------:|:-----:|
| ![SPOJ](https://img.shields.io/badge/SPOJ-000000?style=flat-square&logo=spoj&logoColor=white) | 0 | 0 | 0 | 0 |
| ![LeetCode](https://img.shields.io/badge/LeetCode-FFA116?style=flat-square&logo=leetcode&logoColor=white) | 4 | 0 | 0 | 4 |
| **Total** | 4 | 0 | 0 | 4 |

## 💻 How to Run Solutions

1. Clone the repository:
```bash
git clone https://github.com/adrianmazur-dev/coding-challenges.git
```
2. Open the project in Visual Studio or any other C# compatible IDE.
3. Select the solution you're interested in and run it at Console project.

## 🧪 How to Test Solutions (PS)

1. Choose a challenge and test it with the following command in the test project:
```bash
dotnet test --filter ...
```
2. Example for "219. Contains Duplicates II" from LeetCode:
```bash
..\src\CodingChallenges.LeetCode.Tests> dotnet test --filter FullyQualifiedName~CodingChallenges.LeetCode.Tests.Easy._219.SolutionTests
```