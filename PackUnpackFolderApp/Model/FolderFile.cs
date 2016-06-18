using System;
using System.IO;

namespace PackUnpackFolderApp.Model
{
    [Serializable]
    class FolderFile
    {
        public string FileName { get; set; }
        public long StartPosition { get; set; }
        public long EndPosition { get; set; }

        public FolderFile(string inFilePath, string outFilePath)
        {
            FileInfo file = new FileInfo(inFilePath);
            FileName = file.Name;
            SaveStream(inFilePath, outFilePath);
        }

        void SaveStream(string inFilePath, string outFilePath)
        {
            FileStream inStream = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
            FileStream outStream = new FileStream(outFilePath, FileMode.Append, FileAccess.Write);

            BufferedStream bufInStream = new BufferedStream(inStream);
            BufferedStream bufOutStream = new BufferedStream(outStream);

            StartPosition = outStream.Position;
            EndPosition = outStream.Length + inStream.Length;

            int bufSize = 8192;

            byte[] buf = new byte[bufSize];
            int bytesRead;

            while ((bytesRead = bufInStream.Read(buf, 0, bufSize)) > 0)
            {
                bufOutStream.Write(buf, 0, bytesRead);
            }

            bufInStream.Close();
            bufOutStream.Close();
            inStream.Close();
            outStream.Close();
        }
    }
}
