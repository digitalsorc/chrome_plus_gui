namespace ChromePlusGUI.Models;

public class ExecutableInfo
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Name} - {Path} ({Source})";
    }
}
