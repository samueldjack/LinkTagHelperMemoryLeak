This repo contains code which demonstrates a memory leak involving LinkTagHelper in .Net 8.0 and 9.0.

The memory leak occurs in the following circumstances:
- The asp-append-version="true" tag is used on a <link/> element where the href points to a file which doesn't exist
- WebApplicationFactory is used to start and stop instances of the Web Application repeatedly.

# Running the example code
1. Pull the code
2. Open a terminal in the Tests folder of this project. Type `dotnet test`
3. Observe the memory usage of the process, which grows rapidly. After a couple of minutes the process will crash with an OutOfMemory Exception
4. Now change line 8 of Views/Home/Index.cshtml to remove the asp-append-version attribute
5. Run `dotnet test` again. This time the memory usage remains stable and the tests will eventually complete.
