using static System.Console;
using System.IO;
class FileStatistics
{
   static void Main()
   {
      string fileName;
      Write("Enter a filename >> ");
      fileName = ReadLine();
      if(File.Exists(fileName))
      {
         WriteLine("File exists");
         WriteLine("File was created " +
            File.GetCreationTime(fileName));
         WriteLine("File was last written to " +
            File.GetLastWriteTime(fileName));
      }
      else
      {
         WriteLine("File does not exist");
      }
   }
}
