namespace hc_error_explicit_binding.Types;

public sealed class TestException : Exception, IDomainError
{
    public string Code { get; }

    public TestException(string code, string message) : base(message)
    {
        this.Code = code;
    }
}