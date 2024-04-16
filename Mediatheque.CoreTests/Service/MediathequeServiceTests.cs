using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mediatheque.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatheque.Core.Model;

namespace Mediatheque.Core.Service.Tests
{
    [TestClass()]
    public class MediathequeServiceTests
    {
        [TestMethod()]
        public void PresentationCDTest(INotationService notationService)
        {
            // Arrange
            var cd = new CD("Yuusha", "Yoasobi");

            // Act
            MediathequeService mediatheque = new MediathequeService(notationService);
            mediatheque.AddObjet(cd);

            // Assert
            List<string> expected = new List<string>();
            expected.Add("Présentation des CDs :");
            expected.Add("Album : Yuusha Notation : ");

            CollectionAssert.AreEqual(expected, mediatheque.PresentationCD());
        }
    }
}
