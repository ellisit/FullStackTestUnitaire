using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mikado.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        private UserStatus _status;
        public UserStatus Status { get => _status; set => _status = value; }
        [Required]
        private string _email;
        public string Email { get => _email; set => _email = value; }

        [Required]
        private string _pwd;
        public string Password { get => _pwd; set => _pwd = value; }

        [Required]
        public string _lastname;
        public string Lastname { get => _lastname; set => _lastname = value; }

        public enum UserStatus { isUser= 0, isBibli=1};

        public IList<MediaUser> MediaUsers { get; set; }

    }
}
    