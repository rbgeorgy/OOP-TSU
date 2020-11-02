using System;
using System.Collections.Generic;

namespace OOPFirstSemester
{
    class Program
    {
        static void Main(string[] args)
        {

            WoodDuck woodDuck2 = new WoodDuck();
            woodDuck2.ShowInfo();


            RubberDuck rubberDuck2 = new RubberDuck();
            rubberDuck2.ShowInfo();


            LittleDuck littleDuck2 = new LittleDuck();
            littleDuck2.ShowInfo();


            CommonDuck commonDuck2 = new CommonDuck();
            commonDuck2.ShowInfo();

            CommonTurkeyCock commonTurkeyCock = new CommonTurkeyCock();
            commonTurkeyCock.ShowInfo();

            Duck transGenderDuck = new AdapterTurkeyCock(commonTurkeyCock);
            transGenderDuck.ShowInfo();


            Console.WriteLine("Èç ìàññèâà:");
            Duck[] arr = { woodDuck2, rubberDuck2, transGenderDuck };
            DuckArrayFromArray duckarray = new DuckArrayFromArray(arr);
            duckarray.PrintAll();


            Console.WriteLine("Èç ëèñòà:");

            List<Duck> list = new List<Duck>();
            list.Add(woodDuck2);
            list.Add(rubberDuck2);
            list.Add(transGenderDuck);

            DuckArrayFromList duckList = new DuckArrayFromList(list);
            duckList.PrintAll();

            BirdForSale testBird = new StandardBirdForSale();
            Console.WriteLine(testBird.Price());
            Console.WriteLine(testBird.Info());

            testBird = new PluckedBird(testBird);
            Console.WriteLine(testBird.Price());
            Console.WriteLine(testBird.Info());

            testBird = new FriedBird(testBird);
            Console.WriteLine(testBird.Price());
            Console.WriteLine(testBird.Info());

            commonDuck2.MakeSellable();
            commonDuck2.BirdForSalePropSet = new StuffedBird(testBird);
            Console.WriteLine(commonDuck2.BirdForSaleProp.Price());
            Console.WriteLine(commonDuck2.BirdForSaleProp.Info());

            
            list.Add(commonDuck2);
            duckList = new DuckArrayFromList(list);

            DuckStorage duckStorageObject = DuckStorage.Get();            
            duckStorageObject.Storage = duckList;
            duckStorageObject.Storage.PrintAll();

            Console.ReadLine();
        }
    }
}