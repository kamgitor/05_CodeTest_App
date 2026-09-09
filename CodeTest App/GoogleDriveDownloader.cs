
using System;
using System.IO;
using System.Net;


namespace CodeTest_App
{
	static class Downloader
	{
		// Orig link
		// https://docs.google.com/document/d/1pKape7NE8fiBqN7zHZh0XGvvl9wKtGE1yKmYWTIGrfM/edit?usp=drive_link

		// Works
		private const string TXT_CONFIG_LINK = "https://docs.google.com/document/d/1pKape7NE8fiBqN7zHZh0XGvvl9wKtGE1yKmYWTIGrfM/export?format=txt";



		// Orig excel link
		// https://docs.google.com/spreadsheets/d/1Sq0ZJ646K1qciihv-FtXssX6T3kd5MExSDCe5W9I5eU/edit?usp=drive_link
		private const string XLS_CONFIG_LINK = "https://docs.google.com/spreadsheets/d/1Sq0ZJ646K1qciihv-FtXssX6T3kd5MExSDCe5W9I5eU/export?format=xlsx";
		private const string CONFIG_FILENAME = "web_config.txt";

		public static void DownloadWebConfig()
		{
			DownloadFileToPrivateAppFolder(TXT_CONFIG_LINK, CONFIG_FILENAME);
		}

		/*
		public static async Task DownloadFileToPrivateAppFolder(string fileUrl, string fileName)
		{
			string directoryPath = FileSystem.AppDataDirectory;
			Directory.CreateDirectory(directoryPath);

			string filePath = Path.Combine(directoryPath, fileName);

			using HttpClient client = new HttpClient();

			using var response = await client.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead)
											 .ConfigureAwait(false);

			response.EnsureSuccessStatusCode();

			await using var httpStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
			await using var fileStream = File.Create(filePath);

			await httpStream.CopyToAsync(fileStream).ConfigureAwait(false);
		}
		*/

		public static void DownloadFileToPrivateAppFolder(string fileUrl, string fileName)
		{
			string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
			string filePath = Path.Combine(directoryPath, fileName);

			using (WebClient client = new WebClient())
			// using (HttpClient client = new HttpClient())
			{
				client.DownloadFile(fileUrl, filePath);
			}
		}

	}

}