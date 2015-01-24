String.prototype.contains = function (a) {
    return this.indexOf(a) != -1
};
jQuery.format = function jQueryFormat(f) {
    if (arguments.length <= 1) {
        return f
    }
    var d = arguments.length - 2;
    for (var e = 0; e <= d; ++e) {
        f = f.replace(new RegExp("\\{" + e + "\\}", "gi"), arguments[e + 1])
    }
    return f
};
jQuery.pad = function jQueryPad(f, d, e) {
    f = f.toString();
    if (arguments.length <= 2) {
        return f
    }
    while (f.length < d) {
        f = e.toString() + f
    }
    return f
};
jQuery.ajaxSetup({
    cache: false
});
(function (c) {
    var a = c.noop;
    if (c.browser.msie) {
        a = function (f) {
            var d = c(f).parent(".ui-dialog");
            var e = d.innerWidth();
            if (e) {
                d.css("width", e)
            }
        }
    }
    var b = c.ui.dialog.prototype._init;
    c.ui.dialog.prototype._init = function () {
        if (this.options.width == "auto") {
            var d = this.options.open;
            this.options.open = function () {
                a(this);
                if (d) {
                    d.apply(this)
                }
            }
        }
        if (c.browser.msie && this.options.hide == "drop") {
            this.options.hide = "fold"
        }
        return b.apply(this)
    }
})(jQuery);
jQuery.fn.center = function (b) {
    var a = {
        vertical: true,
        horizontal: true
    };
    var c = jQuery.extend(a, b);
    return this.each(function () {
        var n = jQuery(this);
        var d = n.width();
        var o = n.height();
        var p = parseInt(n.css("padding-top"));
        var e = parseInt(n.css("padding-bottom"));
        var f = parseInt(n.css("border-top-width"));
        var m = parseInt(n.css("border-bottom-width"));
        var i = (f + m) / 2;
        var k = (p + e) / 2;
        var j = n.parent().css("position");
        var h = (d / 2) * (-1);
        var l = ((o / 2) * (-1)) - k - i;
        var g = {
            position: "absolute"
        };
        if (c.vertical) {
            g.height = o;
            g.top = "50%";
            g.marginTop = l
        }
        if (c.horizontal) {
            g.width = d;
            g.left = "50%";
            g.marginLeft = h
        }
        if (j == "static") {
            n.parent().css("position", "relative")
        }
        n.css(g)
    })
};
(function (d) {
    var c = {
        outputMode: "label",
        cssClass: "error",
        scrollTo: false,
        modalErrorsClickable: true,
        defaultFieldName: "This field",
        elementSupport: ":text, :password, textarea, select, :radio, :checkbox",
        argToString: function (k) {
            return k.getDate ? (k.getMonth() + 1) + "/" + k.getDate() + "/" + k.getFullYear() : k
        }
    };
    d.validity = {
        settings: d.extend(c, {}),
        patterns: {
            integer: /^\d+$/,
            date: /^((0?\d)|(1[012]))\/([012]?\d|30|31)\/\d{1,4}$/,
            email: /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$/i,
            usd: /^\$?(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$/,
            url: /^(https?|ftp):\/\/(((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)+(\/(([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)*)*)?)?(\?((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|[\uE000-\uF8FF]|\/|\?)*)?(\#((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|\/|\?)*)?$/i,
            number: /^[+-]?(\d+(\.\d*)?|\.\d+)([Ee]\d+)?$/,
            zip: /^\d{5}(-\d{4})?$/,
            phone: /^[2-9]\d{2}-\d{3}-\d{4}$/,
            guid: /^(\{?([0-9a-fA-F]){8}-(([0-9a-fA-F]){4}-){3}([0-9a-fA-F]){12}\}?)$/,
            time12: /^[01]?\d:[0-5]\d?\s?[aApP]\.?[mM]\.?$/,
            time24: /^(20|21|22|23|[01]\d|\d)(([:][0-5]\d){1,2})$/,
            nonHtml: /^[^<>]*$/
        },
        messages: {
            require: "#{field} is required.",
            match: "#{field} is in an invalid format.",
            integer: "#{field} must be a positive, whole number.",
            date: "#{field} must be formatted as a date.",
            email: "#{field} must be formatted as an email.",
            usd: "#{field} must be formatted as a US Dollar amount.",
            url: "#{field} must be formatted as a URL.",
            number: "#{field} must be formatted as a number.",
            zip: "#{field} must be formatted as a zipcode ##### or #####-####.",
            phone: "#{field} must be formatted as a phone number ###-###-####.",
            guid: "#{field} must be formatted as a guid like {3F2504E0-4F89-11D3-9A0C-0305E82C3301}.",
            time24: "#{field} must be formatted as a 24 hour time: 23:00.",
            time12: "#{field} must be formatted as a 12 hour time: 12:00 AM/PM",
            lessThan: "#{field} must be less than #{max}.",
            lessThanOrEqualTo: "#{field} must be less than or equal to #{max}.",
            greaterThan: "#{field} must be greater than #{min}.",
            greaterThanOrEqualTo: "#{field} must be greater than or equal to #{min}.",
            range: "#{field} must be between #{min} and #{max}.",
            tooLong: "#{field} cannot be longer than #{max} characters.",
            tooShort: "#{field} cannot be shorter than #{min} characters.",
            nonHtml: "#{field} cannot contain HTML characters.",
            alphabet: "#{field} contains disallowed characters.",
            minCharClass: "#{field} cannot have more than #{min} #{charClass} characters.",
            maxCharClass: "#{field} cannot have less than #{min} #{charClass} characters.",
            equal: "Values don't match.",
            distinct: "A value was repeated.",
            sum: "Values don't add to #{sum}.",
            sumMax: "The sum of the values must be less than #{max}.",
            sumMin: "The sum of the values must be greater than #{min}.",
            radioChecked: "The selected value is not valid.",
            generic: "Invalid."
        },
        charClasses: {
            alphabetical: /\w/g,
            numeric: /\d/g,
            alphanumeric: /[A-Za-z0-9]/g,
            symbol: /[^A-Za-z0-9]/g
        },
        outputs: {},
        setup: function (k) {
            this.settings = d.extend(this.settings, k)
        },
        report: null,
        isValidating: function () {
            return !!this.report
        },
        start: function () {
            if (this.outputs[this.settings.outputMode] && this.outputs[this.settings.outputMode].start) {
                this.outputs[this.settings.outputMode].start()
            }
            this.report = {
                errors: 0,
                valid: true
            }
        },
        end: function () {
            var k = this.report || {
                errors: 0,
                valid: true
            };
            this.report = null;
            if (this.outputs[this.settings.outputMode] && this.outputs[this.settings.outputMode].end) {
                this.outputs[this.settings.outputMode].end(k)
            }
            return k
        },
        clear: function () {
            this.start();
            this.end()
        }
    };
    d.fn.extend({
        validity: function (k) {
            return this.each(function () {
                if (this.tagName.toLowerCase() == "form") {
                    var l = null;
                    if (typeof (k) == "string") {
                        l = function () {
                            d(k).require()
                        }
                    } else {
                        if (d.isFunction(k)) {
                            l = k
                        }
                    }
                    if (k) {
                        d(this).bind("submit", function () {
                            d.validity.start();
                            l();
                            return d.validity.end().valid
                        })
                    }
                }
            })
        },
        require: function (k) {
            return g(this, function (m) {
                var n = d(m).val();
                var l = n.length;
                return l
            }, k || d.validity.messages.require)
        },
        match: function (k, l) {
            if (!l) {
                l = d.validity.messages.match;
                if (typeof (k) === "string" && d.validity.messages[k]) {
                    l = d.validity.messages[k]
                }
            }
            if (typeof (k) == "string") {
                k = d.validity.patterns[k]
            }
            return g(this, d.isFunction(k) ? function (m) {
                return !m.value.length || k(m.value)
            } : function (m) {
                if (k.global) {
                    k.lastIndex = 0
                }
                return !m.value.length || k.test(m.value)
            }, l)
        },
        range: function (l, k, m) {
            return g(this, l.getTime && k.getTime ? function (n) {
                var o = new Date(n.value);
                return o >= new Date(l) && o <= new Date(k)
            } : l.substring && k.substring && Big ? function (o) {
                var p = new Big(o.value);
                return (p.greaterThanOrEqualTo(new Big(l)) && p.lessThanOrEqualTo(new Big(k)))
            } : function (o) {
                var n = parseFloat(o.value);
                return n >= l && n <= k
            }, m || i(d.validity.messages.range, {
                min: d.validity.settings.argToString(l),
                max: d.validity.settings.argToString(k)
            }))
        },
        greaterThan: function (k, l) {
            return g(this, k.getTime ? function (m) {
                return new Date(m.value) > k
            } : k.substring && Big ? function (m) {
                return new Big(m.value).greaterThan(new Big(k))
            } : function (m) {
                return parseFloat(m.value) > k
            }, l || i(d.validity.messages.greaterThan, {
                min: d.validity.settings.argToString(k)
            }))
        },
        greaterThanOrEqualTo: function (k, l) {
            return g(this, k.getTime ? function (m) {
                return new Date(m.value) >= k
            } : k.substring && Big ? function (m) {
                return new Big(m.value).greaterThanOrEqualTo(new Big(k))
            } : function (m) {
                return parseFloat(m.value) >= k
            }, l || i(d.validity.messages.greaterThanOrEqualTo, {
                min: d.validity.settings.argToString(k)
            }))
        },
        lessThan: function (k, l) {
            return g(this, k.getTime ? function (m) {
                return new Date(m.value) < k
            } : k.substring && Big ? function (m) {
                return new Big(m.value).lessThan(new Big(k))
            } : function (m) {
                return parseFloat(m.value) < k
            }, l || i(d.validity.messages.lessThan, {
                max: d.validity.settings.argToString(k)
            }))
        },
        lessThanOrEqualTo: function (k, l) {
            return g(this, k.getTime ? function (m) {
                return new Date(m.value) <= k
            } : k.substring && Big ? function (m) {
                return new Big(m.value).lessThanOrEqualTo(new Big(k))
            } : function (m) {
                return parseFloat(m.value) <= k
            }, l || i(d.validity.messages.lessThanOrEqualTo, {
                max: d.validity.settings.argToString(k)
            }))
        },
        maxLength: function (k, l) {
            return g(this, function (m) {
                return m.value.length <= k
            }, l || i(d.validity.messages.tooLong, {
                max: k
            }))
        },
        minLength: function (k, l) {
            return g(this, function (m) {
                return m.value.length >= k
            }, l || i(d.validity.messages.tooShort, {
                min: k
            }))
        },
        alphabet: function (l, m) {
            var k = [];
            return g(this, function (o) {
                for (var n = 0; n < o.value.length; ++n) {
                    if (l.indexOf(o.value.charAt(n)) == -1) {
                        k.push(o.value.charAt(n));
                        return false
                    }
                }
                return true
            }, m || i(d.validity.messages.alphabet, {
                chars: k.join(", ")
            }))
        },
        minCharClass: function (k, l, m) {
            if (typeof (k) == "string") {
                k = k.toLowerCase();
                if (d.validity.charClasses[k]) {
                    k = d.validity.charClasses[k]
                }
            }
            return g(this, function (n) {
                return (n.value.match(k) || []).length >= l
            }, m || i(d.validity.messages.minCharClass, {
                min: l,
                charClass: k
            }))
        },
        maxCharClass: function (l, k, m) {
            if (typeof (l) == "string") {
                l = l.toLowerCase();
                if (d.validity.charClasses[l]) {
                    l = d.validity.charClasses[l]
                }
            }
            return g(this, function (n) {
                return (n.value.match(l) || []).length <= k
            }, m || i(d.validity.messages.maxCharClass, {
                max: k,
                charClass: l
            }))
        },
        password: function (k, l) {
            k = d.extend({
                alphabet: null,
                minLength: 0,
                maxLength: 0,
                minSymbol: 0,
                minAlphabetical: 0,
                minNumeric: 0,
                minAlphaNumeric: 0
            }, k);
            if (k.alphabet) {
                this.alphabet(k.alphabet)
            }
            if (k.minLength) {
                this.minLength(k.minLength)
            }
            if (k.maxLength) {
                this.maxLength(k.maxLength)
            }
            if (k.minSymbol) {
                this.minCharClass("symbol", k.minSymbol)
            }
            if (k.minAlphabetical) {
                this.minCharClass("alphabetical", k.minAlphabetical)
            }
            if (k.minNumeric) {
                this.minCharClass("numeric", k.minNumeric)
            }
            if (k.minAlphanumeric) {
                this.minCharClass("alphanumeric", k.minAlphanumeric)
            }
            return this
        },
        nonHtml: function (k) {
            return g(this, function (l) {
                return d.validity.patterns.nonHtml.test(l.value)
            }, k || d.validity.messages.nonHtml)
        },
        equal: function (r, q) {
            var s = (this.reduction || this).filter(d.validity.settings.elementSupport),
                n = function (t) {
                    return t
                },
                m = d.validity.messages.equal;
            if (s.length) {
                if (d.isFunction(r)) {
                    n = r;
                    if (typeof (q) == "string") {
                        m = q
                    }
                } else {
                    if (typeof (r) == "string") {
                        m = r
                    }
                }
                var l = d.map(s, function (t) {
                    return n(t.value)
                }),
                    p = l[0],
                    k = true;
                for (var o in l) {
                    if (l[o] != p) {
                        k = false
                    }
                }
                if (!k) {
                    a(s, m);
                    this.reduction = d([])
                }
            }
            return this
        },
        distinct: function (r, q) {
            var s = (this.reduction || this).filter(d.validity.settings.elementSupport),
                n = function (u) {
                    return u
                },
                m = d.validity.messages.distinct,
                t = [],
                k = true;
            if (s.length) {
                if (d.isFunction(r)) {
                    n = r;
                    if (typeof (q) == "string") {
                        m = q
                    }
                } else {
                    if (typeof (r) == "string") {
                        m = r
                    }
                }
                var l = d.map(s, function (u) {
                    return n(u.value)
                });
                for (var p = 0; p < l.length; ++p) {
                    if (l[p].length) {
                        for (var o = 0; o < t.length; ++o) {
                            if (t[o] == l[p]) {
                                k = false
                            }
                        }
                        t.push(l[p])
                    }
                }
                if (!k) {
                    a(s, m);
                    this.reduction = d([])
                }
            }
            return this
        },
        sum: function (k, m) {
            var l = (this.reduction || this).filter(d.validity.settings.elementSupport);
            if (l.length && k != h(l)) {
                a(l, m || i(d.validity.messages.sum, {
                    sum: k
                }));
                this.reduction = d([])
            }
            return this
        },
        sumMax: function (k, m) {
            var l = (this.reduction || this).filter(d.validity.settings.elementSupport);
            if (l.length && k < h(l)) {
                a(l, m || i(d.validity.messages.sumMax, {
                    max: k
                }));
                this.reduction = d([])
            }
            return this
        },
        sumMin: function (k, m) {
            var l = (this.reduction || this).filter(d.validity.settings.elementSupport);
            if (l.length && k < h(l)) {
                a(l, m || i(d.validity.messages.sumMin, {
                    min: k
                }));
                this.reduction = d([])
            }
            return this
        },
        radioChecked: function (m, l) {
            var k = (this.reduction || this).filter(d.validity.settings.elementSupport);
            if (k.is(":radio") && k.find(":checked").val() != m) {
                a(k, l || d.validity.messages.radioChecked)
            }
        },
        radioNotChecked: function (m, l) {
            var k = (this.reduction || this).filter(d.validity.settings.elementSupport);
            if (k.is(":radio") && k.filter(":checked").val() == m) {
                a(k, l || d.validity.messages.radioChecked)
            }
        },
        checkboxChecked: function (l) {
            var k = (this.reduction || this).filter(d.validity.settings.elementSupport);
            if (k.is(":checkbox") && !k.is(":checked")) {
                a(k, l || d.validity.messages.radioChecked)
            }
        },
        assert: function (m, l) {
            var k = this.reduction || this;
            if (k.length) {
                if (d.isFunction(m)) {
                    return g(this, m, l || d.validity.messages.generic)
                } else {
                    if (!m) {
                        a(k, l || d.validity.messages.generic);
                        this.reduction = d([])
                    }
                }
            }
            return this
        }
    });

    function g(o, k, l) {
        var n = (o.reduction || o).filter(d.validity.settings.elementSupport),
            m = [];
        n.each(function () {
            if (k(this)) {
                m.push(this)
            } else {
                j(this, i(l, {
                    field: b(this)
                }))
            }
        });
        o.reduction = d(m);
        return o
    }

    function f() {
        if (d.validity.isValidating()) {
            d.validity.report.errors++;
            d.validity.report.valid = false
        }
    }

    function j(k, l) {
        f();
        if (d.validity.outputs[d.validity.settings.outputMode] && d.validity.outputs[d.validity.settings.outputMode].raise) {
            d.validity.outputs[d.validity.settings.outputMode].raise(d(k), l)
        }
    }

    function a(l, k) {
        f();
        if (d.validity.outputs[d.validity.settings.outputMode] && d.validity.outputs[d.validity.settings.outputMode].raiseAggregate) {
            d.validity.outputs[d.validity.settings.outputMode].raiseAggregate(l, k)
        }
    }

    function h(l) {
        var k = 0;
        l.each(function () {
            var m = parseFloat(this.value);
            k += isNaN(m) ? 0 : m
        });
        return k
    }

    function i(m, l) {
        for (var k in l) {
            m = m.replace("#{" + k + "}", l[k])
        }
        return e(m)
    }

    function b(o) {
        var l = d(o),
            m = d.validity.settings.defaultFieldName;
        if (l.attr("title").length) {
            m = l.attr("title")
        } else {
            if (/^([A-Z0-9][a-z]*)+$/.test(o.id)) {
                m = o.id.replace(/([A-Z0-9])[a-z]*/g, " $&")
            } else {
                if (/^[a-z0-9_]*$/.test(o.id)) {
                    var k = o.id.split("_");
                    for (var n = 0; n < k.length; ++n) {
                        k[n] = e(k[n])
                    }
                    m = k.join(" ")
                }
            }
        }
        return m
    }

    function e(k) {
        return k.substring ? k.substring(0, 1).toUpperCase() + k.substring(1, k.length) : k
    }
})(jQuery);
(function (a) {
    function b(c) {
        return c.attr("id").length ? c.attr("id") : c.attr("name")
    }
    a.validity.outputs.label = {
        start: function () {
            a("label." + a.validity.settings.cssClass).remove()
        },
        end: function (c) {
            if (!c.valid && a.validity.settings.scrollTo) {
                location.hash = a("label." + a.validity.settings.cssClass + ":eq(0)").attr("for")
            }
        },
        raise: function (e, c) {
            var d = "label." + a.validity.settings.cssClass + "[for='" + b(e) + "']";
            if (a(d).length) {
                a(d).text(c)
            } else {
                a("<label/>").attr("for", b(e)).addClass(a.validity.settings.cssClass).text(c).click(function () {
                    if (e.length) {
                        e[0].select()
                    }
                }).insertAfter(e)
            }
        },
        raiseAggregate: function (d, c) {
            if (d.length) {
                this.raise(a(d.get(d.length - 1)), c)
            }
        }
    }
})(jQuery);
(function (c) {
    var a = "validity-modal-msg",
        b = "body";
    c.validity.outputs.modal = {
        start: function () {
            c("." + a).remove()
        },
        end: function (d) {
            if (!d.valid && c.validity.settings.scrollTo) {
                location.hash = c("." + a + ":eq(0)").attr("id")
            }
        },
        raise: function (h, g) {
            if (h.length) {
                var f = h.offset(),
                    d = h.get(0),
                    e = {
                        left: parseInt(f.left + h.width() + 4, 10) + "px",
                        top: parseInt(f.top - 10, 10) + "px"
                    };
                c("<div/>").addClass(a).css(e).text(g).click(c.validity.settings.modalErrorsClickable ? function () {
                    c(this).remove()
                } : null).appendTo(b)
            }
        },
        raiseAggregate: function (e, d) {
            if (e.length) {
                this.raise(c(e.get(e.length - 1)), d)
            }
        }
    }
})(jQuery);
(function (f) {
    var b = ".validity-summary-container",
        h = "validity-erroneous",
        g = "WarningAttn",
        i = "." + h,
        e = "." + g,
        c = "!",
        a = "<li/>",
        d = [];
    f.validity.outputs.summary = {
        start: function () {
            f(i).removeClass(h);
            f(e).text("");
            f(e).removeClass(g);
            d = []
        },
        end: function (k) {
            f(b).hide().find("ul").html("");
            if (d.length) {
                for (var j = 0; j < d.length; ++j) {
                    f(a).text(d[j]).appendTo(b + " ul")
                }
                f(b).show();
                if (f.validity.settings.scrollTo) {
                    location.hash = f(i + ":eq(0)").attr("id")
                }
            }
        },
        raise: function (n, m) {
            d.push(m);
            n.addClass(h);
            var j = n.attr("rel");
            if (typeof j !== "undefined" && j !== false) {
                if (j.indexOf("|") > -1) {
                    var k = j.split("|");
                    var l = f("#" + k[0]).find("#" + k[1]);
                    l.html(c);
                    l.addClass(g)
                } else {
                    if (j != "") {
                        var l = f("#" + j);
                        l.html(c);
                        l.addClass(g)
                    }
                }
            }
        },
        raiseAggregate: function (k, j) {
            this.raise(k, j)
        },
        container: function () {
            document.write('<div class="validity-summary-container">The form didn\'t submit for the following reason(s):<ul></ul></div>')
        }
    }
})(jQuery);

function displayConfirmMessage(title, message, error, buttonObjects, postbackId) {
    if (buttonObjects.indexOf("|") > -1) {
        var buttons = {};
        var buttonNames = buttonObjects.split("|");
        buttons[buttonNames[0]] = function () {
            jQuery("#dialog-message").dialog("close");
            eval(jQuery(jQuery.format("#{0}", postbackId)).val())
        };
        buttons[buttonNames[1]] = function () {
            jQuery("#dialog-message").dialog("close")
        };
        buttonObjects = buttons
    }
    return displayMessage(title, message, error, 3, null, null, true, buttonObjects)
}

function displayMessage(e, d, b, c, a) {
    return displayMessage(e, d, b, c, null, null, false, a)
}

function displayMessage(k, o, i, h, l, a, f, n) {
    var e = "#dialog-message";
    var j = "auto";
    var c = 400;
    var b = "";
    if (l != null) {
        j = l
    }
    if (a != null && a > c) {
        c = a
    }
    switch (h) {
        case 1:
            b = "ui-icon-notice";
            break;
        case 2:
            b = "ui-icon-info";
            break;
        case 3:
            b = "ui-icon-help";
            break;
        case 4:
            b = "ui-icon-alert";
            break;
        default:
            b = "ui-icon-info";
            break
    }
    jQuery(e).dialog("destroy");
    jQuery(e).attr("title", k);
    var m = (i != null) ? jQuery.format("<p>Error description:{0}</p>", i.description) : "";
    if (b != "") {
        b = jQuery.format('<span class="ui-icon {0}" style="float:left; margin:0 7px 50px 0;"></span>', b)
    }
    var d = jQuery.format("<p>{0}{1}</p>{2}", b, o, m);
    jQuery(e).html(d);
    if (f) {
        jQuery(e).dialog({
            resizable: true,
            height: j,
            width: c,
            modal: true,
            buttons: n
        })
    } else {
        if (n == null) {
            jQuery(e).dialog({
                modal: true,
                height: j,
                width: c,
                buttons: {
                    Ok: function () {
                        jQuery(this).dialog("close")
                    }
                }
            })
        } else {
            if (n != "") {
                var g = {};
                g[n] = function () {
                    jQuery("#dialog-message").dialog("close")
                };
                jQuery(e).dialog({
                    modal: true,
                    height: j,
                    width: c,
                    buttons: g
                })
            } else {
                jQuery(e).dialog({
                    modal: true,
                    height: j,
                    width: c,
                    buttons: {
                        Ok: function () {
                            jQuery(this).dialog("close")
                        }
                    }
                })
            }
        }
    }
}

function getAbsolutePath() {
    var c = window.location;
    var a = c.pathname.substring(0, c.pathname.lastIndexOf("/") + 1);
    var b = c.href.substring(0, c.href.length - ((c.pathname + c.search + c.hash).length - a.length));
    b = b.replace("Popups/", "");
    return b
}

function JQControl(a, b) {
    if (a != null) {
        return jQuery(jQuery.format("{0}[id$={1}]", a, b))
    } else {
        return jQuery(jQuery.format("#{0}", b))
    }
}

function LogError(a, b) {
    LogError(a, b, "")
}

function LogError(b, e, a) {
    var d = "Unknown error";
    if (typeof (b) == "string" || typeof (b) == "String") {
        HandleLogging(4, b, null)
    } else {
        var c = {};
        c.appcode = a;
        c.message = (jQuery.browser.msie) ? b.description : b.message;
        c.url = (jQuery.browser.msie) ? "" : b.fileName;
        c.lineNumber = (jQuery.browser.msie) ? (b.number & 65535) : b.lineNumber;
        c.stackTrace = (typeof (b.stack) != "undefined") ? b.stack : "";
        c.name = b.name;
        if (typeof (e) != "undefined") {
            c.appendMessage = e
        } else {
            c.appendMessage = ""
        }
        HandleLogging(4, "", c)
    }
}

function LogDebug(a) {
    LogDebug(a, "")
}

function LogDebug(b, a) {
    HandleLogging(2, b, null, a)
}

function HandleLogging(g, i, b, h) {
    var d = {};
    d.Type = g;
    var e = "IE";
    if (jQuery.browser.opera) {
        e = "Opera"
    } else {
        if (jQuery.browser.safari) {
            e = "Safari"
        } else {
            if (jQuery.browser.mozilla) {
                e = "FireFox (mozilla)"
            }
        }
    }
    d.Browser = e;
    d.BrowserVersion = jQuery.browser.version;
    if (b != null) {
        d.AppCode = b.appcode;
        d.Message = b.message;
        d.Url = b.url;
        d.LineNumber = b.lineNumber;
        d.AppendMessage = b.appendMessage;
        d.StackTrace = b.stackTrace;
        d.Name = b.name
    } else {
        d.AppCode = h;
        d.Message = i;
        d.LineNumber = null;
        d.Url = "";
        d.AppendMessage = "";
        d.StackTrace = "";
        d.Name = ""
    }
    var f = {
        xbeException: d
    };
    var a = jQuery.format("{0}services/XbeService.asmx/JQueryLogging", getAbsolutePath());
    if (a.contains("rservices")) {
        a = a.replaces("rservices", "services")
    }
    var c = JSON.stringify(f);
    jQuery.ajax({
        type: "POST",
        url: a,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: c,
        async: false,
        success: HandlingLoggingSuccess
    })
}

function HandlingLoggingSuccess(a) {
    var b = a.d;
    return (b[0] == "Success")
};