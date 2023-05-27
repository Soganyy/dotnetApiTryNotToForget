namespace Dtos;

public record ItemDto
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public double Price { get; init; }
    public DateTimeOffset CreateTime { get; init; }
}