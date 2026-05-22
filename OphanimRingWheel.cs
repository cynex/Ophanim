using T3.Core.DataTypes;
using T3.Core.Operator;
using T3.Core.Operator.Attributes;
using T3.Core.Operator.Slots;
using System.Runtime.InteropServices;

namespace Cynex.Ophanim{
    [Guid("9af8e04b-0cec-489a-bea7-7f00dffcdac4")]
    internal sealed class OphanimRingWheel : Instance<OphanimRingWheel>
    {
        [Output(Guid = "6e07b16b-2cff-44eb-aafd-ec74c2dc44d6")]
        public readonly Slot<Command> Output = new Slot<Command>();

        [Input(Guid = "d85f8517-6405-4c97-9bb0-1207e2a5a91e")]
        public readonly InputSlot<float> RingSize = new InputSlot<float>();

        [Input(Guid = "29031766-e64e-4662-904c-957558fc91fe")]
        public readonly InputSlot<float> RingRotationSpeed = new InputSlot<float>();

        [Input(Guid = "a4e0879e-e65c-48bd-96a5-4309eba9229a")]
        public readonly InputSlot<System.Numerics.Vector3> RingRotationAxis = new InputSlot<System.Numerics.Vector3>();

        [Input(Guid = "95ed5fa3-da7e-452a-88aa-4e0a7a94d516")]
        public readonly InputSlot<System.Numerics.Vector3> RingRotationAxis2 = new InputSlot<System.Numerics.Vector3>();


    }
}

