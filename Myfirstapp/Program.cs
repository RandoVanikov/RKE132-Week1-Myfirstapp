//rakendus küsin kasutajalt tema nime   
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //output 
//string - sõne
string userName = Console.ReadLine(); // input

//Console.WriteLine("Hello, " + userName + "!"); //output
//string interpolation is a bit harder but better 

Console.WriteLine($"Hello, {userName}!"); // output