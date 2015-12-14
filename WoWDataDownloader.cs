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
        /// <summary>
        /// Klucz użytkownika do API Battle.NET
        /// </summary>
        private String apiKey;
        /// <summary>
        /// Klient do pobierania danych z http
        /// </summary>
        private WebClient webClient;

        /// <summary>
        /// Konstruktor klasy.
        /// </summary>
        /// <param name="apiKey">Klucz użytkownika do API Batte.NET</param>
        public WoWDataDownloader(String apiKey)
        {
            this.apiKey = apiKey;
            webClient = new WebClient();
        }

        /// <summary>
        /// Funkcja zwracająca wybrane dane z API Battle.NET.
        /// </summary>
        /// <param name="section">Dział danych z którego chcemy pobrać dane (np. 'guild', 'character')</param>
        /// <param name="type">Typ danych z działu (np. 'items')</param>
        /// <param name="realm">Nazwa serwera</param>
        /// <param name="name">Nazwa własna (np. postaci, gildii, przedmiotu)</param>
        /// <returns></returns>
        private String getInfo(String section, String type, String realm, String name)
        {
            return getData("https://eu.api.battle.net/wow/"+ section + "/" + realm + "/" + name + "?fields=" + type + "&locale=pl_PL&apikey=" + apiKey);
        }
        

        /// <summary>
        /// Metoda zwracająca dane na temat gildii z danego serwera.
        /// </summary>
        /// <param name="type">Typ danych (np. members)</param>
        /// <param name="realm">Nazwa serwera</param>
        /// <param name="guildName">Nazwa gildii</param>
        /// <returns>Dane na temat gildii w postaci jsona</returns>
        public String getGuildInfo(String type, String realm, String guildName)
        {
            return getInfo("guild", type, realm, guildName);
        }

        /// <summary>
        /// Metoda zwracająca dane na temat postaci z danego serwera.
        /// </summary>
        /// <param name="type">Typ danych (np. items)</param>
        /// <param name="realm">Nazwa serwera</param>
        /// <param name="characterName">Nazwa postaci</param>
        /// <returns></returns>
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
