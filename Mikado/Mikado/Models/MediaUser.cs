using System;
using System.Collections.Generic;
using System.Text;

namespace Mikado.Models
{
    public class MediaUser
    {
        public int MediaId { get; set; }
        public Media Media { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
