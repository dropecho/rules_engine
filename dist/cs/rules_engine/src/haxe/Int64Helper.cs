// Generated by Haxe 4.0.5

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Int64Helper : global::haxe.lang.HxObject {
		
		public Int64Helper(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Int64Helper() {
			#line 32 "/usr/share/haxe/std/haxe/Int64Helper.hx"
			global::haxe.Int64Helper.__hx_ctor_haxe_Int64Helper(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_Int64Helper(global::haxe.Int64Helper __hx_this) {
		}
		
		
		public static long parseString(string sParam) {
			unchecked {
				#line 37 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				long @base = ((long) (10) );
				long current = ((long) (0) );
				#line 39 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				long multiplier = ((long) (1) );
				bool sIsNegative = false;
				#line 42 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				string s = sParam.Trim();
				if (( global::haxe.lang.StringExt.charAt(s, 0) == "-" )) {
					#line 44 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					sIsNegative = true;
					s = global::haxe.lang.StringExt.substring(s, 1, new global::haxe.lang.Null<int>(s.Length, true));
				}
				
				#line 47 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				int len = s.Length;
				#line 49 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				{
					#line 49 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					int _g = 0;
					#line 49 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					int _g1 = len;
					#line 49 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					while (( _g < _g1 )) {
						#line 49 "/usr/share/haxe/std/haxe/Int64Helper.hx"
						int i = _g++;
						int digitInt = ( (global::haxe.lang.StringExt.charCodeAt(s, ( ( len - 1 ) - i ))).@value - 48 );
						#line 52 "/usr/share/haxe/std/haxe/Int64Helper.hx"
						if (( ( digitInt < 0 ) || ( digitInt > 9 ) )) {
							#line 53 "/usr/share/haxe/std/haxe/Int64Helper.hx"
							throw global::haxe.lang.HaxeException.wrap("NumberFormatError");
						}
						
						#line 56 "/usr/share/haxe/std/haxe/Int64Helper.hx"
						if (( digitInt != 0 )) {
							#line 57 "/usr/share/haxe/std/haxe/Int64Helper.hx"
							long digit = ((long) (digitInt) );
							if (sIsNegative) {
								#line 59 "/usr/share/haxe/std/haxe/Int64Helper.hx"
								current = ((long) (( ((long) (current) ) - ((long) (( ((long) (multiplier) ) * ((long) (digit) ) )) ) )) );
								if ( ! ((((bool) (( ((long) (current) ) < 0 )) ))) ) {
									#line 61 "/usr/share/haxe/std/haxe/Int64Helper.hx"
									throw global::haxe.lang.HaxeException.wrap("NumberFormatError: Underflow");
								}
								
							}
							else {
								#line 64 "/usr/share/haxe/std/haxe/Int64Helper.hx"
								current = ((long) (( ((long) (current) ) + ((long) (( ((long) (multiplier) ) * ((long) (digit) ) )) ) )) );
								if (((bool) (( ((long) (current) ) < 0 )) )) {
									#line 66 "/usr/share/haxe/std/haxe/Int64Helper.hx"
									throw global::haxe.lang.HaxeException.wrap("NumberFormatError: Overflow");
								}
								
							}
							
						}
						
						#line 71 "/usr/share/haxe/std/haxe/Int64Helper.hx"
						multiplier = ((long) (( ((long) (multiplier) ) * ((long) (@base) ) )) );
					}
					
				}
				
				#line 73 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				return current;
			}
			#line default
		}
		
		
		public static long fromFloat(double f) {
			unchecked {
				#line 80 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				if (( global::System.Double.IsNaN(((double) (f) )) ||  ! (((  ! (global::System.Double.IsInfinity(((double) (f) )))  &&  ! (global::System.Double.IsNaN(((double) (f) )))  )))  )) {
					#line 81 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					throw global::haxe.lang.HaxeException.wrap("Number is NaN or Infinite");
				}
				
				#line 84 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				double noFractions = ( f - ( f % 1 ) );
				#line 90 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				if (( noFractions > 9007199254740991 )) {
					#line 91 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					throw global::haxe.lang.HaxeException.wrap("Conversion overflow");
				}
				
				#line 93 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				if (( noFractions < -9007199254740991 )) {
					#line 94 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					throw global::haxe.lang.HaxeException.wrap("Conversion underflow");
				}
				
				#line 97 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				long result = ((long) (0) );
				bool neg = ( noFractions < 0 );
				#line 99 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				double rest = ( (neg) ? ( - (noFractions) ) : (noFractions) );
				#line 101 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				int i = 0;
				while (( rest >= 1 )) {
					#line 103 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					double curr = ( rest % 2 );
					rest /= ((double) (2) );
					#line 105 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					if (( curr >= 1 )) {
						#line 106 "/usr/share/haxe/std/haxe/Int64Helper.hx"
						result = ((long) (( ((long) (result) ) + (((long) (( ((long) (1) ) << i )) )) )) );
					}
					
					#line 108 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					 ++ i;
				}
				
				#line 111 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				if (neg) {
					#line 112 "/usr/share/haxe/std/haxe/Int64Helper.hx"
					result = global::haxe._Int64.Int64_Impl_.neg(result);
				}
				
				#line 114 "/usr/share/haxe/std/haxe/Int64Helper.hx"
				return result;
			}
			#line default
		}
		
		
	}
}

