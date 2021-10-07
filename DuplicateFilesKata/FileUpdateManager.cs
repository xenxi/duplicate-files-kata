using System.Collections.Generic;
using System.IO;

namespace DuplicateFilesKata
{
    public class FileUpdateManager
    {
        public void AppendFilesWithText(List<string> filePath, string textToAppend) {
            filePath = new DuplicateCleanner().Clean(filePath);
            foreach (var file in filePath)
            {
                if (File.Exists(file) && string.IsNullOrEmpty(textToAppend))
                {
                    File.AppendAllText(file, textToAppend);
                }
            }
            EmailNotifications.NotifyThatFilesHaveChanged(filePath);
        }
    }
}