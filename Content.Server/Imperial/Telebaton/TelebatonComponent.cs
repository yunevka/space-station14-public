using Content.Server.Stunnable.Systems;
using Content.Shared.Timing;
using Robust.Shared.Audio;

namespace Content.Server.Imperial.Telebaton
{
  [RegisterComponent, Access(typeof(TelebatonSystem))]
  public sealed class TelebatonComponent : Component 
  {
    public bool Activated { get; set; } = false;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("onThrowStunChance")]
    public float onThrowStunChance { get; set; } = 0.20f;

    [DataField("stunSound")]
    public SoundSpecifier stunsound { get; set; } = new SoundPathSpecifier("/Audio/Weapons/Guns/Gunshots/bang.ogg");

    [DataField("extendSound")]
    public SoundSpecifier extendsound { get; set; } = new SoundPathSpecifier("/Audio/Weapons/Guns/Gunshots/bang.ogg");
  }
}