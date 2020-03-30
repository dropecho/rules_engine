// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public class Condition : global::haxe.lang.HxObject {
		
		public Condition(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Condition() {
			#line 9 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			global::vantreeseba.rulesEngine.Condition.__hx_ctor_vantreeseba_rulesEngine_Condition(this);
		}
		#line default
		
		protected static void __hx_ctor_vantreeseba_rulesEngine_Condition(global::vantreeseba.rulesEngine.Condition __hx_this) {
			#line 7 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			__hx_this.@value = null;
			#line 6 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			__hx_this.op = global::vantreeseba.rulesEngine.Operator.EQ;
			#line 5 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			__hx_this.fact = "";
			#line 9 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			{
			}
			
		}
		#line default
		
		public string fact;
		
		public global::vantreeseba.rulesEngine.Operator op;
		
		public object @value;
		
		public virtual bool matches(global::vantreeseba.rulesEngine.Blackboard bb) {
			unchecked {
				#line 12 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
				object val = ((object) (global::haxe.lang.Runtime.callField(bb.facts, "get", 5144726, new object[]{this.fact})) );
				#line 14 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
				switch (this.op._hx_index) {
					case 0:
					{
						#line 16 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return ( global::haxe.lang.Runtime.compare(val, this.@value) > 0 );
					}
					
					
					case 1:
					{
						#line 18 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return ( global::haxe.lang.Runtime.compare(val, this.@value) >= 0 );
					}
					
					
					case 2:
					{
						#line 20 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return ( global::haxe.lang.Runtime.compare(val, this.@value) < 0 );
					}
					
					
					case 3:
					{
						#line 22 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return ( global::haxe.lang.Runtime.compare(val, this.@value) <= 0 );
					}
					
					
					case 4:
					{
						#line 24 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return global::haxe.lang.Runtime.eq(val, this.@value);
					}
					
					
					case 5:
					{
						#line 26 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return ( ! (global::haxe.lang.Runtime.eq(val, this.@value)) );
					}
					
					
				}
				
				#line 11 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
				return default(bool);
			}
			#line default
		}
		
		
		public virtual global::vantreeseba.rulesEngine.ConditionResult result(global::vantreeseba.rulesEngine.Blackboard bb) {
			#line 33 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			return new global::vantreeseba.rulesEngine.ConditionResult(this, this.matches(bb));
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
				switch (hash) {
					case 834174833:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						this.@value = ((object) (@value) );
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return @value;
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
				switch (hash) {
					case 834174833:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						this.@value = ((object) (@value) );
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return @value;
					}
					
					
					case 24865:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						this.op = ((global::vantreeseba.rulesEngine.Operator) (@value) );
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return @value;
					}
					
					
					case 1135981740:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						this.fact = global::haxe.lang.Runtime.toString(@value);
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return @value;
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
				switch (hash) {
					case 142895325:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "result", 142895325)) );
					}
					
					
					case 159137011:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "matches", 159137011)) );
					}
					
					
					case 834174833:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return this.@value;
					}
					
					
					case 24865:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return this.op;
					}
					
					
					case 1135981740:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return this.fact;
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
				switch (hash) {
					case 834174833:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.@value)) );
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
				switch (hash) {
					case 142895325:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return this.result(((global::vantreeseba.rulesEngine.Blackboard) (dynargs[0]) ));
					}
					
					
					case 159137011:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return this.matches(((global::vantreeseba.rulesEngine.Blackboard) (dynargs[0]) ));
					}
					
					
					default:
					{
						#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			baseArr.push("value");
			#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			baseArr.push("op");
			#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			baseArr.push("fact");
			#line 4 "/home/vantreeseba/windows/code/unity_plugins/rulesEngine/src/vantreeseba/rulesEngine/Condition.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


