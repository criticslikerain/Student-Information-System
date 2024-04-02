using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Speech.Synthesis;

namespace Student_Information_System 
{
    class CreateAccount
    {
        public static void CreateUser()
        {
            

            Data newUserData = new Data();
            SpeechSynthesizer run = new SpeechSynthesizer();
            run.SelectVoiceByHints(VoiceGender.Male);
            run.Rate = 1;
            int windowWidth = Console.WindowWidth;
            int boxWidth = 60;
            int leftMargin = (windowWidth - boxWidth);


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            

            Console.WriteLine(@"
                 
                                 ╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
                                 |                                                                                                                                                                               |
                                 |                                                                  S T U D E N T   I N F O R M A T I O N                                                                        |
                                 |                                                                                                                                                                               |
                                 |                                                                       A C C O U N T   C R E A T E                                                                             |         
                                 |                                                                                                                                                                               |
                                 |_______________________________________________________________________________________________________________________________________________________________________________|                                                                                                                                                           
                                 |                                                                                                                                                                               |                                                                                                                                                      
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |   N A M E:                                                  S U R N A M E:                                           B I R T H D A T E:                                       |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |   
                                 |   C O N T A C T #:                                          E M A I L:                                               A D D R E S S:                                           |                                                                                    
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               | 
                                 |   G E N D E R:                                              R E L I G I O N:                                         N A T I O N A L I T Y:                                   |                                                      
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |  G R A D E  Y E A R:                                        E N R O L L M E N T   S T A T U S:                  - - - ( A C T I V E  /  I N A C T I V E  /  G R A D U A T E ) |                                                      
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 |  O R G A N I Z A T I O N  R O L E:                                               - - - ( S T U D E N T  /  T E A C H E R  /  A D M I N )                                      |                                                                                                          
                                 |                                                                                                                                                                               |
                                 |                                                                                                                                                                               |
                                 ╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝

            
            ");
            
        
            newUserData.UserRole = Console.ReadLine();


            newUserData.Username = Console.ReadLine();

            
            newUserData.Password = Concealer.MaskInput();

            
            newUserData.Name = Console.ReadLine();

           
            newUserData.Surname = Console.ReadLine();

            
            newUserData.Birthdate = Console.ReadLine();

    
            newUserData.ContactNum = Console.ReadLine();

           
            newUserData.Email = Console.ReadLine();

            newUserData.EmergencyContact = Console.ReadLine();

       
            newUserData.Address = Console.ReadLine();

        
            newUserData.UserID = Console.ReadLine();

            newUserData.RegistrationDate = DateTime.Now.ToString();

      
            newUserData.Gender = Console.ReadLine();

          
            newUserData.Religion = Console.ReadLine();

            
            newUserData.Nationality = Console.ReadLine();


            newUserData.GradeYear = Console.ReadLine();

         
            newUserData.EnrollmentStatus = Console.ReadLine();


            string jsonData = JsonConvert.SerializeObject(newUserData, Formatting.Indented);

            string filePath = "user_data.json";
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[" + jsonData + "]");
            }
            else
            {
                List<Data> userList = JsonConvert.DeserializeObject<List<Data>>(File.ReadAllText(filePath));
                userList.Add(newUserData);
                string updatedJsonData = JsonConvert.SerializeObject(userList, Formatting.Indented);
                File.WriteAllText(filePath, updatedJsonData);
            }

            Console.WriteLine("New account created successfully!");
        }
    }
}
