using System.Collections.Generic;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia{

    public interface InterfaceRespositorioAccidente{
        IEnumerable<Accidente> GetAllAccidentes();

        Accidente AddAccidente(Accidente accidente);

        Accidente UpdateAccidente(Accidente accidente);

        void DeleteAccidente(int Id);

        Accidente GetAccidente(int Id);
    } 

}