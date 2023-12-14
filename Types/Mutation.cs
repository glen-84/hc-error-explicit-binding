namespace hc_error_explicit_binding.Types;

[MutationType]
public static class Mutation
{
    public static Book AddBook()
        => throw new TestException("code", "message");
}
