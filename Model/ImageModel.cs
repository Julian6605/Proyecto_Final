using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using WebApp1.Pages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApp1.Model;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WebApp1.Model
{
    //File : /Models/ImageModel.cs
public class ImageModel
{
    [Key]
    public int ImageId { get; set; }

    [Column(TypeName ="nvarchar(50)")]
    public string Title { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Display (Name ="Image Name")]
    public string ImageName { get; set; }

    [NotMapped]
    [Display( Name ="Upload File")]
    public IFormFile ImageFile { get; set; }
}

}