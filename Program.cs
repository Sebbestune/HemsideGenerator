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
string kurser = "";

foreach (string technique in techniques)
{
    string tmp = technique.Trim();

    kurser += "<p>" + tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower() + "</p>\n";
}

string end = "</main>\n</body>\n</html>";

/*
 * Skriva ut data
 */

Console.WriteLine($"{start}{welcome}{kurser}{end}");