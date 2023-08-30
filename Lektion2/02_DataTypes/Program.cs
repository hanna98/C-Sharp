/*
    C# Standard datatyper som används
    --------------------------------------------------------------------------
  * string          till för text               string name = "Hanna";
  * int             till för heltal             int age = 24;
    long            till för heltal             long age = 24;
  * decimal         till för decimaltal         decimal length = 167.5;
    double          till för decimaltal         double length = 167.5;
    float           till för decimaltal         float length = 167.5;
  * bool            till för sant/falskt        bool isHuman = true;
    char            till för enskilt tecken     char gender = 'W';
    dynamic         kan innehålla vad som       dynamic lastName = "Marohn";
                                                dynamic weight = 105.0;
  * guid            globalt unikt id            guid id = Guid.NewGuid();
    byte                                        byte = 0; byte = 1;
  * null            är ingenting alls
    object









    Deklarera variabler i C#
    ------------------------------------------------------------------------------
    Hur skriver vi variabel namn:
    
    camelCase               firstName               string firtsName = "Hanna";
    Pascal                  FirstName               string FirtsName = "Hanna";
    kebab-case              first-name              string firts-name = "Hanna";
    snake_case              first_name              string firts_name = "Hanna";

    C# använder sig primärt av Pascal men även camelCase

    korrekt sätt att deklarera:             string firstName = "Hanna";
    latmanssättet att deklarera:            var firstName = "Hanna";
    
    
 */

/*
    String - textbaserade värden
    ----------------------------------------------------------------
    
    string firstName = "Hanna";
    var lastName = "Marohn";
 
    string firstName = "Hanna";
    var lastName = "Marohn";

    string sentence_1 = "Jag heter Hanna och börjar bli hungrig!!";
    string sentence_2 = "Jag heter Hanna och jag är \"bäst\"!!";

    string url_1 = "c:\\education\\cms23-csharp";
    string url_2 = @"c:\education\cms23-csharp";

    string placeholder_1 = "Hej, jag heter " + firstName + " " + lastName + ".";
    string placeholder_2 = $"Hej, jag heter {firstName} {lastName}.";                       //Bör köra mestadels nummer 2
    string placeholder_3 = string.Format("Hej, jag heter {0} {1}.", firstName, lastName);

*/

Console.WriteLine("Skriv in ditt förnamn: ");
string firstName = Console.ReadLine() ?? "";

Console.WriteLine("Skriv in ditt efternamn: ");
string lastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Hej {firstName} {lastName} :)");
Console.ReadKey();







