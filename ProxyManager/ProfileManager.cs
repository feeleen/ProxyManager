using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace ProxyManager
{
	public static class ProfileManager
	{
		private static readonly string ProfilesPath = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			"ProxyManager",
			"profiles.json");

		private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
		{
			WriteIndented = true
		};

		public static List<ProxyProfile> LoadProfiles()
		{
			try
			{
				if (!File.Exists(ProfilesPath))
				{
					return new List<ProxyProfile>();
				}

				var json = File.ReadAllText(ProfilesPath);
				var profiles = JsonSerializer.Deserialize<List<ProxyProfile>>(json, JsonOptions);
				return profiles ?? new List<ProxyProfile>();
			}
			catch (JsonException)
			{
				// Файл повреждён - создаём резервную копию и возвращаем пустой список
				try
				{
					var backupPath = ProfilesPath + ".backup." + DateTime.Now.Ticks;
					File.Copy(ProfilesPath, backupPath, false);
					MessageBox.Show(
						$"Файл профилей повреждён. Создана резервная копия: {backupPath}",
						"Ошибка загрузки профилей",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				}
				catch { }
				return new List<ProxyProfile>();
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					$"Ошибка загрузки профилей: {ex.Message}",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return new List<ProxyProfile>();
			}
		}

		public static void SaveProfiles(List<ProxyProfile> profiles)
		{
			try
			{
				var directory = Path.GetDirectoryName(ProfilesPath);
				if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
				{
					Directory.CreateDirectory(directory);
				}

				var json = JsonSerializer.Serialize(profiles, JsonOptions);
				File.WriteAllText(ProfilesPath, json);
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					$"Ошибка сохранения профилей: {ex.Message}",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		public static void SaveProfile(ProxyProfile profile)
		{
			var profiles = LoadProfiles();
			var existing = profiles.Find(p => p.Name == profile.Name);
			if (existing != null)
			{
				profile.Created = existing.Created;
				profiles.Remove(existing);
			}
			profile.Modified = DateTime.Now;
			profiles.Add(profile);
			SaveProfiles(profiles);
		}

		public static void DeleteProfiles(IEnumerable<string> profileNames)
		{
			var profiles = LoadProfiles();
			var namesToDelete = new HashSet<string>(profileNames);
			profiles.RemoveAll(p => namesToDelete.Contains(p.Name));
			SaveProfiles(profiles);
		}

		public static bool ProfileExists(string name)
		{
			var profiles = LoadProfiles();
			return profiles.Any(p => p.Name == name);
		}
	}
}
