// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;
using Aspire.Hosting.Utils;
using Microsoft.AspNetCore.InternalTesting;

namespace Aspire.Hosting.Tests;

public class PublishAsConnectionStringTests
{
    [Fact]
    public async Task PublishAsConnectionStringConfiguresManifestAsParameter()
    {
        var builder = TestDistributedApplicationBuilder.Create(DistributedApplicationOperation.Publish);

        var redis = builder.AddRedis("redis").PublishAsConnectionString();

        var manifest = await ManifestUtils.GetManifest(redis.Resource).DefaultTimeout();

        var expected =
            """
            {
              "type": "parameter.v0",
              "connectionString": "{redis.value}",
              "value": "{redis.inputs.value}",
              "inputs": {
                "value": {
                  "type": "string",
                  "secret": true
                }
              }
            }
            """;

        var actual = manifest.ToString();

        Assert.Equal(expected, actual, ignoreLineEndingDifferences: true, ignoreWhiteSpaceDifferences: true);
    }
}
