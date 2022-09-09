// See https://aka.ms/new-console-template for more information

/*
 * Data ifrån API
 */
string[] techniques = { "C#", "Databaser", "Webb", "Clean Code" };

/*
 * Statisk data
 */
string start = "<!DOCTYPE html>\n<html>\n<body>\n<main>\n";
string welcome = "<h1> Välkomna! </h1>\n";
string kurser = "";

foreach (string technique in techniques)
{
    kurser += "<p>" + technique + "</p>\n";
}

string end = "</main>\n</body>\n</html>";

/*
 * Skriva ut data
 */

Console.WriteLine($"{start}{welcome}{kurser}{end}");