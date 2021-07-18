// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
public sealed class EReg : global::haxe.lang.HxObject {
	
	public EReg(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public EReg(string r, string opt) {
		#line 34 "/usr/share/haxe/std/cs/_std/EReg.hx"
		global::EReg.__hx_ctor__EReg(this, r, opt);
	}
	#line default
	
	private static void __hx_ctor__EReg(global::EReg __hx_this, string r, string opt) {
		unchecked {
			#line 35 "/usr/share/haxe/std/cs/_std/EReg.hx"
			int opts = ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.CultureInvariant) ))) );
			{
				#line 36 "/usr/share/haxe/std/cs/_std/EReg.hx"
				int _g = 0;
				#line 36 "/usr/share/haxe/std/cs/_std/EReg.hx"
				int _g1 = opt.Length;
				#line 36 "/usr/share/haxe/std/cs/_std/EReg.hx"
				while (( _g < _g1 )) {
					#line 36 "/usr/share/haxe/std/cs/_std/EReg.hx"
					int i = _g++;
					#line 38 "/usr/share/haxe/std/cs/_std/EReg.hx"
					switch (((int) (opt[i]) )) {
						case 103:
						{
							#line 42 "/usr/share/haxe/std/cs/_std/EReg.hx"
							__hx_this.isGlobal = true;
							#line 42 "/usr/share/haxe/std/cs/_std/EReg.hx"
							break;
						}
						
						
						case 105:
						{
							#line 40 "/usr/share/haxe/std/cs/_std/EReg.hx"
							opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.IgnoreCase) ))) );
							#line 40 "/usr/share/haxe/std/cs/_std/EReg.hx"
							break;
						}
						
						
						case 109:
						{
							#line 44 "/usr/share/haxe/std/cs/_std/EReg.hx"
							opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.Multiline) ))) );
							#line 44 "/usr/share/haxe/std/cs/_std/EReg.hx"
							break;
						}
						
						
					}
					
				}
				
			}
			
			#line 52 "/usr/share/haxe/std/cs/_std/EReg.hx"
			__hx_this.regex = new global::System.Text.RegularExpressions.Regex(((string) (r) ), ((global::System.Text.RegularExpressions.RegexOptions) (((object) (opts) )) ));
		}
		#line default
	}
	
	
	public static string escape(string s) {
		#line 133 "/usr/share/haxe/std/cs/_std/EReg.hx"
		return global::System.Text.RegularExpressions.Regex.Escape(((string) (s) ));
	}
	#line default
	
	public global::System.Text.RegularExpressions.Regex regex;
	
	public global::System.Text.RegularExpressions.Match m;
	
	public bool isGlobal;
	
	public string cur;
	
	public bool match(string s) {
		#line 56 "/usr/share/haxe/std/cs/_std/EReg.hx"
		this.m = this.regex.Match(((string) (s) ));
		this.cur = s;
		#line 58 "/usr/share/haxe/std/cs/_std/EReg.hx"
		return ( this.m as global::System.Text.RegularExpressions.Group ).Success;
	}
	#line default
	
	public string matched(int n) {
		#line 62 "/usr/share/haxe/std/cs/_std/EReg.hx"
		if (( ( this.m == null ) || ((bool) (( ((uint) (n) ) > this.m.Groups.Count )) ) )) {
			#line 63 "/usr/share/haxe/std/cs/_std/EReg.hx"
			throw global::haxe.lang.HaxeException.wrap("EReg::matched");
		}
		
		#line 64 "/usr/share/haxe/std/cs/_std/EReg.hx"
		if ( ! (this.m.Groups[n].Success) ) {
			#line 65 "/usr/share/haxe/std/cs/_std/EReg.hx"
			return null;
		}
		
		#line 66 "/usr/share/haxe/std/cs/_std/EReg.hx"
		return ( this.m.Groups[n] as global::System.Text.RegularExpressions.Capture ).Value;
	}
	#line default
	
	public string matchedLeft() {
		#line 70 "/usr/share/haxe/std/cs/_std/EReg.hx"
		return this.cur.Substring(((int) (0) ), ((int) (( this.m as global::System.Text.RegularExpressions.Capture ).Index) ));
	}
	#line default
	
	public string matchedRight() {
		#line 74 "/usr/share/haxe/std/cs/_std/EReg.hx"
		return this.cur.Substring(((int) (( ( this.m as global::System.Text.RegularExpressions.Capture ).Index + ( this.m as global::System.Text.RegularExpressions.Capture ).Length )) ));
	}
	#line default
	
	public object matchedPos() {
		#line 78 "/usr/share/haxe/std/cs/_std/EReg.hx"
		int tmp = ( this.m as global::System.Text.RegularExpressions.Capture ).Index;
		#line 78 "/usr/share/haxe/std/cs/_std/EReg.hx"
		{
			#line 78 "/usr/share/haxe/std/cs/_std/EReg.hx"
			int __temp_odecl1 = ( this.m as global::System.Text.RegularExpressions.Capture ).Length;
			#line 78 "/usr/share/haxe/std/cs/_std/EReg.hx"
			return new global::haxe.lang.DynamicObject(new int[]{}, new object[]{}, new int[]{5393365, 5594516}, new double[]{((double) (__temp_odecl1) ), ((double) (tmp) )});
		}
		
	}
	#line default
	
	public bool matchSub(string s, int pos, global::haxe.lang.Null<int> len) {
		unchecked {
			#line 81 "/usr/share/haxe/std/cs/_std/EReg.hx"
			int len1 = ( ( ! (len.hasValue) ) ? (-1) : ((len).@value) );
			this.m = ( (( len1 < 0 )) ? (this.regex.Match(((string) (s) ), ((int) (pos) ))) : (this.regex.Match(((string) (s) ), ((int) (pos) ), ((int) (len1) ))) );
			#line 83 "/usr/share/haxe/std/cs/_std/EReg.hx"
			this.cur = s;
			return ( this.m as global::System.Text.RegularExpressions.Group ).Success;
		}
		#line default
	}
	
	
	public global::Array<string> split(string s) {
		#line 88 "/usr/share/haxe/std/cs/_std/EReg.hx"
		if (this.isGlobal) {
			#line 89 "/usr/share/haxe/std/cs/_std/EReg.hx"
			return new global::Array<string>(((string[]) (this.regex.Split(((string) (s) ))) ));
		}
		
		#line 90 "/usr/share/haxe/std/cs/_std/EReg.hx"
		global::System.Text.RegularExpressions.Match m = this.regex.Match(((string) (s) ));
		if ( ! (( m as global::System.Text.RegularExpressions.Group ).Success) ) {
			#line 92 "/usr/share/haxe/std/cs/_std/EReg.hx"
			return new global::Array<string>(new string[]{s});
		}
		
		#line 93 "/usr/share/haxe/std/cs/_std/EReg.hx"
		return new global::Array<string>(new string[]{s.Substring(((int) (0) ), ((int) (( m as global::System.Text.RegularExpressions.Capture ).Index) )), s.Substring(((int) (( ( m as global::System.Text.RegularExpressions.Capture ).Index + ( m as global::System.Text.RegularExpressions.Capture ).Length )) ))});
	}
	#line default
	
	public int start(int @group) {
		#line 97 "/usr/share/haxe/std/cs/_std/EReg.hx"
		return ( this.m.Groups[@group] as global::System.Text.RegularExpressions.Capture ).Index;
	}
	#line default
	
	public int len(int @group) {
		#line 101 "/usr/share/haxe/std/cs/_std/EReg.hx"
		return ( this.m.Groups[@group] as global::System.Text.RegularExpressions.Capture ).Length;
	}
	#line default
	
	public string replace(string s, string @by) {
		unchecked {
			#line 105 "/usr/share/haxe/std/cs/_std/EReg.hx"
			if (this.isGlobal) {
				#line 105 "/usr/share/haxe/std/cs/_std/EReg.hx"
				return this.regex.Replace(((string) (s) ), ((string) (@by) ));
			}
			else {
				#line 105 "/usr/share/haxe/std/cs/_std/EReg.hx"
				return this.regex.Replace(((string) (s) ), ((string) (@by) ), ((int) (1) ));
			}
			
		}
		#line default
	}
	
	
	public string map(string s, global::haxe.lang.Function f) {
		unchecked {
			#line 109 "/usr/share/haxe/std/cs/_std/EReg.hx"
			int offset = 0;
			global::System.Text.StringBuilder buf_b = new global::System.Text.StringBuilder();
			#line 111 "/usr/share/haxe/std/cs/_std/EReg.hx"
			while (true) {
				#line 112 "/usr/share/haxe/std/cs/_std/EReg.hx"
				if (( offset >= s.Length )) {
					#line 113 "/usr/share/haxe/std/cs/_std/EReg.hx"
					break;
				}
				else if ( ! (this.matchSub(s, offset, default(global::haxe.lang.Null<int>))) ) {
					#line 115 "/usr/share/haxe/std/cs/_std/EReg.hx"
					buf_b.Append(((string) (global::Std.@string(global::haxe.lang.StringExt.substr(s, offset, default(global::haxe.lang.Null<int>)))) ));
					break;
				}
				
				#line 118 "/usr/share/haxe/std/cs/_std/EReg.hx"
				object p = this.matchedPos();
				buf_b.Append(((string) (global::Std.@string(global::haxe.lang.StringExt.substr(s, offset, new global::haxe.lang.Null<int>(( ((int) (global::haxe.lang.Runtime.getField_f(p, "pos", 5594516, true)) ) - ((int) (offset) ) ), true)))) ));
				#line 120 "/usr/share/haxe/std/cs/_std/EReg.hx"
				buf_b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.toString(f.__hx_invoke1_o(default(double), this)))) ));
				if (( ((int) (global::haxe.lang.Runtime.getField_f(p, "len", 5393365, true)) ) == 0 )) {
					#line 122 "/usr/share/haxe/std/cs/_std/EReg.hx"
					buf_b.Append(((string) (global::Std.@string(global::haxe.lang.StringExt.substr(s, ((int) (global::haxe.lang.Runtime.getField_f(p, "pos", 5594516, true)) ), new global::haxe.lang.Null<int>(1, true)))) ));
					offset = ( ((int) (global::haxe.lang.Runtime.getField_f(p, "pos", 5594516, true)) ) + 1 );
				}
				else {
					#line 125 "/usr/share/haxe/std/cs/_std/EReg.hx"
					offset = ( ((int) (global::haxe.lang.Runtime.getField_f(p, "pos", 5594516, true)) ) + ((int) (global::haxe.lang.Runtime.getField_f(p, "len", 5393365, true)) ) );
				}
				
				#line 111 "/usr/share/haxe/std/cs/_std/EReg.hx"
				if ( ! (this.isGlobal) ) {
					#line 111 "/usr/share/haxe/std/cs/_std/EReg.hx"
					break;
				}
				
			}
			
			#line 127 "/usr/share/haxe/std/cs/_std/EReg.hx"
			if (( (  ! (this.isGlobal)  && ( offset > 0 ) ) && ( offset < s.Length ) )) {
				#line 128 "/usr/share/haxe/std/cs/_std/EReg.hx"
				buf_b.Append(((string) (global::Std.@string(global::haxe.lang.StringExt.substr(s, offset, default(global::haxe.lang.Null<int>)))) ));
			}
			
			#line 129 "/usr/share/haxe/std/cs/_std/EReg.hx"
			return buf_b.ToString();
		}
		#line default
	}
	
	
	public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
		unchecked {
			#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
			switch (hash) {
				case 4949376:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					this.cur = global::haxe.lang.Runtime.toString(@value);
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return @value;
				}
				
				
				case 1821933:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					this.isGlobal = global::haxe.lang.Runtime.toBool(@value);
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return @value;
				}
				
				
				case 109:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					this.m = ((global::System.Text.RegularExpressions.Match) (@value) );
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return @value;
				}
				
				
				case 1723805383:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					this.regex = ((global::System.Text.RegularExpressions.Regex) (@value) );
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return @value;
				}
				
				
				default:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return base.__hx_setField(field, hash, @value, handleProperties);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
		unchecked {
			#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
			switch (hash) {
				case 5442204:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "map", 5442204)) );
				}
				
				
				case 724060212:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "replace", 724060212)) );
				}
				
				
				case 5393365:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "len", 5393365)) );
				}
				
				
				case 67859554:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "start", 67859554)) );
				}
				
				
				case 24046298:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "split", 24046298)) );
				}
				
				
				case 1126920507:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "matchSub", 1126920507)) );
				}
				
				
				case 1271070480:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "matchedPos", 1271070480)) );
				}
				
				
				case 614073432:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "matchedRight", 614073432)) );
				}
				
				
				case 2083500811:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "matchedLeft", 2083500811)) );
				}
				
				
				case 159136996:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "matched", 159136996)) );
				}
				
				
				case 52644165:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "match", 52644165)) );
				}
				
				
				case 4949376:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.cur;
				}
				
				
				case 1821933:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.isGlobal;
				}
				
				
				case 109:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.m;
				}
				
				
				case 1723805383:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.regex;
				}
				
				
				default:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override object __hx_invokeField(string field, int hash, object[] dynargs) {
		unchecked {
			#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
			switch (hash) {
				case 5442204:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.map(global::haxe.lang.Runtime.toString(dynargs[0]), ((global::haxe.lang.Function) (dynargs[1]) ));
				}
				
				
				case 724060212:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.replace(global::haxe.lang.Runtime.toString(dynargs[0]), global::haxe.lang.Runtime.toString(dynargs[1]));
				}
				
				
				case 5393365:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.len(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 67859554:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.start(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 24046298:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.split(global::haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				case 1126920507:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.matchSub(global::haxe.lang.Runtime.toString(dynargs[0]), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), global::haxe.lang.Null<object>.ofDynamic<int>(( (( dynargs.Length > 2 )) ? (dynargs[2]) : (null) )));
				}
				
				
				case 1271070480:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.matchedPos();
				}
				
				
				case 614073432:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.matchedRight();
				}
				
				
				case 2083500811:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.matchedLeft();
				}
				
				
				case 159136996:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.matched(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 52644165:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return this.match(global::haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				default:
				{
					#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override void __hx_getFields(global::Array<string> baseArr) {
		#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
		baseArr.push("cur");
		#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
		baseArr.push("isGlobal");
		#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
		baseArr.push("m");
		#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
		baseArr.push("regex");
		#line 28 "/usr/share/haxe/std/cs/_std/EReg.hx"
		base.__hx_getFields(baseArr);
	}
	#line default
	
}

