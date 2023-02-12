
using TecNM.Practica1.Core.Entities;

using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class WeightMarteService: IWeightMarteService{

    public  WeightMarte ProcessWeightMarte(PersonE personE){

        var weightMarte = new WeightMarte();
        
        weightMarte.Index = (float)((personE.Weight/9.81) * 3.71);

        return weightMarte;

    }

}
