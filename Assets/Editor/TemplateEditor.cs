using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Template))]
public class TemplateEditor : Editor {
    private float massSliderMax = 50f;

    public override void OnInspectorGUI()
    {
        /*a = ["metal", "silica", "carbon", "gas", "ice", "transitionMetals", "rareMetals", "alkaliMetals", "magicMetals", "surfaceSilica", "surfaceCarbon", "surfaceOther", "hydrogen", "helium", "nitrogen", "water", "simpleMolecules", "simpleHydrocarbons", "nobleGases", "magicGases"]
        for x in a:
          print(f"public float {x}Min;")
          print(f"public float {x}Max;")
        for x in a:
          print(f"EditorGUILayout.PrefixLabel(\"{x}\");")
          print(f"EditorGUILayout.MinMaxSlider(ref template.{x}Min, ref template.{x}Max, 0, 1);")*/

        //base.OnInspectorGUI();
        Template template = (Template)target;
        EditorGUILayout.PrefixLabel("metal");
        EditorGUILayout.MinMaxSlider(ref template.metalMin, ref template.metalMax, 0, 1);
        EditorGUILayout.PrefixLabel("silica");
        EditorGUILayout.MinMaxSlider(ref template.silicaMin, ref template.silicaMax, 0, 1);
        EditorGUILayout.PrefixLabel("carbon");
        EditorGUILayout.MinMaxSlider(ref template.carbonMin, ref template.carbonMax, 0, 1);
        EditorGUILayout.PrefixLabel("gas");
        EditorGUILayout.MinMaxSlider(ref template.gasMin, ref template.gasMax, 0, 1);
        EditorGUILayout.PrefixLabel("ice");
        EditorGUILayout.MinMaxSlider(ref template.iceMin, ref template.iceMax, 0, 1);
        EditorGUILayout.PrefixLabel("transitionMetals");
        EditorGUILayout.MinMaxSlider(ref template.transitionMetalsMin, ref template.transitionMetalsMax, 0, 1);
        EditorGUILayout.PrefixLabel("rareMetals");
        EditorGUILayout.MinMaxSlider(ref template.rareMetalsMin, ref template.rareMetalsMax, 0, 1);
        EditorGUILayout.PrefixLabel("alkaliMetals");
        EditorGUILayout.MinMaxSlider(ref template.alkaliMetalsMin, ref template.alkaliMetalsMax, 0, 1);
        EditorGUILayout.PrefixLabel("magicMetals");
        EditorGUILayout.MinMaxSlider(ref template.magicMetalsMin, ref template.magicMetalsMax, 0, 1);
        EditorGUILayout.PrefixLabel("surfaceSilica");
        EditorGUILayout.MinMaxSlider(ref template.surfaceSilicaMin, ref template.surfaceSilicaMax, 0, 1);
        EditorGUILayout.PrefixLabel("surfaceCarbon");
        EditorGUILayout.MinMaxSlider(ref template.surfaceCarbonMin, ref template.surfaceCarbonMax, 0, 1);
        EditorGUILayout.PrefixLabel("surfaceOther");
        EditorGUILayout.MinMaxSlider(ref template.surfaceOtherMin, ref template.surfaceOtherMax, 0, 1);
        EditorGUILayout.PrefixLabel("hydrogen");
        EditorGUILayout.MinMaxSlider(ref template.hydrogenMin, ref template.hydrogenMax, 0, 1);
        EditorGUILayout.PrefixLabel("helium");
        EditorGUILayout.MinMaxSlider(ref template.heliumMin, ref template.heliumMax, 0, 1);
        EditorGUILayout.PrefixLabel("nitrogen");
        EditorGUILayout.MinMaxSlider(ref template.nitrogenMin, ref template.nitrogenMax, 0, 1);
        EditorGUILayout.PrefixLabel("water");
        EditorGUILayout.MinMaxSlider(ref template.waterMin, ref template.waterMax, 0, 1);
        EditorGUILayout.PrefixLabel("oxygen");
        EditorGUILayout.MinMaxSlider(ref template.oxygenMin, ref template.oxygenMax, 0, 1);
        EditorGUILayout.PrefixLabel("simpleMolecules");
        EditorGUILayout.MinMaxSlider(ref template.simpleMoleculesMin, ref template.simpleMoleculesMax, 0, 1);
        EditorGUILayout.PrefixLabel("simpleHydrocarbons");
        EditorGUILayout.MinMaxSlider(ref template.simpleHydrocarbonsMin, ref template.simpleHydrocarbonsMax, 0, 1);
        EditorGUILayout.PrefixLabel("nobleGases");
        EditorGUILayout.MinMaxSlider(ref template.nobleGasesMin, ref template.nobleGasesMax, 0, 1);
        EditorGUILayout.PrefixLabel("magicGases");
        EditorGUILayout.MinMaxSlider(ref template.magicGasesMin, ref template.magicGasesMax, 0, 1);
        EditorGUILayout.PrefixLabel("Classification");
        EditorGUILayout.TextField(template.classification);
        EditorGUILayout.FloatField(massSliderMax);
        EditorGUILayout.LabelField("Mass slider max");
        EditorGUILayout.PrefixLabel("Mass");
        EditorGUILayout.MinMaxSlider(ref template.massMin, ref template.massMax, 0.01f, massSliderMax);
        string str = "Mass minimum: " + template.massMin + " Earth Masses, " + "Mass maximum: " + template.massMax + " Earth Masses";
        EditorGUILayout.LabelField(str);
    }
}
