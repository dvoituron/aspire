// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Dashboard.Model;

public class ProjectViewModel : ResourceViewModel
{
    public required string ProjectPath { get; init; }
    public List<string> Addresses { get; } = new();
    public List<ServiceEndpoint> Endpoints { get; } = new();
    public required int ExpectedEndpointCount { get; init; }
}
