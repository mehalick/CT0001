# Bilbayt Code Tests

Please complete these tests by implementing various methods within this solution. Tests are complete when all xUnit and QUnit tests pass and you are happy with the code you've written.

HINT: You can run the xUnit tests from the command line within each project with the .NET CLI:

<pre>
dotnet test
</pre>

You can run the QUnit tests by loading the page in your web browser, the test results will display automatically.

HINT: To quickly find where you need to write code you can look for each TODO in Visual Studio's Task List or search the solution for "// TODO".

## C#

### 1. Palindrome

A palindrome is a word that reads the same backward or forward.

Write a function that checks if a given word is a palindrome. Character case should be ignored.

For example, IsPalindrome("Racecar") should return true as character case should be ignored, resulting in "racecar", which is a palindrome since it reads the same backward and forward.

<table>
    <thead>
        <tr>
            <th>Location</th>
            <th>Unit Tests</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Palindrome.Code/Program.cs</td>
            <td>Palindrome.Tests/Tests.cs</td>
        </tr>
    </tbody>
</table>

### 2. User Input 
 
User interface contains two types of user input controls: **TextInput**, which accepts all characters and **NumericInput**, which accepts only digits. 
 
Implement the class **TextInput** that contains: 
 
* Public method _void Add(char c)_ - adds the given character to the current value 
* Public method _string GetValue()_ - returns the current value 
 
Implement the class **NumericInput** that: 
 
* Inherits **TextInput** 
* Overrides the _Add_ method so that each non-numeric character is ignored 
 
For example, the following code should output "10": 
 
<pre> 
var input = new NumericInput(); 
input.Add('1'); 
input.Add('a'); 
input.Add('0'); 
 
Console.WriteLine(input.GetValue()); 
</pre>

<table>
    <thead>
        <tr>
            <th>Location</th>
            <th>Unit Tests</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>UserInput.Code/Program.cs</td>
            <td>UserInput.Tests/Tests.cs</td>
        </tr>
    </tbody>
</table>

## JavaScript

### 3. Date Formatting

Write a function that converts user entered date formatted as M/D/YYYY to a format required by an API (YYYYMMDD). The parameter "date" and the return value are strings.

For example, it should convert user entered date "12/31/2014" to "20141231" suitable for the API.

<table>
    <thead>
        <tr>
            <th>Location</th>
            <th>Unit Tests</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>DateFormatting.Code/Pages/Index.cshtml</td>
            <td>DateFormatting.Code/Pages/Index.cshtml</td>
        </tr>
    </tbody>
</table>
