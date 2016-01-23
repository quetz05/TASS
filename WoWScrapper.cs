using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TASS
{
    class WoWScrapper
    {
        private static String GetHTMLSource(String address)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(address);
            }
        }


        public static String[] GetGuildNames(String address)
        {
            String[] delimeters = { "\r\n" };
            String[] source = GetHTMLSource(address).Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            List<String> list = new List<String>();

            //szukanie lini z nazwami gildii
            foreach (String line in source)
                if (line.Contains("data-hint=\"Guild &lt;"))
                    list.Add(line);

            //poprawka
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].Substring(list[i].IndexOf("Guild &lt;")+10);
                list[i] = list[i].Substring(0, list[i].IndexOf("&gt;&#"));
            }
            return list.ToArray();
        }
    }
}
