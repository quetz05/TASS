using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TASS
{
    class WoWDataDownloader
    {
        private String apiKey;
        private WebClient webClient;

        /// <summary>
        /// Konstruktor klasy.
        /// </summary>
        /// <param name="apiKey">Klucz użytkownika do API batte.net</param>
        public WoWDataDownloader(String apiKey)
        {
            this.apiKey = apiKey;
            webClient = new WebClient();
        }


        private String getInfo(String section, String type, String realm, String name)
        {
            return getData("https://eu.api.battle.net/wow/"+ section + "/" + realm + "/" + name + "?fields=" + type + "&locale=pl_PL&apikey=" + apiKey);
        }
        

        /// <summary>
        /// Funkcja zwracająca dane na temat gildii z danego serwera.
        /// </summary>
        /// <param name="type">Nazwa danej (np. members)</param>
        /// <param name="realm">Nazwa serwera</param>
        /// <param name="guildName">Nazwa gildii</param>
        /// <returns>Dane na temat gildii w postaci jsona</returns>
        public String getGuildInfo(String type, String realm, String guildName)
        {
            return getInfo("guild", type, realm, guildName);
        }

        public String getCharacterInfo(String type, String realm, String characterName)
        {

            return getInfo("character", type, realm, characterName);
        }


        /// <summary>
        /// Funkcja zwracająca zawartość strony.
        /// </summary>
        /// <param name="html">Adres www strony z danymi</param>
        /// <returns>Zawartość strony</returns>
        private String getData(String html)
        {
            try
            {
                return webClient.DownloadString(html);
            }         
            catch(System.Net.WebException e)
            {
                return null;
            }
        }


    }
}
