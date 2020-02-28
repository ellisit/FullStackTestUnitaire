using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mikado.Models
{
    [Table("Media")]
    public class Media
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MediaId { get; set; }

        [Required]
        private string _title;
        public string Title { get => _title; set => _title = value; }

        [Required]
        private MediaType _type;
        public MediaType Type { get => _type; set => _type = value; }

        private DateTime _reservedFrom;
        public DateTime ReservedFrom { get => _reservedFrom; set => _reservedFrom = value; }

        private DateTime _reservedTo;
        public DateTime ReservedTo { get => _reservedTo; set => _reservedTo = value; }

        public enum MediaType {  Book=0, Music=1, Movie=2};

        public IList<MediaUser> MediaUsers { get; set; }
    }
}
