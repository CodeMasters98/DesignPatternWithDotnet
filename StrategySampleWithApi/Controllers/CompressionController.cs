using Microsoft.AspNetCore.Mvc;
using StrategySampleWithApi.CompressionModels;

namespace StrategySampleWithApi.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class CompressionController : ControllerBase
{
    private readonly Func<string, ICompressionStrategy> _compressionStrategyFactory;

    public CompressionController(Func<string, ICompressionStrategy> compressionStrategyFactory)
    {
        _compressionStrategyFactory = compressionStrategyFactory;
    }

    [HttpPost]
    public IActionResult CompressFile(string filePath, string type)
    {
        try
        {
            var strategy = _compressionStrategyFactory(type);
            var compressor = new Compressor(strategy);
            compressor.Compress(filePath);
            return Ok($"File compressed using {type.ToUpper()}.");
        }
        catch (ArgumentException)
        {
            return BadRequest("Invalid compression type.");
        }
    }
}
