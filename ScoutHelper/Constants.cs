using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;
using ScoutHelper.Models;

namespace ScoutHelper;

public static class Constants {
	#region plugin constants

	public const string PluginName = "Scout Helper";
	public static readonly string PluginVersion;
	public static readonly string PluginNamespace = PluginName.Replace(" ", "");

	public static readonly DateTime LatestPluginUpdate = DateTime.Parse("2024-07-01T00:00:00Z");
	public static readonly IList<string> PluginUpdates = new string[] {
		"updated to run on 7.0 Dawntrail.",
		"added support for 7.0 hunt marks.",
		"added an update notice popup (you're looking at it :P).",
		"added a notice mechanism on the main ui, to alert users to persistent important issues.",
	}.AsList();

	#endregion

	#region core constants

	public const string DefaultCopyTemplate = "{patch-emote} {patch} {#}/{#max} {world} [{tracker}]({link})";
	public const string BearDataFile = @"Data\Bear.json";
	public const string SirenDataFile = @"Data\Siren.json";
	
	#endregion
	
	#region patch update constants

	public static readonly IList<string> Notices = new string[] {
		// "Dawntrail regions are not yet supported.",
	}.AsList();
	public static readonly DateTime LatestPatchUpdate = DateTime.Parse("2024-01-01T00:00:00Z");
	public static readonly (Territory, uint)[] LatestPatchInstances = {};

	#endregion

	#region web constants

	public static readonly MediaTypeWithQualityHeaderValue MediaTypeJson =
		MediaTypeWithQualityHeaderValue.Parse("application/json");

	public static readonly ProductInfoHeaderValue UserAgent = new ProductInfoHeaderValue(
		PluginNamespace,
		PluginVersion
	);

	#endregion

	static Constants() {
		PluginVersion = Assembly.GetCallingAssembly().GetName().Version?.ToString() ?? "?.?.?.?";
	}
}
