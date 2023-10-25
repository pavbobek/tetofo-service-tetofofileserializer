namespace tetofo.Service.FileSerializer;

public interface IAsyncFileSerializer {
    Task<R?> DeserializeFromFileAsync<R>(string path);
    Task SerializeToFileAsync(string path, object o);
}