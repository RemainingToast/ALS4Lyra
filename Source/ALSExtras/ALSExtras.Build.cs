using UnrealBuildTool;

public class ALSExtras : ModuleRules
{
	public ALSExtras(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_2;

		bEnableNonInlinedGenCppWarnings = true;

		PublicDependencyModuleNames.AddRange(new[]
		{
			"ModularGameplayActors"
		});
		
		PrivateDependencyModuleNames.AddRange(new[]
		{
			"Core", "CoreUObject", "Engine", "EnhancedInput", "GameplayTags", "AIModule", "ALS", "ALSCamera"
		});
	}
}