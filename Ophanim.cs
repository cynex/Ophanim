using T3.Core.Operator;
using T3.Core.Operator.Attributes;
using System.Runtime.InteropServices;
using T3.Core.DataTypes;
using T3.Core.Operator.Interfaces;
using T3.Core.Operator.Slots;
using T3.Core.Resource;

namespace Cynex.Ophanim;

[Guid("0090f230-d105-4b75-ac51-ee824ac01e65")]
internal sealed class Ophanim : Instance<Ophanim>
{
}

// ReSharper disable once UnusedType.Global
public sealed class ShareDefinition : IShareResources
{
    // ReSharper disable once EmptyConstructor
    public ShareDefinition(){}
    #pragma warning disable CA1822
    public bool ShouldShareResources => true;
    #pragma warning restore CA1822
}
