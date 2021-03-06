﻿#pragma warning disable 0436

using System.Reflection;

[assembly: AssemblyCompany("Mobile Essentials")]
[assembly: AssemblyProduct("MSBuilder.Roslyn")]
[assembly: AssemblyCopyright("Copyright © Mobile Essentials 2015")]
[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]

#if DEBUG
[assembly: AssemblyConfiguration ("DEBUG")]
#else
[assembly: AssemblyConfiguration ("RELEASE")]
#endif

[assembly: AssemblyVersion (ThisAssembly.Version)]
[assembly: AssemblyFileVersion (ThisAssembly.Version)]
[assembly: AssemblyInformationalVersion (ThisAssembly.InformationalVersion)]

partial class ThisAssembly
{
	public const string Version = Git.SemVer.Major + "." + Git.SemVer.Minor + "." + Git.SemVer.Patch;
	public const string InformationalVersion = Version + "-" + Git.Branch + "+" + Git.Commit;
}

#pragma warning restore 0436