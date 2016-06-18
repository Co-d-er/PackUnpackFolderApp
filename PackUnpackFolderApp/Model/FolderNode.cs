using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PackUnpackFolderApp.Model
{
    [Serializable]
    class FolderNode
    {
        public string FolderNodeName { get; set; }
        public List<FolderFile> Files { get; set; } = new List<FolderFile>();
        public List<FolderNode> FolderNodes { get; set; } = new List<FolderNode>();
        public bool HasChild { get; set; } = false;

        public FolderNode(string packingPath, string outFilePath)
        {
            HasChildren(packingPath);
            DirectoryInfo directory = new DirectoryInfo(packingPath);
            FolderNodeName = directory.Name;
            if (HasChild)
            {
                foreach (var r in Directory.GetDirectories(packingPath).ToList())
                {
                    DirectoryInfo dir = new DirectoryInfo(r);
                    FolderNodes.Add(new FolderNode(dir.FullName, outFilePath));

                }
            }
            foreach (var r in Directory.GetFiles(packingPath).ToList())
            {
                Files.Add(new FolderFile(r, outFilePath));
            }
        }

        void HasChildren(string directoryPath)
        {
            bool result = Directory.GetDirectories(directoryPath).Length > 0 ? true : false;
            HasChild = result;
        }
    }
}
