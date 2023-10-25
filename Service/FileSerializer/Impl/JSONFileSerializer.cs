using System.Text.Json;

namespace tetofo.Service.FileSerializer.Impl;

public class JSONFileSerializer : IAsyncFileSerializer
{
    public async Task<R?> DeserializeFromFileAsync<R>(string path)
    {
        string content = await File.ReadAllTextAsync(path);
        return (R?)JsonSerializer.Deserialize(content, typeof(R));
    }

    public async Task SerializeToFileAsync(string path, object o)
    {
        await File.WriteAllTextAsync(path, JsonSerializer.Serialize(o));
    }
}