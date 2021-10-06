using System.ComponentModel.DataAnnotations;

namespace ProyPeliculas.Shared.Entity
{
    public class Categoryx
    {
        public int IdCategory { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CategoryName { get; set; }
        /* public Category(int idCategory, string categoryName)
        {
            this.IdCategory = idCategory;
            this.CategoryName = categoryName;

        } */

    }
}