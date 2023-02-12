using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;
//

public class WeightMarteManager : IWeightMarteManager{
    //_ sirve para que sea privada
    private readonly IWeightMarteService _service;
    //constructor
    public WeightMarteManager(IWeightMarteService service){
        _service = service;
    }

    public WeightMarte GetWeightMarte(PersonE personE){
        return _service.ProcessWeightMarte(personE);
    }


}