namespace AbstractFactory.cs
{
    public class SystemPath
    {
        public string Path { get; private set; }

        public SystemPath(string path)
        {
            Path = path;
        }
    }
}
