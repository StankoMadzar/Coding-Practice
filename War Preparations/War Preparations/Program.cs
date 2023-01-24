
Sword originalSword = new Sword(SwordMaterial.iron, GemstoneType.none, 120, 20);
Sword betterSword = originalSword with { gemstone = GemstoneType.emerald };
Sword evenBetterSword = originalSword with { material = SwordMaterial.steel, gemstone = GemstoneType.diamond };

Console.WriteLine(originalSword.ToString());
Console.WriteLine(betterSword.ToString());
Console.WriteLine(evenBetterSword.ToString());


public record Sword (SwordMaterial material, GemstoneType gemstone, int length, int crossguardWidth);

public enum GemstoneType { none, emerald, amber, sapphire, diamond, bitsone };
public enum SwordMaterial { wood, bronze, iron, steel, binarium };