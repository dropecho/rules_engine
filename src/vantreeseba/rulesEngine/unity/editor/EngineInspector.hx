package vantreeseba.rulesEngine.unity.editor;

#if cs
import unityengine.*;

@:native("UnityEditor.Editor")
extern class Editor {
	public function OnInspectorGUI():Void;
}

@:meta("UnityEditor.CustomEditor(typeof(EngineComponent))")
@:nativeGen
class EngineInspector extends Editor {
	@:functionCode('
		var myTarget = (vantreeseba.rulesEngine.unity.EngineComponent) target;
    DrawDefaultInspector();
		UnityEditor.EditorGUILayout.LabelField("Level", "HI THERE BOIS");
    if(UnityEngine.GUILayout.Button("Your ButtonText")) {
      UnityEngine.Debug.Log("you pushed the button");
    }
  ')
	public override function OnInspectorGUI():Void {}
}
#end
