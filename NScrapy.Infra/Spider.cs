﻿using NScrapy.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NScrapy.Infra
{
    public interface ISpider
    {
        List<string> URLs { get; set; }

        void StartRequests();

        IResponse ResponseHandler(IResponse response);

    }
}
