using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models.ImageClass
{
    public class FileUploads
    {
        public int ImgId { get; set; }
        public string Parent { get; set; }
        public IFormFile files { get; set; }
        public string Imgname { get; set; }
        public int ParentCatgsID { get; set; }
        public ParentCategory ParentCatgs { get; set; }
    }
}
