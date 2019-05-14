﻿using LibraryMvcCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMvcCore.Models
{
    public class TextBook : Book
    {
        [Required]
        public int Pages { get; set; }

    }
}