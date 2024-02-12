using Microsoft.Extensions.Configuration;
using Minio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Utils
{
    public class Utils
    {
        public static byte[] ConvertStreamToByteArray(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        public static int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        public static async Task<string> GetImageURL(IConfiguration _configuration, string image)
        {
            if (_configuration["ImageSouce:config"] == "admin")
            {
                String url = _configuration["ImageSouce:url"] + image;
                return url;
            }
            else
            {
                var endPoint = _configuration["MinIo:endPoint"];
                var accessKey = _configuration["MinIo:accessKey"];
                var secretKey = _configuration["MinIo:secretKey"];
                var minio = new MinioClient(endPoint, accessKey, secretKey);
                String url = await minio.PresignedGetObjectAsync("savhome", image, 60 * 60 * 24);
                return url;
            }
        }
    }
}
