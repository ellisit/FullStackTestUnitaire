using Mikado.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mikado.DataGeneratorTest
{
    public class DataGeneratorTest : IEnumerable<object[]>
    {
        public IEnumerator<List<object>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<object[]> GetEmptyListOfMusic()
        {
            yield return new Music[0];
        }

        IEnumerator<object[]> IEnumerable<object[]>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
