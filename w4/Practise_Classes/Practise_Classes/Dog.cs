using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Practise_Classes
{
    class Dog
    {
        private readonly EyesColor eyesColor;
        private readonly FurColor furColor;
        private readonly Gender gender;
        private string dogName;
        private DateTime birthDate;
        private readonly Owner owner;

        public Dog(string dogName, EyesColor eyesColor, FurColor furColor, Gender gender, DateTime birthDate, Owner owner)
        {
            this.dogName = dogName;
            this.eyesColor = eyesColor;
            this.furColor = furColor;
            this.gender = gender;
            this.birthDate = birthDate;
            this.owner = owner;
        }

        public Owner OwnerDetails
        {
            get { return this.owner; }
        }
        public enum EyesColor
        {
            Blue,
            Black,
            Brown
        }
        public EyesColor Eyes
        {
            get { return this.eyesColor; }
        }

        public enum FurColor
        {
            White,
            Brown,
            Black
        }
        public FurColor Fur
        { 
            get { return this.furColor; } 
        }

        public enum Gender
        {
            Male,
            Female
        }
        public Gender Sex 
        { 
            get { return this.gender; } 
        }

        public string DogsName
        {
            get { return this.dogName; }
            set { dogName = value; }
        }

        public DateTime DogsDOB
        {
            get { return this.birthDate; }
            set { birthDate = value; }
        }
    }
}
