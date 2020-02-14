using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Mikado.Models;

namespace Mikado.Services
{
    public class DataBaseService
    {
        public static string AddMusics(List<Music> _musics)
        {
            using (var db = new MikadoDbContext())
            {
                if (db is null)
                {
                    return "the connection to the databse failed";
                }

                if ( _musics.Count == 0 )
                {
                    return "the music list is emplty";
                }

                throw new NotImplementedException("Not fully implemented.");
            }
        }
        
    }
}
