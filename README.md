# REIZ TECH HOMEWORK ASSIGNMENT FOR THE .NET DEVELOPER INTERN POSITION
Were The Odds in My Favour?
To help them get to know me better, they have created a small task to see how I approach objectives and they will use this as a discussion point going forward.

<br>

## 🧰 How It's Made
I was not familiar with C#. Not anymore.
I had to learn C# basics for me to finish this task.
**Clock Angle Calculator** — Good thing I knew how to convert clock hand position into an angle.
**Tree Exercise** — Challenging. The document says the structure has a depth of 5. I believe it is 4. A lot of trials and errors. Object manipulation is way easier in JavaScript. Started by creating the given structure without additional Class members. Then time to find the depth of the structure. 💀💀💀.
This [stackoverflow thread](https://stackoverflow.com/questions/43119860/finding-non-binary-tree-depth) saved me. The solution required some extra Class members so I created another console app that resembles the Class but still follows the requirement on how to create the Branch object. Had to change the parameter on depth calculation because I really think the depth is 4.

<br>

## 🛠 Optimizations
Before I started coding in C#, I installed SDK 7.0 (.NET Runtime 7.0.5, ASP.NET Core Runtime 7.0.5
, .NET Desktop Runtime 7.0.5) but I only used Visual Studio Code. Based on the videos I watched, Visual Studio Community could have made C# coding faster and somehow easier.
The console apps could have been web apps or desktop apps.
I also tried not including the boiler plate code (using System, namespace, class Program, even the static void Main). It can compile even if the Program.cs file only contains a Console.WriteLine("") but I still included the boiler plate code because why not.

<br>

## 📚 Lessons Learned
#### .NET History, Background

.NET Framework => .NET Core => .NET 5, 6, 7.
Framework was the old Windows-only implementation. Core is the newer multi-platform implementation. NET 7 is the current version, it's pretty much a rename of .NET Core with the goal to unify .NET Framework and .NET Core even more.
I read that [here](https://www.reddit.com/r/csharp/comments/n077sm/whats_the_difference_between_net_asp_net_net_core/)

<br>

#### Stack, Heap

I read stack before from JavaScript's Event Loop. But this time, it now works with something new for me — the heap. I just know the basic memory allocation stuff. Reference types always go on the heap. Value types usually go to the stack — but what I'm reading says they always go where they were declared. A bit complex, and like Pointers, I still haven't dived that deep yet.

<br>

#### I still have a lot to learn

C# is intimidating. My first programming language was Python, then because of a web dev program, I switched to JavaScript. I felt okay with these two even though I was just new in learning how to code. But now, even as an intermediate coder, C# is making me confused. :)