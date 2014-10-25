using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Person
    {
        // Encapsulation 0/10, don't actually use this in prod
        [Key]
        public int PersonId { get; private set; }

        public string Name;
    }
}