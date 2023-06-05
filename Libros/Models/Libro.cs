using System.ComponentModel.DataAnnotations;

public class Libro
    {
        [Key]
        public int LibroId { get; set; }

        [Required (ErrorMessage = "El nombre del libro es obligatorio")]
        public string? Nombre { get; set; }

        [Required (ErrorMessage = "El Precio del libro es obligatorio")]
        public string? Precio { get; set; }

        [Required (ErrorMessage = "El Precio del libro es obligatorio")]
        public string? Precio { get; set; }
    }