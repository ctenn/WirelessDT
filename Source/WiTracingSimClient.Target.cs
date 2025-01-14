// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class WiTracingSimClientTarget : TargetRules
{
    public WiTracingSimClientTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Client;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("WiTracingSim");
    }
}
