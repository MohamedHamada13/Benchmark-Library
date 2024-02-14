=> Discription of Files: "Program.cs" file have the code to run the Benchmark Class, and the "BenchmarkClass.cs" file have the Benchmark Class that includes the methods to be measured.

=> How to use Benchmark Library:
1- write click on solution → click on “manageNuGet Package for solution”.
2- click on browse → search for BenchmarkDotNet and install it.
3- Build a new class To use it for measuring Methods {Click right on your Project in solution explorer, and select add → Class}.
4- Write Your Methods in the new class prefixed with the line "[Benchmark]", To Point the methods that will be measured.
5- in the start of the new class, write the line "[MemoryDiagnoser(false)]" To make sure that the allocated column will appear in table.
6- do not Forget to use the Benchmark attribute like "using BenchmarkDotNet.Attributes;" To can use the Attributes of Benchmark library like [Benchmark], and [MemoryDiagnoser(false)].
7- Now you can run the Benchmark class by the Runner line "BenchmarkRunner.Run<BenchmarkClass>();", and do not forget to write the line "using BenchmarkDotNet.Running;" To can usr runner line.
8- at last you should change the mode from "Debug" to "Release", and run the code using 'start without debuging' button.

=> Link of Special Article: { https://www.linkedin.com/posts/sara-omran-338463220_benchmarkdotnet-library-activity-7162831456979865600-QSWX/?utm_source=share&utm_medium=member_android }
