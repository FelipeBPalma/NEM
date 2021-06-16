using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NEM.Models
{
    [Table("tb_produto")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name="Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Column("Cargo")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        [Column("Pais")]
        [Display(Name = "Pais")]
        public string Pais { get; set; }

        [Column("Equipe")]
        [Display(Name = "Equipe")]
        public string Equipe { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "DataEntrada")]
        public DateTime DataEntrada { get; set; }

        [Column("DataAlteracao")]
        [Display(Name = "DataAlteracao")]
        public DateTime DataAlteracao { get; set; }
    }
}
