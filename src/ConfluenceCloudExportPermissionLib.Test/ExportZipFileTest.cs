using System;
using Xunit;
using ConfluenceCloudExportPermissionLib;
using Microsoft.Extensions.Logging.Abstractions;

namespace ConfluenceCloudExportPermissionLib.Test
{
    public class ExportZipFileTest
    {
        [Fact]
        public void TestTestMehod()
        {
            Assert.True(new ExportZipFile(NullLogger<ExportZipFile>.Instance).TestMethod());
            //Assert.False(new ExportZipFile().TestMethod());
        }

        [Fact]
        public void TestTestMehodFalse()
        {
            Assert.False(!new ExportZipFile(NullLogger<ExportZipFile>.Instance).TestMethod());
            
        }
    }
}
