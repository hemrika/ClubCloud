/*
 * Globalize Culture cs-CZ
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

Globalize.addCultureInfo( "cs-CZ", "default", {
	name: "cs-CZ",
	englishName: "Czech (Czech Republic)",
	nativeName: "čeština (Česká republika)",
	language: "cs",
	numberFormat: {
		",": " ",
		".": ",",
		"NaN": "Není číslo",
		negativeInfinity: "-nekonečno",
		positiveInfinity: "+nekonečno",
		percent: {
			",": " ",
			".": ","
		},
		currency: {
			pattern: ["-n $","n $"],
			",": " ",
			".": ",",
			symbol: "Kč"
		}
	},
	calendars: {
		standard: {
			"/": ". ",
			firstDay: 1,
			days: {
				names: ["neděle","pondělí","úterý","středa","čtvrtek","pátek","sobota"],
				namesAbbr: ["ne","po","út","st","čt","pá","so"],
				namesShort: ["ne","po","út","st","čt","pá","so"]
			},
			months: {
				names: ["leden","únor","březen","duben","květen","červen","červenec","srpen","září","říjen","listopad","prosinec",""],
				namesAbbr: ["I","II","III","IV","V","VI","VII","VIII","IX","X","XI","XII",""]
			},
			monthsGenitive: {
				names: ["ledna","února","března","dubna","května","června","července","srpna","září","října","listopadu","prosince",""],
				namesAbbr: ["I","II","III","IV","V","VI","VII","VIII","IX","X","XI","XII",""]
			},
			AM: ["dop.","dop.","DOP."],
			PM: ["odp.","odp.","ODP."],
			eras: [{"name":"n. l.","start":null,"offset":0}],
			patterns: {
				d: "d. M. yyyy",
				D: "d. MMMM yyyy",
				t: "H:mm",
				T: "H:mm:ss",
				f: "d. MMMM yyyy H:mm",
				F: "d. MMMM yyyy H:mm:ss",
				M: "d. MMMM"
			}
		}
	}
});

}( this ));
