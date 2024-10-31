// Copyright 2024, Athian Games. All Rights Reserved. 

using UnrealBuildTool;
using System.Collections.Generic;

public class ColorPickerDemoTarget : TargetRules
{
	public ColorPickerDemoTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("ColorPickerDemo");
	}
}
