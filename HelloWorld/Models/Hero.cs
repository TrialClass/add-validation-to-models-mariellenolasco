using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Hero
    {
        private string heroName;
        public string HeroName { 
            get {
                return this.heroName;
            } 
            set {
                if(value == null) throw new ArgumentException();
                this.heroName=value;
            }
        }
        public string SuperPower { get; set; }

    }
}
