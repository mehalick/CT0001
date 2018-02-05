# User Input

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
