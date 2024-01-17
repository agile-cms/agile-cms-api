﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Agile.Cms.Core.EntityFrameworkCore;

[ConnectionStringName(CoreDbProperties.ConnectionStringName)]
public interface ICoreDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
