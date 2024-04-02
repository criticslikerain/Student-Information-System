using System.Numerics;
using System.Speech.Synthesis;

namespace Student_Information_System
{

  class SIS
  {

    public void Display()
    {
              SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);
                run.Rate = 1;
            int windowWidth = Console.WindowWidth;
            int boxWidth = 60;
            int leftMargin = (windowWidth - boxWidth);
            int input;

      do{
      Console.Clear();
      Console.ResetColor();
      Console.WriteLine("\n\n");
      Console.WriteLine(@"
      
      
                                                                      ╔═══════════════════════════════════════════════════════════════════════════════════╗
                                                                      ║                                                                                   ║
                                                                      ║    █▀ ▀█▀ █░█ █▀▄ █▀▀ █▄░█ ▀█▀   █ █▄░█ █▀▀ █▀█ █▀█ █▀▄▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█      ║
                                                                      ║    ▄█ ░█░ █▄█ █▄▀ ██▄ █░▀█ ░█░   █ █░▀█ █▀░ █▄█ █▀▄ █░▀░█ █▀█ ░█░ █ █▄█ █░▀█      ║
                                                                      ║                                                                                   ║     
                                                                      ║                             █▀ █▄█ █▀ ▀█▀ █▀▀ █▀▄▀█                               ║ 
                                                                      ║                             ▄█ ░█░ ▄█ ░█░ ██▄ █░▀░█                               ║
                                                                      ║                                                                                   ║
                                                                      ║                                                                                   ║
                                                                      ║                                                                                   ║
                                                                      ║     １．Ｌｏｇｉｎ                                ３．Ｆｏｒｇｏｔ Ａｃｃｏｕｎｔ                       ║
                                                                      ║                                                                                   ║
                                                                      ║                                                                                   ║   
                                                                      ║                                                                                   ║
                                                                      ║     ２. Ｃｒｅａｔｅ Ｎｅｗ Ａｃｃｏｕｎｔ                  ４．Ｅｘｉｔ Ｐｒｏｇｒａｍ                         ║
                                                                      ║                                                                                   ║ 
                                                                      ║                                                                                   ║ 
                                                                      ║                                                                                   ║ 
                                                                      ║                                                                                   ║ 
                                                                      ║      Ｅ Ｎ Ｔ Ｅ Ｒ    Ｃ Ｈ Ｏ Ｉ Ｃ Ｅ ：                                                   ║ 
                                                                      ║                                                                                   ║ 
                                                                      ║                                                                                   ║ 
                                                                      ║                                                                                   ║
                                                                      ╚═══════════════════════════════════════════════════════════════════════════════════╝      

                                                                        








                                                                                           Copyright 2024 Group2. All rights reserved.
                                                                                                     


    
      ");
      
  
      
      Console.SetCursorPosition(leftMargin - 70, Console.CursorTop - 21);
      string choice = Console.ReadLine();
      
      while(!int.TryParse(choice, out input) || input < 1 || input > 4)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        
        Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tINVALID INPUT!");
        run.Speak("Invalid Input!");
        Display();
    

      }


      switch(input)
      {


        case 1: Console.Beep(); Login run1 = new Login(); run1.LoginUser(); break;
        case 2: Console.Beep(); CreateLoad.Load(); break;
        case 3: Console.Beep(); ForgotAccount.ForgotUser();  break;
        case 4: Console.Beep(); Termination.Exit(); break;

        
        } 
       }while(false);  
    }
  }
}