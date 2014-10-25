using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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