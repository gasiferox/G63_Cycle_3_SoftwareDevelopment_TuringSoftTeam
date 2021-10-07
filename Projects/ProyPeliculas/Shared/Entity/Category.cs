using System.ComponentModel.DataAnnotations;

namespace ProyPeliculas.Shared.Entity
{
    public class Category
    {
        public int Id { get; set; }
        /* [Required(ErrorMessage = "El campo {0} es requerido")] */
        public string Name { get; set; }
        /* public Category(int idCategory, string categoryName)
        {
            this.IdCategory = idCategory;
            this.CategoryName = categoryName;

        } */

    }
}