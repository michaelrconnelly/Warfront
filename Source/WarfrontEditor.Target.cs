// Modern Monkey Studios LLC. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class WarfrontEditorTarget : TargetRules
{
	public WarfrontEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Warfront" } );
	}
}
