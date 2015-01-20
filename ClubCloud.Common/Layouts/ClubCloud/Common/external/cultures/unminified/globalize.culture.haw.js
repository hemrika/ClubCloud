/*
 * Globalize Culture haw
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

Globalize.addCultureInfo( "haw", "default", {
	name: "haw",
	englishName: "Hawaiian",
	nativeName: "Hawaiʻi",
	language: "haw",
	calendars: {
		standard: {
			days: {
				names: ["Lāpule","Pōʻakahi","Poʻalua","Poʻakolu","Poʻahā","Poʻalima","Poʻaono"],
				namesAbbr: ["Lp","P1","P2","P3","P4","P5","P6"],
				namesShort: ["Lp","P1","P2","P3","P4","P5","P6"]
			},
			months: {
				names: ["Ianuali","Pepeluali","Malaki","ʻApelila","Mei","Iune","Iulai","ʻAukake","Kepakemapa","ʻOkakopa","Nowemapa","Kekemapa",""],
				namesAbbr: ["Ian","Pep","Mal","ʻAp","Mei","Iun","Iul","ʻAuk","Kep","ʻOk","Now","Kek",""]
			},
			patterns: {
				D: "dddd, MMMM dd, yyyy",
				f: "dddd, MMMM dd, yyyy h:mm tt",
				F: "dddd, MMMM dd, yyyy h:mm:ss tt",
				M: "d MMMM",
				Y: "MMMM, yyyy"
			}
		}
	}
});

}( this ));
