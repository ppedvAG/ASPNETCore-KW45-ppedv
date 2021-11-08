using System;

namespace DependencyInversionSample
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ICarService carService = new CarService();

    //        ICar testobject = new MockCar(); //Testobjekt mit festen Werten

    //        carService.RepairCar(testobject); //Funktionstest


    //        wenn alles fertig ist
    //        ICar carObject = new Car(); //Produktive Objekt
    //        carService.RepairCar(carObject);
    //    }
    //}

    #region Schlechtes Beispiel in OOP
    // DLL "verschmelzen" -> keine lose Kopplung
    // Verwenden ist nicht Teamorientiert 

    #region Entities.dll 
    public class BadCar //Programmierer A: 5 Tage (von Tag 1 - Tag 5) 
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
    #endregion





    #region Service.dll -> benötigt unbedingt die Entities.dll
    public class BadCarService //Programmierer B: 3 Tage (von 5/6 - 8)
    {
        public void RepairCar(BadCar car) //Harte Verdrahtung: 1) Dll können nicht lose Versioniert und verwendet werden 
        {
            //Repariere Auto
            //....
        }
    }
    #endregion
    #endregion

    #region Best Practise 
    //Konzept ist möglich -> Code First 

    #region inteface.dll
    
    public interface ICar
    {
        int Id { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
    }

    public interface ICarService
    {
        void RepairCar(ICar car);
    }
    #endregion





    #region Entities.dll
    //Programmierer A: 5 Tage (von Tag 1 - Tag 5) 
    public class Car : ICar
    {
        public int Id { get; set;}
        public string Brand { get; set; }
        public string Model { get; set; }
    }
    #endregion


    #region Service.dll -> interfaces.dll 
    //Programmierer B: 3 Tage 
    public class CarService : ICarService
    {
        public void RepairCar(ICar car)
        {
           //Repariere Auto 
        }
    }


    //Programmierer B: kann an Tag ein Mock-Objekt schreiben und seine Funktion testen
    public class MockCar : ICar
    {
        public int Id { get; set; } = 1;
        public string Brand { get; set; } = "VW";
        public string Model { get; set; } = "Polo";
    }
    #endregion
    #endregion
}
