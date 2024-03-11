using System.IO.Pipes;
using System.Runtime.Serialization.Formatters;

string soma;
string subtraia;
string multiplica;
string divida;
string mensage1;

int digitos = 0;

mensage1 = "Qual tipo de conta quer faze-lo? ";


for(digitos = 1; digitos < 10; digitos ++){
    Console.WriteLine(digitos);
}

Console.WriteLine(mensage1);