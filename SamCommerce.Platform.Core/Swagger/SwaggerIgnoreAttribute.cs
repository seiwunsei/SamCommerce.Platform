﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCommerce.Platform.Core.Swagger
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class SwaggerIgnoreAttribute : Attribute
    {
    }
}
