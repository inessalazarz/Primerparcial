

namespace salazar.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum trickType
    {
        imagen,
        icono,
        incendio

    }
    public class Clown
    {
        [Key]
        public int ClownId { get; set; }
        [Required]
        [StringLength(24)]
        public string NickName { get; set; }
        
        [Required]
        public trickType Tricks { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
    }
}