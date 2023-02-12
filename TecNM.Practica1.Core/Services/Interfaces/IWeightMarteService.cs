

using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Services.Interfaces;

//Realiza los calculos.
public interface IWeightMarteService {
    WeightMarte ProcessWeightMarte(PersonE personE);
}