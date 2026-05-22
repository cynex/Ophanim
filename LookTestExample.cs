namespace Cynex.Ophanim;

[Guid("41c01850-6909-4d40-864c-a36c9f7f0391")]
 internal sealed class LookTestExample :Instance<LookTestExample>{

    [Output(Guid = "7946269b-39f0-4337-8343-dabd2bdc8c7d")]
    public readonly Slot<Texture2D> Output = new Slot<Texture2D>();


}