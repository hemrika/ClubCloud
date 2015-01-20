/*
 * Globalize Culture sms
 *
 * http://github.com/jquery/globalize
 *
 * Copyright Software Freedom Conservancy, Inc.
 * Dual licensed under the MIT or GPL Version 2 licenses.
 * http://jquery.org/license
 *
 * This file was generated by the Globalize Culture Generator
 * Translation: bugs found in this file need to be fixed in the generator
 */

(function( window, undefined ) {

var Globalize;

if ( typeof require !== "undefined" &&
	typeof exports !== "undefined" &&
	typeof module !== "undefined" ) {
	// Assume CommonJS
	Globalize = require( "globalize" );
} else {
	// Global variable
	Globalize = window.Globalize;
}

Globalize.addCultureInfo( "sms", "default", {
	name: "sms",
	englishName: "Sami (Skolt)",
	nativeName: "sää´mǩiõll",
	language: "sms",
	numberFormat: {
		",": " ",
		".": ",",
		percent: {
			",": " ",
			".": ","
		},
		currency: {
			pattern: ["-n $","n $"],
			",": " ",
			".": ",",
			symbol: "€"
		}
	},
	calendars: {
		standard: {
			"/": ".",
			firstDay: 1,
			days: {
				names: ["pâ´sspei´vv","vuõssargg","mââibargg","seärad","neljdpei´vv","piâtnâc","sue´vet"],
				namesAbbr: ["pâ","vu","mâ","se","ne","pi","su"],
				namesShort: ["pâ","v","m","s","n","pi","s"]
			},
			months: {
				names: ["ođđee´jjmään","tä´lvvmään","pâ´zzlâšttam-mään","njuhččmään","vue´ssmään","ǩie´ssmään","suei´nnmään","på´rǧǧmään","čõhččmään","kålggmään","skamm-mään","rosttovmään",""],
				namesAbbr: ["ođđee´jjmään","tä´lvvmään","pâ´zzlâšttam-mään","njuhččmään","vue´ssmään","ǩie´ssmään","suei´nnmään","på´rǧǧmään","čõhččmään","kålggmään","skamm-mään","rosttovmään",""]
			},
			monthsGenitive: {
				names: ["ođđee´jjmannu","tä´lvvmannu","pâ´zzlâšttam-mannu","njuhččmannu","vue´ssmannu","ǩie´ssmannu","suei´nnmannu","på´rǧǧmannu","čõhččmannu","kålggmannu","skamm-mannu","rosttovmannu",""],
				namesAbbr: ["ođđee´jjmannu","tä´lvvmannu","pâ´zzlâšttam-mannu","njuhččmannu","vue´ssmannu","ǩie´ssmannu","suei´nnmannu","på´rǧǧmannu","čõhččmannu","kålggmannu","skamm-mannu","rosttovmannu",""]
			},
			AM: null,
			PM: null,
			patterns: {
				d: "d.M.yyyy",
				D: "MMMM d'. p. 'yyyy",
				t: "H:mm",
				T: "H:mm:ss",
				f: "MMMM d'. p. 'yyyy H:mm",
				F: "MMMM d'. p. 'yyyy H:mm:ss",
				M: "MMMM d'. p. '"
			}
		}
	}
});

}( this ));