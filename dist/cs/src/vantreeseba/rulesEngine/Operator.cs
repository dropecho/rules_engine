// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public class Operator : global::haxe.lang.Enum {
		
		protected Operator(int index) : base(index) {
		}
		
		
		public static readonly global::vantreeseba.rulesEngine.Operator GT = new global::vantreeseba.rulesEngine.Operator_GT();
		
		public static readonly global::vantreeseba.rulesEngine.Operator GTE = new global::vantreeseba.rulesEngine.Operator_GTE();
		
		public static readonly global::vantreeseba.rulesEngine.Operator LT = new global::vantreeseba.rulesEngine.Operator_LT();
		
		public static readonly global::vantreeseba.rulesEngine.Operator LTE = new global::vantreeseba.rulesEngine.Operator_LTE();
		
		public static readonly global::vantreeseba.rulesEngine.Operator EQ = new global::vantreeseba.rulesEngine.Operator_EQ();
		
		public static readonly global::vantreeseba.rulesEngine.Operator NEQ = new global::vantreeseba.rulesEngine.Operator_NEQ();
		
		protected static readonly string[] __hx_constructs = new string[]{"GT", "GTE", "LT", "LTE", "EQ", "NEQ"};
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public sealed class Operator_GT : global::vantreeseba.rulesEngine.Operator {
		
		public Operator_GT() : base(0) {
		}
		
		
		public override string getTag() {
			return "GT";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public sealed class Operator_GTE : global::vantreeseba.rulesEngine.Operator {
		
		public Operator_GTE() : base(1) {
		}
		
		
		public override string getTag() {
			return "GTE";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public sealed class Operator_LT : global::vantreeseba.rulesEngine.Operator {
		
		public Operator_LT() : base(2) {
		}
		
		
		public override string getTag() {
			return "LT";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public sealed class Operator_LTE : global::vantreeseba.rulesEngine.Operator {
		
		public Operator_LTE() : base(3) {
		}
		
		
		public override string getTag() {
			return "LTE";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public sealed class Operator_EQ : global::vantreeseba.rulesEngine.Operator {
		
		public Operator_EQ() : base(4) {
		}
		
		
		public override string getTag() {
			return "EQ";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace vantreeseba.rulesEngine {
	public sealed class Operator_NEQ : global::vantreeseba.rulesEngine.Operator {
		
		public Operator_NEQ() : base(5) {
		}
		
		
		public override string getTag() {
			return "NEQ";
		}
		
		
	}
}


