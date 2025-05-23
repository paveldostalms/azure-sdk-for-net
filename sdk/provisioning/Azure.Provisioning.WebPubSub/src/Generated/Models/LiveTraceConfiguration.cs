// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.WebPubSub;

/// <summary>
/// Live trace configuration of a Microsoft.SignalRService resource.
/// </summary>
public partial class LiveTraceConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// Indicates whether or not enable live trace.
    /// </summary>
    public BicepValue<string> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<string>? _isEnabled;

    /// <summary>
    /// Gets or sets the list of category configurations.
    /// </summary>
    public BicepList<LiveTraceCategory> Categories 
    {
        get { Initialize(); return _categories!; }
        set { Initialize(); _categories!.Assign(value); }
    }
    private BicepList<LiveTraceCategory>? _categories;

    /// <summary>
    /// Creates a new LiveTraceConfiguration.
    /// </summary>
    public LiveTraceConfiguration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of LiveTraceConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isEnabled = DefineProperty<string>("IsEnabled", ["enabled"]);
        _categories = DefineListProperty<LiveTraceCategory>("Categories", ["categories"]);
    }
}
