namespace Student_Information_System
{

  class Concealer
  {

     public static string MaskInput()
{
    string input = "";
    ConsoleKeyInfo keyInfo;

    do
    {
        keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.Backspace && input.Length > 0)
        {
         
            input = input.Substring(0, input.Length - 1);
            Console.Write("\b \b");
        }
        else if (!char.IsControl(keyInfo.KeyChar))
        {
            Console.Write(keyInfo.KeyChar);
                Thread.Sleep(50); 
                Console.Write("\b*"); 
                input += keyInfo.KeyChar;
        }
       
    } while (keyInfo.Key != ConsoleKey.Enter);

    return input;
    }
  }
}