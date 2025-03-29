// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UNICEF_Project_5_5_1Target : TargetRules
{
	public UNICEF_Project_5_5_1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "UNICEF_Project_5_5_1" } );
	}
}
