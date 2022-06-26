using System.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace restapinet.Domain.Models
{
    public class MoodEntry
    {
        [Key]
        public string key { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public int mood { get; set; }
        public int sleep { get; set; }
        public bool medication { get; set; }
        public ArrayList activities { get; set; }
        public ArrayList feelings { get; set; }
    }
}