namespace TaskManagementSystem.GrpcLib.Configurations.Clients.Configs;


public sealed record GrpcClientConfig
{
    public Type ClientType { get; init; }
    public string Host { get; init; }
    public string Port { get; init; }
    public string Scheme { get; init; } = "https";

    public GrpcClientConfig(Type clientType, string host, string port, string scheme)
    {
        ClientType = clientType;
        Host = host;
        Port = port;
        Scheme = scheme;
    }

    public Uri Url => new Uri($"{Scheme}://{Host}:{Port}");
}
