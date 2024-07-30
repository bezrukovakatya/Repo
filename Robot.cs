using System;

namespace PROJECT{
    abstract class Robot: Irun, Ijump{

        private static int count;
        private string name = null!;
        private int weight;
        private byte[] coordinates = null!;

        public string Name {
            get {
            return name;
            } 
            private set{}
        }


        public byte[] Coordinates {
            get {
            return coordinates;
            } 
            private set{}
        }
    

        protected string nickname;

        public int Weight{
            get{
                System.Console.WriteLine("Результат: ");
                return this.weight;
            }
            set{
                if(value < 1){
                    this.weight = 1;
                }else if( this.weight > 5000){
                    this.weight = 5000;
                }else{
                    this.weight = value;
                }
                
            }
        }

        public float speed { get; set; }
        public float y { get; set ; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Robot(string name, int weight, byte[] coordinates){
            System.Console.WriteLine("Object gas been created.");
            setValues(name, weight, coordinates);
            count++;
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Robot(){
            count++;
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Robot(string name){
            System.Console.WriteLine("Object gas been created.");
            this.name = name;
            count++;
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.


        public void setValues(string name, int weight, byte[] coordinates){
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void setValues(string name, int weight){
            this.name = name;
            this.weight = weight;
        }

        public void setValues(int weight){
            this.weight = weight;
        }

        public void setValues(string name){
            this.name = name;
        }

        public abstract void printValues();

        public static void Print(){
            System.Console.WriteLine("Count is " + count);
        }

        public void RobotRun()
        {
           Console.WriteLine("Robot is now running!");
        }

        public void Jump()
        {
            Console.WriteLine("Robot is jumping!");
        }
    }
}