﻿using System;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Minio;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class UploadController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ILogger<UploadController> _logger;
        public IConfiguration Configuration { get; }
        public UploadController(IWebHostEnvironment hostingEnvironment,
                              ILogger<UploadController> logger, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
            Configuration = configuration;
        }
        [HttpPost]
        public string ImgUpload(IFormFile file)
        {
            try
            {
                //string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                //filename = EnsureCorrectFilename(filename);
                var endPoint = Configuration["MinIo:endPoint"];
                var accessKey = Configuration["MinIo:accessKey"];
                var secretKey = Configuration["MinIo:secretKey"];
                var minio = new MinioClient(endPoint, accessKey, secretKey);
               
                FileInfo fileInfo = new FileInfo(file.FileName);
                string extn = fileInfo.Extension.ToLower();
                if (extn == ".png" || extn == ".jpeg" || extn == ".jpg")
                {
                    Guid id = Guid.NewGuid();
                    string filename = id.ToString() + extn;

                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "LLImages");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                    string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                    file.CopyTo(new FileStream(imagePath, FileMode.Create));
                    return "/LLImages/" + uniqueFileName;
                }
                else
                    return "invalid file format";


            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return "";
            }
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }

        [HttpGet]
        public async Task<string> GetImageUrl(string image)
        {
            var endPoint = Configuration["MinIo:endPoint"];
            var accessKey = Configuration["MinIo:accessKey"];
            var secretKey = Configuration["MinIo:secretKey"];
            var minio = new MinioClient(endPoint, accessKey, secretKey);
            String url = await minio.PresignedGetObjectAsync("savhome", image, 60 * 60 * 24);
            return url;
        }

    }
}
