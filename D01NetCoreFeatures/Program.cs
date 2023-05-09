// See https://aka.ms/new-console-template for more information
using D04TestingLibrary;
using System.Net;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //main differences between .net core and .net framework are

        // 1) cross - platform not only windows but also linux, macos, phone, tablet
        // 2) open-source
        // 3) modularity


        //WeatherManager weatherMenager = new WeatherManager();
        //double temp = weatherMenager.GetTemperature("warsaw");


        //regex101 - page for regular expressions

        WebClient webClient = new WebClient();

        string url = "https://www.google.com/search?q=weather+";
        string city = "warsaw";
        string text = webClient.DownloadString(url + city);

        File.WriteAllText("output.html", text);
        //Console.ReadKey();


        // dictionary: 

        //!-exclamation mark
        //@ - at sign

        //# - hash, pound, or octothorpe
        //$ - dollar sign
        //% - percent sign
        //^ - caret or circumflex
        //& - ampersand

        //* asterisk or star
        //( - left parenthesis or open parenthesis
        //) -right parenthesis or close parenthesis
        // - hyphen or minus
        // + plus sign
        // = - equals sign
        // , - comma
        // . - period or dot
        // / - forward slash or solidus
        // < - less-than sign
        // > greater-than sign
        // ; -semicolon
        // : -colon
        // [- left bracket or open bracket
        // ] - right bracket or close bracket
        // { - left brace or open brace
        // } - right brace or close brace
        // ` - backtick or grave accent
        // ? question mark.


        string pattern = "<div class=\"BNeawe iBp4i AP7Wnd\">(-{0,1}\\d{1,2}.{0,1}\\d{0,2}).C<\\/div>";

        Regex regex = new Regex(pattern);
        Match match = regex.Match(text);

        string resoult = match.Groups[1].Value;

        Console.WriteLine(resoult);


    }
}


//Console.WriteLine(temp);