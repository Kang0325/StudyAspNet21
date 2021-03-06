using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        [Required(ErrorMessage = "이메일은 필수입니다.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(125)]
        public String Email { get; set; }

        [Required(ErrorMessage = "비밀번호는 필수입니다.")]
        [DataType(DataType.Password)]
        [StringLength(20)]
        public String Password { get; set; }
        public String Grade { get; set; }
    }
}