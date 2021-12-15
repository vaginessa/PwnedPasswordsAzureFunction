﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using HaveIBeenPwned.PwnedPasswords.Models;

namespace HaveIBeenPwned.PwnedPasswords.Abstractions
{
    public interface IQueueStorage
    {
        Task PushTransactionAsync(QueueTransactionEntry entry, CancellationToken cancellationToken = default);
        Task PushPasswordsAsync(List<QueuePasswordEntry> entry, CancellationToken cancellationToken = default);
    }
}
