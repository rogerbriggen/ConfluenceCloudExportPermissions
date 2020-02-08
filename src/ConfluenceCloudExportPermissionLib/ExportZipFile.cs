using System;
using Microsoft.Extensions.Logging;

namespace ConfluenceCloudExportPermissionLib
{
    
    public class ExportZipFile
    {
        private readonly ILogger _logger;
        public ExportZipFile(ILogger<ExportZipFile> logger)
        {
            _logger = logger;
        }

        public bool TestMethod()
        {
            _logger.LogDebug("TestMethod");
            return true;
        }
    }
}
