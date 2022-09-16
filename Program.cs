﻿// See https://aka.ms/new-console-template for more information

/*
 * Skriva ut data
 */

string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };
string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };

WebsiteGenerator website = new WebsiteGenerator("Klass A", messagesToClass, techniques);

website.printPage();


class WebsiteGenerator
{
    /*
     * Data ifrån API
     */

    string[] messagesToClass, techniques;
    string className;
    string kurser = "";

    public WebsiteGenerator(string className, string[] messageToClass, string[] techniques)
    {
        this.className = className;
        this.messagesToClass = messageToClass;
        this.techniques = techniques;
    }

    void printStart()
    {
        string start = "<!DOCTYPE html>\n<html>\n<body>\n<main>\n";
        Console.WriteLine(start);
    }
    void printWelcome(string className, string[] message)
    {
        string welcome = $"<h1> Välkomna {className}! </h1>";

        string welcomeMessage = "";

        foreach (string msg in message)
        {
            welcomeMessage += $"\n<p><b> Meddelande: </b> {msg} </p>";
        }

        Console.WriteLine(welcome + welcomeMessage);
    }
    void printKurser()
    {
        string kurser = courseGenerator(this.techniques);
        Console.WriteLine(kurser);
    }
    void printEnd()
    {
        string end = "</main>\n</body>\n</html>";
        Console.WriteLine(end);
    }

    public void printPage()
    {
        printStart();
        printWelcome(this.className, this.messagesToClass);
        printKurser();
        printEnd();
    }
    string courseGenerator(string[] techniques)
    {

        foreach (string technique in techniques)
        {
            string tmp = technique.Trim();
            kurser += "<p>" + tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower() + "</p>\n";
        }

        return kurser;
    }
}