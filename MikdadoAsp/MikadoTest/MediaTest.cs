using FluentAssertions;
using Mikado.Models;
using Mikado.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace MikadoTest
{
    public class MediaTest
    {
        public class AddMediasTest
        {
                [Fact]
                public void NullMedia_Return_StringMessage()
                {

                    MediaServices dbs = new MediaServices();

                    // Tests des exceptions 
                    dbs.Invoking(d => dbs.AddMedia(null)).Should().NotThrow();

                    try
                    {

                        var res = dbs.AddMedia(null);

                        res.Should().NotBeNull(res);
                        res.Should().Be("the media is null");

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                // test if the list is empty 
                [Fact]
                public void EmptyParameter_ShouldReturn_StringMessage()
                {

                    MediaServices dbs = new MediaServices();
                    var toto = new Media();
                    // Tests des exceptions 
                    dbs.Invoking(d => dbs.AddMedia(toto)).Should().NotThrow();
                    try
                    {
                        var res = dbs.AddMedia(toto);
                        res.Should().NotBeNull(res);
                        res.Should().Be("the media have empty parameter");
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
        }

        public class DeleteMediaTest
        {

        }

        public class GetMediasTest
        {

        }

        public class GetOneMediaTest
        {

        }

        public class ModifyMediaClass
        {

        }

        public class ReserveMediaTest
        {

        }
    // this is an exmpale for theorie test with classes 
    //[InlineData(null)]
    //[MemberData(nameof(DataGeneratorTest.GetEmptyListOfMusic), MemberType = typeof(DataGeneratorTest)) ]

}
}
