﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace invoice.Services
{
    public interface IExportToPDF
    {
        Task<String> RenderToStringAsync(string viewName, object model);
    }
}
