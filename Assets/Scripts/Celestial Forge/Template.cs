using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.EditorGUI;
//using UnityEditor.EditorGUILayout;
//using MinMaxCustomSlider;
[CreateAssetMenu(fileName = "New Template", menuName = "Celestial Body Template")]
public class Template : ScriptableObject {
    //a = ["metal", "silica", "carbon", "gas", "ice", "transitionMetals", "rareMetals", "alkaliMetals", "magicMetals", "surfaceSilica", "surfaceCarbon", "surfaceOther", "hydrogen", "helium", "nitrogen", "water", "simpleMolecules", "simpleHydrocarbons", "nobleGases", "magicGases"]
    public string classification;
    public float massMin;
    public float massMax;

    //Base composition
    public float metalMin;
    public float metalMax;
    public float silicaMin;
    public float silicaMax;
    public float carbonMin;
    public float carbonMax;
    public float gasMin;
    public float gasMax;
    public float iceMin;
    public float iceMax;
    //Surface composition
    public float transitionMetalsMin;
    public float transitionMetalsMax;
    public float rareMetalsMin;
    public float rareMetalsMax;
    public float alkaliMetalsMin;
    public float alkaliMetalsMax;
    public float magicMetalsMin;
    public float magicMetalsMax;
    public float surfaceSilicaMin;
    public float surfaceSilicaMax;
    public float surfaceCarbonMin;
    public float surfaceCarbonMax;
    public float surfaceOtherMin;
    public float surfaceOtherMax;
    //Atmosphere composition
    public float hydrogenMin;
    public float hydrogenMax;
    public float heliumMin;
    public float heliumMax;
    public float nitrogenMin;
    public float nitrogenMax;
    public float waterMin;
    public float waterMax;
    public float oxygenMin;
    public float oxygenMax;
    public float simpleMoleculesMin;
    public float simpleMoleculesMax;
    public float simpleHydrocarbonsMin;
    public float simpleHydrocarbonsMax;
    public float nobleGasesMin;
    public float nobleGasesMax;
    public float magicGasesMin;
    public float magicGasesMax;
    ///////////////////////////////////////////
}
