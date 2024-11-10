/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

ChangeValue();

Console.WriteLine(x);

void ChangeValue() 
{
    x = 10;
}