namespace AbstractFactory.cs
{
    public class WindowsPathFactory : IPathFactory
    {
        public SystemPath GetPath(string directory, string subDirectory)
        {
            string path = string.Format("\\{0}\\{1}",directory, subDirectory);
            return new SystemPath(path);
        }
    }
}
