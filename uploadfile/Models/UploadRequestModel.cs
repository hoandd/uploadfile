using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uploadfile.Models
{
    public class UploadRequestModel
    {
        public string Path { get; set; }
        public string Action { get; set; }
        public IList<IFormFile> uploadFiles { get; set; }
        public object Data { get; set; }
    }
}
