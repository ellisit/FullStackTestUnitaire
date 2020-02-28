using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Mikado.Models;

namespace Mikado.Services
{
    public class MediaServices
    {
        // add one media
        public string AddMedia(Media _media)
        {
            using (var db = new MikadoDbContext())
            {

                // check db connection is null 
                if (db == null)
                {
                    return "the connection to the databse failed";
                }

                // check media is null 
                if (_media == null)
                {
                    return "the media is null";
                }
 
                // check propety title of media is nul or empty 
                if (String.IsNullOrEmpty(_media.Title))
                {
                    return "the media have empty parameter";
                }

                // add in bdd if all test is ok 
                db.Medias.Add(_media);
                db.SaveChanges();

                throw new NotImplementedException("Not fully implemented.");
            }
        }

        // get list of all media
        public IEnumerable<Media> GetMedias()
        {
            using (var db = new MikadoDbContext())
            {
                var medias = db.Medias.ToList();
            }
            throw new NotImplementedException("Not fully implemented.");
        }

        // delete one media by id
        public string DeleteMedia( int _mediaId)
        {

            using (var db = new MikadoDbContext())
            {
                if (db == null)
                {
                    return "the connection to the databse failed";
                }

                if (_mediaId <= 0)
                {
                    return "the media id is null";
                }
                var mediaToDelete = GetOneMedia(_mediaId);
                db.Medias.Remove(mediaToDelete);
                db.SaveChanges();

            }
                throw new NotImplementedException("Not fully implemented.");
        }

        // get one media by id
        public Media GetOneMedia( int _idMedia)
        {
            using (var db = new MikadoDbContext())
            {
                var media = db.Medias.Where(m => m.MediaId == _idMedia).ToList();
                return media[0];
            }
                throw new NotImplementedException("Not fully implemented.");
        }

        // moduify one media by id 
        public string ModifyMedia(int _mediaIdYouWantToModify, Media newMedia)
        {

            using (var db = new MikadoDbContext())
            {
                var mediaToChange = newMedia;
                db.Medias.Update(mediaToChange);
                db.SaveChanges();
            }
                throw new NotImplementedException("Not fully implemented.");

        }

        // get one media and set it reverved value
        public string ReserveMedia(int _mediaId, DateTime _reserveFrom, DateTime _reserveTo)
        {
           
            var mediaYouWantToReserve = GetOneMedia(_mediaId);
            mediaYouWantToReserve.ReservedFrom =_reserveFrom;
            mediaYouWantToReserve.ReservedTo = _reserveTo;
            ModifyMedia(_mediaId, mediaYouWantToReserve);
           
            throw new NotImplementedException("Not fully implemented.");
        }




    }
}
