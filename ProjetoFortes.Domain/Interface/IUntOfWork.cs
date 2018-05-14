namespace ProjetoFortes.Domain.Interface
{
    public interface IUntOfWork
    {

        void Iniciar();
        void Persistir();
    }
}
