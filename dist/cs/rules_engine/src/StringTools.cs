// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
public class StringTools : global::haxe.lang.HxObject {
	
	static StringTools() {
		unchecked{
			#line 569 "/usr/share/haxe/std/StringTools.hx"
			global::StringTools.winMetaCharacters = ((global::Array<int>) (global::haxe.SysTools.winMetaCharacters) );
			#line 601 "/usr/share/haxe/std/StringTools.hx"
			global::StringTools.MIN_SURROGATE_CODE_POINT = 65536;
		}
	}
	#line default
	
	public StringTools(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public StringTools() {
		#line 38 "/usr/share/haxe/std/StringTools.hx"
		global::StringTools.__hx_ctor__StringTools(this);
	}
	#line default
	
	protected static void __hx_ctor__StringTools(global::StringTools __hx_this) {
	}
	
	
	public static string urlEncode(string s) {
		#line 54 "/usr/share/haxe/std/StringTools.hx"
		return global::System.Uri.EscapeDataString(((string) (s) ));
	}
	#line default
	
	public static string urlDecode(string s) {
		#line 125 "/usr/share/haxe/std/StringTools.hx"
		return global::System.Uri.UnescapeDataString(((string) (s) ));
	}
	#line default
	
	public static string htmlEscape(string s, global::haxe.lang.Null<bool> quotes) {
		unchecked {
			#line 159 "/usr/share/haxe/std/StringTools.hx"
			global::StringBuf buf = new global::StringBuf();
			{
				#line 160 "/usr/share/haxe/std/StringTools.hx"
				int _g_offset = 0;
				#line 160 "/usr/share/haxe/std/StringTools.hx"
				string _g_s = s;
				#line 160 "/usr/share/haxe/std/StringTools.hx"
				while (( _g_offset < _g_s.Length )) {
					#line 160 "/usr/share/haxe/std/StringTools.hx"
					string s1 = _g_s;
					#line 160 "/usr/share/haxe/std/StringTools.hx"
					int index = _g_offset++;
					#line 160 "/usr/share/haxe/std/StringTools.hx"
					int c = ( (((bool) (( ((uint) (index) ) < s1.Length )) )) ? (((int) (s1[index]) )) : (-1) );
					#line 160 "/usr/share/haxe/std/StringTools.hx"
					if (( ( c >= 55296 ) && ( c <= 56319 ) )) {
						#line 160 "/usr/share/haxe/std/StringTools.hx"
						int index1 = ( index + 1 );
						#line 606 "/usr/share/haxe/std/StringTools.hx"
						c = ( ( ( c - 55232 ) << 10 ) | ( (( (((bool) (( ((uint) (index1) ) < s1.Length )) )) ? (((int) (s1[index1]) )) : (-1) )) & 1023 ) );
					}
					
					#line 160 "/usr/share/haxe/std/StringTools.hx"
					int c1 = c;
					#line 160 "/usr/share/haxe/std/StringTools.hx"
					if (( c1 >= 65536 )) {
						#line 160 "/usr/share/haxe/std/StringTools.hx"
						 ++ _g_offset;
					}
					
					#line 160 "/usr/share/haxe/std/StringTools.hx"
					int code = c1;
					switch (code) {
						case 34:
						{
							#line 168 "/usr/share/haxe/std/StringTools.hx"
							if (((quotes)).@value) {
								#line 169 "/usr/share/haxe/std/StringTools.hx"
								buf.b.Append(((string) ("&quot;") ));
							}
							else {
								#line 173 "/usr/share/haxe/std/StringTools.hx"
								buf.addChar(code);
							}
							
							#line 168 "/usr/share/haxe/std/StringTools.hx"
							break;
						}
						
						
						case 38:
						{
							#line 163 "/usr/share/haxe/std/StringTools.hx"
							buf.b.Append(((string) ("&amp;") ));
							#line 163 "/usr/share/haxe/std/StringTools.hx"
							break;
						}
						
						
						case 39:
						{
							#line 170 "/usr/share/haxe/std/StringTools.hx"
							if (((quotes)).@value) {
								#line 171 "/usr/share/haxe/std/StringTools.hx"
								buf.b.Append(((string) ("&#039;") ));
							}
							else {
								#line 173 "/usr/share/haxe/std/StringTools.hx"
								buf.addChar(code);
							}
							
							#line 170 "/usr/share/haxe/std/StringTools.hx"
							break;
						}
						
						
						case 60:
						{
							#line 165 "/usr/share/haxe/std/StringTools.hx"
							buf.b.Append(((string) ("&lt;") ));
							#line 165 "/usr/share/haxe/std/StringTools.hx"
							break;
						}
						
						
						case 62:
						{
							#line 167 "/usr/share/haxe/std/StringTools.hx"
							buf.b.Append(((string) ("&gt;") ));
							#line 167 "/usr/share/haxe/std/StringTools.hx"
							break;
						}
						
						
						default:
						{
							#line 173 "/usr/share/haxe/std/StringTools.hx"
							buf.addChar(code);
							#line 173 "/usr/share/haxe/std/StringTools.hx"
							break;
						}
						
					}
					
				}
				
			}
			
			#line 176 "/usr/share/haxe/std/StringTools.hx"
			return buf.b.ToString();
		}
		#line default
	}
	
	
	public static string htmlUnescape(string s) {
		#line 194 "/usr/share/haxe/std/StringTools.hx"
		return global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&gt;").@join(">"), "&lt;").@join("<"), "&quot;").@join("\""), "&#039;").@join("\'"), "&amp;").@join("&");
	}
	#line default
	
	public static bool contains(string s, string @value) {
		unchecked {
			#line 212 "/usr/share/haxe/std/StringTools.hx"
			return ( global::haxe.lang.StringExt.indexOf(s, @value, default(global::haxe.lang.Null<int>)) != -1 );
		}
		#line default
	}
	
	
	public static bool startsWith(string s, string start) {
		#line 226 "/usr/share/haxe/std/StringTools.hx"
		return s.StartsWith(start);
	}
	#line default
	
	public static bool endsWith(string s, string end) {
		#line 256 "/usr/share/haxe/std/StringTools.hx"
		return s.EndsWith(end);
	}
	#line default
	
	public static bool isSpace(string s, int pos) {
		unchecked {
			#line 293 "/usr/share/haxe/std/StringTools.hx"
			global::haxe.lang.Null<int> c = global::haxe.lang.StringExt.charCodeAt(s, pos);
			if ( ! ((( ( (c).@value > 8 ) && ( (c).@value < 14 ) ))) ) {
				#line 294 "/usr/share/haxe/std/StringTools.hx"
				return global::haxe.lang.Runtime.eq((c).toDynamic(), 32);
			}
			else {
				#line 294 "/usr/share/haxe/std/StringTools.hx"
				return true;
			}
			
		}
		#line default
	}
	
	
	public static string ltrim(string s) {
		#line 308 "/usr/share/haxe/std/StringTools.hx"
		return s.TrimStart();
	}
	#line default
	
	public static string rtrim(string s) {
		#line 333 "/usr/share/haxe/std/StringTools.hx"
		return s.TrimEnd();
	}
	#line default
	
	public static string trim(string s) {
		#line 355 "/usr/share/haxe/std/StringTools.hx"
		return s.Trim();
	}
	#line default
	
	public static string lpad(string s, string c, int l) {
		#line 376 "/usr/share/haxe/std/StringTools.hx"
		if (( c.Length <= 0 )) {
			#line 377 "/usr/share/haxe/std/StringTools.hx"
			return s;
		}
		
		#line 379 "/usr/share/haxe/std/StringTools.hx"
		global::System.Text.StringBuilder buf_b = new global::System.Text.StringBuilder();
		l -= s.Length;
		#line 381 "/usr/share/haxe/std/StringTools.hx"
		while (( buf_b.Length < l )) {
			#line 382 "/usr/share/haxe/std/StringTools.hx"
			buf_b.Append(((string) (global::Std.@string(c)) ));
		}
		
		#line 384 "/usr/share/haxe/std/StringTools.hx"
		buf_b.Append(((string) (global::Std.@string(s)) ));
		return buf_b.ToString();
	}
	#line default
	
	public static string rpad(string s, string c, int l) {
		#line 401 "/usr/share/haxe/std/StringTools.hx"
		if (( c.Length <= 0 )) {
			#line 402 "/usr/share/haxe/std/StringTools.hx"
			return s;
		}
		
		#line 404 "/usr/share/haxe/std/StringTools.hx"
		global::System.Text.StringBuilder buf_b = new global::System.Text.StringBuilder();
		buf_b.Append(((string) (global::Std.@string(s)) ));
		#line 406 "/usr/share/haxe/std/StringTools.hx"
		while (( buf_b.Length < l )) {
			#line 407 "/usr/share/haxe/std/StringTools.hx"
			buf_b.Append(((string) (global::Std.@string(c)) ));
		}
		
		#line 409 "/usr/share/haxe/std/StringTools.hx"
		return buf_b.ToString();
	}
	#line default
	
	public static string replace(string s, string sub, string @by) {
		#line 429 "/usr/share/haxe/std/StringTools.hx"
		if (( sub.Length == 0 )) {
			#line 430 "/usr/share/haxe/std/StringTools.hx"
			return global::haxe.lang.StringExt.split(s, sub).@join(@by);
		}
		else {
			#line 432 "/usr/share/haxe/std/StringTools.hx"
			return s.Replace(sub, @by);
		}
		
	}
	#line default
	
	public static string hex(int n, global::haxe.lang.Null<int> digits) {
		unchecked {
			#line 450 "/usr/share/haxe/std/StringTools.hx"
			string s = "";
			string hexChars = "0123456789ABCDEF";
			#line 452 "/usr/share/haxe/std/StringTools.hx"
			while (true) {
				#line 453 "/usr/share/haxe/std/StringTools.hx"
				s = global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hexChars, ( n & 15 )), s);
				n = ((int) (( ((uint) (n) ) >> 4 )) );
				#line 452 "/usr/share/haxe/std/StringTools.hx"
				if ( ! ((( n > 0 ))) ) {
					#line 452 "/usr/share/haxe/std/StringTools.hx"
					break;
				}
				
			}
			
			#line 465 "/usr/share/haxe/std/StringTools.hx"
			if (digits.hasValue) {
				#line 466 "/usr/share/haxe/std/StringTools.hx"
				while (( s.Length < (digits).@value )) {
					#line 467 "/usr/share/haxe/std/StringTools.hx"
					s = global::haxe.lang.Runtime.concat("0", s);
				}
				
			}
			
			#line 469 "/usr/share/haxe/std/StringTools.hx"
			return s;
		}
		#line default
	}
	
	
	public static int fastCodeAt(string s, int index) {
		unchecked {
			#line 496 "/usr/share/haxe/std/StringTools.hx"
			if (((bool) (( ((uint) (index) ) < s.Length )) )) {
				#line 496 "/usr/share/haxe/std/StringTools.hx"
				return ((int) (s[index]) );
			}
			else {
				#line 496 "/usr/share/haxe/std/StringTools.hx"
				return -1;
			}
			
		}
		#line default
	}
	
	
	public static global::haxe.iterators.StringIterator iterator(string s) {
		#line 522 "/usr/share/haxe/std/StringTools.hx"
		return new global::haxe.iterators.StringIterator(((string) (s) ));
	}
	#line default
	
	public static global::haxe.iterators.StringKeyValueIterator keyValueIterator(string s) {
		#line 533 "/usr/share/haxe/std/StringTools.hx"
		return new global::haxe.iterators.StringKeyValueIterator(((string) (s) ));
	}
	#line default
	
	public static bool isEof(int c) {
		unchecked {
			#line 547 "/usr/share/haxe/std/StringTools.hx"
			return ( c == -1 );
		}
		#line default
	}
	
	
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public static string quoteUnixArg(string argument) {
		#line 561 "/usr/share/haxe/std/StringTools.hx"
		if (( argument == "" )) {
			#line 561 "/usr/share/haxe/std/StringTools.hx"
			return "\'\'";
		}
		else if ( ! (new global::EReg("[^a-zA-Z0-9_@%+=:,./-]", "").match(argument)) ) {
			#line 561 "/usr/share/haxe/std/StringTools.hx"
			return argument;
		}
		else {
			#line 561 "/usr/share/haxe/std/StringTools.hx"
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("\'", global::StringTools.replace(argument, "\'", "\'\"\'\"\'")), "\'");
		}
		
	}
	#line default
	
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public static global::Array<int> winMetaCharacters;
	
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public static string quoteWinArg(string argument, bool escapeMetaCharacters) {
		unchecked {
			#line 587 "/usr/share/haxe/std/StringTools.hx"
			string argument1 = argument;
			#line 587 "/usr/share/haxe/std/StringTools.hx"
			if ( ! (new global::EReg("^[^ \t\\\\\"]+$", "").match(argument1)) ) {
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				global::StringBuf result = new global::StringBuf();
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				bool needquote = ( ( ( global::haxe.lang.StringExt.indexOf(argument1, " ", default(global::haxe.lang.Null<int>)) != -1 ) || ( global::haxe.lang.StringExt.indexOf(argument1, "\t", default(global::haxe.lang.Null<int>)) != -1 ) ) || ( argument1 == "" ) );
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				if (needquote) {
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					result.b.Append(((string) ("\"") ));
				}
				
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				global::StringBuf bs_buf = new global::StringBuf();
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				{
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					int _g = 0;
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					int _g1 = argument1.Length;
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					while (( _g < _g1 )) {
						#line 587 "/usr/share/haxe/std/StringTools.hx"
						int i = _g++;
						#line 587 "/usr/share/haxe/std/StringTools.hx"
						{
							#line 587 "/usr/share/haxe/std/StringTools.hx"
							global::haxe.lang.Null<int> _g2 = global::haxe.lang.StringExt.charCodeAt(argument1, i);
							#line 587 "/usr/share/haxe/std/StringTools.hx"
							if ( ! (_g2.hasValue) ) {
								#line 587 "/usr/share/haxe/std/StringTools.hx"
								global::haxe.lang.Null<int> c = _g2;
								#line 587 "/usr/share/haxe/std/StringTools.hx"
								{
									#line 587 "/usr/share/haxe/std/StringTools.hx"
									if (( bs_buf.b.Length > 0 )) {
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										{
											#line 587 "/usr/share/haxe/std/StringTools.hx"
											string x = bs_buf.b.ToString();
											#line 587 "/usr/share/haxe/std/StringTools.hx"
											result.b.Append(((string) (global::Std.@string(x)) ));
										}
										
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										bs_buf = new global::StringBuf();
									}
									
									#line 587 "/usr/share/haxe/std/StringTools.hx"
									result.addChar((c).@value);
								}
								
							}
							else {
								#line 587 "/usr/share/haxe/std/StringTools.hx"
								switch (((_g2)).@value) {
									case 34:
									{
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										string bs = bs_buf.b.ToString();
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										result.b.Append(((string) (global::Std.@string(bs)) ));
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										result.b.Append(((string) (global::Std.@string(bs)) ));
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										bs_buf = new global::StringBuf();
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										result.b.Append(((string) ("\\\"") ));
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										break;
									}
									
									
									case 92:
									{
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										bs_buf.b.Append(((string) ("\\") ));
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										break;
									}
									
									
									default:
									{
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										global::haxe.lang.Null<int> c1 = _g2;
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										{
											#line 587 "/usr/share/haxe/std/StringTools.hx"
											if (( bs_buf.b.Length > 0 )) {
												#line 587 "/usr/share/haxe/std/StringTools.hx"
												{
													#line 587 "/usr/share/haxe/std/StringTools.hx"
													string x1 = bs_buf.b.ToString();
													#line 587 "/usr/share/haxe/std/StringTools.hx"
													result.b.Append(((string) (global::Std.@string(x1)) ));
												}
												
												#line 587 "/usr/share/haxe/std/StringTools.hx"
												bs_buf = new global::StringBuf();
											}
											
											#line 587 "/usr/share/haxe/std/StringTools.hx"
											result.addChar((c1).@value);
										}
										
										#line 587 "/usr/share/haxe/std/StringTools.hx"
										break;
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				{
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					string x2 = bs_buf.b.ToString();
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					result.b.Append(((string) (global::Std.@string(x2)) ));
				}
				
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				if (needquote) {
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					{
						#line 587 "/usr/share/haxe/std/StringTools.hx"
						string x3 = bs_buf.b.ToString();
						#line 587 "/usr/share/haxe/std/StringTools.hx"
						result.b.Append(((string) (global::Std.@string(x3)) ));
					}
					
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					result.b.Append(((string) ("\"") ));
				}
				
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				argument1 = result.b.ToString();
			}
			
			#line 587 "/usr/share/haxe/std/StringTools.hx"
			if (escapeMetaCharacters) {
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				global::StringBuf result1 = new global::StringBuf();
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				{
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					int _g3 = 0;
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					int _g11 = argument1.Length;
					#line 587 "/usr/share/haxe/std/StringTools.hx"
					while (( _g3 < _g11 )) {
						#line 587 "/usr/share/haxe/std/StringTools.hx"
						int i1 = _g3++;
						#line 587 "/usr/share/haxe/std/StringTools.hx"
						global::haxe.lang.Null<int> c2 = global::haxe.lang.StringExt.charCodeAt(argument1, i1);
						#line 587 "/usr/share/haxe/std/StringTools.hx"
						if (( global::haxe.SysTools.winMetaCharacters.indexOf((c2).@value, default(global::haxe.lang.Null<int>)) >= 0 )) {
							#line 587 "/usr/share/haxe/std/StringTools.hx"
							result1.addChar(94);
						}
						
						#line 587 "/usr/share/haxe/std/StringTools.hx"
						result1.addChar((c2).@value);
					}
					
				}
				
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				return result1.b.ToString();
			}
			else {
				#line 587 "/usr/share/haxe/std/StringTools.hx"
				return argument1;
			}
			
		}
		#line default
	}
	
	
	public static int MIN_SURROGATE_CODE_POINT;
	
	public static int utf16CodePointAt(string s, int index) {
		unchecked {
			#line 604 "/usr/share/haxe/std/StringTools.hx"
			int c = ( (((bool) (( ((uint) (index) ) < s.Length )) )) ? (((int) (s[index]) )) : (-1) );
			if (( ( c >= 55296 ) && ( c <= 56319 ) )) {
				#line 606 "/usr/share/haxe/std/StringTools.hx"
				int index1 = ( index + 1 );
				#line 606 "/usr/share/haxe/std/StringTools.hx"
				c = ( ( ( c - 55232 ) << 10 ) | ( (( (((bool) (( ((uint) (index1) ) < s.Length )) )) ? (((int) (s[index1]) )) : (-1) )) & 1023 ) );
			}
			
			#line 608 "/usr/share/haxe/std/StringTools.hx"
			return c;
		}
		#line default
	}
	
	
}


