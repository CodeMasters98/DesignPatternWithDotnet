namespace StrategySampleWithApi.CompressionModels;

public class Compressor
{
    private readonly ICompressionStrategy _strategy;

    public Compressor(ICompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Compress(string filePath) => _strategy.Compress(filePath);
}

