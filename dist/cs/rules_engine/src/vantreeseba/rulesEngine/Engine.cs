// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public class Engine : global::haxe.lang.HxObject {
		
		public Engine(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Engine() {
			#line 8 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
			global::vantreeseba.rulesEngine.Engine.__hx_ctor_vantreeseba_rulesEngine_Engine(this);
		}
		#line default
		
		protected static void __hx_ctor_vantreeseba_rulesEngine_Engine(global::vantreeseba.rulesEngine.Engine __hx_this) {
			#line 6 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
			__hx_this.blackboard = new global::vantreeseba.rulesEngine.Blackboard();
			#line 5 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
			__hx_this.rules = new global::Array<object>();
			#line 8 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
			{
			}
			
		}
		#line default
		
		public global::Array<object> rules;
		
		public global::vantreeseba.rulesEngine.Blackboard blackboard;
		
		public virtual void run() {
		}
		
		
		public virtual void DOOOBITY() {
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
				switch (hash) {
					case 1516338311:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						this.blackboard = ((global::vantreeseba.rulesEngine.Blackboard) (@value) );
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return @value;
					}
					
					
					case 1901487095:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						this.rules = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return @value;
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
				switch (hash) {
					case 1161235959:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "DOOOBITY", 1161235959)) );
					}
					
					
					case 5695307:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "run", 5695307)) );
					}
					
					
					case 1516338311:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return this.blackboard;
					}
					
					
					case 1901487095:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return this.rules;
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
				switch (hash) {
					case 1161235959:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						this.DOOOBITY();
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						break;
					}
					
					
					case 5695307:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						this.run();
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						break;
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
			baseArr.push("blackboard");
			#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
			baseArr.push("rules");
			#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Engine.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}

