namespace StrategySampleWithApi.CompressionModels;

public class ZipCompression : ICompressionStrategy
{
    public void Compress(string filePath) => Console.WriteLine("Compressing with ZIP");
}
