﻿using System.ComponentModel.DataAnnotations;

namespace Demo_Entity_Framework.Models
{
    public class EditPostViewModel
    {
        [Required]
        public string Titel { get; set; }
        [Required]
        public string Inhoud { get; set; }
    }
}
