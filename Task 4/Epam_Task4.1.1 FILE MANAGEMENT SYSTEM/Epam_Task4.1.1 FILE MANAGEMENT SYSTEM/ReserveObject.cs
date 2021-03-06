﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

namespace Epam_Task4._1._1_FILE_MANAGEMENT_SYSTEM
{
    public delegate void delCheckDict();

    internal class ReserveObject
    {
        public static readonly string _pathDict = Path.Combine(Directory.GetCurrentDirectory(), "MyTextFile");

        public static readonly string _pathSystem = Path.Combine(Directory.GetCurrentDirectory(), "MyTextFileCopy");

        private readonly ConcurrentDictionary<string, DateTime> dateTimeDictionary = new ConcurrentDictionary<string, DateTime>();

        private readonly delCheckDict ChDict;

        public ReserveObject()
        {
            FileSystemWatcher watcher = new FileSystemWatcher
            {
                Path = _pathDict,
                NotifyFilter = NotifyFilters.LastWrite |
                                NotifyFilters.LastAccess |
                                NotifyFilters.FileName |
                                NotifyFilters.DirectoryName |
                                NotifyFilters.Size,
                EnableRaisingEvents = true,
                IncludeSubdirectories = true,
                Filter = "*.*"
            };

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnDelete);
            watcher.Renamed += new RenamedEventHandler(OnRename);
            watcher.IncludeSubdirectories = true;
            ChDict = new delCheckDict(CheckDict);
            IAsyncResult ir = ChDict.BeginInvoke(null, null);

            watcher.EnableRaisingEvents = true;
        }

        public static void RollBackChanges()
        {
            Directory.Delete(_pathDict, true);
            Directory.CreateDirectory(_pathDict);
            SearchingFiles(InputDate());
        }

        private void OnRename(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Переименование файла {e.OldName} в {e.Name}");
            if (e.Name.Contains(".txt"))
            {
                string newFileName;
                using (StreamWriter sw = new StreamWriter($"{_pathSystem}\\LogFile.txt", true, Encoding.Default))
                {
                    newFileName = GetNewFileName(e.FullPath, _pathSystem);
                    sw.WriteLine($"{DateTime.Now}|Change|{e.FullPath}|{newFileName}|");
                }

                CopyFile(e.FullPath, newFileName);
            }
        }

        private void OnDelete(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Удаление файла {e.Name}");
            using (var sw = new StreamWriter($"{_pathSystem}\\LogFile.txt", true, Encoding.Default))
            {
                sw.WriteLine($"{DateTime.Now}|Delete|{e.FullPath}||");
            }
        }

        private void OnChanged(Object sender, FileSystemEventArgs e)
        {
            if (dateTimeDictionary.ContainsKey(e.FullPath))
            {
                dateTimeDictionary.TryRemove(e.FullPath, out DateTime date);
            }
            else
            {
                dateTimeDictionary.TryAdd(e.FullPath, DateTime.Now);
            }

            MakeEvents(e.FullPath);
        }

        private void MakeEvents(string filePath)
        {
            if (filePath.Contains(".txt"))
            {
                Console.WriteLine($"Изменение файла {filePath}");
                string newFileName;

                using (StreamWriter sw = new StreamWriter($"{_pathSystem}\\LogFile.txt", true, Encoding.Default))
                {
                    newFileName = GetNewFileName(filePath, _pathSystem);
                    sw.WriteLine($"{DateTime.Now}|Change|{filePath}|{newFileName}|");
                }

                lock (this)
                {
                    CopyFile(filePath, newFileName);
                }
            }
        }

        private void CopyFile(string originalFileName, string newFileName)
        {
            byte[] array;
            using (FileStream fstream = File.OpenRead(originalFileName))
            {
                array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
            }

            using (FileStream fstream = new FileStream(newFileName, FileMode.OpenOrCreate))
            {
                fstream.Write(array, 0, array.Length);
            }
        }

        private static string GetNewFileName(string originalFileName, string newDirName)
        {
            string newFileName = $"{newDirName}\\{Path.GetFileName(originalFileName)}";
            int numOfCopy = 0;
            while (File.Exists(newFileName))
            {
                numOfCopy++;
                newFileName = $"{newDirName}\\{Path.GetFileNameWithoutExtension(originalFileName)}({numOfCopy}){Path.GetExtension(originalFileName)}";
            }

            return newFileName;
        }

        private void CheckDict()
        {
            while (true)
            {
                foreach (KeyValuePair<string, DateTime> entry in dateTimeDictionary)
                {
                    if ((DateTime.Now.Millisecond - entry.Value.Millisecond) > 2000)
                    {
                        MakeEvents(entry.Key);
                        dateTimeDictionary.TryRemove(entry.Key, out DateTime time);
                    }
                }

                Thread.Sleep(2000);
            }
        }

        private static DateTime InputDate()
        {
            DateTime rollBackDate;
            string input;
            do
            {
                Console.WriteLine("Enter the rollback date in the format dd.MM.yyyy hh:mm:ss");
                input = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out rollBackDate));

            return rollBackDate;
        }

        private static void SearchingFiles(DateTime creat)
        {
            var allText = File.ReadAllText($"{_pathSystem}\\LogFile.txt", Encoding.Default).Split('\n');
            for (int i = 0; i < allText.Length; i++)
            {
                if (!string.IsNullOrEmpty(allText[i]))
                {
                    var fileInfo = allText[i].Split(new char[] { '|' });
                    bool flag = DateTime.TryParse(fileInfo[0], out DateTime fileDate);
                    if (flag && fileDate <= creat)
                    {
                        switch (fileInfo[1])
                        {
                            case "Change":
                                ChangeInfo(fileInfo[2], fileInfo[3]);
                                break;

                            case "Delete":
                                DeleteInfo(fileInfo[2]);
                                break;

                            case "Rename":
                                RenameInfo(fileInfo[2], fileInfo[3]);
                                break;
                        }
                    }
                }
            }
        }

        private static void RenameInfo(string originalName, string newName)
        {
            if (File.Exists(originalName))
            {
                File.Delete(Path.GetFullPath(originalName));
            }

            try
            {
                File.Copy(Path.GetFullPath(newName), $"{Path.GetDirectoryName(originalName)}\\{Path.GetFileName(newName)}", true);
            }
            catch
            {
                Directory.CreateDirectory(Path.GetDirectoryName(originalName));
                File.Copy(Path.GetFullPath(newName), $"{Path.GetDirectoryName(originalName)}\\{Path.GetFileName(newName)}", true);
            }
        }

        private static void DeleteInfo(string filePath)
        {
            try
            {
                File.Delete(Path.GetFullPath(filePath));
            }
            catch
            {
                Directory.Delete(Path.GetFullPath(filePath), true);
            }
        }

        private static void ChangeInfo(string originalFilePath, string pathOfCopy)
        {
            try
            {
                File.Copy(Path.GetFullPath(pathOfCopy), Path.GetFullPath(originalFilePath), true);
            }
            catch
            {
                Directory.CreateDirectory(Path.GetDirectoryName(originalFilePath));
                File.Copy(Path.GetFullPath(pathOfCopy), Path.GetFullPath(originalFilePath), true);
            }
        }
    }
}
