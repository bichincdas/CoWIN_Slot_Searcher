using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CoWIN_Slot_Searcher
{
    public static class TelegramNotifier
    {
        /// <summary>
        /// Telegram url
        /// </summary>
        const string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";

        /// <summary>
        /// Bot api token
        /// </summary>
        const string apiToken = "1868212792:AAEOQZdP_AtKvOcfuueZpT0ulXud3UbWDME";

        /// <summary>
        /// Group id
        /// </summary>
        const  string chatId = "@cowin_slots_bcd";

        /// <summary>
        /// Sends the telegram message to group
        /// </summary>
        /// <param name="message"></param>
        public static void SendTelegramMessage(string message)
        {
            try
            {
                string url = String.Format(urlString, apiToken, chatId, message);
                WebRequest request = WebRequest.Create(url);
                request.Timeout = 1000 * 5;
                WebResponse response = request.GetResponse();
                response.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
