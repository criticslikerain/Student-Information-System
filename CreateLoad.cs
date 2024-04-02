using System.Speech.Synthesis;

namespace Student_Information_System
{


  class CreateLoad
  {



    public static void Load()
    {

      SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      Console.Clear();
      Thread.Sleep(500);
    
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n\n\n");
      Console.WriteLine(@"
      
      
      
                                                                                                        ╔════════════════════════╗
                                                                                                        ║   CREATING ACCOUNT...  ║
                                                                                                        ╚════════════════════════╝

                                                                                      
                                                                                                              █▒▒▒▒▒▒▒▒▒ 10%



                                                                                                 
      ");
        run.Speak("Creating account..");
        Load2();
    }

        public static void Load2()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n\n\n");
      Console.WriteLine(@"
      
      
      
                                                                                                        ╔════════════════════════╗
                                                                                                        ║   CREATING ACCOUNT...  ║
                                                                                                        ╚════════════════════════╝

                                                                                      
                                                                                                              ████▒▒▒▒▒▒ 30%



                                                                                                 
      ");
        Thread.Sleep(1000);
        Load3();
    }

        public static void Load3()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n\n\n");
      Console.WriteLine(@"
      
      
      
                                                                                                        ╔════════════════════════╗
                                                                                                        ║   CREATING ACCOUNT...  ║
                                                                                                        ╚════════════════════════╝

                                                                                      
                                                                                                              █████▒▒▒▒▒ 50%



                                                                                                 
      ");
        Thread.Sleep(1000);
        Load4();
    }

        public static void Load4()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n\n\n");
      Console.WriteLine(@"
      
      
      
                                                                                                        ╔════════════════════════╗
                                                                                                        ║   CREATING ACCOUNT...  ║
                                                                                                        ╚════════════════════════╝

                                                                                      
                                                                                                              ████████▒▒ 80%



                                                                                                 
      ");
        Thread.Sleep(1500);
        Load5();
    }

        public static void Load5()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n\n\n");
      Console.WriteLine(@"
      
      
      
                                                                                                        ╔════════════════════════╗
                                                                                                        ║   CREATING ACCOUNT...  ║
                                                                                                        ╚════════════════════════╝

                                                                                      
                                                                                                              ██████████ 100%


      
                                                                                                 
      ");
        Thread.Sleep(1000);
        CreateAccount.CreateUser();
    }
  }
}