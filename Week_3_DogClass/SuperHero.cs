using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_DogClass
{
    class SuperHero
    {
        //Super Villan Field
        private string villanName;
        private bool canTrack;
        private double health;
        private string weapon;

        //Properties
        public string VillanName
        {
            get {return this.villanName;}
            set { this.villanName = value; }
        }
        public bool CanTrack
        {
            get { return this.canTrack; }
            set { this.canTrack = value; }
        }
        public double Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public string Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        //CONSTRUCTORS
        public SuperHero()
        {

        }
        //First Class Constructor
        public SuperHero(string villanName, string weapon)
        {
            this.villanName = villanName;
            this.weapon = weapon;
        }
        //Second Class Constructor
        public SuperHero(bool canTrack, double health)
        {
            this.canTrack = canTrack;
            this.health = health;
        }

        public void Find()
        {
            villanName = "People cry: JASON!";
            weapon = "Becomes a Slashing Device!";
        }

        public void LocatingPeople()
        {
            //canTrack = true;
            health = health + 10;
        }
    }
}
