using System.Text;

namespace PoE2Converter.Parsers;

public class Csd
{
    public string Path { get; set; }
    public Dictionary<string, CsdEntry> Entries { get; set; } = [];

}
public class CsdEntry
{
    public List<CsdSubEntry> Descriptions { get; set; } = [];
}
public class CsdSubEntry
{
    public string Operator { get; set; }
    public string Description { get; set; }
    public bool IsCanonical { get; set; }
    public Dictionary<string, int> Parameters { get; set; } = [];
}


public static class CsdParser
{

    public static Csd Parse(string filePath)
    {
        var name = Path.ChangeExtension(filePath.Split("\\metadata\\")[1], "");

        var result = new Csd { Path = "metadata/" + name[..^1].Replace("\\", "/") };
        CsdEntry current = null;

        var lines = File.ReadAllLines(filePath, Encoding.Unicode).Where(l => l.Trim().Length != 0).ToList();

        for (var i = 0; i < lines.Count; i++)
        {
            var line = lines[i];

            if (line[0] == '\t')
                continue;
            if (line.StartsWith("include"))
                continue;

            if (line.StartsWith("no_description"))
            {
                current = new CsdEntry();
                var entryName = line.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[1];
                result.Entries[entryName] = current;
                continue;
            }

            if (line.StartsWith("description"))
            {
                current = new CsdEntry();
                i++;
                if (i >= lines.Count)
                    break;
                line = lines[i];
                var parts = line.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (parts[0] != "1")
                    continue;

                result.Entries[parts[1]] = current;
                i++;
                var count = int.Parse(lines[i].Trim());
                for (var j = 0; j < count; j++)
                {
                    i++;
                    line = lines[i];
                    parts = line.Split('"', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                    var subEntry = new CsdSubEntry
                    {
                        Operator = parts[0],
                        Description = parts[1]
                    };
                    if (parts.Length > 2)
                    {
                        var parameters = parts[2].Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                        var isCanonical = parameters.FirstOrDefault(p => p == "canonical_line") != null;
                        if (isCanonical)
                        {
                            subEntry.IsCanonical = true;
                            parameters = parameters.Where(p => p != "canonical_line").ToArray();
                        }
                        for (var k = 0; k < parameters.Length; k += 2)
                        {
                            subEntry.Parameters.Add(parameters[k], int.Parse(parameters[k + 1]));
                        }
                    }
                    current.Descriptions.Add(subEntry);

                }
            }


        }
        return result;
    }
}