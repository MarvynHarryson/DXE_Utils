namespace Obj.Hydrator.Interfaces
{
    public interface IGenerator
    {
        object Generate();
    }

    public interface IGenerator<T>
    {
        T Generate();
    }
}
