// See https://aka.ms/new-console-template for more information

/*
 * Skriva ut data
 */
WebsiteGenerator website = new WebsiteGenerator();

website.printPage();


class WebsiteGenerator
{
    /*
     * Data ifrån API
     */
    public string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };
    public string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };

    string className = "Klass A";
    string kurser = "";

    public void printStart()
    {
        string start = "<!DOCTYPE html>\n<html>\n<body>\n<main>\n";
        Console.WriteLine(start);
    }
    public void printWelcome(string className, string[] message)
    {
        string welcome = $"<h1> Välkomna {className}! </h1>";

        string welcomeMessage = "";

        foreach (string msg in message)
        {
            welcomeMessage += $"\n<p><b> Meddelande: </b> {msg} </p>";
        }

        Console.WriteLine(welcome + welcomeMessage);
    }
    public void printKurser()
    {
        string kurser = courseGenerator(this.techniques);
        Console.WriteLine(kurser);
    }
    public void printEnd()
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
    public string courseGenerator(string[] techniques)
    {

        foreach (string technique in techniques)
        {
            string tmp = technique.Trim();
            kurser += "<p>" + tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower() + "</p>\n";
        }

        return kurser;
    }
}