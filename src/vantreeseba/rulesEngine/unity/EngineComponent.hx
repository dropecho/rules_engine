package vantreeseba.rulesEngine.unity;

#if cs
import unityengine.*;

@:nativeGen 
class EngineComponent extends MonoBehaviour {
  public var Test:String = "FOO";

	function Start():Void {
		Debug.Log("hello!");
	}

	function Update():Void {}
}
#end
