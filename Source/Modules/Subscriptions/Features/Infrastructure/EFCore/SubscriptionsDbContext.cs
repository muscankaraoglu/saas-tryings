﻿using Microsoft.EntityFrameworkCore;
using Modules.Subscriptions.Features.DomainFeatures.StripeCustomerAggregate;
using Modules.Subscriptions.Features.DomainFeatures.StripeSubscriptionAggregate;
using Shared.Features.EFCore;

namespace Modules.Subscriptions.Features.Infrastructure.EFCore
{
    public class SubscriptionsDbContext : BaseDbContext<SubscriptionsDbContext>
    {
        public SubscriptionsDbContext(DbContextOptions<SubscriptionsDbContext> dbContextOptions, IServiceProvider serviceProvider = null) : base(serviceProvider, "Subscriptions", dbContextOptions)
        {
            
        }

        public DbSet<StripeCustomer> StripeCustomers { get; set; }
        public DbSet<StripeSubscription> StripeSubscriptions { get; set; }
    }
}
