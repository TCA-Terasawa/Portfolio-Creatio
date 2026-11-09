// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Miz_Portfolio : ModuleRules
{
	public Miz_Portfolio(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Miz_Portfolio",
			"Miz_Portfolio/Variant_Horror",
			"Miz_Portfolio/Variant_Horror/UI",
			"Miz_Portfolio/Variant_Shooter",
			"Miz_Portfolio/Variant_Shooter/AI",
			"Miz_Portfolio/Variant_Shooter/UI",
			"Miz_Portfolio/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
