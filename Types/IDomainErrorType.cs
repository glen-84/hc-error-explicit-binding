namespace hc_error_explicit_binding.Types;

public sealed class IDomainErrorType : InterfaceType<IDomainError>
{
    protected override void Configure(IInterfaceTypeDescriptor<IDomainError> descriptor)
    {
        descriptor.Field(e => e.Code);

        descriptor.Field(e => e.Message);
    }
}