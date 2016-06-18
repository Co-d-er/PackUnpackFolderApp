using System;
using System.IO;
using System.Threading.Tasks;

namespace PackUnpackFolderApp.Model
{
    public class DataManager
    {
        string FilePath { get; set; }
        public string CurrentDirectory { get; set; } = Directory.GetCurrentDirectory();

        public Task Pack(string path)
        {
            return Task.Run(() => {
                FolderTree folder = new FolderTree(path);
                folder.Serialize();
            });
            
        }

        public Task Unpack(string filePath, string folderPath)
        {
            return Task.Run(() => {
                FilePath = filePath;
                FolderTree folder = new FolderTree();
                folder.Deserialize(filePath);

                Unpacking(folderPath, folder.FolderStructure);
            });
            
        }


        void Unpacking(string unpackingPath, FolderNode folderStructure)
        {
            unpackingPath = unpackingPath + "\\" + folderStructure.FolderNodeName;
            Directory.CreateDirectory(unpackingPath);
            DirectoryInfo d = new DirectoryInfo(unpackingPath);
            if (folderStructure.HasChild)
            {
                foreach (var r in folderStructure.FolderNodes)
                {
                    Unpacking(d.FullName, r);
                }
            }

            if (folderStructure.Files.Count != 0)
            {
                foreach (var r in folderStructure.Files)
                    FileSerialize(r, d.FullName);
            }
        }

        void FileSerialize(FolderFile file, string path)
        {
            path = path + "\\" + file.FileName;
            FileStream infile = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            FileStream outfile = new FileStream(path, FileMode.CreateNew, FileAccess.Write);


            BufferedStream bufInStream = new BufferedStream(infile);
            bufInStream.Position = file.StartPosition;
            BufferedStream bufOutStream = new BufferedStream(outfile);

            int bufSize = 8192;

            byte[] buf = new byte[bufSize];
            int bytesRead;

            long bufPosition = ((file.EndPosition - bufInStream.Position) / bufSize * bufSize) + bufInStream.Position;
            int lastBufSize = Convert.ToInt32(file.EndPosition - bufPosition);

            while (bufInStream.Position < bufPosition)
            {
                bytesRead = bufInStream.Read(buf, 0, bufSize);
                bufOutStream.Write(buf, 0, bytesRead);
            }
            byte[] lastBuf = new byte[lastBufSize];
            bytesRead = bufInStream.Read(lastBuf, 0, lastBufSize);
            bufOutStream.Write(lastBuf, 0, bytesRead);

            bufInStream.Close();
            bufOutStream.Close();
            infile.Close();
            outfile.Close();
        }
    }
}
