public record ErrorResponse
{
    public List<ErrorMessage> Errors { get; init; }
}