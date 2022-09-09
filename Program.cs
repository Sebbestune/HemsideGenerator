// See https://aka.ms/new-console-template for more information

/*
 * Data ifrån API
 */
string[] techniques = {"   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   "};

/*
 * Statisk data
 */
string start = "<!DOCTYPE html>\n<html>\n<body>\n<main>\n";
string welcome = "<h1> Välkomna! </h1>\n";
string kurser = courseGenerator(techniques);
string end = "</main>\n</body>\n</html>";

printPage();

/*
 * Skriva ut data
 */

void printStart()
{
    Console.WriteLine(start);
}
void printWelcome()
{
    Console.WriteLine(welcome);
}
void printKurser()
{
    Console.WriteLine(kurser);
}
void printEnd()
{
    Console.WriteLine(end);
}


void printPage()
{
    printStart();
    printWelcome();
    printKurser();
    printEnd(); 
}


string courseGenerator(string[] techniques)
{
    string kurser = "";

    foreach (string technique in techniques)
    {
        string tmp = technique.Trim();
        kurser += "<p>" + tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower() + "</p>\n";
    }

    return kurser;
}