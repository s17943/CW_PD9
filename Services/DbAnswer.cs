using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW_PD8.Services
{
    public enum DbAnswer
    {
        OK = 200,
        PasswordLengthIsNotProper,
        UserIsAlreadyRegistered,
        BadPassword,
        UserNotFound,
        RefreshTokenIsExpired
    }
}