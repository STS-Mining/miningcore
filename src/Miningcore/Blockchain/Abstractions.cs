namespace Miningcore.Blockchain;

public class BlockchainStats
{
    public string NetworkType { get; set; }
    public double NetworkHashrate { get; set; }
    public double NetworkDifficulty { get; set; }
    public string NextNetworkTarget { get; set; }
    public string NextNetworkBits { get; set; }
    public DateTime? LastNetworkBlockTime { get; set; }
    public ulong BlockHeight { get; set; }
    public int ConnectedPeers { get; set; }
    public string NodeVersion { get; set; } = "Unknown";
    public string RewardType { get; set; }

    public double? AverageBlockTime { get; set; }  // Average time between blocks in seconds
    public double? TimeToNextBlock { get; set; }   // Estimated time to next block for pool hashrate in seconds
}

public interface IExtraNonceProvider
{
    int ByteSize { get; }
    string Next();
}
