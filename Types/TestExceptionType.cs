namespace hc_error_explicit_binding.Types;

// Does not work.
public sealed class TestExceptionType : ObjectType<TestException>
{
    protected override void Configure(IObjectTypeDescriptor<TestException> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(e => e.Code);

        descriptor.Field(e => e.Message);
    }
}
