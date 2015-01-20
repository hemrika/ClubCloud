/*
 * Globalize Culture en-JM
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

Globalize.addCultureInfo( "en-JM", "default", {
	name: "en-JM",
	englishName: "English (Jamaica)",
	nativeName: "English (Jamaica)",
	numberFormat: {
		currency: {
			pattern: ["-$n","$n"],
			symbol: "J$"
		}
	},
	calendars: {
		standard: {
			patterns: {
				d: "dd/MM/yyyy",
				D: "dd MMMM, yyyy",
				t: "HH:mm",
				T: "HH:mm:ss",
				f: "dd MMMM, yyyy HH:mm",
				F: "dd MMMM, yyyy HH:mm:ss",
				M: "d MMMM",
				Y: "MMMM, yyyy"
			}
		}
	}
});

}( this ));
