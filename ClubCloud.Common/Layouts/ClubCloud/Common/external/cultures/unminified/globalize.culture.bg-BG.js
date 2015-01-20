/*
 * Globalize Culture bg-BG
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

Globalize.addCultureInfo( "bg-BG", "default", {
	name: "bg-BG",
	englishName: "Bulgarian (Bulgaria)",
	nativeName: "български (България)",
	language: "bg",
	numberFormat: {
		",": " ",
		".": ",",
		negativeInfinity: "- безкрайност",
		positiveInfinity: "+ безкрайност",
		percent: {
			",": " ",
			".": ","
		},
		currency: {
			pattern: ["-n $","n $"],
			",": " ",
			".": ",",
			symbol: "лв."
		}
	},
	calendars: {
		standard: {
			"/": ".",
			firstDay: 1,
			days: {
				names: ["неделя","понеделник","вторник","сряда","четвъртък","петък","събота"],
				namesAbbr: ["нед","пон","вт","ср","четв","пет","съб"],
				namesShort: ["нд","пн","вт","ср","чт","пт","сб"]
			},
			months: {
				names: ["януари","февруари","март","април","май","юни","юли","август","септември","октомври","ноември","декември",""],
				namesAbbr: ["яну","фев","мар","апр","май","юни","юли","авг","сеп","окт","ное","дек",""]
			},
			AM: null,
			PM: null,
			eras: [{"name":"след новата ера","start":null,"offset":0}],
			patterns: {
				d: "d.M.yyyy 'г.'",
				D: "dd MMMM yyyy 'г.'",
				t: "H:mm",
				T: "H:mm:ss",
				f: "dd MMMM yyyy 'г.' H:mm",
				F: "dd MMMM yyyy 'г.' H:mm:ss",
				M: "d MMMM",
				Y: "MMMM yyyy 'г.'"
			}
		}
	}
});

}( this ));
