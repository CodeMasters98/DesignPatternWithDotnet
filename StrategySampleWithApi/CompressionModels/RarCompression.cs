namespace StrategySampleWithApi.CompressionModels;

public class RarCompression : ICompressionStrategy
{
    public void Compress(string filePath) => Console.WriteLine("Compressing with Rar");
}
