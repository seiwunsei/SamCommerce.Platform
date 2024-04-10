﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCommerce.Platform.Core.Security
{
    /// <summary>
    /// Obsolete. Left due to compatibility issues. Will be removed. Instead of, use: ApplicationUser.EmailConfirmed, ApplicationUser.LockoutEnd.
    /// </summary>
    public enum AccountState
    {
        PendingApproval,
        Approved,
        Rejected
    }
}
