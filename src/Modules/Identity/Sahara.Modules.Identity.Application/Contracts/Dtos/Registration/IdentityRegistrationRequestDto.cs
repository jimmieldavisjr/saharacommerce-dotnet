using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sahara.Modules.Identity.Application.Contracts.Dtos.Registration
{
    internal sealed record IdentityRegistrationRequestDto(string Email, string Password, AccountType AccountType);
}
