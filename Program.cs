// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("J'apprend le C# !");

// Différents types de variables
int age = 33;
string nom = "Nicolas";
bool estVivant = true;
Console.WriteLine("Utilisateur : " + nom);
Console.WriteLine("Age : " + age);
Console.WriteLine((estVivant) ? "Utilisateur vivant" : "Utilisateur HS");

// Exercice affectation variable
Console.WriteLine("Veuillez saisir votre nom : ");
string nomUser = Console.ReadLine();
Console.WriteLine("Bonjour " + nomUser);


// Soom sur les types textuels
char copyright = '\u00A9';
Console.WriteLine(copyright);