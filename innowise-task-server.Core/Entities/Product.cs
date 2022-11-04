﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Core.Entities
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name must be no shorter than 3 and no longer than 30 characters")]
        [MaxLength(30, ErrorMessage = "Name must be no shorter than 3 and no longer than 30 characters")]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        public int? DefaultQuantity { get; set; }

        public ICollection<FridgeProduct>? Fridges { get; set; }
    }
}
