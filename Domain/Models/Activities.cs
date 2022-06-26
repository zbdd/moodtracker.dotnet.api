using System.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace restapinet.Domain.Models
{
    public class Activities
    {
        [Key]
        public int Id { get; set; }
        public string activity { get; set; }
    }
}