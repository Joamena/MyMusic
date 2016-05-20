using System;
using System.Windows.Forms;

namespace twitterPruebas
{
    public class PublicarTwetter
    {
        private readonly OAuthInfo _oauth;

        public PublicarTwetter()
        {
            _oauth = new OAuthInfo
            {
                AccessToken = "722419719362338816-kndw2f5UZDW8ZevTygrI7o5toRmaK24",
                AccessSecret = "5csFJywnlDZqBB7l1REXntpAE1fcHDn9cwZLE57RsJpSH",
                ConsumerKey = "xI3ASM3An2j3SVFwgUUrJuIxj",
                ConsumerSecret = "BcTgiE43wJy8BERLYjy3H6nO7OnsfJlKH39VjnQHsPkZH19Ryq"
            };
        }

        public bool PublicarTweet(string strMensaje)
        {
            var twitter = new MetodosTwitter(_oauth);
            //twitter no acepta repitición de mensajes
            try
            {
                twitter.UpdateStatus(strMensaje);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
            }
        }

        public bool CountHashtag(string strMensaje)
        {
            var twitter = new MetodosTwitter(_oauth);
            try
            {
                twitter.GetMentions();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
            }
        }
    }
}
