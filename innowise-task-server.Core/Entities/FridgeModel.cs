﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Core.Entities
{
    public class FridgeModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Name must be no shorter than 1 and no longer than 20 characters")]
        [MaxLength(20, ErrorMessage = "Name must be no shorter than 1 and no longer than 20 characters")]
        public string Name { get; set; }

        [Range(1913, 2022, ErrorMessage = "Year cannot be less than 1913 or greater than 2022")]
        public int? year { get; set; }

    }
}
