using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    class Rabbit
    {
        /* a rabbit can have Blue, Red or Black eyes
           a rabbit's fur can be white, brown, black or grey
           it has a gender
           has a birth date, and based on that you should be able 
           to see how old the rabbit is
        */
        private DateTime birthDate;
        private EyesColor eyesColor;
        private FurColor furColor;
        private Gender gender;
        private Owner owner;
       public Rabbit(EyesColor eyesColor, FurColor furColor, Gender gender, DateTime birthDate, Owner owner)
        {
            this.eyesColor = eyesColor;
            this.furColor = furColor;
            this.gender = gender;
            this.birthDate = birthDate;
            this.owner = owner;
        }       
        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthDate.Year;
                //return (int)(DateTime.Now - birthDate).TotalDays / 365;
            }
        }
        public Owner OwnerDetails
        {
            get
            {
                return this.owner;
            }
        }
        public FurColor Fur
        {
            get
            {
                return this.furColor;
            }
        }
        public EyesColor Eye
        {
            get
            {
                return this.eyesColor;
            }
        }
        public Gender Sex
        {
            get
            {
                return this.gender;
            }
        }
        public enum EyesColor
        {
            Blue,
            Red,
            Black
        }
        public enum FurColor
        {
            White,
            Brown,
            Grey
        }
        public enum Gender
        {
            Male,
            Female
        }
    }
}
