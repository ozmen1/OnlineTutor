namespace OnlineTutor.Core
{
    public class Jobs
    {
        public static string InitUrl(string url)
        {

            #region SorunluKarakterler
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");
            #endregion

            #region KucukHarfeCevirme
            url = url.ToLower();
            #endregion

            #region TurkceKarakterlerDonusturme
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion

            #region BosluklarTireyeCevirme
            url = url.Replace(" ", "-");
            #endregion

            #region SorunluKarakterlerKaldiriliyor
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");
            #endregion

            return url;
        }
    }
}