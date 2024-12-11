using Newtonsoft.Json;

namespace Extractor.Parsers;

public class Metadata : MetaDataNode
{
    public string Path { get; set; }
    public string Extends { get; set; }
    public override string ToString()
    {
        return Key ?? Path;
    }
}

public class MetaDataNode
{
    public string Key { get; set; }
    public object Value { get; set; }
    [JsonIgnore]
    public MetaDataNode Parent { get; set; }
    public List<MetaDataNode> Children { get; set; } = new();
    public override string ToString()
    {
        return Key;
    }
}

public static class MetadataParser
{
    public static Metadata Parse(string filePath)
    {
        var name = Path.ChangeExtension(filePath.Split("\\metadata\\")[1], "");

        var root = new Metadata { Path = "metadata/" + name[..^1].Replace("\\", "/") };

        MetaDataNode current = root;
        string previousLine = null;
        foreach (var line in File.ReadLines(filePath))
        {
            var trimmed = line.Trim();

            // Ignore empty lines or comments (if any)
            if (string.IsNullOrWhiteSpace(trimmed) || trimmed.StartsWith("#"))
                continue;


            if (trimmed == "{") // Start of a new block
            {
                if (previousLine != null)
                {
                    var child = new MetaDataNode
                    {
                        Key = previousLine,
                        Parent = current
                    };

                    current.Children.Add(child);
                    current = child;

                }
            }
            else if (trimmed == "}") // End of the current block
            {
                current = current.Parent;

            }
            else if (trimmed.StartsWith("extends")) // Inheritance
            {
                var parts = trimmed.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                var value = JsonConvert.DeserializeObject(parts[1]);
                root.Extends = value.ToString().ToLowerInvariant();
                if (root.Extends == "nothing")
                    root.Extends = null;

            }
            else if (trimmed.Contains('=')) // Key-value pair
            {
                var parts = trimmed.Split('=', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var key = parts[0];
                var value = JsonConvert.DeserializeObject(parts[1]);
                var arrayEntry = current.Children.FirstOrDefault(c => c.Key == key);
                current.Children.Add(new MetaDataNode
                {
                    Key = key,
                    Value = value,
                    Parent = current
                });

            }
            previousLine = trimmed;
        }

        return root;
    }

    public static Metadata Merge(Metadata parent, Metadata child)
    {
        if (parent == null) return child;
        if (child == null) return parent;

        child.Extends = parent.Extends;

        foreach (var parentChild in parent.Children)
        {
            var existingNode = child.Children.FirstOrDefault(c => c.Key == parentChild.Key);
            if (existingNode == null)
                child.Children.Add(parentChild);
            else
            {
                existingNode.Children.AddRange(parentChild.Children);
            }
        }

        return child;
    }
}
