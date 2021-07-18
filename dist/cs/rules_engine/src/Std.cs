// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Std {
	
	public Std() {
	}
	
	
	public static bool @is(object v, object t) {
		unchecked {
			#line 29 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( v == null )) {
				#line 30 "/usr/share/haxe/std/cs/_std/Std.hx"
				return false;
			}
			
			#line 31 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( t == null )) {
				#line 32 "/usr/share/haxe/std/cs/_std/Std.hx"
				return false;
			}
			
			#line 33 "/usr/share/haxe/std/cs/_std/Std.hx"
			global::System.Type clt = ((global::System.Type) (( t as global::System.Type )) );
			if (global::haxe.lang.Runtime.typeEq(clt, null)) {
				#line 35 "/usr/share/haxe/std/cs/_std/Std.hx"
				return false;
			}
			
			#line 37 "/usr/share/haxe/std/cs/_std/Std.hx"
			switch (( clt as global::System.Reflection.MemberInfo ).ToString()) {
				case "System.Boolean":
				{
					#line 43 "/usr/share/haxe/std/cs/_std/Std.hx"
					return v is bool;
				}
				
				
				case "System.Double":
				{
					#line 39 "/usr/share/haxe/std/cs/_std/Std.hx"
					return v is double || v is int;
				}
				
				
				case "System.Int32":
				{
					#line 41 "/usr/share/haxe/std/cs/_std/Std.hx"
					return global::haxe.lang.Runtime.isInt(v);
				}
				
				
				case "System.Object":
				{
					#line 45 "/usr/share/haxe/std/cs/_std/Std.hx"
					return true;
				}
				
				
			}
			
			#line 48 "/usr/share/haxe/std/cs/_std/Std.hx"
			global::System.Type vt = v.GetType();
			#line 50 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (clt.IsAssignableFrom(((global::System.Type) (vt) ))) {
				#line 51 "/usr/share/haxe/std/cs/_std/Std.hx"
				return true;
			}
			
			#line 54 "/usr/share/haxe/std/cs/_std/Std.hx"
			{
				#line 54 "/usr/share/haxe/std/cs/_std/Std.hx"
				global::System.Type[] _g1_arr = clt.GetInterfaces();
				#line 54 "/usr/share/haxe/std/cs/_std/Std.hx"
				uint _g1_idx = ((uint) (0) );
				#line 54 "/usr/share/haxe/std/cs/_std/Std.hx"
				while (((bool) (( _g1_idx < ( _g1_arr as global::System.Array ).Length )) )) {
					#line 54 "/usr/share/haxe/std/cs/_std/Std.hx"
					_g1_idx += ((uint) (1) );
					#line 54 "/usr/share/haxe/std/cs/_std/Std.hx"
					global::System.Type iface = ((global::System.Type) (_g1_arr[((int) (((uint) (( _g1_idx - 1 )) )) )]) );
					global::haxe.lang.GenericInterface g = global::haxe.lang.Runtime.getGenericAttr(iface);
					#line 56 "/usr/share/haxe/std/cs/_std/Std.hx"
					if (( ( g != null ) && global::haxe.lang.Runtime.typeEq(g.generic, clt) )) {
						#line 57 "/usr/share/haxe/std/cs/_std/Std.hx"
						return iface.IsAssignableFrom(((global::System.Type) (vt) ));
					}
					
				}
				
			}
			
			#line 62 "/usr/share/haxe/std/cs/_std/Std.hx"
			return false;
		}
		#line default
	}
	
	
	public static string @string(object s) {
		#line 66 "/usr/share/haxe/std/cs/_std/Std.hx"
		if (( s == null )) {
			#line 67 "/usr/share/haxe/std/cs/_std/Std.hx"
			return "null";
		}
		
		#line 68 "/usr/share/haxe/std/cs/_std/Std.hx"
		if (( s is bool )) {
			#line 69 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (global::haxe.lang.Runtime.toBool(s)) {
				#line 69 "/usr/share/haxe/std/cs/_std/Std.hx"
				return "true";
			}
			else {
				#line 69 "/usr/share/haxe/std/cs/_std/Std.hx"
				return "false";
			}
			
		}
		
		#line 71 "/usr/share/haxe/std/cs/_std/Std.hx"
		return s.ToString();
	}
	#line default
	
	public static int @int(double x) {
		#line 75 "/usr/share/haxe/std/cs/_std/Std.hx"
		return ((int) (x) );
	}
	#line default
	
	public static global::haxe.lang.Null<int> parseInt(string x) {
		unchecked {
			#line 79 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( x == null )) {
				#line 80 "/usr/share/haxe/std/cs/_std/Std.hx"
				return default(global::haxe.lang.Null<int>);
			}
			
			#line 82 "/usr/share/haxe/std/cs/_std/Std.hx"
			int @base = 10;
			int len = x.Length;
			#line 84 "/usr/share/haxe/std/cs/_std/Std.hx"
			int foundCount = 0;
			int sign = 0;
			#line 86 "/usr/share/haxe/std/cs/_std/Std.hx"
			int firstDigitIndex = 0;
			int lastDigitIndex = -1;
			#line 88 "/usr/share/haxe/std/cs/_std/Std.hx"
			int previous = 0;
			#line 90 "/usr/share/haxe/std/cs/_std/Std.hx"
			{
				#line 90 "/usr/share/haxe/std/cs/_std/Std.hx"
				int _g = 0;
				#line 90 "/usr/share/haxe/std/cs/_std/Std.hx"
				int _g1 = len;
				#line 90 "/usr/share/haxe/std/cs/_std/Std.hx"
				while (( _g < _g1 )) {
					#line 90 "/usr/share/haxe/std/cs/_std/Std.hx"
					int i = _g++;
					int c = ( (((bool) (( ((uint) (i) ) < x.Length )) )) ? (((int) (x[i]) )) : (-1) );
					#line 92 "/usr/share/haxe/std/cs/_std/Std.hx"
					if (( ( ( c > 8 ) && ( c < 14 ) ) || ( c == 32 ) )) {
						#line 94 "/usr/share/haxe/std/cs/_std/Std.hx"
						if (( foundCount > 0 )) {
							#line 95 "/usr/share/haxe/std/cs/_std/Std.hx"
							return default(global::haxe.lang.Null<int>);
						}
						
						#line 97 "/usr/share/haxe/std/cs/_std/Std.hx"
						continue;
					}
					else {
						#line 92 "/usr/share/haxe/std/cs/_std/Std.hx"
						switch (c) {
							case 43:
							{
								#line 100 "/usr/share/haxe/std/cs/_std/Std.hx"
								if (( foundCount == 0 )) {
									#line 101 "/usr/share/haxe/std/cs/_std/Std.hx"
									sign = 1;
								}
								else if (( ( 48 <= c ) && ( c <= 57 ) )) {
								}
								else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
								}
								else {
									#line 108 "/usr/share/haxe/std/cs/_std/Std.hx"
									goto label1;
								}
								
								#line 100 "/usr/share/haxe/std/cs/_std/Std.hx"
								break;
							}
							
							
							case 45:
							{
								#line 98 "/usr/share/haxe/std/cs/_std/Std.hx"
								if (( foundCount == 0 )) {
									#line 99 "/usr/share/haxe/std/cs/_std/Std.hx"
									sign = -1;
								}
								else if (( ( 48 <= c ) && ( c <= 57 ) )) {
								}
								else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
								}
								else {
									#line 108 "/usr/share/haxe/std/cs/_std/Std.hx"
									goto label1;
								}
								
								#line 98 "/usr/share/haxe/std/cs/_std/Std.hx"
								break;
							}
							
							
							case 48:
							{
								#line 102 "/usr/share/haxe/std/cs/_std/Std.hx"
								if (( ( foundCount == 0 ) || ( ( foundCount == 1 ) && ( sign != 0 ) ) )) {
								}
								else if (( ( 48 <= c ) && ( c <= 57 ) )) {
								}
								else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
								}
								else {
									#line 108 "/usr/share/haxe/std/cs/_std/Std.hx"
									goto label1;
								}
								
								#line 102 "/usr/share/haxe/std/cs/_std/Std.hx"
								break;
							}
							
							
							case 88:
							case 120:
							{
								#line 103 "/usr/share/haxe/std/cs/_std/Std.hx"
								if (( ( previous == 48 ) && (( ( ( foundCount == 1 ) && ( sign == 0 ) ) || ( ( foundCount == 2 ) && ( sign != 0 ) ) )) )) {
									#line 104 "/usr/share/haxe/std/cs/_std/Std.hx"
									@base = 16;
								}
								else if (( ( 48 <= c ) && ( c <= 57 ) )) {
								}
								else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
								}
								else {
									#line 108 "/usr/share/haxe/std/cs/_std/Std.hx"
									goto label1;
								}
								
								#line 103 "/usr/share/haxe/std/cs/_std/Std.hx"
								break;
							}
							
							
							default:
							{
								#line 105 "/usr/share/haxe/std/cs/_std/Std.hx"
								if (( ( 48 <= c ) && ( c <= 57 ) )) {
								}
								else if (( ( @base == 16 ) && (( ( ( 97 <= c ) && ( c <= 122 ) ) || ( ( 65 <= c ) && ( c <= 90 ) ) )) )) {
								}
								else {
									#line 108 "/usr/share/haxe/std/cs/_std/Std.hx"
									goto label1;
								}
								
								#line 105 "/usr/share/haxe/std/cs/_std/Std.hx"
								break;
							}
							
						}
						
					}
					
					#line 110 "/usr/share/haxe/std/cs/_std/Std.hx"
					if (( ( ( foundCount == 0 ) && ( sign == 0 ) ) || ( ( foundCount == 1 ) && ( sign != 0 ) ) )) {
						#line 111 "/usr/share/haxe/std/cs/_std/Std.hx"
						firstDigitIndex = i;
					}
					
					#line 113 "/usr/share/haxe/std/cs/_std/Std.hx"
					 ++ foundCount;
					lastDigitIndex = i;
					#line 115 "/usr/share/haxe/std/cs/_std/Std.hx"
					previous = c;
				}
				label1: {};
			}
			
			#line 117 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( firstDigitIndex <= lastDigitIndex )) {
				#line 118 "/usr/share/haxe/std/cs/_std/Std.hx"
				string digits = global::haxe.lang.StringExt.substring(x, firstDigitIndex, new global::haxe.lang.Null<int>(( lastDigitIndex + 1 ), true));
				#line 120 "/usr/share/haxe/std/cs/_std/Std.hx"
				try {
					#line 120 "/usr/share/haxe/std/cs/_std/Std.hx"
					return new global::haxe.lang.Null<int>(( (( (( sign == -1 )) ? (-1) : (1) )) * global::System.Convert.ToInt32(((string) (digits) ), ((int) (@base) )) ), true);
				}
				catch (global::System.FormatException e){
					#line 122 "/usr/share/haxe/std/cs/_std/Std.hx"
					global::haxe.lang.Exceptions.exception = e;
					#line 122 "/usr/share/haxe/std/cs/_std/Std.hx"
					return default(global::haxe.lang.Null<int>);
				}
				
				
			}
			
			#line 125 "/usr/share/haxe/std/cs/_std/Std.hx"
			return default(global::haxe.lang.Null<int>);
		}
		#line default
	}
	
	
	public static double parseFloat(string x) {
		unchecked {
			#line 129 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( x == null )) {
				#line 130 "/usr/share/haxe/std/cs/_std/Std.hx"
				return global::Math.NaN;
			}
			
			#line 131 "/usr/share/haxe/std/cs/_std/Std.hx"
			x = x.TrimStart();
			bool found = false;
			bool hasDot = false;
			bool hasSign = false;
			bool hasE = false;
			bool hasESign = false;
			bool hasEData = false;
			#line 138 "/usr/share/haxe/std/cs/_std/Std.hx"
			int i = -1;
			#line 142 "/usr/share/haxe/std/cs/_std/Std.hx"
			while ((  ++ i < x.Length )) {
				#line 143 "/usr/share/haxe/std/cs/_std/Std.hx"
				int chr = ((int) (((global::System.String) (x) )[i]) );
				if (( ( chr >= 48 ) && ( chr <= 57 ) )) {
					#line 145 "/usr/share/haxe/std/cs/_std/Std.hx"
					if (hasE) {
						#line 146 "/usr/share/haxe/std/cs/_std/Std.hx"
						hasEData = true;
					}
					
					#line 148 "/usr/share/haxe/std/cs/_std/Std.hx"
					found = true;
				}
				else {
					#line 150 "/usr/share/haxe/std/cs/_std/Std.hx"
					switch (chr) {
						case 43:
						case 45:
						{
							#line 155 "/usr/share/haxe/std/cs/_std/Std.hx"
							if ((  ! (found)  &&  ! (hasSign)  )) {
								#line 156 "/usr/share/haxe/std/cs/_std/Std.hx"
								hasSign = true;
							}
							else if (( ( ( found &&  ! (hasESign)  ) && hasE ) &&  ! (hasEData)  )) {
								#line 158 "/usr/share/haxe/std/cs/_std/Std.hx"
								hasESign = true;
							}
							else {
								#line 160 "/usr/share/haxe/std/cs/_std/Std.hx"
								goto label1;
							}
							
							#line 155 "/usr/share/haxe/std/cs/_std/Std.hx"
							break;
						}
						
						
						case 46:
						{
							#line 153 "/usr/share/haxe/std/cs/_std/Std.hx"
							if ( ! (hasDot) ) {
								#line 154 "/usr/share/haxe/std/cs/_std/Std.hx"
								hasDot = true;
							}
							else {
								#line 160 "/usr/share/haxe/std/cs/_std/Std.hx"
								goto label1;
							}
							
							#line 153 "/usr/share/haxe/std/cs/_std/Std.hx"
							break;
						}
						
						
						case 69:
						case 101:
						{
							#line 151 "/usr/share/haxe/std/cs/_std/Std.hx"
							if ( ! (hasE) ) {
								#line 152 "/usr/share/haxe/std/cs/_std/Std.hx"
								hasE = true;
							}
							else {
								#line 160 "/usr/share/haxe/std/cs/_std/Std.hx"
								goto label1;
							}
							
							#line 151 "/usr/share/haxe/std/cs/_std/Std.hx"
							break;
						}
						
						
						default:
						{
							#line 160 "/usr/share/haxe/std/cs/_std/Std.hx"
							goto label1;
						}
						
					}
					
				}
				
			}
			label1: {};
			#line 163 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( hasE &&  ! (hasEData)  )) {
				#line 164 "/usr/share/haxe/std/cs/_std/Std.hx"
				 -- i;
				if (hasESign) {
					#line 166 "/usr/share/haxe/std/cs/_std/Std.hx"
					 -- i;
				}
				
			}
			
			#line 168 "/usr/share/haxe/std/cs/_std/Std.hx"
			if (( i != x.Length )) {
				#line 169 "/usr/share/haxe/std/cs/_std/Std.hx"
				x = global::haxe.lang.StringExt.substr(x, 0, new global::haxe.lang.Null<int>(i, true));
			}
			
			#line 171 "/usr/share/haxe/std/cs/_std/Std.hx"
			try {
				#line 171 "/usr/share/haxe/std/cs/_std/Std.hx"
				return global::System.Double.Parse(((string) (x) ), ((global::System.IFormatProvider) (global::System.Globalization.CultureInfo.InvariantCulture) ));
			}
			catch (global::System.Exception catchallException){
				#line 171 "/usr/share/haxe/std/cs/_std/Std.hx"
				global::haxe.lang.Exceptions.exception = catchallException;
				#line 171 "/usr/share/haxe/std/cs/_std/Std.hx"
				object e = ( (( catchallException is global::haxe.lang.HaxeException )) ? (((global::haxe.lang.HaxeException) (catchallException) ).obj) : ((object) (catchallException) ) );
				#line 171 "/usr/share/haxe/std/cs/_std/Std.hx"
				return global::Math.NaN;
			}
			
			
		}
		#line default
	}
	
	
	public static int random(int x) {
		#line 184 "/usr/share/haxe/std/cs/_std/Std.hx"
		if (( x <= 0 )) {
			#line 185 "/usr/share/haxe/std/cs/_std/Std.hx"
			return 0;
		}
		
		#line 186 "/usr/share/haxe/std/cs/_std/Std.hx"
		return global::Math.rand.Next(((int) (x) ));
	}
	#line default
	
}

