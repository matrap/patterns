namespace AbstractFactory.cs
{
    public interface IPathFactory
    {
        SystemPath GetPath(string directory, string subDirectory);
    }
}
