// Generated by Haxe 4.0.5
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public class RuleResult : global::haxe.lang.HxObject {
		
		static RuleResult() {
			{
				object __temp_odecl1 = new global::haxe.lang.DynamicObject(new int[]{1149080132}, new object[]{null}, new int[]{}, new double[]{});
				global::vantreeseba.rulesEngine.RuleResult.__meta__ = new global::haxe.lang.DynamicObject(new int[]{5541879}, new object[]{__temp_odecl1}, new int[]{}, new double[]{});
			}
			
		}
		
		
		public RuleResult(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public RuleResult(global::vantreeseba.rulesEngine.Rule rule, global::haxe.root.Array<object> conditionResults) {
			global::vantreeseba.rulesEngine.RuleResult.__hx_ctor_vantreeseba_rulesEngine_RuleResult(this, rule, conditionResults);
		}
		
		
		protected static void __hx_ctor_vantreeseba_rulesEngine_RuleResult(global::vantreeseba.rulesEngine.RuleResult __hx_this, global::vantreeseba.rulesEngine.Rule rule, global::haxe.root.Array<object> conditionResults) {
			__hx_this.conditionResults = new global::haxe.root.Array<object>();
			{
				__hx_this.rule = rule;
				if (( conditionResults != null )) {
					__hx_this.conditionResults = conditionResults;
				}
				
			}
			
		}
		
		
		public static object __meta__;
		
		public global::vantreeseba.rulesEngine.Rule rule;
		
		public global::haxe.root.Array<object> conditionResults;
		
		public bool matches;
		
		
		
		public virtual string get_reason() {
			if (( this.matches == false )) {
				global::haxe.root.Array<object> _this = this.conditionResults;
				global::haxe.root.Array<object> ret = new global::haxe.root.Array<object>(new object[]{});
				{
					int _g = 0;
					int _g1 = _this.length;
					while (( _g < _g1 )) {
						int i = _g++;
						global::vantreeseba.rulesEngine.ConditionResult elt = ((global::vantreeseba.rulesEngine.ConditionResult) (_this.__a[i]) );
						if (( elt.matches == false )) {
							ret.push(elt);
						}
						
					}
					
				}
				
				global::haxe.root.Array<object> _this1 = ret;
				global::haxe.root.Array<string> ret1 = new global::haxe.root.Array<string>(((string[]) (new string[_this1.length]) ));
				{
					int _g2 = 0;
					int _g11 = _this1.length;
					while (( _g2 < _g11 )) {
						int i1 = _g2++;
						ret1.__a[i1] = ((global::vantreeseba.rulesEngine.ConditionResult) (_this1.__a[i1]) ).reason;
					}
					
				}
				
				return ret1.@join("\n");
			}
			
			global::haxe.root.Array<object> _this2 = this.conditionResults;
			global::haxe.root.Array<string> ret2 = new global::haxe.root.Array<string>(((string[]) (new string[_this2.length]) ));
			{
				int _g3 = 0;
				int _g12 = _this2.length;
				while (( _g3 < _g12 )) {
					int i2 = _g3++;
					ret2.__a[i2] = ((global::vantreeseba.rulesEngine.ConditionResult) (_this2.__a[i2]) ).reason;
				}
				
			}
			
			return ret2.@join("\n");
		}
		
		
		public virtual string set_reason(string val) {
			return this.get_reason();
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 2090667972:
					{
						this.set_reason(global::haxe.lang.Runtime.toString(@value));
						return @value;
					}
					
					
					case 159137011:
					{
						this.matches = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 71225499:
					{
						this.conditionResults = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1270053116:
					{
						this.rule = ((global::vantreeseba.rulesEngine.Rule) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1889672705:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_reason", 1889672705)) );
					}
					
					
					case 1831108493:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_reason", 1831108493)) );
					}
					
					
					case 2090667972:
					{
						return this.get_reason();
					}
					
					
					case 159137011:
					{
						return this.matches;
					}
					
					
					case 71225499:
					{
						return this.conditionResults;
					}
					
					
					case 1270053116:
					{
						return this.rule;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 1889672705:
					{
						return this.set_reason(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 1831108493:
					{
						return this.get_reason();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<string> baseArr) {
			baseArr.push("reason");
			baseArr.push("matches");
			baseArr.push("conditionResults");
			baseArr.push("rule");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


