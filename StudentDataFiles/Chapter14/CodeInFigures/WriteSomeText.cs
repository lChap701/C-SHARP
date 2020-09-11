using static System.Console;
using System.IO;
class WriteSomeText
{
   static void Main()
   {
      FileStream outFile = new
         FileStream("SomeText.txt", FileMode.Create,
            FileAccess.Write);
      StreamWriter writer = new StreamWriter(outFile);
      Write("Enter some text >> ");
      string text = ReadLine();
      writer.WriteLine(text);
      // Error occurs if the next two statements are reversed
      writer.Close();
      outFile.Close();
   }
}
