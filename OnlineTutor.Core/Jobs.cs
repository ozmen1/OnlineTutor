using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
        public static string UploadImage(IFormFile image)
        {
            var extension = Path.GetExtension(image.FileName);
            var randomName = $"{Guid.NewGuid()}{extension}";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", randomName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return randomName;
        }

        public static string CreateMessage(string title, string message, string alertType)
        {
            var msg = new AlertMessage
            {
                Title = title,
                Message = message,
                AlertType = alertType
            };
            return JsonConvert.SerializeObject(msg);
        }
    }
}