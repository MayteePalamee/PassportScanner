using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportScanner
{
    public class Response
    {
        private String passportNumber;
        private String personalNumber;
        private String nationCode;
        private String name;
        private String lastName;
        private String birthDate;
        private String gender;
        private String expireDate;
        private String image;
        private String message;

        public String PassportNumber
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }
        public String PersonalNumber
        {
            get { return personalNumber; }
            set { personalNumber = value; }
        }
        public String NationCode
        {
            get { return nationCode; }
            set { nationCode = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public String BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public String ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }
        public String Image
        {
            get { return image; }
            set { image = value; }
        }
        public String Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
