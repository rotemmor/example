using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace example.Models
{
    public class Images
     {
        public int Id { get; set; }

        [Display(Name = "Image Url")]
        public String imageUrl { get; set; }

        [Required]
        [Display(Name = "Image Name")]
        public String imageName { get; set; }

        [Required]
        [Display(Name = "Image Size")]
        public int ImageSize { get; set; }

        [Required]
        [Display(Name = "Image Size")]
        public String imageModifiedDate { get; set; }
        

        }
    }