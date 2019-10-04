using System;
using System.Collections.Generic;

namespace arcgis_netcore.domain
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
