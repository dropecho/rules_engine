// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
public class RuleResult : global::haxe.lang.HxObject {
	
	public RuleResult(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public RuleResult(global::Rule rule, global::Array<object> conditionResults) {
		global::RuleResult.__hx_ctor__RuleResult(this, rule, conditionResults);
	}
	
	
	protected static void __hx_ctor__RuleResult(global::RuleResult __hx_this, global::Rule rule, global::Array<object> conditionResults) {
		__hx_this.conditionResults = new global::Array<object>();
		{
			__hx_this.rule = rule;
			if (( conditionResults != null )) {
				__hx_this.conditionResults = conditionResults;
			}
			
		}
		
	}
	
	
	public global::Rule rule;
	
	public global::Array<object> conditionResults;
	
	public bool matches;
	
	
	
	public virtual string get_reason() {
		if (( this.matches == false )) {
			global::Array<object> _this = this.conditionResults;
			global::Array<object> ret = new global::Array<object>(new object[]{});
			{
				int _g = 0;
				int _g1 = _this.length;
				while (( _g < _g1 )) {
					int i = _g++;
					global::ConditionResult elt = ((global::ConditionResult) (_this.__a[i]) );
					if (( elt.matches == false )) {
						ret.push(elt);
					}
					
				}
				
			}
			
			global::Array<object> _this1 = ret;
			global::Array<string> ret1 = new global::Array<string>(((string[]) (new string[_this1.length]) ));
			{
				int _g2 = 0;
				int _g11 = _this1.length;
				while (( _g2 < _g11 )) {
					int i1 = _g2++;
					ret1.__a[i1] = ((global::ConditionResult) (_this1.__a[i1]) ).reason;
				}
				
			}
			
			return ret1.@join("\n");
		}
		
		global::Array<object> _this2 = this.conditionResults;
		global::Array<string> ret2 = new global::Array<string>(((string[]) (new string[_this2.length]) ));
		{
			int _g3 = 0;
			int _g12 = _this2.length;
			while (( _g3 < _g12 )) {
				int i2 = _g3++;
				ret2.__a[i2] = ((global::ConditionResult) (_this2.__a[i2]) ).reason;
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
					this.conditionResults = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
					return @value;
				}
				
				
				case 1270053116:
				{
					this.rule = ((global::Rule) (@value) );
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
	
	
	public override void __hx_getFields(global::Array<string> baseArr) {
		baseArr.push("reason");
		baseArr.push("matches");
		baseArr.push("conditionResults");
		baseArr.push("rule");
		base.__hx_getFields(baseArr);
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Rule : global::haxe.lang.HxObject {
	
	public Rule(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Rule() {
		global::Rule.__hx_ctor__Rule(this);
	}
	
	
	protected static void __hx_ctor__Rule(global::Rule __hx_this) {
		__hx_this.conditions = new global::Array<object>();
		{
		}
		
	}
	
	
	public global::Array<object> conditions;
	
	public virtual bool matches(global::Blackboard bb) {
		{
			int _g = 0;
			global::Array<object> _g1 = this.conditions;
			while (( _g < _g1.length )) {
				global::Condition con = ((global::Condition) (_g1[_g]) );
				 ++ _g;
				if (( con.matches(bb) == false )) {
					return false;
				}
				
			}
			
		}
		
		return true;
	}
	
	
	public virtual global::RuleResult result(global::Blackboard bb) {
		global::RuleResult result = new global::RuleResult(this, null);
		result.matches = true;
		{
			int _g = 0;
			global::Array<object> _g1 = this.conditions;
			while (( _g < _g1.length )) {
				global::Condition con = ((global::Condition) (_g1[_g]) );
				 ++ _g;
				global::ConditionResult conRes = con.result(bb);
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
					return this.result(((global::Blackboard) (dynargs[0]) ));
				}
				
				
				case 159137011:
				{
					return this.matches(((global::Blackboard) (dynargs[0]) ));
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

