﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;

namespace HaveIBeenPwned.PwnedPasswords.Models
{
    public class PwnedPasswordsTransaction
    {
        [JsonPropertyName("transactionId")]
        public string TransactionId { get; set; } = "";
    }
}
