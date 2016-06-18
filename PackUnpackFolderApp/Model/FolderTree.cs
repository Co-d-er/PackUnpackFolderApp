using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PackUnpackFolderApp.Model
{
    class FolderTree
    {
        public FolderNode FolderStructure { get; set; }
        string FilePath { get; set; }

        public FolderTree()
        {

        }

        public FolderTree(string packingPath)
        {
            FilePath = GenerateUniqueFileName();
            FolderStructure = new FolderNode(packingPath, FilePath);            
        }

        public void Serialize()
        {            
            FileStream fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {                
                long res = fs.Length;
                formatter.Serialize(fs, FolderStructure);

                // save FolderNode object position in the file
                formatter.Serialize(fs, res);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public void Deserialize(string filePath)
        {
            FileStream inStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            // set position in the file to get a FolderNode object position  
            inStream.Position = inStream.Length - 58;
            BinaryFormatter myformatter = new BinaryFormatter();

            // get a FolderNode object position in the file
            long nodePosition = (long)myformatter.Deserialize(inStream);
            inStream.Position = nodePosition;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FolderStructure = (FolderNode)formatter.Deserialize(inStream);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                inStream.Close();
            }
        }

        string GenerateUniqueFileName()
        {
            string fileName = Path.GetRandomFileName();
            fileName = fileName.Split('.')[0] + ".bak";
            return fileName;
        }

    }
}

