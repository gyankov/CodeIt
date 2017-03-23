﻿using System.Linq;
using NUnit.Framework;
using CodeIt.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace CodeIt.UnitTests.DbModels.FileInfoTests
{
    [TestFixture]
    public class FileSystemPath_Should
    {
        [Test]
        public void Be_OfTypeString()
        {
            // Arange
            var filePathPropType = typeof(FileInfo).GetProperty(nameof(FileInfo.FileSystemPath)).PropertyType;

            // Act & Assert
            Assert.IsTrue(filePathPropType == typeof(string));
        }

        [Test]
        public void Has_RequiredAttribute()
        {
            // Arange
            var hasAttrRequired =
                typeof(FileInfo)
                .GetProperty(nameof(FileInfo.FileSystemPath))
                .GetCustomAttributes(false)
                .Where(x => x.GetType() == typeof(RequiredAttribute))
                .Any();

            // Act & Assert
            Assert.IsTrue(hasAttrRequired);
        }
    }
}
