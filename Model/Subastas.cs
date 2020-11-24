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
          public class Subastas
          {
                  [Key]
                  public int IdSubastas { get; set;}
                
                  [Required (ErrorMessage = "El Campo para el Nombre es obligatorio")][MaxLength(100)]
                  [Display( Name= "Nombre del Usuario")]
                  public string NombreUsuario { get; set;}
            
                 [Required (ErrorMessage = "El Campo para el apellido es obligatorio")][MaxLength(100)]
                  [Display( Name= "Apellido del Usuario")]
                  public string ApellidoUsuario { get; set;}

                  [Required (ErrorMessage = "Campo obligatorio")][MaxLength(40)] 
                  [Display( Name= "Nombre del articulo a subastar")]
                  public string NombreArticulo { get; set;}
                  
                  [Required (ErrorMessage = "Campo obligatorio")][MaxLength(250)]
                  [Display( Name= "Descripción del articulo a subastar")]
                  public string DescripcionArticulo { get; set;}
                  
                  [RegularExpression (@"^La categoria del articulo es oblogatoria")]
                [Required (ErrorMessage = "La categoria del articulo es oblogatoria")]
                [Display( Name= "Categoria del articulo")]
                public string Categoria { get; set;}
                  
                  [RegularExpression (@"^El precio del articulo es oblogatorio")]
                  [Required(ErrorMessage = "El precio del articulo es oblogatorio")]
                  [Display( Name= "Precio Incial del articulo")]
                  [Range(1, 1000000000)]
                  public int Precio { get; set;}
               
                  [Required (ErrorMessage = "Campo obligatorio")]
                  [Display( Name= "Fecha de inicio de la subasta")]
                  [DataType(DataType.Date)]
                  public DateTime FechaSubasta {get;set;} 
                
                  [Required (ErrorMessage = "Campo obligatorio")] 
                  [Display( Name= "Fecha de finalizacion de la subasta")]
                  [DataType(DataType.Date)]                  
                  public DateTime FechaFinSubasta {get;set;} 
                
                [Display( Name= "Oferta")]               
                 public int Oferta {get;set;} 

}
}