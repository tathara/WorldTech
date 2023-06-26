namespace WorldTech.DI
{
    public interface ICheckData<T>
    {
        IEnumerable<T> ReadAllChecks();
        void AddCheck(T check);
        void RemoveCheck(T check);
        ICheck FindCheck(T check);
    }
}
