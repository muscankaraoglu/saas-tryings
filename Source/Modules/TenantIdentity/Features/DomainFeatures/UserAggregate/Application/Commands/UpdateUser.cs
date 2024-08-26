﻿using Microsoft.AspNetCore.Http;
using Shared.Features.Messaging.Command;

namespace Modules.TenantIdentity.Features.DomainFeatures.UserAggregate.Application.Commands
{
    public class UpdateUser : ICommand
    {
        public string UserName { get; set; }
        public IFormFile ProfilePicture { get; set; }
    }
}
