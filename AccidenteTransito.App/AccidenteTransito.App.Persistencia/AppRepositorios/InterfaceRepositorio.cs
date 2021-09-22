using System.Collections.Generic;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia{

    public interface InterfaceRespositorio{
        IEnumerable<Accidente> GetAllAccidentes();
    } 
}