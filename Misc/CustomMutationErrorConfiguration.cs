using hc_error_explicit_binding.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;

namespace hc_error_explicit_binding.Misc;

public sealed class CustomMutationErrorConfiguration : MutationErrorConfiguration
{
    public override void OnConfigure(
        IDescriptorContext context,
        ObjectFieldDefinition mutationField)
    {
        mutationField.AddErrorType(context, typeof(TestException));
    }
}