using System;
using System.Net.Http.Headers;

namespace ThiefAndPolice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            int SizeY = 100;
            int SizeX = 25;
            int prisonX=10;
            int prisonY=10;
            Person[,] matrix = new Person[SizeX, SizeY];
            Person[,] prisonMatrix = new Person[prisonX, prisonY];
            int amountOfThives = 10;
            int amountOfPolice = 20;
            int amountOfCitizen = 20;
         

            //Grid grid = new Grid(SizeX, SizeY);
            //matrix = Grid.CreateGrid(SizeX, SizeY, matrix);

            

            

            List<Person> personList = new List<Person>(); //ini list
            List<Person> prisonList = new List<Person>();

            Random rnd = new Random();
            int posX;
            int posY;
            int xDirection;
            int yDirection;
            for (int i = 0; i < amountOfThives; i++) //put thives in list
            {
                do
                {
                    posX = rnd.Next(SizeX);
                    posY = rnd.Next(SizeY);
                }
                while (matrix[posX, posY] != null); //Check if empty else roll again
                


                do
                {
                    xDirection = rnd.Next(-1, 2);
                    yDirection = rnd.Next(-1, 2);
                } while (xDirection == 0 && yDirection == 0); //check if empty roll again


                Thief thief = new Thief(posX, posY,xDirection,yDirection);
                matrix[posX, posY] = thief; //add thief to matrix[posX,PosY]
                personList.Add(thief);
            }

            for (int i = 0; i < amountOfPolice; i++)//put police in list
            {
                do
                {
                    posX = rnd.Next(SizeX);
                    posY = rnd.Next(SizeY);
                }
                while (matrix[posX, posY] != null); //Check if empty else roll again
                


                do
                {
                    xDirection = rnd.Next(-1, 2);
                    yDirection = rnd.Next(-1, 2);
                } while (xDirection == 0 && yDirection == 0); //check if empty roll again

                Police police = new Police(posX, posY,xDirection,yDirection);
                matrix[posX, posY] = police; 
                personList.Add(police);
            }

            for (int i = 0; i < amountOfCitizen; i++) //add citizen to list
            {
                do
                {
                    posX = rnd.Next(SizeX);
                    posY = rnd.Next(SizeY);
                }
                while (matrix[posX, posY] != null); //Check if empty else roll again
                


                do
                {
                    xDirection = rnd.Next(-1, 2);
                    yDirection = rnd.Next(-1, 2);
                } while (xDirection == 0 && yDirection == 0); //check if empty roll again

                Citizen citizen = new Citizen(posX, posY, xDirection, yDirection);
                matrix[posX, posY] = citizen; //add police to matrix[posX,PosY]
                personList.Add(citizen);
            }
            
            while (true)
            {
                Grid.Print(SizeX, SizeY, matrix);
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.WriteLine("PRISON");
                Grid.PrintPrison(prisonX, prisonY, prisonMatrix);

                for (int i = 0; i < prisonList.Count; i++)
                {
                    Person person = prisonList[i];
                    if (person is Thief)
                    {
                        Thief thief = (Thief)person; // Cast to Thief type
                        if (thief.PrisonTime > 0)
                        {
                            Helper.PrisonMovement(thief, prisonMatrix, prisonX, prisonY, personList, prisonList);
                            thief.PrisonTime--;
                            Thread.Sleep(1000);
                            if (thief.PrisonTime <= 0)
                            {

                                Helper.MoveBackToCity(thief, personList, prisonList, prisonMatrix);
                                
                            }
                        }
                        

                    }
                }

                    for (int i = 0; i < personList.Count; i++)
                    {
                    Person person = personList[i];
                    if (person!= null)
                    {
                            Helper.Movement(person, matrix, SizeX, SizeY, personList, prisonList);
                        
                        
                    }
                    
                    }
                
                
                
                //Thread.Sleep(1000);
                //prisonTime--;
                Console.Clear();
                

            }
        }


    }
    
}