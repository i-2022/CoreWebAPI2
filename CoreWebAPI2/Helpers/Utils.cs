namespace CoreWebAPI2.Helpers
{
    public class Utils
    {

        public static string RemoveHTMLTagsCharArray(string html)
        {
            html = html.ToString().Replace("&nbsp;", " ").Replace("<p><br></p>", "").Replace("<p>", "").Replace("</p>", " ").Replace("\n", " ").Replace("\r", " ").Trim();
            while (html.Contains("  ")) html = html.Replace("  ", " ");

            char[] charArray = new char[html.Length];
            int index = 0;
            bool isInside = false;

            for (int i = 0; i < html.Length; i++)
            {
                char left = html[i];

                if (left == '<')
                {
                    isInside = true;
                    continue;
                }

                if (left == '>')
                {
                    isInside = false;
                    continue;
                }

                if (!isInside)
                {
                    charArray[index] = left;
                    index++;
                }
            }

            return new string(charArray, 0, index);
        }
        public static int CountWords(string str)
        {
            int l = 0;
            int wrd = 1;

            while (l <= str.Length - 1)
            {
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }
                l++;
            }

            return wrd;

        }
    }

}
