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

namespace WebApp1.Model
{
          public class Ofertar
          {
                  [Key]
                  public int IdOfertas { get; set;}
                 
                  [RegularExpression ("Debe realizar una oferta, solo se admiten números")]
                  [Required]
                  [Display( Name= "Oferta ofrecida")]
                  public int Oferta { get; set;}
            
                 [EmailAddress]
                  [Display( Name= "correo")]
                  public string Correo { get; set;}
          }
}