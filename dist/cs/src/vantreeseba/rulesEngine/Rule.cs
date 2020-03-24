// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public class Rule : global::haxe.lang.HxObject {
		
		public Rule(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Rule() {
			global::vantreeseba.rulesEngine.Rule.__hx_ctor_vantreeseba_rulesEngine_Rule(this);
		}
		
		
		protected static void __hx_ctor_vantreeseba_rulesEngine_Rule(global::vantreeseba.rulesEngine.Rule __hx_this) {
			__hx_this.conditions = new global::Array<object>();
			{
			}
			
		}
		
		
		public global::Array<object> conditions;
		
		public virtual bool matches(global::vantreeseba.rulesEngine.Blackboard bb) {
			{
				int _g = 0;
				global::Array<object> _g1 = this.conditions;
				while (( _g < _g1.length )) {
					global::vantreeseba.rulesEngine.Condition con = ((global::vantreeseba.rulesEngine.Condition) (_g1[_g]) );
					 ++ _g;
					if (( con.matches(bb) == false )) {
						return false;
					}
					
				}
				
			}
			
			return true;
		}
		
		
		public virtual global::vantreeseba.rulesEngine.RuleResult result(global::vantreeseba.rulesEngine.Blackboard bb) {
			global::vantreeseba.rulesEngine.RuleResult result = new global::vantreeseba.rulesEngine.RuleResult(this, null);
			result.matches = true;
			{
				int _g = 0;
				global::Array<object> _g1 = this.conditions;
				while (( _g < _g1.length )) {
					global::vantreeseba.rulesEngine.Condition con = ((global::vantreeseba.rulesEngine.Condition) (_g1[_g]) );
					 ++ _g;
					global::vantreeseba.rulesEngine.ConditionResult conRes = con.result(bb);
					result.conditionResults.push(conRes);
					if (( conRes.matches == false )) {
						result.matches = false;
					}
					
				}
				
			}
			
			return result;
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 825785976:
					{
						this.conditions = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
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
					case 142895325:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "result", 142895325)) );
					}
					
					
					case 159137011:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "matches", 159137011)) );
					}
					
					
					case 825785976:
					{
						return this.conditions;
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
					case 142895325:
					{
						return this.result(((global::vantreeseba.rulesEngine.Blackboard) (dynargs[0]) ));
					}
					
					
					case 159137011:
					{
						return this.matches(((global::vantreeseba.rulesEngine.Blackboard) (dynargs[0]) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			baseArr.push("conditions");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}

