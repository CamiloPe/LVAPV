using System.ComponentModel.DataAnnotations;

namespace lva0008.Entidades
{
    public class Student
    {
        #region propiedades autoimplementadas
        //se indica que este id es una llave
        [Key]
        //prop tab tab para crear automaticamente
        public int Id { get; set; }
        //se indica que es un campo requerido
        [Required]
        //longitud de caracteres que se pueden poner
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        public int Age { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        #endregion
    }
}
