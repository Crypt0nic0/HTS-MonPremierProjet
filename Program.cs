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

//======= EXERCICE 1 ====== affectation variable
//Console.WriteLine("Veuillez saisir votre nom : ");
//string nomUser = Console.ReadLine();
//Console.WriteLine("Bonjour " + nomUser);


// Soom sur les types textuels
char copyright = '\u00A9';
Console.WriteLine(copyright);

// Le @ permet de définir les " et \ en tant que texte
string cheminWindowsSimple = @"C:\docs\fichier.txt";


//======== EXERCICE 2 ========
Console.WriteLine("Saisir un nom : ");
nom = Console.ReadLine();
Console.WriteLine("Saisir un âge : ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Bonjour {nom}, vous avez {age} ans.");
