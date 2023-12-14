namespace hc_error_explicit_binding.Types;

public sealed class BookType : ObjectType<Book>
{
    protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.Field(b => b.Title);

        descriptor.Field(b => b.Author);
    }
}