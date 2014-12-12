using System;
using System.Collections.Generic;
namespace Static_Members_and_Namespaces
{

    class loadHTMLDispatcher
    {
        public static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddAttribute("metod", "adds");
            div.AddContent("<p>Hello</p>");
            div.AddContent("<p>SoftUni</p>");
            div.AddContent("<p>Homework OOP2!</p>");
            Console.WriteLine(div*2);
            Console.WriteLine();
            Console.WriteLine(HTMLDispatcher.CreateImage(@"\temp\homework\img.jpg","test","img"));
            Console.WriteLine(HTMLDispatcher.CreateURL("http://www.w3schools.com/", "w3school", "w3school"));
            Console.WriteLine(HTMLDispatcher.CreateInput("Submit","OK","submit"));
            //div.AddContent("<p>Mika</p>");
            //Console.WriteLine(div.ToString());
        }
    }
    class ElementBuilder
    {
        private string elementName;
        private Dictionary<string, string> attDict = new Dictionary<string, string>();
        private List<String> contList = new List<string>();

        public ElementBuilder(string elementName = null)
        {
            this.elementName = elementName;
        }

        public void AddAttribute(string att, string value)
        {
            attDict.Add(att, value);
        }

        public void AddContent(string cont)
        {
            contList.Add(cont);
        }

        public override string ToString()
        {
            string res = String.Format("<{0} ", elementName);
            int i = 1;
            foreach (var att in attDict)
            {
                if (i == 1)
                {
                    res += String.Format("{0}=\"{1}\"\n", att.Key, att.Value);
                }
                else if (i == attDict.Count)
                {
                    res += String.Format("{0}=\"{1}\"", att.Key, att.Value);
                }
                else
                {
                    res += String.Format("{0}=\"{1}\" ", att.Key, att.Value);
                }

                i++;
            }
            if (contList.Capacity != 0)
            {
                res += ">";
                foreach (var c in contList)
                {
                    res += String.Format("{0}", c);
                }

                res += String.Format("</{0}>", elementName);
            }
            else
            {

                res += String.Format("></{0}>", elementName);
            }

            return res;
        }

        public static string operator *(ElementBuilder element,int count){

            string res = "";
            for (int i = 0; i < count; i++)
            {
                res += element.ToString();
            }

            return res;
        }
    }

    static class HTMLDispatcher {

        public static string CreateImage(string imgSrc, string alt, string title
            )
        {
            //<img src="smiley.gif" alt="Smiley face" height="42" width="42">
            ElementBuilder image = new ElementBuilder("img");
            image.AddAttribute("src", imgSrc);
            image.AddAttribute("alt", alt);
            image.AddContent(title);
            return image.ToString().Replace("\n","");
        }

        public static string CreateURL(string url, string title, string text) {
            //<a href="http://www.w3schools.com">Visit W3Schools.com!</a>
            ElementBuilder href = new ElementBuilder("a");
            href.AddAttribute("href", url);
            href.AddAttribute("title", title);
            href.AddContent(text);
            return href.ToString().Replace("\n", " ");
        }

        public static string CreateInput(string inpType, string name, string value){
            // <input type="submit" value="Submit">
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("type", inpType);
            input.AddAttribute("value", value);
            input.AddContent(name);

            return input.ToString().Replace("\n", " ");
        }
    }


}