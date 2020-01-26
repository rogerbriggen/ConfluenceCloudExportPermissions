using System;
using Xunit;
using ConfluenceCloudExportPermissionLib;

namespace ConfluenceCloudExportPermissionLib.Test
{
    public class ExportZipFileTest
    {
        [Fact]
        public void TestTestMehod()
        {
            Assert.True(new ExportZipFile().TestMethod());
            //Assert.False(new ExportZipFile().TestMethod());
        }

        [Fact]
        public void TestTestMehodFalse()
        {
            Assert.False(new ExportZipFile().TestMethod());
            
        }
    }
}
