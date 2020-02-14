using Mikado.DataGeneratorTest;
using Mikado.Models;
using Mikado.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace MikadoTest
{
    public class BookTest
    {

 
  
        [Fact]
        //[InlineData(null)]
        //[MemberData(nameof(DataGeneratorTest.GetEmptyListOfMusic), MemberType = typeof(DataGeneratorTest)) ]
        public void NullConnection_ToDataBase_ShouldReturn_StringMessage()
        {
            try
            { 
                var res = DataBaseService.AddMusics(null);
            }
            catch( Exception e)
            {
                throw e;
            }
        }

        [Fact]
        public void EmptyListShouldReturnEmptyMessage()
        {
            try
            {
                var toto = new List<Music>();
                var res = DataBaseService.AddMusics(toto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
