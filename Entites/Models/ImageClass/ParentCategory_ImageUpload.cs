﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models.ImageClass
{
    public class ParentCategory_imgupl
    {
        public FileUploads fileUploads { get; set; }
        public ParentCategory parent_Catgs { get; set; }
        public List<ParentCategory> parent_CatgList { get; set; }
    }
}
