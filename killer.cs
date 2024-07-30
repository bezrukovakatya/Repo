using System;

namespace PROJECT{

    enum Type {Hero, Enemy, Traitor}
    class Killer : Robot{

        public Type type;
        public int Health {get; set;}

        public void Lazer(){
            System.Console.WriteLine("Lazer shooting! Paw-paw-paw!!!");
            this.nickname = "Doe";
        }

        public Killer() {}

        public override void printValues(){
            System.Console.WriteLine(this.Name + " weight " + this.Weight);
            System.Console.WriteLine("Health is: " + this.Health);

            if (this.type == Type.Hero) {
                Console.WriteLine("He is Hero!");
            }
        }

        public Killer(string name, int weight, byte[] coordinates, int health, Type type) : base(name, weight, coordinates) {
            this.Health = health;
            this.type = type;
        }
    }
}