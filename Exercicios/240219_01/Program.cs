﻿using System.Reflection.Metadata;

string message1 = null;

string message2 = null;

string message3 = System.String.Empty;

var message4 = "Mensagem qualquer ";

Console.WriteLine(message4);

string concat  = (message1 == null ? "" : message1) + "" +  message2  + " "+  message3 + " " +  message4;

Console.WriteLine("\n" + concat);

Console.WriteLine("A Temperatura de hoje {0: D} é {1}°C", DateTime.Now, 23);

string name = string.Empty;

Console.WriteLine("Qual é o seu nome? ");
name = Console.ReadLine();
string resultado = $"Oi, {name} ! Pare de malandragem !";
Console.WriteLine(resultado);

//Lucas é um estudante de computação.

// substituindo conteúdo de strings

string nomeCompleto = "LucasMorais";
nomeCompleto  = nomeCompleto.Replace("Morais", "king");
Console.WriteLine(nomeCompleto);

bool isNomeEqual1 = (nomeCompleto == "Lucas Morais" );

bool isNomeEqual2 = (nomeCompleto == "Lucas Morais"); 

string.Equals(nomeCompleto, "Lucas King");

Console.WriteLine(nomeCompleto);

