// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System;
using System.IO;

public class vsthost : ModuleRules
{



    public void includeAdd(string env)
    {
        var items = Environment.GetEnvironmentVariable(env);
        foreach (string s in items.Split(';'))
        {
            Console.WriteLine("INCLUDE:" + s);
            PublicIncludePaths.Add(s);

        }

    }

    public void addPreproc(string ros_preproc)
    {
        foreach (string s in ros_preproc.Split(';'))
        {
            Console.WriteLine("DEFINE:" + s);
            Definitions.Add(s);

        }
    }

    public void includeLib(string env, string prefix = null)
    {
        var items = Environment.GetEnvironmentVariable(env);
        string slib;

        if (prefix != null)
        {//TODO:make for non windows case
            if (prefix.PadRight(1) != "\\")
                prefix += '\\';
        }

        foreach (string s in items.Split(';'))
        {


            slib = prefix + s;
            Console.WriteLine("LIB INCLUDE:" + slib);
            PublicAdditionalLibraries.Add(slib);

        }
    }


    public vsthost(TargetInfo Target)
	{
		 Type = ModuleType.External;
        
	if (Target.Platform == UnrealTargetPlatform.Win64)
		{
        PublicIncludePaths.Add(ModuleDirectory + @"\vsthost\include");
		PublicIncludePaths.Add(ModuleDirectory + @"\vsthost\include\vsthost");
        PublicLibraryPaths.Add(ModuleDirectory + @"\vsthost\vsthost\Lib\Win64");
        
		Console.WriteLine(ModuleDirectory);
		
		Console.WriteLine("DEBUGMODULEvsthost:"+ModuleDirectory +
			@"\vsthost\Lib\Win64");
		
		
		PublicAdditionalLibraries.Add(ModuleDirectory + @"\vsthost\Lib\Win64\"+@"vsthost.lib");
		PublicAdditionalLibraries.Add(ModuleDirectory + @"\vsthost\Lib\Win64\"+@"sharedmem.lib");
		
		}
		
		





    }





}
