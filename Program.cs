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
//Console.WriteLine("Saisir un nom : ");
//nom = Console.ReadLine();
//Console.WriteLine("Saisir un âge : ");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Bonjour {nom}, vous avez {age} ans.");


//======== EXERCICE 3 ========
// int a = 9;
// int b = 2;
// Console.WriteLine(a + b);
// Console.WriteLine(a - b);
// Console.WriteLine(a * b);
// Console.WriteLine(a / b);
// Console.WriteLine(a % b);

//======== EXERCICE 4 ========
//Console.WriteLine("Saisir un nom : ");
//nom = Console.ReadLine();
//Console.WriteLine("Saisir un âge : ");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Bonjour " + nom + ", vous avez " + age + " ans.");

//======== EXERCICE 5 ========
// Console.WriteLine("Saisir un nom : ");
// nom = Console.ReadLine();
// Console.WriteLine("Saisir un âge : ");
// age = int.Parse(Console.ReadLine());
// Console.WriteLine($"Bonjour {nom}, vous avez {age} ans.");

//======== EXERCICE 6 ========
// Console.WriteLine("Saisir un nom : ");
// nom = Console.ReadLine();
// Console.WriteLine("Saisir un âge : ");
// age = int.Parse(Console.ReadLine());
// Console.WriteLine($"Bonjour {nom}, vous avez {age} ans.");
// if (age >= 18)
// {
//     Console.WriteLine("Vous êtes majeur");
// }
// else
// {
//     Console.WriteLine("Vous êtes mineur");
// }


//======== EXERCICE 6 ========
// BOUCLE FOR

// Console.WriteLine("Bonjour, vous allez saisir 3 nombres qui seront stockés dans un tableau puis affichés");
// int[] tabNB = new int[3];
// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Saisir le nombre qui sera stocké en position {i} : ");
//     tabNB[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Merci pour votre saisie, voici les 3 nombres saisis : ");
// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine(tabNB[i]);
// }


