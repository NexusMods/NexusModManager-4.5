using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Client.Mods
{
	public class ModBackupInfo
	{
		#region Properties

		/// <summary>
		/// Gets the format of the mod.
		/// </summary>
		/// <value>The format of the mod.</value>
		public IMod Mod { get; private set; }

		/// <summary>
		/// Gets whether the mod is a packed OMod, or an OMod-ready archive.
		/// </summary>
		/// <value>Whether the mod is a packed OMod, or an OMod-ready archive.</value>
		public Dictionary<string, bool> ModFileDictionary { get; private set; }

		#endregion

		#region Constructors

		/// <summary>
		/// A simple constructor that initializes the OMod from the specified file.
		/// </summary>
		/// <param name="p_strFilePath">The mod file from which to create the OMod.</param>
		/// <param name="p_mftModFormat">The format of the mod.</param>
		/// <param name="p_mcmModCacheManager">The manager for the current game mode's mod cache.</param>
		/// <param name="p_stgScriptTypeRegistry">The registry of supported script types.</param>
		public ModBackupInfo(IMod p_Mod)
		{
			Mod = p_Mod;
			ModFileDictionary = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);
		}

		#endregion

	}
}
