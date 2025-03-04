﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    [Table("Users")]
    public class DatabaseUser : Welcome.Model.User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Uid { get; set; }
    }
}
