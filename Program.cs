// Data types for Unity

/*
 * Note, you do not need to specify 'var'
 * as this is inferred from the data that's assigned
 */

// --------------------
// Numeric
// --------------------

float f1 = 0.1f; // Initialise with f after the number to set as a float
var f2 = 2.5f;
float f3 = f1 + f2; // Add two values
Console.WriteLine(f3);

int i1 = 1;
var i2 = 2; // As it's an int, no need to specify anything after the number
Console.WriteLine(i1 + i2);

i2 = 6;
Console.WriteLine(i2++); // Print and then increment value, prints 6
i2 = 6;
Console.WriteLine(++i2); // Incremement then print value, prints 7

i2 = 2;
Console.WriteLine(MathF.Pow(i2, 3)); // 8, as it makes 3 to the power of 3

// Adding inline
i2 = 3;
i2 += 4; // total 7, same as writing i2 = i2 + 4
Console.WriteLine(i2);


// --------------------
// Strings
// --------------------

string s1 = "string a";
var s2 = "string b";

// to concatenate
Console.WriteLine(s1 + s2); // "string astring b"
Console.WriteLine($"{s1} {s2}"); // "string a string b"

// contantenation works with any data type that can be turned into a string
Console.WriteLine($"{s1} {i1} {f1}"); // string a 1 0.1

// --------------------
// Classes
// --------------------

// *NOTE*: this is very basic OOP, read documentation and guides on good OOP practices
// This is only for reference of using C#, not Unity.

// Getting the compomnent and using it
Mario mario = GetComponent<Mario>();

// Move player
mario.Position.x = 12f;
mario.Position.y = 0;

mario.Disable();
mario.Enable();

// ---------------------------------------------------------
// This is just for show, Unity uses MonoBehaviour which goes and gets the given component from the game object
static T GetComponent<T>() where T : class, new() => new();

class Vector
{
    public float x;
    public float y;
}

// Assuming this is a Mario script on the game object
class Mario
{
    public Vector Position { get; set; } = new Vector();
    public void Disable() { }
    public void Enable() { }

    public Mario()
    {
    }
}
// ---------------------------------------------------------
