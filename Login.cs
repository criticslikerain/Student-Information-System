using System;
using Newtonsoft.Json;
using System.IO;
using System.Threading; 
using System.Speech.Synthesis;

namespace Student_Information_System
{
    class Login
    {
        public string LoginUser()
        {
            Console.Clear();
            Console.WriteLine(@"
            
             
                                                                                                             ▓▓▓▓▓▓    
                                                                                                          ▓▓▓▓▓▓▓▓▓▓▓▓  
                                                                                                          ▓▓▓▓▓▓▓▓▓▓▓▓  
                                                                                                          ▓▓▓▓▓▓▓▓▓▓▓▓  
                                                                                                             ▓▓▓▓▓▓    
                                                                                                       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓   
                                                                                                      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓       
                                                                                                      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    
            
            ");
           
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                   Student Information System               ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                             Login                          ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╚════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n");
        
            int windowWidth = Console.WindowWidth;
            int boxWidth = 60;
            int leftMargin = (windowWidth - boxWidth);

          
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║  Username:                                                 ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║  Password:                                                 ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╚════════════════════════════════════════════════════════════╝");

     
          Console.SetCursorPosition(leftMargin - 83, Console.CursorTop - 8);
          string username = Console.ReadLine();

      
          Console.SetCursorPosition(leftMargin - 83, Console.CursorTop + 2);
          string password = Concealer.MaskInput();

            string filePath = "user_data.json";
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                var userList = JsonConvert.DeserializeObject<Data[]>(jsonData);

                foreach (var user in userList)
                {
                    if (user.Username == username && user.Password == password)
                    {   
                        Console.WriteLine("\n\n\n\n\n\n");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t  ╔═════════════════════╗");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t  ║  Login Successful ! ║");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t  ╚═════════════════════╝");
                        Thread.Sleep(3000); // 3 seconds delay
                        Console.Clear();

                        // Display user information
                        UserInformation.DisplayUserInfo(user);
                        
                    }

                    if (user.Username == username && user.Password != password)
                    {
                        

                    }


                    if (username != user.Username &&  password != user.Password)

                    {

                       NoUserFound();

                     }
                }

            }
            
            return password;
        }
        public int WrongPassword()
        {
            int limit = 3;
            
            return limit;
            
        }



        public void NoUserFound()
        {
             SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);
                run.Rate = 1;
            
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("\n\n\n\n\n");
             Console.WriteLine(@"
                                                                                ╔═════════════════════════════════════════════════════════════╗
                                                                                ║     No user data found!, Please create an account first.    ║
                                                                                ╚═════════════════════════════════════════════════════════════╝
             ");
             run.Speak("No user Data Found, Please create an account first!");
             Console.ResetColor();
             SIS run1 = new SIS(); run1.Display();
        }
    }
}
