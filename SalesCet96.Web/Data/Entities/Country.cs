using System.ComponentModel.DataAnnotations;

namespace SalesCet96.Web.Data.Entities
{
    public class Country
    {
        public int id { get; set; }


        //Data Anotations:
        [Display(Name="País")]
        [MaxLength(50, ErrorMessage = "= campo {0} deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string? Name { get; set; }
    }
}
