
using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;


public static class Program {

    public static void Main(string[] args){

        
        float weight = 0;

        System.Console.WriteLine("Please enter the Weight in the earth:");
        Single.TryParse(System.Console.ReadLine(), out weight);

        

        var personE = new PersonE{Weight = weight};

        var service = new WeightMarteService();
        var manager = new WeightMarteManager(service);

        WeightMarte weightMarte = manager.GetWeightMarte(personE);

        System.Console.WriteLine($"Weight in Mars {weightMarte.Index}");

        

    }

}
