using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //xor(2, 2);
            //Console.WriteLine("hello tarif!");
            string input1 = "The following text</C><B>is centered and in boldface</B></C>";
            CheckHtmlTag(input1);
            string input2 = @"<B>This <\g>is <B>boldface</B> in <<*> a</B> <\6> <<d>sentence";
            CheckHtmlTag(input2);
            string input3 = "<B><C> This should be centered and in boldface, but the tags are wrongly nested </B></C>";
            CheckHtmlTag(input3);
            string input4 = "<B>This should be in boldface, but there is an extra closing tag</B></C>";
            CheckHtmlTag(input4);
            string input5 = "<B><C>This should be centered and in boldface, but there is a missing closing tag</C>";
            CheckHtmlTag(input5);


        }
        static void CheckHtmlTag(string inputString)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(inputString);

            if (htmlDoc.ParseErrors.Count() > 0)
            {
                foreach (var error in htmlDoc.ParseErrors)
                {
                    // Prints: TagNotOpened
                    //Console.WriteLine(error.Code);
                    // Prints: Start tag <u> was not found
                    Console.WriteLine(error.Reason);
                }
            }
            else
            {
                Console.WriteLine("Correctly tagged paragraph");
            }
        }


    }
}