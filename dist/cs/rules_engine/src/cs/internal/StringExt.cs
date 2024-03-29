// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class StringExt {
		
		public StringExt() {
		}
		
		
		public static readonly global::System.String empty = new global::System.String(((char) (0) ), 0);
		
		public static global::System.String charAt(global::System.String me, int index) {
			unchecked {
				#line 33 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				if (((bool) (( ((uint) (index) ) >= me.Length )) )) {
					#line 34 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return global::haxe.lang.StringExt.empty;
				}
				else {
					#line 36 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return new global::System.String(me[index], 1);
				}
				
			}
			#line default
		}
		
		
		public static global::haxe.lang.Null<int> charCodeAt(global::System.String me, int index) {
			#line 40 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (((bool) (( ((uint) (index) ) >= me.Length )) )) {
				#line 41 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return default(global::haxe.lang.Null<int>);
			}
			else {
				#line 43 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return new global::haxe.lang.Null<int>(((int) (me[index]) ), true);
			}
			
		}
		#line default
		
		public static int indexOf(global::System.String me, string str) {
			#line 46 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::haxe.lang.StringExt.indexOf(me, str, default(global::haxe.lang.Null<int>));
		}
		#line default
		
		public static int indexOf(global::System.String me, string str, global::haxe.lang.Null<int> startIndex) {
			unchecked {
				#line 47 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				int sIndex = ( (startIndex.hasValue) ? ((startIndex).@value) : (0) );
				if (( sIndex >= me.Length )) {
					#line 49 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return -1;
				}
				
				#line 50 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return me.IndexOf(((string) (str) ), ((int) (sIndex) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
			}
			#line default
		}
		
		
		public static int lastIndexOf(global::System.String me, global::System.String str) {
			#line 53 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::haxe.lang.StringExt.lastIndexOf(me, str, default(global::haxe.lang.Null<int>));
		}
		#line default
		
		public static int lastIndexOf(global::System.String me, global::System.String str, global::haxe.lang.Null<int> startIndex) {
			unchecked {
				#line 54 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				int sIndex = ( ( ! (startIndex.hasValue) ) ? (( me.Length - 1 )) : ((startIndex).@value) );
				if (( sIndex >= me.Length )) {
					#line 56 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					sIndex = ( me.Length - 1 );
				}
				else if (( sIndex < 0 )) {
					#line 58 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return -1;
				}
				
				#line 61 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				if (startIndex.hasValue) {
					#line 65 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					int d = ( ( me.Length - sIndex ) - str.Length );
					if (( d < 0 )) {
						#line 67 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						sIndex += d;
					}
					
					#line 70 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					int i = ( sIndex + 1 );
					while (( i-- > 0 )) {
						#line 72 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						bool found = true;
						{
							#line 73 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							int _g = 0;
							#line 73 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							int _g1 = str.Length;
							#line 73 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							while (( _g < _g1 )) {
								#line 73 "/usr/share/haxe/std/cs/internal/StringExt.hx"
								int j = _g++;
								if (( me[( i + j )] != str[j] )) {
									#line 75 "/usr/share/haxe/std/cs/internal/StringExt.hx"
									found = false;
									break;
								}
								
							}
							
						}
						
						#line 80 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						if (found) {
							#line 81 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							return i;
						}
						
					}
					
					#line 84 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return -1;
				}
				else {
					#line 86 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return me.LastIndexOf(((string) (str) ), ((int) (sIndex) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
				}
				
			}
			#line default
		}
		
		
		public static global::Array<string> split(global::System.String me, global::System.String delimiter) {
			unchecked {
				#line 92 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				string[] native = null;
				if (( delimiter.Length == 0 )) {
					#line 94 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					int len = me.Length;
					native = new string[len];
					#line 96 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					{
						#line 96 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						int _g = 0;
						#line 96 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						int _g1 = len;
						#line 96 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						while (( _g < _g1 )) {
							#line 96 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							int i = _g++;
							native[i] = new global::System.String(me[i], 1);
						}
						
					}
					
				}
				else {
					#line 99 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					string[] str = new string[1];
					str[0] = global::haxe.lang.Runtime.toString(delimiter);
					#line 102 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					native = me.Split(((string[]) (str) ), ((global::System.StringSplitOptions) (global::System.StringSplitOptions.None) ));
				}
				
				#line 105 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return new global::Array<string>(((string[]) (native) ));
			}
			#line default
		}
		
		
		public static string substr(global::System.String me, int pos) {
			#line 108 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::haxe.lang.StringExt.substr(me, pos, default(global::haxe.lang.Null<int>));
		}
		#line default
		
		public static string substr(global::System.String me, int pos, global::haxe.lang.Null<int> len) {
			#line 109 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			int meLen = me.Length;
			int targetLen = meLen;
			#line 111 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (len.hasValue) {
				#line 112 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				targetLen = (len).@value;
				if (( ( targetLen == 0 ) || ( ( pos != 0 ) && ( targetLen < 0 ) ) )) {
					#line 114 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return "";
				}
				
			}
			
			#line 117 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( pos < 0 )) {
				#line 118 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				pos = ( meLen + pos );
				if (( pos < 0 )) {
					#line 120 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					pos = 0;
				}
				
			}
			else if (( targetLen < 0 )) {
				#line 122 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				targetLen = ( ( meLen + targetLen ) - pos );
			}
			
			#line 125 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( ( pos + targetLen ) > meLen )) {
				#line 126 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				targetLen = ( meLen - pos );
			}
			
			#line 129 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( ( pos < 0 ) || ( targetLen <= 0 ) )) {
				#line 130 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return "";
			}
			
			#line 132 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me.Substring(((int) (pos) ), ((int) (targetLen) ));
		}
		#line default
		
		public static string substring(global::System.String me, int startIndex) {
			#line 135 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::haxe.lang.StringExt.substring(me, startIndex, default(global::haxe.lang.Null<int>));
		}
		#line default
		
		public static string substring(global::System.String me, int startIndex, global::haxe.lang.Null<int> endIndex) {
			#line 136 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			int len = me.Length;
			int endIdx = default(int);
			#line 138 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if ( ! (endIndex.hasValue) ) {
				#line 139 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				endIdx = len;
			}
			else {
				#line 140 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				endIdx = (endIndex).@value;
				#line 140 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				if (( endIdx < 0 )) {
					#line 141 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					endIdx = 0;
				}
				else if (( endIdx > len )) {
					#line 143 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					endIdx = len;
				}
				
			}
			
			#line 145 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( startIndex < 0 )) {
				#line 146 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				startIndex = 0;
			}
			else if (( startIndex > len )) {
				#line 148 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				startIndex = len;
			}
			
			#line 150 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			if (( startIndex > endIdx )) {
				#line 151 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				int tmp = startIndex;
				startIndex = endIdx;
				#line 153 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				endIdx = tmp;
			}
			
			#line 156 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me.Substring(((int) (startIndex) ), ((int) (( endIdx - startIndex )) ));
		}
		#line default
		
		public static global::System.String toString(global::System.String me) {
			#line 160 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me;
		}
		#line default
		
		public static string toLowerCase(global::System.String me) {
			#line 164 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me.ToLowerInvariant();
		}
		#line default
		
		public static string toUpperCase(global::System.String me) {
			#line 168 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me.ToUpperInvariant();
		}
		#line default
		
		public static global::System.String toNativeString(global::System.String me) {
			#line 172 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return me;
		}
		#line default
		
		public static string fromCharCode(int code) {
			#line 176 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			return global::System.Char.ConvertFromUtf32(((int) (code) ));
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class StringRefl {
		
		static StringRefl() {
			#line 182 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			global::haxe.lang.StringRefl.fields = new global::Array<string>(new string[]{"length", "toUpperCase", "toLowerCase", "charAt", "charCodeAt", "indexOf", "lastIndexOf", "split", "substr", "substring"});
		}
		#line default
		
		public StringRefl() {
		}
		
		
		public static global::Array<string> fields;
		
		public static object handleGetField(string str, string f, bool throwErrors) {
			#line 187 "/usr/share/haxe/std/cs/internal/StringExt.hx"
			switch (f) {
				case "length":
				{
					#line 189 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return str.Length;
				}
				
				
				case "charAt":
				case "charCodeAt":
				case "indexOf":
				case "lastIndexOf":
				case "split":
				case "substr":
				case "substring":
				case "toLowerCase":
				case "toUpperCase":
				{
					#line 191 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					return new global::haxe.lang.Closure(str, f, 0);
				}
				
				
				default:
				{
					#line 193 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					if (throwErrors) {
						#line 194 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Field not found: \'", f), "\' in String"));
					}
					else {
						#line 196 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						return null;
					}
					
				}
				
			}
			
		}
		#line default
		
		public static object handleCallField(global::System.String str, string f, object[] args) {
			unchecked {
				#line 201 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				object[] _args = null;
				if (( args == null )) {
					#line 203 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					_args = new global::System.String[]{((global::System.String) (str) )};
				}
				else {
					#line 205 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					_args = new object[( ( args as global::System.Array ).Length + 1 )];
					{
						#line 206 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						int _g = 0;
						#line 206 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						int _g1 = ( args as global::System.Array ).Length;
						#line 206 "/usr/share/haxe/std/cs/internal/StringExt.hx"
						while (( _g < _g1 )) {
							#line 206 "/usr/share/haxe/std/cs/internal/StringExt.hx"
							int i = _g++;
							_args[( i + 1 )] = args[i];
						}
						
					}
					
					#line 208 "/usr/share/haxe/std/cs/internal/StringExt.hx"
					_args[0] = str;
				}
				
				#line 210 "/usr/share/haxe/std/cs/internal/StringExt.hx"
				return global::haxe.lang.Runtime.slowCallField(typeof(global::haxe.lang.StringExt), f, _args);
			}
			#line default
		}
		
		
	}
}


