using JLRWebVideos.Providers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoIsraelFutbol.Helpers
{
    public class HelperUploadFiles
    {
        private PathProvider pathProvider;

        public HelperUploadFiles(PathProvider pathProvider)
        {
            this.pathProvider = pathProvider;
        }

        public async Task<string> UploadFileAsync
        (IFormFile formFile, Folders folder, string filename)
        {
            string path = this.pathProvider.MapPath(filename, folder);
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }
            return filename;
        }


    }
}