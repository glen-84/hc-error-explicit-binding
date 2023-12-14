namespace hc_error_explicit_binding.Types;

public interface IDomainError
{
    public string Code { get; }

    public string Message { get; }
}