using System;
using ProjetoFortes.Domain.Interface;
using ProjetoFortes.Infraestrutura.Data;

namespace ProjetoFortes.Infraestructure.Data.Configuration
{
    public class RepositoryManager : IRepositoryManager
    {
        public const string ContextoHttp = "ContextoHttp";

        //public Contexto Contexto
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Items[ContextoHttp]==null)
        //        {

        //        }
        //    }
        //}

        public void Finalizar()
        {
            throw new NotImplementedException();
        }
    }
}
