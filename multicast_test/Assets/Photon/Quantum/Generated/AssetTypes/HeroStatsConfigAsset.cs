// <auto-generated>
// This code was auto-generated by a tool, every time
// the tool executes this code will be reset.
//
// If you need to extend the classes generated to add
// fields or methods to them, please create partial  
// declarations in another file.
// </auto-generated>

using Quantum;
using UnityEngine;

[CreateAssetMenu(menuName = "Quantum/HeroStatsConfig", order = Quantum.EditorDefines.AssetMenuPriorityStart + 182)]
public partial class HeroStatsConfigAsset : AssetBase {
  public Quantum.HeroStatsConfig Settings;

  public override Quantum.AssetObject AssetObject => Settings;
  public new Quantum.HeroStatsConfig AssetObjectT => (Quantum.HeroStatsConfig)AssetObject;
  
  public override void Reset() {
    if (Settings == null) {
      Settings = new Quantum.HeroStatsConfig();
    }
    base.Reset();
  }
}

public static partial class HeroStatsConfigAssetExts {
  public static HeroStatsConfigAsset GetUnityAsset(this HeroStatsConfig data) {
    return data == null ? null : UnityDB.FindAsset<HeroStatsConfigAsset>(data);
  }
}
