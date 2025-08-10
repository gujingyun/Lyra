// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LyraEditorTarget : TargetRules
{
	public LyraEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		
		
		
		ExtraModuleNames.AddRange(new string [] {"LyraGame","LyraEditor"});
		
		if (!bBuildAllModules)
		{
			NativePointerMemberBehaviorOverride = PointerMemberBehavior.Disallow;
		}
		
		LyraGameTarget.ApplySharedLyraTargetSettings(this);
		
		//此功能用于触屏设备开发，同时与“虚幻引擎”应用程序配合使用
		EnablePlugins.Add("RemoteSession");
	}
}
