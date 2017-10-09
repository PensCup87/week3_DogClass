using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_DogClass
{
    class Dog
    {
        //Fields
        private string furLength;
        private float height;
        private string runningSpeed;
        private int weight;

        //PROPERTIES
        public string FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }
        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //CONSTRUCTOR
        public Dog()
        {
            //default constructor
            //USE A DEFAULT CONSTRUCTOR IF YOU WANT A CONSTRUCTOR WITH PARAMETERS
        }
        
        //OVERLOADED CONSTRUCTOR
        //Can have as many OverLoaded Constructors
        //If you reverse the order of the states, it counts as a NEW Constructor
        public Dog(string furLength, float height)
        {
            this.furLength = furLength;
            this.height = height;
        }




    }
}
