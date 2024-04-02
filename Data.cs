namespace Student_Information_System
{
    class Data
    { 
      
        private string user_role; 
        private string username;
        private string password;
        private string birthdate;
        private string name;
        private string surname;
        private string email;
        private string contactNum;
        private string emergencyContact;
        private string address;
        private string userID;
        private string registrationDate;
        private string gender;
        private string religion;
        private string nationality;
        private string gradeYear;
        private string enrollmentStatus;


        public string UserRole
        {
          get{return user_role;}
          set{user_role = value;}
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
          get {return email;}
          set {email = value;}
        }

        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string ContactNum
        {
            get { return contactNum; }
            set { contactNum = value; }
        }

        public string EmergencyContact
        {
            get { return emergencyContact; }
            set { emergencyContact = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Religion
        {
            get { return religion; }
            set { religion = value; }
        }

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public string GradeYear
        {
            get { return gradeYear; }
            set { gradeYear = value; }
        }

        public string EnrollmentStatus
        {
            get { return enrollmentStatus; }
            set { enrollmentStatus = value; }
        }
    }
}
