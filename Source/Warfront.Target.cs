// Modern Monkey Studios LLC. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class WarfrontTarget : TargetRules
{
	public WarfrontTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Warfront" } );
	}
}
