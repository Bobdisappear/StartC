
Console.WriteLine("Hello, World!");

// variable

int i = 5;
long l = 32165161231;
double d = 12.34;
decimal de = 15.158612m;
char c = 'a';
string s ="cosas" ;
bool ok = true;

Console.WriteLine(d);

//Metodo vacio
EmptyMethod();  
void EmptyMethod()
{
    Console.WriteLine("Hello"); 
}

//Metodo numero 
int sum = Calculations(10, 25);
Console.WriteLine(sum);
int Calculations(int a , int b)
{
    return a + b;
}

//Metodo booleano
bool greater =IsItGreater(20);
Console.WriteLine(greater);
bool IsItGreater(int a)
{
    return a > 10;
}
