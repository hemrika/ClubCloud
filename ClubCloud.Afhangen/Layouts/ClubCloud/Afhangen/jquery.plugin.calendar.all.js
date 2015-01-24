(function (d) {
    function f() {
        this.regional = {
            "": {
                invalidCalendar: "Calendar {0} not found",
                invalidDate: "Invalid {0} date",
                invalidMonth: "Invalid {0} month",
                invalidYear: "Invalid {0} year",
                differentCalendars: "Cannot mix {0} and {1} dates"
            }
        };
        this.local = this.regional[""];
        this.calendars = {};
        this._localCals = {}
    }
    d.extend(f.prototype, {
        instance: function (g, i) {
            g = (g || "gregorian").toLowerCase();
            i = i || "";
            var h = this._localCals[g + "-" + i];
            if (!h && this.calendars[g]) {
                h = new this.calendars[g](i);
                this._localCals[g + "-" + i] = h
            }
            if (!h) {
                throw (this.local.invalidCalendar || this.regional[""].invalidCalendar).replace(/\{0\}/, g)
            }
            return h
        },
        newDate: function (h, j, g, i, k) {
            i = (h != null && h.year ? h.calendar() : (typeof i == "string" ? this.instance(i, k) : i)) || this.instance();
            return i.newDate(h, j, g)
        }
    });

    function b(j, h, i, g) {
        this._calendar = j;
        this._year = h;
        this._month = i;
        this._day = g;
        if (this._calendar._validateLevel == 0 && !this._calendar.isValid(this._year, this._month, this._day)) {
            throw (d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate).replace(/\{0\}/, this._calendar.local.name)
        }
    }

    function e(h, g) {
        h = "" + h;
        return "000000".substring(0, g - h.length) + h
    }
    d.extend(b.prototype, {
        newDate: function (h, i, g) {
            return this._calendar.newDate((h == null ? this : h), i, g)
        },
        year: function (g) {
            return (arguments.length == 0 ? this._year : this.set(g, "y"))
        },
        month: function (g) {
            return (arguments.length == 0 ? this._month : this.set(g, "m"))
        },
        day: function (g) {
            return (arguments.length == 0 ? this._day : this.set(g, "d"))
        },
        date: function (h, i, g) {
            if (!this._calendar.isValid(h, i, g)) {
                throw (d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate).replace(/\{0\}/, this._calendar.local.name)
            }
            this._year = h;
            this._month = i;
            this._day = g;
            return this
        },
        leapYear: function () {
            return this._calendar.leapYear(this)
        },
        epoch: function () {
            return this._calendar.epoch(this)
        },
        formatYear: function () {
            return this._calendar.formatYear(this)
        },
        monthOfYear: function () {
            return this._calendar.monthOfYear(this)
        },
        weekOfYear: function () {
            return this._calendar.weekOfYear(this)
        },
        daysInYear: function () {
            return this._calendar.daysInYear(this)
        },
        dayOfYear: function () {
            return this._calendar.dayOfYear(this)
        },
        daysInMonth: function () {
            return this._calendar.daysInMonth(this)
        },
        dayOfWeek: function () {
            return this._calendar.dayOfWeek(this)
        },
        weekDay: function () {
            return this._calendar.weekDay(this)
        },
        extraInfo: function () {
            return this._calendar.extraInfo(this)
        },
        add: function (h, g) {
            return this._calendar.add(this, h, g)
        },
        set: function (g, h) {
            return this._calendar.set(this, g, h)
        },
        compareTo: function (g) {
            if (this._calendar.name != g._calendar.name) {
                throw (d.calendars.local.differentCalendars || d.calendars.regional[""].differentCalendars).replace(/\{0\}/, this._calendar.local.name).replace(/\{1\}/, g._calendar.local.name)
            }
            var h = (this._year != g._year ? this._year - g._year : this._month != g._month ? this.monthOfYear() - g.monthOfYear() : this._day - g._day);
            return (h == 0 ? 0 : (h < 0 ? -1 : +1))
        },
        calendar: function () {
            return this._calendar
        },
        toJD: function () {
            return this._calendar.toJD(this)
        },
        fromJD: function (g) {
            return this._calendar.fromJD(g)
        },
        toJSDate: function () {
            return this._calendar.toJSDate(this)
        },
        fromJSDate: function (g) {
            return this._calendar.fromJSDate(g)
        },
        toString: function () {
            return (this.year() < 0 ? "-" : "") + e(Math.abs(this.year()), 4) + "-" + e(this.month(), 2) + "-" + e(this.day(), 2)
        }
    });

    function a() {
        this.shortYearCutoff = "+10"
    }
    d.extend(a.prototype, {
        _validateLevel: 0,
        newDate: function (h, i, g) {
            if (h == null) {
                return this.today()
            }
            if (h.year) {
                this._validate(h, i, g, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
                g = h.day();
                i = h.month();
                h = h.year()
            }
            return new b(this, h, i, g)
        },
        today: function () {
            return this.fromJSDate(new Date())
        },
        epoch: function (h) {
            var g = this._validate(h, this.minMonth, this.minDay, d.calendars.local.invalidYear || d.calendars.regional[""].invalidYear);
            return (g.year() < 0 ? this.local.epochs[0] : this.local.epochs[1])
        },
        formatYear: function (h) {
            var g = this._validate(h, this.minMonth, this.minDay, d.calendars.local.invalidYear || d.calendars.regional[""].invalidYear);
            return (g.year() < 0 ? "-" : "") + e(Math.abs(g.year()), 4)
        },
        monthsInYear: function (g) {
            this._validate(g, this.minMonth, this.minDay, d.calendars.local.invalidYear || d.calendars.regional[""].invalidYear);
            return 12
        },
        monthOfYear: function (h, i) {
            var g = this._validate(h, i, this.minDay, d.calendars.local.invalidMonth || d.calendars.regional[""].invalidMonth);
            return (g.month() + this.monthsInYear(g) - this.firstMonth) % this.monthsInYear(g) + this.minMonth
        },
        fromMonthOfYear: function (i, h) {
            var g = (h + this.firstMonth - 2 * this.minMonth) % this.monthsInYear(i) + this.minMonth;
            this._validate(i, g, this.minDay, d.calendars.local.invalidMonth || d.calendars.regional[""].invalidMonth);
            return g
        },
        daysInYear: function (h) {
            var g = this._validate(h, this.minMonth, this.minDay, d.calendars.local.invalidYear || d.calendars.regional[""].invalidYear);
            return (this.leapYear(g) ? 366 : 365)
        },
        dayOfYear: function (i, j, g) {
            var h = this._validate(i, j, g, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
            return h.toJD() - this.newDate(h.year(), this.fromMonthOfYear(h.year(), this.minMonth), this.minDay).toJD() + 1
        },
        daysInWeek: function () {
            return 7
        },
        dayOfWeek: function (i, j, g) {
            var h = this._validate(i, j, g, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
            return (Math.floor(this.toJD(h)) + 2) % this.daysInWeek()
        },
        extraInfo: function (h, i, g) {
            this._validate(h, i, g, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
            return {}
        },
        add: function (g, i, h) {
            this._validate(g, this.minMonth, this.minDay, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
            return this._correctAdd(g, this._add(g, i, h), i, h)
        },
        _add: function (h, j, n) {
            this._validateLevel++;
            if (n == "d" || n == "w") {
                var p = h.toJD() + j * (n == "w" ? this.daysInWeek() : 1);
                var l = h.calendar().fromJD(p);
                this._validateLevel--;
                return [l.year(), l.month(), l.day()]
            }
            try {
                var o = h.year() + (n == "y" ? j : 0);
                var i = h.monthOfYear() + (n == "m" ? j : 0);
                var l = h.day();
                var q = function (r) {
                    while (i < r.minMonth) {
                        o--;
                        i += r.monthsInYear(o)
                    }
                    var m = r.monthsInYear(o);
                    while (i > m - 1 + r.minMonth) {
                        o++;
                        i -= m;
                        m = r.monthsInYear(o)
                    }
                };
                if (n == "y") {
                    if (h.month() != this.fromMonthOfYear(o, i)) {
                        i = this.newDate(o, h.month(), this.minDay).monthOfYear()
                    }
                    i = Math.min(i, this.monthsInYear(o));
                    l = Math.min(l, this.daysInMonth(o, this.fromMonthOfYear(o, i)))
                } else {
                    if (n == "m") {
                        q(this);
                        l = Math.min(l, this.daysInMonth(o, this.fromMonthOfYear(o, i)))
                    }
                }
                var g = [o, this.fromMonthOfYear(o, i), l];
                this._validateLevel--;
                return g
            } catch (k) {
                this._validateLevel--;
                throw k
            }
        },
        _correctAdd: function (i, j, l, k) {
            if (!this.hasYearZero && (k == "y" || k == "m")) {
                if (j[0] == 0 || (i.year() > 0) != (j[0] > 0)) {
                    var g = {
                        y: [1, 1, "y"],
                        m: [1, this.monthsInYear(-1), "m"],
                        w: [this.daysInWeek(), this.daysInYear(-1), "d"],
                        d: [1, this.daysInYear(-1), "d"]
                    }[k];
                    var h = (l < 0 ? -1 : +1);
                    j = this._add(i, l * g[0] + h * g[1], g[2])
                }
            }
            return i.date(j[0], j[1], j[2])
        },
        set: function (h, i, k) {
            this._validate(h, this.minMonth, this.minDay, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
            var l = (k == "y" ? i : h.year());
            var g = (k == "m" ? i : h.month());
            var j = (k == "d" ? i : h.day());
            if (k == "y" || k == "m") {
                j = Math.min(j, this.daysInMonth(l, g))
            }
            return h.date(l, g, j)
        },
        isValid: function (i, k, g) {
            this._validateLevel++;
            var j = (this.hasYearZero || i != 0);
            if (j) {
                var h = this.newDate(i, k, this.minDay);
                j = (k >= this.minMonth && k - this.minMonth < this.monthsInYear(h)) && (g >= this.minDay && g - this.minDay < this.daysInMonth(h))
            }
            this._validateLevel--;
            return j
        },
        toJSDate: function (i, j, g) {
            var h = this._validate(i, j, g, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
            return d.calendars.instance().fromJD(this.toJD(h)).toJSDate()
        },
        fromJSDate: function (g) {
            return this.fromJD(d.calendars.instance().fromJSDate(g).toJD())
        },
        _validate: function (j, l, g, i) {
            if (j.year) {
                if (this._validateLevel == 0 && this.name != j.calendar().name) {
                    throw (d.calendars.local.differentCalendars || d.calendars.regional[""].differentCalendars).replace(/\{0\}/, this.local.name).replace(/\{1\}/, j.calendar().local.name)
                }
                return j
            }
            try {
                this._validateLevel++;
                if (this._validateLevel == 1 && !this.isValid(j, l, g)) {
                    throw i.replace(/\{0\}/, this.local.name)
                }
                var h = this.newDate(j, l, g);
                this._validateLevel--;
                return h
            } catch (k) {
                this._validateLevel--;
                throw k
            }
        }
    });

    function c(g) {
        this.local = this.regional[g || ""] || this.regional[""]
    }
    c.prototype = new a;
    d.extend(c.prototype, {
        name: "Gregorian",
        jdEpoch: 1721425.5,
        daysPerMonth: [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31],
        hasYearZero: false,
        minMonth: 1,
        firstMonth: 1,
        minDay: 1,
        regional: {
            "": {
                name: "Gregorian",
                epochs: ["BCE", "CE"],
                monthNames: ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
                monthNamesShort: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
                dayNames: ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"],
                dayNamesShort: ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"],
                dayNamesMin: ["Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"],
                dateFormat: "mm/dd/yyyy",
                firstDay: 0,
                isRTL: false
            }
        },
        leapYear: function (h) {
            var g = this._validate(h, this.minMonth, this.minDay, d.calendars.local.invalidYear || d.calendars.regional[""].invalidYear);
            var h = g.year() + (g.year() < 0 ? 1 : 0);
            return h % 4 == 0 && (h % 100 != 0 || h % 400 == 0)
        },
        weekOfYear: function (h, i, g) {
            var j = this.newDate(h, i, g);
            j.add(4 - (j.dayOfWeek() || 7), "d");
            return Math.floor((j.dayOfYear() - 1) / 7) + 1
        },
        daysInMonth: function (h, i) {
            var g = this._validate(h, i, this.minDay, d.calendars.local.invalidMonth || d.calendars.regional[""].invalidMonth);
            return this.daysPerMonth[g.month() - 1] + (g.month() == 2 && this.leapYear(g.year()) ? 1 : 0)
        },
        weekDay: function (h, i, g) {
            return (this.dayOfWeek(h, i, g) || 7) < 6
        },
        toJD: function (k, l, i) {
            var j = this._validate(k, l, i, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
            k = j.year();
            l = j.month();
            i = j.day();
            if (k < 0) {
                k++
            }
            if (l <= 2) {
                l += 12;
                k--
            }
            var h = Math.floor(k / 100);
            var g;
            if (k < 1582) {
                g = 0
            } else {
                if (k > 1582) {
                    g = 2 - h + Math.floor(h / 4)
                } else {
                    if (l < 10) {
                        g = 0
                    } else {
                        if (l > 10) {
                            g = 2 - h + Math.floor(h / 4)
                        } else {
                            if (i < 5) {
                                g = 0
                            } else {
                                if (i >= 15) {
                                    g = 2 - h + Math.floor(h / 4)
                                } else {
                                    return -1
                                }
                            }
                        }
                    }
                }
            }
            return Math.floor(365.25 * (k + 4716)) + Math.floor(30.6001 * (l + 1)) + i + g - 1524.5
        },
        fromJD: function (o) {
            var l = Math.floor(o + 0.5);
            var p = Math.floor((l - 1867216.25) / 36524.25);
            p = l + 1 + p - Math.floor(p / 4);
            var n = p + 1524;
            var k = Math.floor((n - 122.1) / 365.25);
            var i = Math.floor(365.25 * k);
            var h = Math.floor((n - i) / 30.6001);
            var m = n - i - Math.floor(h * 30.6001);
            var g = h - (h > 13.5 ? 13 : 1);
            var j = k - (g > 2.5 ? 4716 : 4715);
            if (j <= 0) {
                j--
            }
            return this.newDate(j, g, m)
        },
        toJSDate: function (j, k, h) {
            var i = this._validate(j, k, h, d.calendars.local.invalidDate || d.calendars.regional[""].invalidDate);
            var g = new Date(i.year(), i.month() - 1, i.day());
            g.setHours(0);
            g.setMinutes(0);
            g.setSeconds(0);
            g.setMilliseconds(0);
            g.setHours(g.getHours() > 12 ? g.getHours() + 2 : 0);
            return g
        },
        fromJSDate: function (g) {
            return this.newDate(g.getFullYear(), g.getMonth() + 1, g.getDate())
        }
    });
    d.calendars = new f();
    d.calendars.cdate = b;
    d.calendars.baseCalendar = a;
    d.calendars.calendars.gregorian = c
})(jQuery);
(function (a) {
    a.extend(a.calendars.regional[""], {
        invalidArguments: "Invalid arguments",
        invalidFormat: "Cannot format a date from another calendar",
        missingNumberAt: "Missing number at position {0}",
        unknownNameAt: "Unknown name at position {0}",
        unexpectedLiteralAt: "Unexpected literal at position {0}",
        unexpectedText: "Additional text found at end"
    });
    a.calendars.local = a.calendars.regional[""];
    a.extend(a.calendars.cdate.prototype, {
        formatDate: function (b) {
            return this._calendar.formatDate(b || "", this)
        }
    });
    a.extend(a.calendars.baseCalendar.prototype, {
        UNIX_EPOCH: a.calendars.instance().newDate(1970, 1, 1).toJD(),
        SECS_PER_DAY: 24 * 60 * 60,
        TICKS_EPOCH: a.calendars.instance().jdEpoch,
        TICKS_PER_DAY: 24 * 60 * 60 * 10000000,
        ATOM: "yyyy-mm-dd",
        COOKIE: "D, dd M yyyy",
        FULL: "DD, MM d, yyyy",
        ISO_8601: "yyyy-mm-dd",
        JULIAN: "J",
        RFC_822: "D, d M yy",
        RFC_850: "DD, dd-M-yy",
        RFC_1036: "D, d M yy",
        RFC_1123: "D, d M yyyy",
        RFC_2822: "D, d M yyyy",
        RSS: "D, d M yy",
        TICKS: "!",
        TIMESTAMP: "@",
        W3C: "yyyy-mm-dd",
        formatDate: function (m, f, g) {
            if (typeof m != "string") {
                g = f;
                f = m;
                m = ""
            }
            if (!f) {
                return ""
            }
            if (f.calendar() != this) {
                throw a.calendars.local.invalidFormat || a.calendars.regional[""].invalidFormat
            }
            m = m || this.local.dateFormat;
            g = g || {};
            var o = g.dayNamesShort || this.local.dayNamesShort;
            var c = g.dayNames || this.local.dayNames;
            var k = g.monthNamesShort || this.local.monthNamesShort;
            var h = g.monthNames || this.local.monthNames;
            var d = g.calculateWeek || this.local.calculateWeek;
            var i = function (p, q) {
                var r = 1;
                while (n + r < m.length && m.charAt(n + r) == p) {
                    r++
                }
                n += r - 1;
                return Math.floor(r / (q || 1)) > 1
            };
            var b = function (r, t, p, s) {
                var q = "" + t;
                if (i(r, s)) {
                    while (q.length < p) {
                        q = "0" + q
                    }
                }
                return q
            };
            var j = function (p, r, q, s) {
                return (i(p) ? s[r] : q[r])
            };
            var e = "";
            var l = false;
            for (var n = 0; n < m.length; n++) {
                if (l) {
                    if (m.charAt(n) == "'" && !i("'")) {
                        l = false
                    } else {
                        e += m.charAt(n)
                    }
                } else {
                    switch (m.charAt(n)) {
                        case "d":
                            e += b("d", f.day(), 2);
                            break;
                        case "D":
                            e += j("D", f.dayOfWeek(), o, c);
                            break;
                        case "o":
                            e += b("o", f.dayOfYear(), 3);
                            break;
                        case "w":
                            e += b("w", f.weekOfYear(), 2);
                            break;
                        case "m":
                            e += b("m", f.month(), 2);
                            break;
                        case "M":
                            e += j("M", f.month() - this.minMonth, k, h);
                            break;
                        case "y":
                            e += (i("y", 2) ? f.year() : (f.year() % 100 < 10 ? "0" : "") + f.year() % 100);
                            break;
                        case "Y":
                            i("Y", 2);
                            e += f.formatYear();
                            break;
                        case "J":
                            e += f.toJD();
                            break;
                        case "@":
                            e += (f.toJD() - this.UNIX_EPOCH) * this.SECS_PER_DAY;
                            break;
                        case "!":
                            e += (f.toJD() - this.TICKS_EPOCH) * this.TICKS_PER_DAY;
                            break;
                        case "'":
                            if (i("'")) {
                                e += "'"
                            } else {
                                l = true
                            }
                            break;
                        default:
                            e += m.charAt(n)
                    }
                }
            }
            return e
        },
        parseDate: function (r, l, u) {
            if (l == null) {
                throw a.calendars.local.invalidArguments || a.calendars.regional[""].invalidArguments
            }
            l = (typeof l == "object" ? l.toString() : l + "");
            if (l == "") {
                return null
            }
            r = r || this.local.dateFormat;
            u = u || {};
            var c = u.shortYearCutoff || this.shortYearCutoff;
            c = (typeof c != "string" ? c : this.today().year() % 100 + parseInt(c, 10));
            var k = u.dayNamesShort || this.local.dayNamesShort;
            var v = u.dayNames || this.local.dayNames;
            var b = u.monthNamesShort || this.local.monthNamesShort;
            var e = u.monthNames || this.local.monthNames;
            var x = -1;
            var g = -1;
            var w = -1;
            var p = -1;
            var i = -1;
            var t = false;
            var o = false;
            var f = function (z, A) {
                var B = 1;
                while (d + B < r.length && r.charAt(d + B) == z) {
                    B++
                }
                d += B - 1;
                return Math.floor(B / (A || 1)) > 1
            };
            var y = function (B, D) {
                var z = f(B, D);
                var C = [2, 3, z ? 4 : 2, z ? 4 : 2, 10, 11, 20]["oyYJ@!".indexOf(B) + 1];
                var E = new RegExp("^-?\\d{1," + C + "}");
                var A = l.substring(q).match(E);
                if (!A) {
                    throw (a.calendars.local.missingNumberAt || a.calendars.regional[""].missingNumberAt).replace(/\{0\}/, q)
                }
                q += A[0].length;
                return parseInt(A[0], 10)
            };
            var j = this;
            var h = function (z, B, E, C) {
                var D = (f(z, C) ? E : B);
                for (var A = 0; A < D.length; A++) {
                    if (l.substr(q, D[A].length) == D[A]) {
                        q += D[A].length;
                        return A + j.minMonth
                    }
                }
                throw (a.calendars.local.unknownNameAt || a.calendars.regional[""].unknownNameAt).replace(/\{0\}/, q)
            };
            var n = function () {
                if (l.charAt(q) != r.charAt(d)) {
                    throw (a.calendars.local.unexpectedLiteralAt || a.calendars.regional[""].unexpectedLiteralAt).replace(/\{0\}/, q)
                }
                q++
            };
            var q = 0;
            for (var d = 0; d < r.length; d++) {
                if (o) {
                    if (r.charAt(d) == "'" && !f("'")) {
                        o = false
                    } else {
                        n()
                    }
                } else {
                    switch (r.charAt(d)) {
                        case "d":
                            p = y("d");
                            break;
                        case "D":
                            h("D", k, v);
                            break;
                        case "o":
                            i = y("o");
                            break;
                        case "w":
                            y("w");
                            break;
                        case "m":
                            w = y("m");
                            break;
                        case "M":
                            w = h("M", b, e);
                            break;
                        case "y":
                            var s = d;
                            t = !f("y", 2);
                            d = s;
                            g = y("y", 2);
                            break;
                        case "Y":
                            g = y("Y", 2);
                            break;
                        case "J":
                            x = y("J") + 0.5;
                            if (l.charAt(q) == ".") {
                                q++;
                                y("J")
                            }
                            break;
                        case "@":
                            x = y("@") / this.SECS_PER_DAY + this.UNIX_EPOCH;
                            break;
                        case "!":
                            x = y("!") / this.TICKS_PER_DAY + this.TICKS_EPOCH;
                            break;
                        case "*":
                            q = l.length;
                            break;
                        case "'":
                            if (f("'")) {
                                n()
                            } else {
                                o = true
                            }
                            break;
                        default:
                            n()
                    }
                }
            }
            if (q < l.length) {
                throw a.calendars.local.unexpectedText || a.calendars.regional[""].unexpectedText
            }
            if (g == -1) {
                g = this.today().year()
            } else {
                if (g < 100 && t) {
                    g += (c == -1 ? 1900 : this.today().year() - this.today().year() % 100 - (g <= c ? 0 : 100))
                }
            }
            if (i > -1) {
                w = 1;
                p = i;
                for (var m = this.daysInMonth(g, w) ; p > m; m = this.daysInMonth(g, w)) {
                    w++;
                    p -= m
                }
            }
            return (x > -1 ? this.fromJD(x) : this.newDate(g, w, p))
        },
        determineDate: function (d, h, c, b, f) {
            if (c && typeof c != "object") {
                f = b;
                b = c;
                c = null
            }
            if (typeof b != "string") {
                f = b;
                b = ""
            }
            var g = this;
            var e = function (m) {
                try {
                    return g.parseDate(b, m, f)
                } catch (l) { }
                m = m.toLowerCase();
                var i = (m.match(/^c/) && c ? c.newDate() : null) || g.today();
                var k = /([+-]?[0-9]+)\s*(d|w|m|y)?/g;
                var j = k.exec(m);
                while (j) {
                    i.add(parseInt(j[1], 10), j[2] || "d");
                    j = k.exec(m)
                }
                return i
            };
            h = (h ? h.newDate() : null);
            d = (d == null ? h : (typeof d == "string" ? e(d) : (typeof d == "number" ? (isNaN(d) || d == Infinity || d == -Infinity ? h : g.today().add(d, "d")) : g.newDate(d))));
            return d
        }
    })
})(jQuery);
(function (c) {
    function b() {
        this._defaults = {
            calendar: c.calendars.instance(),
            pickerClass: "",
            showOnFocus: true,
            showTrigger: null,
            showAnim: "show",
            showOptions: {},
            showSpeed: "normal",
            popupContainer: null,
            alignment: "bottom",
            fixedWeeks: false,
            firstDay: null,
            calculateWeek: null,
            monthsToShow: 1,
            monthsOffset: 0,
            monthsToStep: 1,
            monthsToJump: 12,
            useMouseWheel: true,
            changeMonth: true,
            yearRange: "+0:+3",
            showOtherMonths: false,
            selectOtherMonths: false,
            defaultDate: null,
            selectDefaultDate: false,
            minDate: null,
            maxDate: null,
            dateFormat: null,
            autoSize: false,
            rangeSelect: false,
            rangeSeparator: " - ",
            multiSelect: 0,
            multiSeparator: ",",
            onDate: null,
            onShow: null,
            onChangeMonthYear: null,
            onSelect: null,
            onClose: null,
            altField: null,
            altFormat: null,
            constrainInput: true,
            commandsAsDateFormat: false,
            commands: this.commands,
            isTripSummary: false,
            isTripModify: false,
            isCalendarDisplayed: false,
            isNightsDropdownDisplayed: false,
            isHighlightWeekendsAndHolidays: false,
            weekEndDefinition: 0
        };
        this.regional = {
            "": {
                renderer: this.defaultRenderer,
                prevText: "&lt;Prev",
                prevStatus: "Show the previous month",
                prevJumpText: "&lt;&lt;",
                prevJumpStatus: "Show the previous year",
                nextText: "Next&gt;",
                nextStatus: "Show the next month",
                nextJumpText: "&gt;&gt;",
                nextJumpStatus: "Show the next year",
                currentText: "Current",
                currentStatus: "Show the current month",
                todayText: "Today",
                todayStatus: "Show today's month",
                clearText: "Clear",
                clearStatus: "Clear all the dates",
                closeText: "Close",
                closeStatus: "Close the datepicker",
                yearStatus: "Change the year",
                monthStatus: "Change the month",
                weekText: "Wk",
                weekStatus: "Week of the year",
                dayStatus: "DD, M d, yyyy",
                defaultStatus: "Select a date",
                isRTL: false
            }
        };
        c.extend(this._defaults, this.regional[""]);
        this._disabled = []
    }
    c.extend(b.prototype, {
        dataName: "calendarsPicker",
        markerClass: "hasCalendarsPicker",
        _popupClass: "calendars-popup",
        _triggerClass: "calendars-trigger",
        _disableClass: "calendars-disable",
        _coverClass: "calendars-cover",
        _monthYearClass: "calendars-month-year",
        _curMonthClass: "calendars-month-",
        _anyYearClass: "calendars-any-year",
        _curDoWClass: "calendars-dow-",
        commands: {
            prev: {
                text: "prevText",
                status: "prevStatus",
                keystroke: {
                    keyCode: 33
                },
                enabled: function (f) {
                    var e = f.curMinDate();
                    var d = (!e || f.drawDate.newDate().add(1 - f.get("monthsToStep") - f.get("monthsOffset"), "m").day(f.get("calendar").minDay).add(-1, "d").compareTo(e) != -1);
                    if (f.inline) {
                        if (typeof (_drawMonthsInDisplay) != "undefined" && e.year() == f.drawDate.year()) {
                            d = (jQuery.inArray(e.month(), _drawMonthsInDisplay) == -1)
                        }
                    }
                    return d
                },
                date: function (d) {
                    return d.drawDate.newDate().add(-d.get("monthsToStep") - d.get("monthsOffset"), "m").day(d.get("calendar").minDay)
                },
                action: function (d) {
                    c.calendars.picker.changeMonth(this, -d.get("monthsToStep"))
                }
            },
            prevJump: {
                text: "prevJumpText",
                status: "prevJumpStatus",
                keystroke: {
                    keyCode: 33,
                    ctrlKey: true
                },
                enabled: function (e) {
                    var d = e.curMinDate();
                    return (!d || e.drawDate.newDate().add(1 - e.get("monthsToJump") - e.get("monthsOffset"), "m").day(e.get("calendar").minDay).add(-1, "d").compareTo(d) != -1)
                },
                date: function (d) {
                    return d.drawDate.newDate().add(-d.get("monthsToJump") - d.get("monthsOffset"), "m").day(d.get("calendar").minDay)
                },
                action: function (d) {
                    c.calendars.picker.changeMonth(this, -d.get("monthsToJump"))
                }
            },
            next: {
                text: "nextText",
                status: "nextStatus",
                keystroke: {
                    keyCode: 34
                },
                enabled: function (d) {
                    var e = d.get("maxDate");
                    return (!e || d.drawDate.newDate().add(d.get("monthsToStep") - d.get("monthsOffset"), "m").day(d.get("calendar").minDay).compareTo(e) != +1)
                },
                date: function (d) {
                    return d.drawDate.newDate().add(d.get("monthsToStep") - d.get("monthsOffset"), "m").day(d.get("calendar").minDay)
                },
                action: function (d) {
                    c.calendars.picker.changeMonth(this, d.get("monthsToStep"))
                }
            },
            nextJump: {
                text: "nextJumpText",
                status: "nextJumpStatus",
                keystroke: {
                    keyCode: 34,
                    ctrlKey: true
                },
                enabled: function (d) {
                    var e = d.get("maxDate");
                    return (!e || d.drawDate.newDate().add(d.get("monthsToJump") - d.get("monthsOffset"), "m").day(d.get("calendar").minDay).compareTo(e) != +1)
                },
                date: function (d) {
                    return d.drawDate.newDate().add(d.get("monthsToJump") - d.get("monthsOffset"), "m").day(d.get("calendar").minDay)
                },
                action: function (d) {
                    c.calendars.picker.changeMonth(this, d.get("monthsToJump"))
                }
            },
            current: {
                text: "currentText",
                status: "currentStatus",
                keystroke: {
                    keyCode: 36,
                    ctrlKey: true
                },
                enabled: function (f) {
                    var e = f.curMinDate();
                    var g = f.get("maxDate");
                    var d = f.selectedDates[0] || f.get("calendar").today();
                    return (!e || d.compareTo(e) != -1) && (!g || d.compareTo(g) != +1)
                },
                date: function (d) {
                    return d.selectedDates[0] || d.get("calendar").today()
                },
                action: function (e) {
                    var d = e.selectedDates[0] || e.get("calendar").today();
                    c.calendars.picker.showMonth(this, d.year(), d.month())
                }
            },
            today: {
                text: "todayText",
                status: "todayStatus",
                keystroke: {
                    keyCode: 36,
                    ctrlKey: true
                },
                enabled: function (e) {
                    var d = e.curMinDate();
                    var f = e.get("maxDate");
                    return (!d || e.get("calendar").today().compareTo(d) != -1) && (!f || e.get("calendar").today().compareTo(f) != +1)
                },
                date: function (d) {
                    return d.get("calendar").today()
                },
                action: function (d) {
                    c.calendars.picker.showMonth(this)
                }
            },
            clear: {
                text: "clearText",
                status: "clearStatus",
                keystroke: {
                    keyCode: 35,
                    ctrlKey: true
                },
                enabled: function (d) {
                    return true
                },
                date: function (d) {
                    return null
                },
                action: function (d) {
                    c.calendars.picker.clear(this)
                }
            },
            close: {
                text: "closeText",
                status: "closeStatus",
                keystroke: {
                    keyCode: 27
                },
                enabled: function (d) {
                    return true
                },
                date: function (d) {
                    return null
                },
                action: function (d) {
                    c.calendars.picker.hide(this)
                }
            },
            prevWeek: {
                text: "prevWeekText",
                status: "prevWeekStatus",
                keystroke: {
                    keyCode: 38,
                    ctrlKey: true
                },
                enabled: function (e) {
                    var d = e.curMinDate();
                    return (!d || e.drawDate.newDate().add(-e.get("calendar").daysInWeek(), "d").compareTo(d) != -1)
                },
                date: function (d) {
                    return d.drawDate.newDate().add(-d.get("calendar").daysInWeek(), "d")
                },
                action: function (d) {
                    c.calendars.picker.changeDay(this, -d.get("calendar").daysInWeek())
                }
            },
            prevDay: {
                text: "prevDayText",
                status: "prevDayStatus",
                keystroke: {
                    keyCode: 37,
                    ctrlKey: true
                },
                enabled: function (e) {
                    var d = e.curMinDate();
                    return (!d || e.drawDate.newDate().add(-1, "d").compareTo(d) != -1)
                },
                date: function (d) {
                    return d.drawDate.newDate().add(-1, "d")
                },
                action: function (d) {
                    c.calendars.picker.changeDay(this, -1)
                }
            },
            nextDay: {
                text: "nextDayText",
                status: "nextDayStatus",
                keystroke: {
                    keyCode: 39,
                    ctrlKey: true
                },
                enabled: function (d) {
                    var e = d.get("maxDate");
                    return (!e || d.drawDate.newDate().add(1, "d").compareTo(e) != +1)
                },
                date: function (d) {
                    return d.drawDate.newDate().add(1, "d")
                },
                action: function (d) {
                    c.calendars.picker.changeDay(this, 1)
                }
            },
            nextWeek: {
                text: "nextWeekText",
                status: "nextWeekStatus",
                keystroke: {
                    keyCode: 40,
                    ctrlKey: true
                },
                enabled: function (d) {
                    var e = d.get("maxDate");
                    return (!e || d.drawDate.newDate().add(d.get("calendar").daysInWeek(), "d").compareTo(e) != +1)
                },
                date: function (d) {
                    return d.drawDate.newDate().add(d.get("calendar").daysInWeek(), "d")
                },
                action: function (d) {
                    c.calendars.picker.changeDay(this, d.get("calendar").daysInWeek())
                }
            }
        },
        defaultRenderer: {
            picker: '<div class="calendars"><div class="calendars-nav">{link:prev}{link:today}{link:next}</div>{months}{popup:start}<div class="calendars-ctrl">{link:clear}{link:close}</div>{popup:end}<div class="calendars-clear-fix"></div></div>',
            monthRow: '<div class="calendars-month-row">{months}</div>',
            month: '<div class="calendars-month"><div class="calendars-month-header">{monthHeader}</div><table><thead>{weekHeader}</thead><tbody>{weeks}</tbody></table></div>',
            weekHeader: "<tr>{days}</tr>",
            dayHeader: "<th>{day}</th>",
            week: "<tr>{days}</tr>",
            day: "<td>{day}</td>",
            monthSelector: ".calendars-month",
            daySelector: "td",
            rtlClass: "calendars-rtl",
            multiClass: "calendars-multi",
            defaultClass: "",
            selectedClass: "calendars-selected",
            highlightedClass: "calendars-highlight",
            todayClass: "calendars-today",
            otherMonthClass: "calendars-other-month",
            weekendClass: "calendars-weekend",
            commandClass: "calendars-cmd",
            commandButtonClass: "",
            commandLinkClass: "",
            disabledClass: "calendars-disabled",
            weekEndDay1Class: " BEWeekEndHeaderDay1",
            weekEndDay2Class: " BEWeekEndHeaderDay2"
        },
        setDefaults: function (d) {
            c.extend(this._defaults, d || {});
            return this
        },
        _attachPicker: function (g, e) {
            g = c(g);
            if (g.hasClass(this.markerClass)) {
                return
            }
            g.addClass(this.markerClass);
            var f = {
                target: g,
                selectedDates: [],
                drawDate: null,
                pickingRange: false,
                inline: (c.inArray(g[0].nodeName.toLowerCase(), ["div", "span"]) > -1),
                get: function (h) {
                    var i = this.settings[h] !== undefined ? this.settings[h] : c.calendars.picker._defaults[h];
                    if (c.inArray(h, ["defaultDate", "minDate", "maxDate"]) > -1) {
                        i = this.get("calendar").determineDate(i, null, this.selectedDates[0], this.get("dateFormat"), f.getConfig())
                    } else {
                        if (h == "dateFormat") {
                            i = i || this.get("calendar").local.dateFormat
                        }
                    }
                    return i
                },
                curMinDate: function () {
                    return (this.pickingRange ? this.selectedDates[0] : this.get("minDate"))
                },
                getConfig: function () {
                    return {
                        dayNamesShort: this.get("dayNamesShort"),
                        dayNames: this.get("dayNames"),
                        monthNamesShort: this.get("monthNamesShort"),
                        monthNames: this.get("monthNames"),
                        calculateWeek: this.get("calculateWeek"),
                        shortYearCutoff: this.get("shortYearCutoff")
                    }
                }
            };
            c.data(g[0], this.dataName, f);
            var d = (c.fn.metadata ? g.metadata() : {});
            f.settings = c.extend({}, e || {}, d || {});
            if (f.inline) {
                this._update(g[0]);
                if (c.fn.mousewheel) {
                    g.mousewheel(this._doMouseWheel)
                }
            } else {
                this._attachments(g, f);
                g.bind("keydown." + this.dataName, this._keyDown).bind("keypress." + this.dataName, this._keyPress).bind("keyup." + this.dataName, this._keyUp);
                if (g.attr("disabled")) {
                    this.disable(g[0])
                }
            }
        },
        options: function (f, d) {
            var e = c.data(f, this.dataName);
            return (e ? (d ? (d == "all" ? e.settings : e.settings[d]) : c.calendars.picker._defaults) : {})
        },
        option: function (k, e, g) {
            k = c(k);
            if (!k.hasClass(this.markerClass)) {
                return
            }
            e = e || {};
            if (typeof e == "string") {
                var d = e;
                e = {};
                e[d] = g
            }
            var f = c.data(k[0], this.dataName);
            if (e.calendar && e.calendar != f.get("calendar")) {
                var j = function (l) {
                    return (typeof f.settings[l] == "object" ? null : f.settings[l])
                };
                e = c.extend({
                    defaultDate: j("defaultDate"),
                    minDate: j("minDate"),
                    maxDate: j("maxDate")
                }, e);
                f.selectedDates = [];
                f.drawDate = null
            }
            var i = f.selectedDates;
            a(f.settings, e);
            this.setDate(k[0], i, null, false, true);
            f.pickingRange = false;
            var h = f.get("calendar");
            f.drawDate = this._checkMinMax((e.defaultDate ? f.get("defaultDate") : f.drawDate) || f.get("defaultDate") || h.today(), f).newDate();
            if (!f.inline) {
                this._attachments(k, f)
            }
            if (f.inline || f.div) {
                this._update(k[0])
            }
        },
        _attachments: function (h, e) {
            h.unbind("focus." + this.dataName);
            if (e.get("showOnFocus")) {
                h.bind("focus." + this.dataName, this.show);
                h.keypress(function (i) {
                    i.preventDefault()
                })
            }
            if (e.trigger) {
                e.trigger.remove()
            }
            var d = e.get("showTrigger");
            e.trigger = (!d ? c([]) : c(d).clone().addClass(this._triggerClass)[e.get("isRTL") ? "insertBefore" : "insertAfter"](h).click(function () {
                if (!c.calendars.picker.isDisabled(h[0])) {
                    c.calendars.picker[c.calendars.picker.curInst == e ? "hide" : "show"](h[0])
                }
            }));
            this._autoSize(h, e);
            var g = this._extractDates(e, h.val());
            if (g) {
                this.setDate(h[0], g, null, true)
            }
            if (e.get("selectDefaultDate") && e.get("defaultDate") && e.selectedDates.length == 0) {
                var f = e.get("calendar");
                this.setDate(h[0], (e.get("defaultDate") || f.today()).newDate())
            }
        },
        _autoSize: function (i, g) {
            if (g.get("autoSize") && !g.inline) {
                var h = g.get("calendar");
                var f = h.newDate(2009, 10, 20);
                var d = g.get("dateFormat");
                if (d.match(/[DM]/)) {
                    var e = function (m) {
                        var j = 0;
                        var k = 0;
                        for (var l = 0; l < m.length; l++) {
                            if (m[l].length > j) {
                                j = m[l].length;
                                k = l
                            }
                        }
                        return k
                    };
                    f.month(e(h.local[d.match(/MM/) ? "monthNames" : "monthNamesShort"]) + 1);
                    f.day(e(h.local[d.match(/DD/) ? "dayNames" : "dayNamesShort"]) + 20 - f.dayOfWeek())
                }
                g.target.attr("size", f.formatDate(d).length)
            }
        },
        destroy: function (e) {
            e = c(e);
            if (!e.hasClass(this.markerClass)) {
                return
            }
            var d = c.data(e[0], this.dataName);
            if (d.trigger) {
                d.trigger.remove()
            }
            e.removeClass(this.markerClass).empty().unbind("." + this.dataName);
            if (d.inline && c.fn.mousewheel) {
                e.unmousewheel()
            }
            if (!d.inline && d.get("autoSize")) {
                e.removeAttr("size")
            }
            c.removeData(e[0], this.dataName)
        },
        multipleEvents: function (e) {
            var d = arguments;
            return function (f) {
                for (var g = 0; g < d.length; g++) {
                    d[g].apply(this, arguments)
                }
            }
        },
        enable: function (f) {
            var d = c(f);
            if (!d.hasClass(this.markerClass)) {
                return
            }
            var e = c.data(f, this.dataName);
            if (e.inline) {
                d.children("." + this._disableClass).remove().end().find("button,select").attr("disabled", "").end().find("a").attr("href", "javascript:void(0)")
            } else {
                f.disabled = false;
                e.trigger.filter("button." + this._triggerClass).attr("disabled", "").end().filter("img." + this._triggerClass).css({
                    opacity: "1.0",
                    cursor: ""
                })
            }
            this._disabled = c.map(this._disabled, function (g) {
                return (g == f ? null : g)
            })
        },
        disable: function (g) {
            var d = c(g);
            if (!d.hasClass(this.markerClass)) {
                return
            }
            var e = c.data(g, this.dataName);
            if (e.inline) {
                var f = d.children(":last");
                var i = f.offset();
                var h = {
                    left: 0,
                    top: 0
                };
                f.parents().each(function () {
                    if (c(this).css("position") == "relative") {
                        h = c(this).offset();
                        return false
                    }
                });
                var j = d.css("zIndex");
                j = (j == "auto" ? 0 : parseInt(j, 10)) + 1;
                d.prepend('<div class="' + this._disableClass + '" style="width: ' + f.outerWidth() + "px; height: " + f.outerHeight() + "px; left: " + (i.left - h.left) + "px; top: " + (i.top - h.top) + "px; z-index: " + j + '"></div>').find("button,select").attr("disabled", "disabled").end().find("a").removeAttr("href")
            } else {
                g.disabled = true;
                e.trigger.filter("button." + this._triggerClass).attr("disabled", "disabled").end().filter("img." + this._triggerClass).css({
                    opacity: "0.5",
                    cursor: "default"
                })
            }
            this._disabled = c.map(this._disabled, function (k) {
                return (k == g ? null : k)
            });
            this._disabled.push(g)
        },
        isDisabled: function (d) {
            return (d && c.inArray(d, this._disabled) > -1)
        },
        show: function (j) {
            j = j.target || j;
            var i = c.data(j, c.calendars.picker.dataName);
            if (c.calendars.picker.curInst == i) {
                return
            }
            if (c.calendars.picker.curInst) {
                c.calendars.picker.hide(c.calendars.picker.curInst, true)
            }
            if (i) {
                i.lastVal = null;
                i.selectedDates = c.calendars.picker._extractDates(i, c(j).val());
                i.pickingRange = false;
                i.drawDate = c.calendars.picker._checkMinMax((i.selectedDates[0] || i.get("defaultDate") || i.get("calendar").today()).newDate(), i);
                c.calendars.picker.curInst = i;
                c.calendars.picker._update(j, true);
                var k = c.calendars.picker._checkOffset(i);
                i.div.css({
                    left: k.left,
                    top: k.top
                });
                var d = i.get("showAnim");
                var f = i.get("showSpeed");
                f = (f == "normal" && c.ui && c.ui.version >= "1.8" ? "_default" : f);
                var h = function () {
                    var m = i.div.find("." + c.calendars.picker._coverClass);
                    if (m.length) {
                        var l = c.calendars.picker._getBorders(i.div);
                        m.css({
                            left: -l[0],
                            top: -l[1],
                            width: i.div.outerWidth() + l[0],
                            height: i.div.outerHeight() + l[1]
                        })
                    }
                };
                if (c.effects && c.effects[d]) {
                    var g = i.div.data();
                    for (var e in g) {
                        if (e.match(/^ec\.storage\./)) {
                            g[e] = i._mainDiv.css(e.replace(/ec\.storage\./, ""))
                        }
                    }
                    i.div.data(g).show(d, i.get("showOptions"), f, h)
                } else {
                    i.div[d || "show"]((d ? f : ""), h)
                }
                if (!d) {
                    h()
                }
            }
        },
        _extractDates: function (n, q) {
            if (q == n.lastVal) {
                return
            }
            n.lastVal = q;
            var l = n.get("calendar");
            var f = n.get("dateFormat");
            var h = n.get("multiSelect");
            var p = n.get("rangeSelect");
            q = q.split(h ? n.get("multiSeparator") : (p ? n.get("rangeSeparator") : "\x00"));
            var d = [];
            for (var m = 0; m < q.length; m++) {
                try {
                    var g = l.parseDate(f, q[m]);
                    if (g) {
                        var r = false;
                        for (var k = 0; k < d.length; k++) {
                            if (d[k].compareTo(g) == 0) {
                                r = true;
                                break
                            }
                        }
                        if (!r) {
                            d.push(g)
                        }
                    }
                } catch (o) { }
            }
            d.splice(h || (p ? 2 : 1), d.length);
            if (p && d.length == 1) {
                d[1] = d[0]
            }
            return d
        },
        _update: function (j, h) {
            j = c(j.target || j);
            var g = c.data(j[0], c.calendars.picker.dataName);
            if (g) {
                var f = g.curMinDate();
                var e = true;
                if (g.inline || c.calendars.picker.curInst == g) {
                    var d = g.get("onChangeMonthYear");
                    if (d && g.drawDate != null && (!g.prevDate || g.prevDate.year() != g.drawDate.year() || g.prevDate.month() != g.drawDate.month())) {
                        var i = false;
                        if (_drawMonthsInDisplay.length == 1) {
                            i = true
                        } else {
                            if (g.drawDate.month() == g.selectedDates[0].month() && (!g.prevDate || g.prevDate.year() == g.drawDate.year())) {
                                if (g.selectedDates[0].month() == g.selectedDates[g.selectedDates.length - 1].month()) {
                                    i = (jQuery.inArray(g.selectedDates[0].month(), _drawMonthsInDisplay) == -1)
                                } else {
                                    i = (jQuery.inArray(g.selectedDates[0].month(), _drawMonthsInDisplay) == -1 || jQuery.inArray(g.selectedDates[g.selectedDates.length - 1].month(), _drawMonthsInDisplay) == -1)
                                }
                            } else {
                                i = true
                            }
                        }
                        if (i) {
                            d.apply(j[0], [g.drawDate.year(), g.drawDate.month()])
                        }
                    }
                }
                if (g.inline) {
                    j.html(this._generateContent(j[0], g))
                } else {
                    if (c.calendars.picker.curInst == g) {
                        if (!g.div) {
                            g.div = c("<div></div>").addClass(this._popupClass).css({
                                display: (h ? "none" : "static"),
                                position: "absolute",
                                left: j.offset().left,
                                top: j.offset().top + j.outerHeight()
                            }).appendTo(c(g.get("popupContainer") || "body"));
                            if (c.fn.mousewheel) {
                                g.div.mousewheel(this._doMouseWheel)
                            }
                        }
                        g.div.html(this._generateContent(j[0], g));
                        j.focus()
                    }
                }
            }
        },
        _updateInput: function (l, e) {
            var k = c.data(l, this.dataName);
            if (k) {
                var n = "";
                var f = "";
                var o = (k.get("multiSelect") ? k.get("multiSeparator") : k.get("rangeSeparator"));
                var j = k.get("calendar");
                var d = k.get("dateFormat") || j.local.dateFormat;
                var g = k.get("altFormat") || d;
                for (var h = 0; h < k.selectedDates.length; h++) {
                    n += (e ? "" : (h > 0 ? o : "") + j.formatDate(d, k.selectedDates[h]));
                    f += (h > 0 ? o : "") + j.formatDate(g, k.selectedDates[h])
                }
                if (!k.inline && !e) {
                    c(l).val(n)
                }
                c(k.get("altField")).val(f);
                var m = k.get("onSelect");
                if (m && !e && !k.inSelect) {
                    k.inSelect = true;
                    m.apply(l, [k.selectedDates]);
                    k.inSelect = false
                }
            }
        },
        _getBorders: function (d) {
            var e = function (g) {
                var f = (c.browser.msie ? 1 : 0);
                return {
                    thin: 1 + f,
                    medium: 3 + f,
                    thick: 5 + f
                }[g] || g
            };
            return [parseFloat(e(d.css("border-left-width"))), parseFloat(e(d.css("border-top-width")))]
        },
        _checkOffset: function (j) {
            var e = (j.target.is(":hidden") && j.trigger ? j.trigger : j.target);
            var i = e.offset();
            var g = false;
            c(j.target).parents().each(function () {
                g |= c(this).css("position") == "fixed";
                return !g
            });
            if (g && c.browser.opera) {
                i.left -= document.documentElement.scrollLeft;
                i.top -= document.documentElement.scrollTop
            }
            var s = (!c.browser.mozilla || document.doctype ? document.documentElement.clientWidth : 0) || document.body.clientWidth;
            var k = (!c.browser.mozilla || document.doctype ? document.documentElement.clientHeight : 0) || document.body.clientHeight;
            if (s == 0) {
                return i
            }
            var n = j.get("alignment");
            var f = j.get("isRTL");
            var r = document.documentElement.scrollLeft || document.body.scrollLeft;
            var q = document.documentElement.scrollTop || document.body.scrollTop;
            var m = i.top - j.div.outerHeight() - (g && c.browser.opera ? document.documentElement.scrollTop : 0);
            var p = i.top + e.outerHeight();
            var o = i.left;
            var l = i.left + e.outerWidth() - j.div.outerWidth() - (g && c.browser.opera ? document.documentElement.scrollLeft : 0);
            var h = (i.left + j.div.outerWidth() - r) > s;
            var d = (i.top + j.target.outerHeight() + j.div.outerHeight() - q) > k;
            if (n == "topLeft") {
                i = {
                    left: o,
                    top: m
                }
            } else {
                if (n == "topRight") {
                    i = {
                        left: l,
                        top: m
                    }
                } else {
                    if (n == "bottomLeft") {
                        i = {
                            left: o,
                            top: p
                        }
                    } else {
                        if (n == "bottomRight") {
                            i = {
                                left: l,
                                top: p
                            }
                        } else {
                            if (n == "top") {
                                i = {
                                    left: (f || h ? l : o),
                                    top: m
                                }
                            } else {
                                i = {
                                    left: (f || h ? l : o),
                                    top: (d ? m : p)
                                }
                            }
                        }
                    }
                }
            }
            i.left = Math.max((g ? 0 : r), i.left - (g ? r : 0));
            i.top = Math.max((g ? 0 : q), i.top - (g ? q : 0));
            return i
        },
        _checkExternalClick: function (d) {
            if (!c.calendars.picker.curInst) {
                return
            }
            var e = c(d.target);
            if (!e.parents().andSelf().hasClass(c.calendars.picker._popupClass) && !e.hasClass(c.calendars.picker.markerClass) && !e.parents().andSelf().hasClass(c.calendars.picker._triggerClass)) {
                c.calendars.picker.hide(c.calendars.picker.curInst)
            }
        },
        hide: function (j, f) {
            var i = c.data(j, this.dataName) || j;
            if (i && i == c.calendars.picker.curInst) {
                var e = (f ? "" : i.get("showAnim"));
                var g = i.get("showSpeed");
                g = (g == "normal" && c.ui && c.ui.version >= "1.8" ? "_default" : g);
                var h = function () {
                    i.div.remove();
                    i.div = null;
                    c.calendars.picker.curInst = null;
                    var k = i.get("onClose");
                    if (k) {
                        k.apply(j, [i.selectedDates])
                    }
                };
                i.div.stop();
                if (c.effects && c.effects[e]) {
                    i.div.hide(e, i.get("showOptions"), g, h)
                } else {
                    var d = (e == "slideDown" ? "slideUp" : (e == "fadeIn" ? "fadeOut" : "hide"));
                    i.div[d]((e ? g : ""), h)
                }
                if (!e) {
                    h()
                }
            }
        },
        _keyDown: function (f) {
            var i = f.target;
            var g = c.data(i, c.calendars.picker.dataName);
            var h = false;
            if (g.div) {
                if (f.keyCode == 9) {
                    c.calendars.picker.hide(i)
                } else {
                    if (f.keyCode == 13) {
                        c.calendars.picker.selectDate(i, c("a." + g.get("renderer").highlightedClass, g.div)[0]);
                        h = true
                    } else {
                        var d = g.get("commands");
                        for (var e in d) {
                            var j = d[e];
                            if (j.keystroke.keyCode == f.keyCode && !!j.keystroke.ctrlKey == !!(f.ctrlKey || f.metaKey) && !!j.keystroke.altKey == f.altKey && !!j.keystroke.shiftKey == f.shiftKey) {
                                c.calendars.picker.performAction(i, e);
                                h = true;
                                break
                            }
                        }
                    }
                }
            } else {
                var j = g.get("commands").current;
                if (j.keystroke.keyCode == f.keyCode && !!j.keystroke.ctrlKey == !!(f.ctrlKey || f.metaKey) && !!j.keystroke.altKey == f.altKey && !!j.keystroke.shiftKey == f.shiftKey) {
                    c.calendars.picker.show(i);
                    h = true
                }
            }
            g.ctrlKey = ((f.keyCode < 48 && f.keyCode != 32) || f.ctrlKey || f.metaKey);
            if (h) {
                f.preventDefault();
                f.stopPropagation()
            }
            return !h
        },
        _keyPress: function (f) {
            var h = f.target;
            var g = c.data(h, c.calendars.picker.dataName);
            if (g && g.get("constrainInput")) {
                var e = String.fromCharCode(f.keyCode || f.charCode);
                var d = c.calendars.picker._allowedChars(g);
                return (f.metaKey || g.ctrlKey || e < " " || !d || d.indexOf(e) > -1)
            }
            return true
        },
        _allowedChars: function (k) {
            var d = k.get("dateFormat");
            var e = (k.get("multiSelect") ? k.get("multiSeparator") : (k.get("rangeSelect") ? k.get("rangeSeparator") : ""));
            var j = false;
            var f = false;
            for (var g = 0; g < d.length; g++) {
                var h = d.charAt(g);
                if (j) {
                    if (h == "'" && d.charAt(g + 1) != "'") {
                        j = false
                    } else {
                        e += h
                    }
                } else {
                    switch (h) {
                        case "d":
                        case "m":
                        case "o":
                        case "w":
                            e += (f ? "" : "0123456789");
                            f = true;
                            break;
                        case "y":
                        case "@":
                        case "!":
                            e += (f ? "" : "0123456789") + "-";
                            f = true;
                            break;
                        case "J":
                            e += (f ? "" : "0123456789") + "-.";
                            f = true;
                            break;
                        case "D":
                        case "M":
                        case "Y":
                            return null;
                        case "'":
                            if (d.charAt(g + 1) == "'") {
                                e += "'"
                            } else {
                                j = true
                            }
                            break;
                        default:
                            e += h
                    }
                }
            }
            return e
        },
        _keyUp: function (d) {
            var g = d.target;
            var e = c.data(g, c.calendars.picker.dataName);
            if (e && !e.ctrlKey && e.lastVal != e.target.val()) {
                try {
                    var f = c.calendars.picker._extractDates(e, e.target.val());
                    if (f.length > 0) {
                        c.calendars.picker.setDate(g, f, null, true)
                    }
                } catch (d) { }
            }
            return true
        },
        _doMouseWheel: function (d, g) {
            var f = (c.calendars.picker.curInst && c.calendars.picker.curInst.target[0]) || c(d.target).closest("." + c.calendars.picker.markerClass)[0];
            if (c.calendars.picker.isDisabled(f)) {
                return
            }
            var e = c.data(f, c.calendars.picker.dataName);
            if (e.get("useMouseWheel")) {
                g = (c.browser.opera ? -g : g);
                g = (g < 0 ? -1 : +1);
                c.calendars.picker.changeMonth(f, -e.get(d.ctrlKey ? "monthsToJump" : "monthsToStep") * g)
            }
            d.preventDefault()
        },
        clear: function (f) {
            var d = c.data(f, this.dataName);
            if (d) {
                d.selectedDates = [];
                this.hide(f);
                if (d.get("selectDefaultDate") && d.get("defaultDate")) {
                    var e = d.get("calendar");
                    this.setDate(f, (d.get("defaultDate") || e.today()).newDate())
                } else {
                    this._updateInput(f)
                }
            }
        },
        getDate: function (e) {
            var d = c.data(e, this.dataName);
            return (d ? d.selectedDates : [])
        },
        setDate: function (s, e, r, g, n) {
            var q = c.data(s, this.dataName);
            if (q) {
                if (!c.isArray(e)) {
                    e = [e];
                    if (r) {
                        e.push(r)
                    }
                }
                var p = q.get("calendar");
                var f = q.get("dateFormat");
                var m = q.get("minDate");
                var d = q.get("maxDate");
                var k = q.selectedDates[0];
                q.selectedDates = [];
                for (var o = 0; o < e.length; o++) {
                    var h = p.determineDate(e[o], null, k, f, q.getConfig());
                    if (h) {
                        if ((!m || h.compareTo(m) != -1) && (!d || h.compareTo(d) != +1)) {
                            var u = false;
                            for (var l = 0; l < q.selectedDates.length; l++) {
                                if (q.selectedDates[l].compareTo(h) == 0) {
                                    u = true;
                                    break
                                }
                            }
                            if (!u) {
                                q.selectedDates.push(h)
                            }
                        }
                    }
                }
                var t = q.get("rangeSelect");
                q.selectedDates.splice(q.get("multiSelect") || (t ? 2 : 1), q.selectedDates.length);
                if (t) {
                    switch (q.selectedDates.length) {
                        case 1:
                            q.selectedDates[1] = q.selectedDates[0];
                            break;
                        case 2:
                            q.selectedDates[1] = (q.selectedDates[0].compareTo(q.selectedDates[1]) == +1 ? q.selectedDates[0] : q.selectedDates[1]);
                            break
                    }
                    q.pickingRange = false
                }
                q.prevDate = (q.drawDate ? q.drawDate.newDate() : null);
                q.drawDate = this._checkMinMax((q.selectedDates[0] || q.get("defaultDate") || p.today()).newDate(), q);
                if (!n) {
                    this._update(s);
                    this._updateInput(s, g)
                }
            }
        },
        isSelectable: function (f, d) {
            var e = c.data(f, this.dataName);
            if (!e) {
                return false
            }
            d = e.get("calendar").determineDate(d, e.selectedDates[0] || e.get("calendar").today(), null, e.get("dateFormat"), e.getConfig());
            return this._isSelectable(f, d, e.get("onDate"), e.get("minDate"), e.get("maxDate"))
        },
        _isSelectable: function (h, e, d, g, i) {
            var f = (typeof d == "boolean" ? {
                selectable: d
            } : (!d ? {} : d.apply(h, [e, true])));
            return (f.selectable != false) && (!g || e.toJD() >= g.toJD()) && (!i || e.toJD() <= i.toJD())
        },
        performAction: function (g, f) {
            var e = c.data(g, this.dataName);
            if (e && !this.isDisabled(g)) {
                var d = e.get("commands");
                if (d[f] && d[f].enabled.apply(g, [e])) {
                    d[f].action.apply(g, [e])
                }
            }
        },
        showMonth: function (j, f, i, e) {
            var g = c.data(j, this.dataName);
            if (g && (e != null || (g.drawDate.year() != f || g.drawDate.month() != i))) {
                g.prevDate = g.drawDate.newDate();
                var h = g.get("calendar");
                var d = this._checkMinMax((f != null ? h.newDate(f, i, 1) : h.today()), g);
                g.drawDate.date(d.year(), d.month(), (e != null ? e : Math.min(g.drawDate.day(), h.daysInMonth(d.year(), d.month()))));
                this._update(j)
            }
        },
        changeMonth: function (f, g) {
            var e = c.data(f, this.dataName);
            if (e) {
                var d = e.drawDate.newDate().add(g, "m");
                this.showMonth(f, d.year(), d.month())
            }
        },
        changeDay: function (f, g) {
            var e = c.data(f, this.dataName);
            if (e) {
                var d = e.drawDate.newDate().add(g, "d");
                this.showMonth(f, d.year(), d.month(), d.day())
            }
        },
        _checkMinMax: function (d, f) {
            var e = f.get("minDate");
            var g = f.get("maxDate");
            d = (e && d.compareTo(e) == -1 ? e.newDate() : d);
            d = (g && d.compareTo(g) == +1 ? g.newDate() : d);
            return d
        },
        retrieveDate: function (f, d) {
            var e = c.data(f, this.dataName);
            return (!e ? null : e.get("calendar").fromJD(parseFloat(d.className.replace(/^.*jd(\d+\.5).*$/, "$1"))))
        },
        selectDate: function (l, g) {
            var j = c.data(l, this.dataName);
            if (j && !this.isDisabled(l)) {
                var e = this.retrieveDate(l, g);
                var k = j.get("multiSelect");
                var d = j.get("rangeSelect");
                if (k) {
                    var h = false;
                    for (var f = 0; f < j.selectedDates.length; f++) {
                        if (e.compareTo(j.selectedDates[f]) == 0) {
                            j.selectedDates.splice(f, 1);
                            h = true;
                            break
                        }
                    }
                    if (!h && j.selectedDates.length < k) {
                        j.selectedDates.push(e)
                    }
                } else {
                    if (d) {
                        if (j.pickingRange) {
                            j.selectedDates[1] = e
                        } else {
                            j.selectedDates = [e, e]
                        }
                        j.pickingRange = !j.pickingRange
                    } else {
                        j.selectedDates = [e]
                    }
                }
                this._updateInput(l);
                if (j.inline || j.pickingRange || j.selectedDates.length < (k || (d ? 2 : 1))) {
                    this._update(l)
                } else {
                    this.hide(l)
                }
            }
        },
        _generateContent: function (w, e) {
            var n = e.get("calendar");
            var q = e.get("renderer");
            var d = e.get("monthsToShow");
            d = (c.isArray(d) ? d : [1, d]);
            e.drawDate = this._checkMinMax(e.drawDate || e.get("defaultDate") || n.today(), e);
            var u = 0;
            if (e.inline) {
                var s = (typeof (_firstMonthInDisplay) != "undefined") ? _firstMonthInDisplay : e.settings.minDate.month();
                u = (e.drawDate.month() == e.settings.minDate.month() && e.drawDate.year() == e.settings.minDate.year()) ? 0 : (e.drawDate.month() - s)
            }
            var v = e.drawDate.newDate().add(-u, "m");
            var t = "";
            for (var i = 0; i < d[0]; i++) {
                var k = "";
                for (var f = 0; f < d[1]; f++) {
                    k += this._generateMonth(w, e, v.year(), v.month(), n, q, (i == 0 && f == 0));
                    v.add(1, "m")
                }
                t += this._prepare(q.monthRow, e).replace(/\{months\}/, k)
            }
            var l = this._prepare(q.picker, e).replace(/\{months\}/, t).replace(/\{weekHeader\}/g, this._generateDayHeaders(e, n, q)) + (c.browser.msie && parseInt(c.browser.version, 10) < 7 && !e.inline ? '<iframe src="javascript:void(0);" class="' + this._coverClass + '"></iframe>' : "");
            var g = e.get("commands");
            var j = e.get("commandsAsDateFormat");
            var m = function (C, A, E, z, B) {
                if (l.indexOf("{" + C + ":" + z + "}") == -1) {
                    return
                }
                var D = g[z];
                var y = (j ? D.date.apply(w, [e]) : null);
                l = l.replace(new RegExp("\\{" + C + ":" + z + "\\}", "g"), "<" + A + (D.status ? ' title="' + e.get(D.status) + '"' : "") + ' class="' + q.commandClass + " " + q.commandClass + "-" + z + " " + B + (D.enabled(e) ? "" : " " + q.disabledClass) + '">' + (y ? y.formatDate(e.get(D.text)) : e.get(D.text)) + "</" + E + ">")
            };
            for (var x in g) {
                m("button", 'button type="button"', "button", x, q.commandButtonClass);
                m("link", 'a href="javascript:void(0)"', "a", x, q.commandLinkClass)
            }
            l = c(l);
            if (d[1] > 1) {
                var h = 0;
                c(q.monthSelector, l).each(function () {
                    var y = ++h % d[1];
                    c(this).addClass(y == 1 ? "first" : (y == 0 ? "last" : ""))
                })
            }
            var o = this;
            l.find(q.daySelector + " a").hover(function () {
                c(this).addClass(q.highlightedClass)
            }, function () {
                (e.inline ? c(this).parents("." + o.markerClass) : e.div).find(q.daySelector + " a").removeClass(q.highlightedClass)
            }).click(function () {
                o.selectDate(w, this)
            }).end().find("select." + this._monthYearClass + ":not(." + this._anyYearClass + ")").change(function () {
                var y = c(this).val().split("/");
                o.showMonth(w, parseInt(y[1], 10), parseInt(y[0], 10))
            }).end().find("select." + this._anyYearClass).click(function () {
                c(this).next("input").css({
                    left: this.offsetLeft,
                    top: this.offsetTop,
                    width: this.offsetWidth,
                    height: this.offsetHeight
                }).show().focus()
            }).end().find("input." + o._monthYearClass).change(function () {
                try {
                    var y = parseInt(c(this).val(), 10);
                    y = (isNaN(y) ? e.drawDate.year() : y);
                    o.showMonth(w, y, e.drawDate.month(), e.drawDate.day())
                } catch (z) {
                    alert(z)
                }
            }).keydown(function (y) {
                if (y.keyCode == 27) {
                    c(y.target).hide();
                    e.target.focus()
                }
            });
            l.find("." + q.commandClass).click(function () {
                if (!c(this).hasClass(q.disabledClass)) {
                    var y = this.className.replace(new RegExp("^.*" + q.commandClass + "-([^ ]+).*$"), "$1");
                    c.calendars.picker.performAction(w, y)
                }
            });
            if (e.get("isRTL")) {
                l.addClass(q.rtlClass)
            }
            if (d[0] * d[1] > 1) {
                switch (d[1]) {
                    case 3:
                        l.addClass(q.multiClass + "-3");
                        break;
                    case 6:
                        l.addClass(q.multiClass + "-6");
                        break;
                    default:
                        l.addClass(q.multiClass);
                        break
                }
            }
            var r = e.get("pickerClass");
            if (r) {
                l.addClass(r)
            }
            c("body").append(l);
            var p = e.get("onShow");
            if (p) {
                p.apply(w, [l, n, e])
            }
            return l
        },
        _generateMonth: function (d, F, k, e, J, H, q) {
            var n = J.daysInMonth(k, e);
            var z = F.get("monthsToShow");
            z = (c.isArray(z) ? z : [1, z]);
            var M = F.get("fixedWeeks") || (z[0] * z[1] > 1);
            var y = F.get("firstDay");
            y = (y == null ? J.local.firstDay : y);
            var w = (J.dayOfWeek(k, e, J.minDay) - y + J.daysInWeek()) % J.daysInWeek();
            var N = (M ? 6 : Math.ceil((w + n) / J.daysInWeek()));
            var p = F.get("showOtherMonths");
            var t = F.get("selectOtherMonths") && p;
            var E = F.get("dayStatus");
            var l = (F.pickingRange ? F.selectedDates[0] : F.get("minDate"));
            var r = F.get("maxDate");
            var x = F.get("rangeSelect");
            var L = F.get("onDate");
            var G = H.week.indexOf("{weekOfYear}") > -1;
            var g = F.get("calculateWeek");
            var s = J.today();
            var v = J.newDate(k, e, J.minDay);
            v.add(-w - (M && (v.dayOfWeek() == y || v.daysInMonth() < J.daysInWeek()) ? J.daysInWeek() : 0), "d");
            var u = v.toJD();
            var j = "";
            for (var h = 0; h < N; h++) {
                var I = (!G ? "" : '<span class="jd' + u + '">' + (g ? g(v) : v.weekOfYear()) + "</span>");
                var m = "";
                for (var B = 0; B < J.daysInWeek() ; B++) {
                    var D = false;
                    if (x && F.selectedDates.length > 0) {
                        D = (v.compareTo(F.selectedDates[0]) != -1 && v.compareTo(F.selectedDates[1]) != +1)
                    } else {
                        for (var K = 0; K < F.selectedDates.length; K++) {
                            if (F.selectedDates[K].compareTo(v) == 0) {
                                D = true;
                                break
                            }
                        }
                    }
                    var f = (!L ? {} : L.apply(d, [v, v.month() == e]));
                    var o = (t || v.month() == e) && this._isSelectable(d, v, f.selectable, l, r);
                    m += this._prepare(H.day, F).replace(/\{day\}/g, (o ? '<a href="javascript:void(0)"' : "<span") + ' class="jd' + u + " " + (f.dateClass || "") + (D && (t || v.month() == e) ? " " + H.selectedClass : "") + (o ? " " + H.defaultClass : "") + (v.weekDay() ? "" : " " + H.weekendClass) + (v.month() == e ? "" : " " + H.otherMonthClass) + (v.compareTo(s) == 0 && v.month() == e ? " " + H.todayClass : "") + (v.compareTo(F.drawDate) == 0 && v.month() == e ? " " + H.highlightedClass : "") + '"' + (f.title || (E && o) ? ' title="' + (f.title || v.formatDate(E)) + '"' : "") + ">" + this._generateDayWithPricing(p, e, v, f) + (o ? "</a>" : "</span>"));
                    v.add(1, "d");
                    u++
                }
                j += this._prepare(H.week, F).replace(/\{days\}/g, m).replace(/\{weekOfYear\}/g, I)
            }
            var A = this._prepare(H.month, F).match(/\{monthHeader(:[^\}]+)?\}/);
            A = (A[0].length <= 13 ? "MM yyyy" : A[0].substring(13, A[0].length - 1));
            A = (q ? this._generateMonthSelection(F, k, e, l, r, A, J, H) : J.formatDate(A, J.newDate(k, e, J.minDay)));
            var C = this._prepare(H.weekHeader, F).replace(/\{days\}/g, this._generateDayHeaders(F, J, H));
            return this._prepare(H.month, F).replace(/\{monthHeader(:[^\}]+)?\}/g, A).replace(/\{weekHeader\}/g, C).replace(/\{weeks\}/g, j)
        },
        _generateDayWithPricing: function (g, j, e, i) {
            var h = "";
            var d = XbeState.currencySymbol;
            if (typeof (i.content) != "undefined" && i.content != "") {
                h = '<span class="DayContent">' + i.content + "</span>"
            }
            var k = '<span class="DayNum">' + ((g || e.month() == j) ? e.day() : "&nbsp;") + "</span>";
            var f = '<span class="DayPrice">' + (((typeof (i.price) == "undefined") || (i.price == 0)) ? "&nbsp;" : d + " " + i.price) + "</span>";
            return k + h + ((XbeState.calculatePricing == 0) ? "" : f)
        },
        _generateDayHeaders: function (g, h, f) {
            var e = g.get("firstDay");
            e = (e == null ? h.local.firstDay : e);
            var k = "";
            for (var d = 0; d < h.daysInWeek() ; d++) {
                var j = (d + e) % h.daysInWeek();
                var i = "";
                if (g.settings.isHighlightWeekendsAndHolidays) {
                    if (g.settings.weekEndDefinition == "0") {
                        if (j == "0") {
                            i = f.weekEndDay2Class
                        } else {
                            if (j == "6") {
                                i = f.weekEndDay1Class
                            }
                        }
                    } else {
                        if (g.settings.weekEndDefinition == "1") {
                            if (j == "5") {
                                i = f.weekEndDay1Class
                            } else {
                                if (j == "6") {
                                    i = f.weekEndDay2Class
                                }
                            }
                        }
                    }
                }
                k += this._prepare(f.dayHeader, g).replace(/\{day\}/g, '<span class="' + this._curDoWClass + j + i + '" title="' + h.local.dayNames[j] + '">' + h.local.dayNamesMin[j] + "</span>")
            }
            return k
        },
        _generateMonthSelection: function (f, r, v, j, q, e, s) {
            if (!f.get("changeMonth")) {
                return s.formatDate(e, s.newDate(r, v, 1))
            }
            var n = s.local["monthNames" + (e.match(/mm/i) ? "" : "Short")];
            var p = e.replace(/m+/i, "\\x2E").replace(/y+/i, "\\x2F");
            var u = '<select class="' + this._monthYearClass + '" title="' + f.get("monthStatus") + '">';
            var d = s.monthsInYear(r) + s.minMonth;
            for (var t = s.minMonth; t < d; t++) {
                if ((!j || s.newDate(r, t, s.daysInMonth(r, t) - 1 + s.minDay).compareTo(j) != -1) && (!q || s.newDate(r, t, s.minDay).compareTo(q) != +1)) {
                    u += '<option value="' + t + "/" + r + '"' + (v == t ? ' selected="selected"' : "") + ">" + n[t - s.minMonth] + "</option>"
                }
            }
            u += "</select>";
            p = p.replace(/\\x2E/, u);
            var g = f.get("yearRange");
            if (g == "any") {
                u = '<select class="' + this._monthYearClass + " " + this._anyYearClass + '" title="' + f.get("yearStatus") + '"><option>' + r + '</option></select><input class="' + this._monthYearClass + " " + this._curMonthClass + v + '" value="' + r + '">'
            } else {
                g = g.split(":");
                var o = s.today().year();
                var i = (g[0].match("c[+-].*") ? r + parseInt(g[0].substring(1), 10) : ((g[0].match("[+-].*") ? o : 0) + parseInt(g[0], 10)));
                var h = (g[1].match("c[+-].*") ? r + parseInt(g[1].substring(1), 10) : ((g[1].match("[+-].*") ? o : 0) + parseInt(g[1], 10)));
                u = '<select class="' + this._monthYearClass + '" title="' + f.get("yearStatus") + '">';
                i = s.newDate(i + 1, s.firstMonth, s.minDay).add(-1, "d");
                h = s.newDate(h, s.firstMonth, s.minDay);
                var k = function (m) {
                    if (m != 0 || s.hasYearZero) {
                        u += '<option value="' + Math.min(v, s.monthsInYear(m) - 1 + s.minMonth) + "/" + m + '"' + (r == m ? ' selected="selected"' : "") + ">" + m + "</option>"
                    }
                };
                if (i.toJD() < h.toJD()) {
                    i = (j && j.compareTo(i) == +1 ? j : i).year();
                    h = (q && q.compareTo(h) == -1 ? q : h).year();
                    for (var l = i; l <= h; l++) {
                        k(l)
                    }
                } else {
                    i = (q && q.compareTo(i) == -1 ? q : i).year();
                    h = (j && j.compareTo(h) == +1 ? j : h).year();
                    for (var l = i; l >= h; l--) {
                        k(l)
                    }
                }
                u += "</select>"
            }
            p = p.replace(/\\x2F/, u);
            return p
        },
        _prepare: function (h, f) {
            var g = function (k, i) {
                while (true) {
                    var l = h.indexOf("{" + k + ":start}");
                    if (l == -1) {
                        return
                    }
                    var j = h.substring(l).indexOf("{" + k + ":end}");
                    if (j > -1) {
                        h = h.substring(0, l) + (i ? h.substr(l + k.length + 8, j - k.length - 8) : "") + h.substring(l + j + k.length + 6)
                    }
                }
            };
            g("inline", f.inline);
            g("popup", !f.inline);
            var e = /\{l10n:([^\}]+)\}/;
            var d = null;
            while (d = e.exec(h)) {
                h = h.replace(d[0], f.get(d[1]))
            }
            return h
        }
    });

    function a(f, e) {
        c.extend(f, e);
        for (var d in e) {
            if (e[d] == null || e[d] == undefined) {
                f[d] = e[d]
            }
        }
        return f
    }
    c.fn.calendarsPicker = function (e) {
        var d = Array.prototype.slice.call(arguments, 1);
        if (c.inArray(e, ["getDate", "isDisabled", "isSelectable", "options", "retrieveDate"]) > -1) {
            return c.calendars.picker[e].apply(c.calendars.picker, [this[0]].concat(d))
        }
        return this.each(function () {
            if (typeof e == "string") {
                c.calendars.picker[e].apply(c.calendars.picker, [this].concat(d))
            } else {
                c.calendars.picker._attachPicker(this, e || {})
            }
        })
    };
    c.calendars.picker = new b();
    c(function () {
        c(document).mousedown(c.calendars.picker._checkExternalClick).resize(function () {
            c.calendars.picker.hide(c.calendars.picker.curInst)
        })
    })
})(jQuery);
(function (b) {
    var a = {
        picker: '<div{popup:start} id="ui-datepicker-div"{popup:end} class="ui-datepicker ui-widget ui-widget-content ui-helper-clearfix ui-corner-all{inline:start} ui-datepicker-inline{inline:end}"><div class="ui-datepicker-header ui-widget-header ui-helper-clearfix ui-corner-all">{link:prev}{link:today}{link:next}</div>{months}{popup:start}<div class="ui-datepicker-header ui-widget-header ui-helper-clearfix ui-corner-all">{button:clear}{button:close}</div>{popup:end}<div class="ui-helper-clearfix"></div></div>',
        monthRow: '<div class="ui-datepicker-row-break">{months}</div>',
        month: '<div class="ui-datepicker-group"><div class="ui-datepicker-header ui-widget-header ui-helper-clearfix ui-corner-all">{monthHeader:MM yyyy}</div><table class="ui-datepicker-calendar"><thead>{weekHeader}</thead><tbody>{weeks}</tbody></table></div>',
        weekHeader: "<tr>{days}</tr>",
        dayHeader: "<th>{day}</th>",
        week: "<tr>{days}</tr>",
        day: "<td>{day}</td>",
        monthSelector: ".ui-datepicker-group",
        daySelector: "td",
        rtlClass: "ui-datepicker-rtl",
        multiClass: "ui-datepicker-multi",
        defaultClass: "ui-state-default",
        selectedClass: "ui-state-active",
        highlightedClass: "ui-state-hover",
        todayClass: "",
        otherMonthClass: "ui-datepicker-other-month",
        weekendClass: "ui-datepicker-week-end",
        commandClass: "ui-datepicker-cmd",
        commandButtonClass: "ui-state-default ui-corner-all",
        commandLinkClass: "",
        disabledClass: "ui-datepicker-disabled",
        weekEndDay1Class: " BEWeekEndHeaderDay1",
        weekEndDay2Class: " BEWeekEndHeaderDay2"
    };
    b.extend(b.calendars.picker, {
        weekOfYearRenderer: b.extend({}, b.calendars.picker.defaultRenderer, {
            weekHeader: '<tr><th class="calendars-week"><span title="{l10n:weekStatus}">{l10n:weekText}</span></th>{days}</tr>',
            week: '<tr><td class="calendars-week">{weekOfYear}</td>{days}</tr>'
        }),
        themeRollerRenderer: a,
        themeRollerWeekOfYearRenderer: b.extend({}, a, {
            weekHeader: '<tr><th class="ui-state-hover"><span>{l10n:weekText}</span></th>{days}</tr>',
            week: '<tr><td class="ui-state-hover">{weekOfYear}</td>{days}</tr>'
        }),
        noWeekends: function (c) {
            return {
                selectable: c.weekDay()
            }
        },
        changeFirstDay: function (c, f, d) {
            var e = b(this);
            c.find("th span").each(function () {
                if (this.parentNode.className.match(/.*calendars-week.*/)) {
                    return
                }
                b('<a href="javascript:void(0)" class="' + this.className + '" title="Change first day of the week">' + b(this).text() + "</a>").click(function () {
                    var g = parseInt(this.className.replace(/^.*calendars-dow-(\d+).*$/, "$1"), 10);
                    e.calendarsPicker("option", {
                        firstDay: g
                    })
                }).replaceAll(this)
            })
        },
        hoverCallback: function (c) {
            return function (d, h, f) {
                var g = this;
                var e = f.get("renderer");
                d.find(e.daySelector + " a, " + e.daySelector + " span").hover(function () {
                    c.apply(g, [b.calendars.picker.retrieveDate(g, this), this.nodeName.toLowerCase() == "a"])
                }, function () {
                    c.apply(g, [])
                })
            }
        },
        highlightWeek: function (c, g, e) {
            var f = this;
            var d = e.get("renderer");
            c.find(d.daySelector + " a, " + d.daySelector + " span").hover(function () {
                b(this).parents("tr").find(d.daySelector + " *").addClass(d.highlightedClass)
            }, function () {
                b(this).parents("tr").find(d.daySelector + " *").removeClass(d.highlightedClass)
            })
        },
        showStatus: function (e, i, g) {
            var h = this;
            var f = g.get("renderer");
            var d = (f.selectedClass == "ui-state-active");
            var j = g.get("defaultStatus") || "&nbsp;";
            var c = b('<div class="' + (!d ? "calendars-status" : "ui-datepicker-status ui-widget-header ui-helper-clearfix ui-corner-all") + '">' + j + "</div>").insertAfter(e.find(".calendars-month-row:last,.ui-datepicker-row-break:last"));
            e.find("*[title]").each(function () {
                var k = b(this).attr("title");
                b(this).removeAttr("title").hover(function () {
                    c.text(k || j)
                }, function () {
                    c.text(j)
                })
            })
        },
        monthNavigation: function (l, h, k) {
            var m = b(this);
            var n = k.get("renderer");
            var q = (n.selectedClass == "ui-state-active");
            var e = k.curMinDate();
            var c = k.get("maxDate");
            var g = h.local.monthNames;
            var p = h.local.monthNamesShort;
            var o = k.drawDate.year();
            var j = '<div class="' + (!q ? "calendars-month-nav" : "ui-datepicker-month-nav") + '">';
            for (var f = 0; f < h.monthsInYear(o) ; f++) {
                var d = h.fromMonthOfYear(o, f + h.minMonth) - h.minMonth;
                var r = ((!e || h.newDate(o, f + h.minMonth, h.daysInMonth(o, f + h.minMonth)).compareTo(e) > -1) && (!c || h.newDate(o, f + h.minMonth, h.minDay).compareTo(c) < +1));
                j += "<div>" + (r ? '<a href="#" class="jd' + h.newDate(o, f + h.minMonth, h.minDay).toJD() + '"' : "<span") + ' title="' + g[d] + '">' + p[d] + (r ? "</a>" : "</span>") + "</div>"
            }
            j += "</div>";
            b(j).insertAfter(l.find("div.calendars-nav,div.ui-datepicker-header:first")).find("a").click(function () {
                var i = b.calendars.picker.retrieveDate(m[0], this);
                m.calendarsPicker("showMonth", i.year(), i.month());
                return false
            })
        },
        selectWeek: function (c, f, d) {
            var e = b(this);
            c.find("td.calendars-week span").each(function () {
                b('<a href="javascript:void(0)" class="' + this.className + '" title="Select the entire week">' + b(this).text() + "</a>").click(function () {
                    var g = e.calendarsPicker("retrieveDate", this);
                    var j = [g];
                    for (var h = 1; h < f.daysInWeek() ; h++) {
                        j.push(g = g.newDate().add(1, "d"))
                    }
                    if (d.get("rangeSelect")) {
                        j.splice(1, j.length - 2)
                    }
                    e.calendarsPicker("setDate", j).calendarsPicker("hide")
                }).replaceAll(this)
            })
        },
        selectMonth: function (c, f, d) {
            var e = b(this);
            c.find("th.calendars-week").each(function () {
                b('<a href="javascript:void(0)" title="Select the entire month">' + b(this).text() + "</a>").click(function () {
                    var g = e.calendarsPicker("retrieveDate", b(this).parents("table").find("td:not(.calendars-week) *:not(.calendars-other-month)")[0]);
                    var k = [g.day(1)];
                    var j = f.daysInMonth(g);
                    for (var h = 1; h < j; h++) {
                        k.push(g = g.newDate().add(1, "d"))
                    }
                    if (d.get("rangeSelect")) {
                        k.splice(1, k.length - 2)
                    }
                    e.calendarsPicker("setDate", k).calendarsPicker("hide")
                }).appendTo(this)
            })
        },
        monthOnly: function (c, g, e) {
            var f = b(this);
            var d = b('<div style="text-align: center;"><button type="button">Select</button></div>').insertAfter(c.find(".calendars-month-row:last,.ui-datepicker-row-break:last")).children().click(function () {
                var h = c.find(".calendars-month-year:first").val().split("/");
                f.calendarsPicker("setDate", g.newDate(parseInt(h[1], 10), parseInt(h[0], 10), g.minDay)).calendarsPicker("hide")
            });
            c.find(".calendars-month-row table,.ui-datepicker-row-break table").remove()
        }
    })
})(jQuery);
var _languages = {
    "": {
        "": "Default (English)",
        af: "Afrikaans",
        ar: "&#8235;العربية&#8236; (Arabic)",
        "ar-EG": "&#8235;العربية&#8236; (Arabic/Egypt)",
        az: "Azərbaycan dili (Azerbaijani)",
        id: "Bahasa Indonesia (Indonesian)",
        ms: "Bahasa Melayu (Malaysian)",
        "nl-BE": "Belgisch-Nederlands (Dutch/Belgian)",
        bs: "Bosanski (Bosnian)",
        bg: "български език (Bulgarian)",
        ca: "Català (Catalan)",
        cs: "Čeština (Czech)",
        da: "Dansk (Danish)",
        de: "Deutsch (German)",
        el: "Ελληνικά (Greek)",
        "en-GB": "English/UK",
        es: "Español (Spanish)",
        "es-AR": "Español/Argentina (Spanish/Argentina)",
        eo: "Esperanto",
        et: "eesti keel (Estonian)",
        eu: "Euskara (Basque)",
        fa: "&#8235;فارسی&#8236; (Farsi/Persian)",
        fo: "Føroyskt (Faroese)",
        fr: "Français (French)",
        "fr-CH": "Français de Suisse (French/Swiss)",
        gl: "Galego (Galician)",
        sq: "Gjuha shqipe (Albanian)",
        gu: "ગુજરાતી (Gujarati)",
        ko: "한국어 (Korean)",
        he: "&#8235;עברית&#8236; (Hebrew)",
        hr: "Hrvatski jezik (Croatian)",
        hy: "Հայերեն (Armenian)",
        is: "Íslenska (Icelandic)",
        it: "Italiano (Italian)",
        lv: "Latviešu Valoda (Latvian)",
        lt: "lietuvių kalba (Lithuanian)",
        mk: "македонски јазик (Macedonian)",
        hu: "Magyar (Hungarian)",
        me: "Montenegrin (Црногорски језик)",
        "me-ME": "Montenegrin (Crnogorski jezik)",
        nl: "Nederlands (Dutch)",
        ja: "日本語 (Japanese)",
        nb: "Norsk (Norwegian)",
        th: "ภาษาไทย (Thai)",
        pl: "Polski (Polish)",
        "pt-BR": "Português (Portuguese/Brazilian)",
        ro: "Română (Romanian)",
        ru: "Русский (Russian)",
        "de-CH": "Schweizerdeutsch (Swiss-German)",
        sk: "Slovenčina (Slovak)",
        sl: "Slovenski Jezik (Slovenian)",
        sr: "српски језик (Serbian)",
        "sr-SR": "srpski jezik (Serbian)",
        fi: "suomi (Finnish)",
        sv: "Svenska (Swedish)",
        ta: "தமிழ் (Tamil)",
        vi: "Tiếng Việt (Vietnamese)",
        tr: "Türkçe (Turkish)",
        ur: "&#8235;اُردوُ&#8236;( Urdu)",
        uk: "Українська (Ukranian)",
        "zh-HK": "繁體中文 (Chinese Hong Kong)",
        "zh-CN": "简体中文 (Chinese Simplified)",
        "zh-TW": "繁體中文 (Chinese Traditional)"
    },
    taiwan: {
        "": "Default (English)",
        "zh-TW": "繁體中文 (Chinese Traditional)"
    },
    thai: {
        "": "Default (English)",
        th: "ภาษาไทย (Thai)"
    },
    persian: {
        "": "Default (English)",
        fa: "&#8235;فارسی&#8236; (Farsi/Persian)"
    },
    islamic: {
        "": "Default (English)",
        ar: "&#8235;العربية&#8236; (Arabic)"
    },
    hebrew: {
        "": "Default (English)",
        he: "&#8235;עברית&#8236; (Hebrew)"
    },
    ethiopian: {
        "": "Default (English)",
        am: "አማርኛ (Amharic)"
    },
    coptic: {
        "": "Default (English)"
    },
    mayan: {
        "": "Default (English)"
    }
};
var _calendarArrivalInstance = null;
var _calendarDepartureInstance = null;
var _calendarInstance = null;
var _nightsDropDownId;
var _maxLOS;
var _unavailableDays;
var _calendarMonths;
var _calendarMaxNights;
var _calendarHiddenButtonId;
var _calendarResetArrival;
var _calendarResetDeparture;
var _ignoreDateChange = false;
var _isDayClickedEvent = false;
var _isOddMouseClick = true;
var _isCalendarSetOnLoad;
var _arrivalDatePickerId;
var _departureDatePickerId;
var _availabilityCalendarId;
var _availabilityDates;
var _minStayArrivalDates;
var _maxStayArrivalDates;
var _noArrivalDates;
var _noDepartureDates;
var _closedDates;
var _datesWithPrices;
var _optionalFieldValidations;
var _isOnChangeDatePickerDepartureControl = false;
var _invalidArrivalDateId;
var _invalidDepartureDateId;
var _hotelDDLid;
var _roomsDDLid;
var _adultsDDLid;
var _childDDLid;
var _checkAvailHLid;
var _groupTBid;
var _promoTBid;
var _iataTBid;
var _templateCodeHFid;
var _shellCodeHFid;
var _langHFid;
var _hotelHFid;
var _hotelGroupHFid;
var _rateCodeHFid;
var _roomCodeHFid;
var _viewIds;
var _hotelIds;
var _tripSummaryMaxLOS;
var _SkipOnChangeMonthYear;
var _previousArrivalDate;
var _isOnChangeNummberOfNights = false;
var _calendarLosLegendControlId = "";
var _calendarLosLegendText = "";
var _firstMonthInDisplay;
var _firstMonthYearInDisplay;
var _drawMonthsInDisplay;
var _minDate;
var _isSetOnDatePicker;
var _tripSummary = {};
var _isRateFilterDropDown;
var _legendClientId = "";
var _productSortingHFid;
var _totalPriceLabelClientId = "";
var _roomsText = "";
var _totalPriceNumberRoomsLabelClientId = "";

function DateAvailabilityLabels() {
    this.IsEnabled = false;
    this.Closed = "";
    this.NoArrival = "";
    this.NoDeparture = "";
    this.MinStay = "";
    this.MaxStay = ""
}
var _DateAvailabilityLabels = new DateAvailabilityLabels();

function SetDateAvailabilityLabels(e, b, a, d, c, f) {
    _DateAvailabilityLabels.IsEnabled = e;
    _DateAvailabilityLabels.Closed = b;
    _DateAvailabilityLabels.NoArrival = a;
    _DateAvailabilityLabels.NoDeparture = d;
    _DateAvailabilityLabels.MinStay = c;
    _DateAvailabilityLabels.MaxStay = f
}

function CriteriaControlIds() {
    this.QtyControlId = "";
    this.AdultsDropdownId = "";
    this.ChildrenDropdownId = "";
    this.RoomsDropdownId = "";
    this.NightsDropdownId = "";
    this.RateFilterDropDownId = "";
    this.GroupCodeTextboxId = "";
    this.PromoCodeTextboxId = "";
    this.IataNumberTextboxId = "";
    this.RoomTypeFilterHiddenId = "";
    this.RoomFeatureFilterHiddenId = "";
    this.RatesFilterHiddenId = "";
    this.ChildrenAgesHiddenFieldClientId = "";
    this.GroupCodeErrLabelId = "";
    this.PromoCodeErrLabelId = "";
    this.IataNumberErrLabelId = ""
}
var _CriteriaControlIds = null;

function SetCriteriaControlIds(k, h, l, i, d, b, a, c, m, f, n, g, e, p, o, j) {
    _CriteriaControlIds = new CriteriaControlIds();
    _CriteriaControlIds.QtyControlId = k;
    _CriteriaControlIds.AdultsDropdownId = h;
    _CriteriaControlIds.ChildrenDropdownId = l;
    _CriteriaControlIds.RoomsDropdownId = i;
    _CriteriaControlIds.NightsDropdownId = d;
    _CriteriaControlIds.RateFilterDropDownId = b;
    _CriteriaControlIds.GroupCodeTextboxId = a;
    _CriteriaControlIds.PromoCodeTextboxId = c;
    _CriteriaControlIds.IataNumberTextboxId = m;
    _CriteriaControlIds.RoomTypeFilterHiddenId = f;
    _CriteriaControlIds.RoomFeatureFilterHiddenId = n;
    _CriteriaControlIds.RatesFilterHiddenId = g;
    _CriteriaControlIds.ChildrenAgesHiddenFieldClientId = e;
    _CriteriaControlIds.GroupCodeErrLabelId = p;
    _CriteriaControlIds.PromoCodeErrLabelId = o;
    _CriteriaControlIds.IataNumberErrLabelId = j
}

function NewCDate(a, b) {
    if (b == null) {
        return jQuery.calendars.newDate(a)
    } else {
        return b.newDate(a)
    }
}

function AvailabilityCalendarOnSelect(c) {
    if (_isOnChangeNummberOfNights) {
        return
    }
    var l = jQuery(this).data("calendarsPicker");
    var s = l.prevDate;
    var u = false;
    try {
        var h = jQuery(l.settings.altField);
        var e = h.val();
        if ((c.length > 0 && typeof (s) != "undefined") && !_isSetOnDatePicker) {
            _isDayClickedEvent = true;
            if (_isOnChangeDatePickerDepartureControl) {
                var f = false;
                _isCalendarSetOnLoad = f;
                _isDayClickedEvent = f;
                _isOddMouseClick = f;
                _isOnChangeDatePickerDepartureControl = f
            } else {
                if (_isOddMouseClick) {
                    if (c.length > 0) {
                        var j = null;
                        var n = null;
                        var x = null;
                        if (c.length == 3 && !_isCalendarSetOnLoad) {
                            var y = NewCDate(l.drawDate, _calendarInstance);
                            var r = NewCDate(c[0], _calendarInstance);
                            var p = NewCDate(c[2], _calendarInstance);
                            if (y.compareTo(r) == 0 && y.compareTo(p) == -1) {
                                n = NewCDate(p, _calendarInstance);
                                j = NewCDate(p.add(1, "d"), _calendarInstance);
                                _isOddMouseClick = false
                            }
                            if (n == null && j == null) {
                                var o = NewCDate(c[(c.length - 1)], _calendarInstance);
                                var i = NewCDate(c[(c.length - 1)], _calendarInstance).add(1, "d");
                                n = o;
                                j = i;
                                _isOddMouseClick = false
                            }
                            u = true
                        } else {
                            if (_isCalendarSetOnLoad) {
                                n = NewCDate(c[0], _calendarInstance);
                                x = NewCDate(c[0], _calendarInstance);
                                if (x.compareTo(c[(c.length - 1)]) == 0) {
                                    j = NewCDate(x.add(1, "d"), _calendarInstance)
                                } else {
                                    j = NewCDate(c[(c.length - 1)], _calendarInstance)
                                }
                                u = (c[0].compareTo(c[(c.length - 1)]) == -1)
                            } else {
                                if (c.length > 3) {
                                    var g = jQuery(_arrivalDatePickerId).data("calendarsPicker").drawDate;
                                    var w = NewCDate(c[0], _calendarInstance);
                                    var k = NewCDate(c[c.length - 2], _calendarInstance);
                                    var a = NewCDate(c[c.length - 1], _calendarInstance);
                                    var b = (g.compareTo(w) == 0) ? GetDateClicked(c, true) : (a.compareTo(k)) == -1 ? a : GetDateClicked(c, true);
                                    if (b == null) {
                                        b = a
                                    }
                                    x = NewCDate(b, _calendarInstance);
                                    n = NewCDate(b, _calendarInstance);
                                    j = NewCDate(x.add(1, "d"), _calendarInstance)
                                } else {
                                    if (c.length == 1) {
                                        var m = NewCDate(c[0], _calendarInstance);
                                        var q = NewCDate(c[0], _calendarInstance);
                                        switch (m.compareTo(_previousArrivalDate)) {
                                            case -1:
                                                n = NewCDate(_previousArrivalDate, _calendarInstance);
                                                j = NewCDate(_previousArrivalDate.add(1, "d"), _calendarInstance);
                                                break;
                                            case 0:
                                                n = NewCDate(q.add(1, "d"), _calendarInstance);
                                                j = NewCDate(m.add(2, "d"), _calendarInstance);
                                                _isOddMouseClick = false;
                                                break;
                                            case 1:
                                                n = NewCDate(q.add(-1, "d"), _calendarInstance);
                                                j = NewCDate(m, _calendarInstance);
                                                _isOddMouseClick = false;
                                                break
                                        }
                                    } else {
                                        if (c.length == 2) {
                                            var b = null;
                                            var w = NewCDate(c[0], _calendarInstance);
                                            var k = NewCDate(c[1], _calendarInstance);
                                            if (w.compareTo(k) == -1) {
                                                var i = NewCDate(w.add(1, "d"), _calendarInstance);
                                                switch (i.compareTo(k)) {
                                                    case -1:
                                                        b = NewCDate(i, _calendarInstance);
                                                        break;
                                                    case 0:
                                                        var g = jQuery(_arrivalDatePickerId).data("calendarsPicker").drawDate;
                                                        var v = jQuery(_departureDatePickerId).data("calendarsPicker").drawDate;
                                                        if (g.compareTo(c[0]) == 0 && v.compareTo(k) == 1) {
                                                            b = NewCDate(v, _calendarInstance)
                                                        } else {
                                                            b = NewCDate(g, _calendarInstance)
                                                        }
                                                        break
                                                }
                                            }
                                            x = NewCDate(b, _calendarInstance);
                                            n = NewCDate(b, _calendarInstance);
                                            j = NewCDate(x.add(1, "d"), _calendarInstance)
                                        }
                                    }
                                }
                                u = true
                            }
                        }
                        if (u && (n != null && j != null)) {
                            SetAvailabilityCalendarDates(_availabilityCalendarId, n, ValidateDepartureDate(n, j))
                        }
                        if (n != null && j != null) {
                            CriteriaSetControls(n, ValidateDepartureDate(n, j), false)
                        }
                    }
                    _isDayClickedEvent = _isCalendarSetOnLoad;
                    _isOddMouseClick = _isCalendarSetOnLoad;
                    _isCalendarSetOnLoad = false
                } else {
                    _isOddMouseClick = true;
                    _isDayClickedEvent = false;
                    var n = null;
                    var j = null;
                    if (c.length == 1) {
                        var m = NewCDate(c[0], _calendarInstance);
                        var q = NewCDate(c[0], _calendarInstance);
                        switch (m.compareTo(_previousArrivalDate)) {
                            case -1:
                                n = NewCDate(_previousArrivalDate, _calendarInstance);
                                j = NewCDate(_previousArrivalDate.add(1, "d"), _calendarInstance);
                                break;
                            case 0:
                                n = NewCDate(m.add(1, "d"), _calendarInstance);
                                j = NewCDate(c[0].add(2, "d"), _calendarInstance);
                                _isOddMouseClick = false;
                                break;
                            case 1:
                                n = NewCDate(q.add(-1, "d"), _calendarInstance);
                                j = NewCDate(m, _calendarInstance);
                                _isOddMouseClick = false;
                                break
                        }
                    } else {
                        if (c.length >= 3) {
                            var d = NewCDate(c[0], _calendarInstance);
                            var b = NewCDate(c[c.length - 1], _calendarInstance);
                            var q = NewCDate(c[c.length - 1], _calendarInstance);
                            switch (b.compareTo(d)) {
                                case -1:
                                    n = q;
                                    j = NewCDate(b.add(1, "d"), _calendarInstance);
                                    _isOddMouseClick = false;
                                    break;
                                case 0:
                                    n = NewCDate(b, _calendarInstance);
                                    j = NewCDate(d.add(1, "d"), _calendarInstance);
                                    _isOddMouseClick = false;
                                    break;
                                case 1:
                                    n = NewCDate(d, _calendarInstance);
                                    j = NewCDate(b, _calendarInstance);
                                    break
                            }
                        }
                    }
                    if (n != null && j != null) {
                        var z = ValidateDepartureDate(n, j);
                        SetAvailabilityCalendarDates(_availabilityCalendarId, n, z);
                        CriteriaSetControls(n, z, false)
                    }
                }
            }
        }
    } catch (t) {
        LogError(t, "AvailabilityCalendarOnSelect", id)
    }
}

function GetDateClicked(e, g) {
    var h = null;
    var d = 0;
    var f = e.length;
    for (var c = 0; c < f; c++) {
        var a = e[c];
        if (d != 0 && d != a.day()) {
            if ((d < a.day()) && (c != (e.length - 1))) {
                h = _calendarInstance.newDate(a.year(), a.month(), d)
            } else {
                if ((d > a.day()) && (c != (e.length - 1))) {
                    h = NewCDate(a.add(-1, "d"), _calendarInstance)
                } else {
                    if ((f == 3) || ((d < a.day()) && (c == (e.length - 1)))) {
                        h = a
                    }
                }
            }
            break
        }
        if (c != (e.length - 1)) {
            d = (a.day() + 1);
            var b = a.daysInMonth();
            if (d > b) {
                d = (d - b)
            }
        }
    }
    return (h == null) ? ((g) ? null : e[e.length - 1].add(1, "d")) : h
}

function DatePickerArrivalOnSelect(j) {
    if (!_ignoreDateChange) {
        try {
            var f = j[0];
            _previousArrivalDate = f;
            var l = jQuery(this).data("calendarsPicker");
            var g = l.prevDate;
            var e = jQuery(jQuery.format("#{0}_HiddenSelectedDate", this.id));
            e.val(jQuery.format("{0}|{1}|{2}", f.month(), f.day(), f.year()));
            var c = _calendarArrivalInstance.newDate(f.year(), f.month(), f.day());
            c = c.add(1, "d");
            var k = jQuery.format("#{0}", this.id.replace(/Arrival/i, "Departure"));
            var i = jQuery(k).data("calendarsPicker");
            var a = i.prevDate;
            var d = jQuery(k).calendarsPicker("getDate");
            var m = null;
            if (l.settings.isTripModify) {
                if (d.length > 0) {
                    m = d[0]
                } else {
                    m = f.add(1, "d")
                }
                if (GetNumberOfNights(f, m) == (_maxLOS - 1)) {
                    jQuery(k).calendarsPicker("setDate", f.add((_maxLOS - 1), "d"))
                } else {
                    jQuery(k).calendarsPicker("setDate", m)
                }
                return
            }
            if (l.settings.isTripSummary) {
                if (d.length > 0) {
                    m = d[0]
                } else {
                    m = f.add(1, "d")
                }
                var b = null;
                if (f.compareTo(m) != -1) {
                    b = m.add(1, "d")
                } else {
                    b = m
                }
                if (GetNumberOfNights(f, b) == (_tripSummaryMaxLOS - 1)) {
                    jQuery(k).calendarsPicker("setDate", f.add((_tripSummaryMaxLOS - 1), "d"))
                } else {
                    jQuery(k).calendarsPicker("setDate", b)
                }
                return
            }
            if (d.length > 0) {
                m = d[0];
                if (m.compareTo(f) != 1) {
                    jQuery(k).calendarsPicker("setDate", c);
                    return
                }
            }
            if (l.settings.isCalendarDisplayed) {
                if (a == null) {
                    jQuery(k).calendarsPicker("setDate", c);
                    return
                }
                if (f.compareTo(a) != -1) {
                    jQuery(k).calendarsPicker("setDate", c);
                    return
                }
                if ((m != null) && (typeof (_availabilityCalendarId) != "undefined")) {
                    _isSetOnDatePicker = true;
                    SetAvailabilityCalendarDates(_availabilityCalendarId, f, ValidateDepartureDate(f, m));
                    _isSetOnDatePicker = false
                }
            }
            if (l.settings.isNightsDropdownDisplayed) {
                UpdateNumberOfNightsDropdownControl()
            }
        } catch (h) {
            LogError(h, "onSelect", this.id)
        }
    }
}

function DatePickerDepartureOnSelect(c) {
    if (!_ignoreDateChange) {
        try {
            var n = null;
            var m = null;
            var a = c[0];
            var t = jQuery(this).data("calendarsPicker");
            var l = t.prevDate;
            var j = jQuery(jQuery.format("#{0}_HiddenSelectedDate", this.id));
            var p = jQuery.format("#{0}", this.id.replace(/Departure/i, "Arrival"));
            var k = jQuery(jQuery.format("#{0}_HiddenSelectedDate", this.id.replace(/Departure/i, "Arrival"))).val().split("|");
            var q = jQuery(p).data("calendarsPicker");
            var h = jQuery(p).calendarsPicker("getDate")[0];
            var o = false;
            if (q.settings.minDate.compareTo(a) == 0) {
                n = NewCDate(q.settings.minDate);
                jQuery(p).calendarsPicker("setDate", n);
                var d = n.add(1, "d");
                jQuery(jQuery.format("#{0}", this.id)).calendarsPicker("setDate", d);
                j.val(jQuery.format("{0}|{1}|{2}", d.month(), d.day(), d.year()));
                m = d;
                o = true
            }
            if (t.settings.isTripSummary) {
                m = a;
                var b = q.settings.minDate;
                if (h.compareTo(a) != -1) {
                    b = a.add(-1, "d");
                    jQuery(p).calendarsPicker("setDate", b)
                }
                if (GetNumberOfNights(b, m) == (_tripSummaryMaxLOS - 1)) {
                    jQuery(jQuery.format("#{0}", this.id)).calendarsPicker("setDate", b.add((_tripSummaryMaxLOS - 1), "d"))
                }
                return
            }
            var s = false;
            if (!o) {
                switch (a.compareTo(h)) {
                    case -1:
                        var i = a.add(-1, "d");
                        n = i;
                        jQuery(p).calendarsPicker("setDate", i);
                        j.val(jQuery.format("{0}|{1}|{2}", a.month(), a.day(), a.year()));
                        m = a;
                        break;
                    case 0:
                        h = _calendarArrivalInstance.newDate(parseInt(k[2]), parseInt(k[0]), parseInt(k[1]));
                        n = h;
                        if (a.compareTo(h) != 1) {
                            var d = h.add(1, "d");
                            jQuery(jQuery.format("#{0}", this.id)).calendarsPicker("setDate", d);
                            j.val(jQuery.format("{0}|{1}|{2}", d.month(), d.day(), d.year()));
                            m = d
                        } else {
                            var f = jQuery(jQuery.format("#{0}", this.id)).calendarsPicker("getDate");
                            if (f.length == 1) {
                                m = f[0]
                            }
                        }
                        break;
                    default:
                        n = NewCDate(q.selectedDates[0], _calendarArrivalInstance);
                        var b = q.selectedDates[0];
                        var e = 1;
                        if (typeof (_calendarMaxNights) == "undefined") {
                            e = _maxLOS
                        } else {
                            e = _calendarMaxNights
                        }
                        if (GetNumberOfNights(b, a) == (e - 1)) {
                            m = b.add((e - 1), "d");
                            s = true;
                            _isOnChangeNummberOfNights = true
                        } else {
                            m = a
                        }
                        break
                }
            }
            var g = (n != null && m != null);
            if (g && (t.settings.isCalendarDisplayed) && (typeof (_availabilityCalendarId) != "undefined")) {
                if (s) {
                    _isOnChangeDatePickerDepartureControl = true
                }
                _isSetOnDatePicker = true;
                SetAvailabilityCalendarDates(_availabilityCalendarId, n, ValidateDepartureDate(n, m));
                _isSetOnDatePicker = false;
                if (s) {
                    _isOnChangeNummberOfNights = false;
                    CriteriaSetControls(n, ValidateDepartureDate(n, m), false)
                }
            } else {
                if (g && s) {
                    _isOnChangeNummberOfNights = false;
                    CriteriaSetControls(n, m, false)
                }
            }
            if (t.settings.isNightsDropdownDisplayed) {
                UpdateNumberOfNightsDropdownControl(n, m)
            }
        } catch (r) {
            LogError(r, "onSelect", this.id)
        }
    }
}

function AvailabilityCalendarOnChangeMonthYear(k, r) {
    try {
        if (_legendClientId.length > 0) {
            jQuery(_legendClientId).hide()
        }
        _firstMonthInDisplay = r;
        _firstMonthYearInDisplay = k;
        var s = [];
        var l = 0;
        for (var f = 0; f < _drawMonthsInDisplay.length; f++) {
            var n = _drawMonthsInDisplay[f];
            if ((_minDate.month() == r && _minDate.year() == k) && n == _minDate.month()) {
                l = _minDate.month()
            }
        }
        var g = 0;
        while (g < _drawMonthsInDisplay.length) {
            if (l != 0) {
                s.push(l + g)
            } else {
                s.push(r + g)
            }
            g++
        }
        _drawMonthsInDisplay = s;
        var j = "input[id$={0}]";
        var m = "select[id$={0}]";
        var e = {};
        e.year = k;
        e.month = r;
        if (_CriteriaControlIds.QtyControlId == null || typeof (_CriteriaControlIds.QtyControlId) == "undefined") {
            _CriteriaControlIds.QtyControlId = "*"
        }
        if (_CriteriaControlIds.QtyControlId.indexOf("*") == -1) {
            var a = GetQuantitiesData(_CriteriaControlIds.QtyControlId);
            var u = 0;
            var b = 0;
            var d = "";
            for (var o = 0; o < a.length; o++) {
                var q = a[o];
                u += q.AdultQty;
                b += q.ChildrenQty;
                if (q.ChildAges.length > 0) {
                    d += q.ChildAges + ","
                }
            }
            if (d.length > 0) {
                d = d.substring(0, d.length - 1)
            }
            e.adults = u;
            e.children = b;
            e.childrenAges = d
        } else {
            e.adults = _CriteriaControlIds.AdultsDropdownId.indexOf("*") == -1 ? tryParseInt(jQuery(jQuery.format(m, _CriteriaControlIds.AdultsDropdownId)).val()) : 0;
            e.children = _CriteriaControlIds.ChildrenDropdownId.indexOf("*") == -1 ? tryParseInt(jQuery(jQuery.format(m, _CriteriaControlIds.ChildrenDropdownId)).val()) : 0;
            e.childrenAges = _CriteriaControlIds.ChildrenAgesHiddenFieldClientId.indexOf("*") == -1 ? jQuery(jQuery.format(j, _CriteriaControlIds.ChildrenAgesHiddenFieldClientId)).val() : ""
        }
        e.rooms = _CriteriaControlIds.RoomsDropdownId.indexOf("*") == -1 ? tryParseInt(jQuery(jQuery.format(m, _CriteriaControlIds.RoomsDropdownId)).val()) : 0;
        e.groupCode = _CriteriaControlIds.GroupCodeTextboxId.indexOf("*") == -1 ? jQuery(jQuery.format(j, _CriteriaControlIds.GroupCodeTextboxId)).val() : 0;
        e.corporatePromotionCode = _CriteriaControlIds.PromoCodeTextboxId.indexOf("*") == -1 ? jQuery(jQuery.format(j, _CriteriaControlIds.PromoCodeTextboxId)).val() : 0;
        e.travelIndustryCode = _CriteriaControlIds.IataNumberTextboxId.indexOf("*") == -1 ? jQuery(jQuery.format(j, _CriteriaControlIds.IataNumberTextboxId)).val() : 0;
        e.numberOfMonths = _calendarMonths;
        e.nights = XbeState.numberOfNights;
        e.hotelId = XbeState.hotelId;
        e.hotelGroupId = XbeState.hotelGroupId;
        e.hotelGuid = XbeState.hotelGuid;
        e.hotelGroupGuid = XbeState.hotelGroupGuid;
        e.primaryChannelId = XbeState.primaryChannelId;
        e.secondaryChannelId = XbeState.secondaryChannelId;
        e.customerUniqueId = XbeState.customerUniqueId;
        e.BookerUniqueId = XbeState.bookerUniqueId;
        e.templateInstanceUniqueId = XbeState.templateInstanceUniqueId;
        e.roomTypeFilterCodes = _CriteriaControlIds.RoomTypeFilterHiddenId.indexOf("*") == -1 ? jQuery(jQuery.format("#{0}", _CriteriaControlIds.RoomTypeFilterHiddenId)).val() : "";
        if (_isRateFilterDropDown == true) {
            e.rateFilterCodes = _CriteriaControlIds.RateFilterDropDownId.indexOf("*") == -1 ? jQuery(jQuery.format(m, _CriteriaControlIds.RateFilterDropDownId)).val() : ""
        } else {
            e.rateFilterCodes = _CriteriaControlIds.RatesFilterHiddenId.indexOf("*") == -1 ? jQuery(jQuery.format("#{0}", _CriteriaControlIds.RatesFilterHiddenId)).val() : ""
        }
        if (e.rateFilterCodes == "0") {
            e.rateFilterCodes = ""
        }
        e.isRequireFilter = XbeState.isFilterRequired;
        e.includeUnassignedRatesInRateFilters = XbeState.includeUnassignedRateFilter;
        e.hideAssignedRatesOnEmptyFilter = XbeState.hideAssignedRatesOnEmptyFilter;
        e.requestedNewRates = XbeState.requestedNewRates;
        e.roomTypeFilterCodes = XbeState.requestedRooms;
        e.userLocationCode = XbeState.userLocationCode;
        e.arrivalTicks = XbeState.arrivalDate;
        e.departureTicks = XbeState.departureDate;
        e.calculatePricing = XbeState.calculatePricing;
        e.includeTaxesInPricingCalculation = XbeState.includeTaxesInPricing;
        e.showPriceAmount = XbeState.showPriceAmount;
        e.calendarRate = XbeState.calendarRate;
        e.currencyDisplayId = XbeState.currencyDisplayId;
        e.restrictions = XbeState.restrictions;
        e.losUsedByCalendar = XbeState.losUsedByCalendar;
        e.membershipLevel = XbeState.membershipLevel;
        e.certificates = XbeState.certificates;
        e.confirmNumber = Xbe.State.confirmNumber;
        e.isSoaEnabled = getQueryStringParameterByName("soa");
        e.dayCellStyleSuffix = XbeState.dayCellStyleSuffix;
        e.highlightWeekendsAndHolidays = XbeState.highlightWeekendsAndHolidays;
        e.weekendDefinition = XbeState.weekendDefinition;
        e.forceDisplayPricing = XbeState.forceDisplayPricing;
        e.localCalId = XbeState.localCalId;
        var h = {
            criteria: e
        };
        var c = jQuery.format("{0}services/XbeService.asmx/GetCalendarAvailability", getAbsolutePath());
        var t = JSON.stringify(h);
        jQuery.ajax({
            type: "POST",
            url: c,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: t,
            async: false,
            success: HandleCalendarAvailabilityOnChangeMonthYear,
            error: HandleCalendarAvailabilityOnChangeMonthYearFailure
        })
    } catch (p) {
        LogError(p, "OnChangeMonthYear", this.id)
    }
}

function getQueryStringParameterByName(b) {
    b = b.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var a = "[\\?&]" + b + "=([^&#]*)";
    var d = new RegExp(a);
    var c = d.exec(window.location.search);
    if (c == null) {
        return ""
    } else {
        return decodeURIComponent(c[1].replace(/\+/g, " "))
    }
}

function HandleCalendarAvailabilityOnChangeMonthYear(availability) {
    var results = availability.d;
    _optionalFieldValidations = results[0].split(",");
    _availabilityDates = eval(results[1]);
    _minStayArrivalDates = eval(results[2]);
    _maxStayArrivalDates = eval(results[3]);
    _noArrivalDates = eval(results[4]);
    _noDepartureDates = eval(results[5]);
    _closedDates = eval(results[6]);
    _datesWithPrices = eval(results[7]);
    var invalidGrpLabel = _CriteriaControlIds.GroupCodeErrLabelId.indexOf("*") == -1 ? JQControl(null, _CriteriaControlIds.GroupCodeErrLabelId) : "";
    var invalidPromoLabel = _CriteriaControlIds.PromoCodeErrLabelId.indexOf("*") == -1 ? JQControl(null, _CriteriaControlIds.PromoCodeErrLabelId) : "";
    var invalidIataLabel = _CriteriaControlIds.IataNumberErrLabelId.indexOf("*") == -1 ? JQControl(null, _CriteriaControlIds.IataNumberErrLabelId) : "";
    if (invalidGrpLabel == "" && invalidPromoLabel == "" && invalidIataLabel == "") {
        return
    }
    if (_optionalFieldValidations[0] != "true") {
        invalidGrpLabel.show()
    } else {
        if (invalidGrpLabel.length == 1) {
            invalidGrpLabel.hide()
        }
    }
    if (_optionalFieldValidations[1] != "true") {
        invalidPromoLabel.show()
    } else {
        if (invalidPromoLabel.length == 1) {
            invalidPromoLabel.hide()
        }
    }
    if (_optionalFieldValidations[2] != "true") {
        invalidIataLabel.show()
    } else {
        if (invalidIataLabel.length == 1) {
            invalidIataLabel.hide()
        }
    }
    if (_legendClientId.length > 0) {
        jQuery(_legendClientId).show()
    }
}

function HandleCalendarAvailabilityOnChangeMonthYearFailure(a) {
    if (a.status == "0" && /Chrome/.test(navigator.userAgent)) {
        MakeChromeBackupCalendarCall();
        return
    }
    displayMessage("HandleCalendarAvailabilityOnChangeMonthYearFailure", jQuery.format("{0} {1}", a.status, a.statusText), null, 4, null)
}

function MakeChromeBackupCalendarCall() {
    var a = "AvailabilityCalendarOnChangeMonthYear(_firstMonthYearInDisplay, _firstMonthInDisplay); SetAvailabilityCalendarDates(_availabilityCalendarId, NewCDate(jQuery(_arrivalDatePickerId).calendarsPicker('getDate')[0], _calendarArrivalInstance), NewCDate(jQuery(_departureDatePickerId).calendarsPicker('getDate')[0], _calendarDepartureInstance));";
    setTimeout(a, 1000)
}

function SetCalendarDisplay(b, e) {
    var d = jQuery(this).data("calendarsPicker").settings.minDate;
    try {
        if (e) {
            if (b.compareTo(d) != -1) {
                if (typeof (_availabilityDates) != "undefined") {
                    for (var a = 0; a < _availabilityDates.length; a++) {
                        if (b.month() == _availabilityDates[a][0] && b.day() == _availabilityDates[a][1]) {
                            return {
                                dateClass: _availabilityDates[a][2],
                                selectable: true,
                                price: _availabilityDates[a][3],
                                title: GetDateAvailabilityTitle(_availabilityDates[a])
                            }
                        }
                    }
                }
                if (typeof (_minStayArrivalDates) != "undefined") {
                    for (var a = 0; a < _minStayArrivalDates.length; a++) {
                        if (b.month() == _minStayArrivalDates[a][0] && b.day() == _minStayArrivalDates[a][1]) {
                            return {
                                dateClass: _minStayArrivalDates[a][2],
                                selectable: true,
                                price: _minStayArrivalDates[a][3],
                                title: GetDateAvailabilityTitle(_minStayArrivalDates[a])
                            }
                        }
                    }
                }
                if (typeof (_maxStayArrivalDates) != "undefined") {
                    for (var a = 0; a < _maxStayArrivalDates.length; a++) {
                        if (b.month() == _maxStayArrivalDates[a][0] && b.day() == _maxStayArrivalDates[a][1]) {
                            return {
                                dateClass: _maxStayArrivalDates[a][2],
                                selectable: true,
                                price: _maxStayArrivalDates[a][3],
                                title: GetDateAvailabilityTitle(_maxStayArrivalDates[a])
                            }
                        }
                    }
                }
                if (typeof (_noArrivalDates) != "undefined") {
                    for (var a = 0; a < _noArrivalDates.length; a++) {
                        if (b.month() == _noArrivalDates[a][0] && b.day() == _noArrivalDates[a][1]) {
                            return {
                                dateClass: _noArrivalDates[a][2],
                                selectable: true,
                                price: _noArrivalDates[a][3],
                                title: GetDateAvailabilityTitle(_noArrivalDates[a])
                            }
                        }
                    }
                }
                if (typeof (_noDepartureDates) != "undefined") {
                    for (var a = 0; a < _noDepartureDates.length; a++) {
                        if (b.month() == _noDepartureDates[a][0] && b.day() == _noDepartureDates[a][1]) {
                            return {
                                dateClass: _noDepartureDates[a][2],
                                selectable: true,
                                price: _noDepartureDates[a][3],
                                title: GetDateAvailabilityTitle(_noDepartureDates[a])
                            }
                        }
                    }
                }
                if (typeof (_closedDates) != "undefined") {
                    for (var a = 0; a < _closedDates.length; a++) {
                        if (b.month() == _closedDates[a][0] && b.day() == _closedDates[a][1]) {
                            return {
                                dateClass: _closedDates[a][2],
                                selectable: true,
                                title: GetDateAvailabilityTitle(_closedDates[a])
                            }
                        }
                    }
                }
            }
        }
    } catch (c) {
        LogError(c, "SetCalendarDisplay", this.id)
    }
    return {}
}

function GetDateAvailabilityTitle(b) {
    var c = b[4];
    var a = "";
    if (c == "MinStayArrive") {
        a = _DateAvailabilityLabels.MinStay
    } else {
        if (c == "MaxStayArrive") {
            a = _DateAvailabilityLabels.MaxStay
        } else {
            if (c == "NoArrive") {
                a = _DateAvailabilityLabels.NoArrival
            } else {
                if (c == "NoDeparture") {
                    a = _DateAvailabilityLabels.NoDeparture
                } else {
                    if (c == "Closed") {
                        a = _DateAvailabilityLabels.Closed
                    }
                }
            }
        }
    }
    if (_DateAvailabilityLabels.IsEnabled && a.length > 0) {
        return a.replace(/\{0\}/, b[5])
    } else {
        return null
    }
}

function SetAvailabilityCalendarDates(b, c, e) {
    try {
        jQuery(b).calendarsPicker("clear");
        var d = GetCalendarSelectedDates(c, e);
        _previousArrivalDate = c;
        jQuery(b).calendarsPicker("setDate", d, e)
    } catch (a) {
        LogError(a, "SetAvailabilityCalendarDates", b)
    }
}

function ValidateDepartureDate(d, f) {
    var e = [];
    var a = NewCDate(d, _calendarInstance);
    var c = null;
    var b = 0;
    while (a.compareTo(f) != 1) {
        e.push(NewCDate(a, _calendarInstance));
        a = a.add(1, "d");
        if (b == (_calendarMaxNights - 1)) {
            c = NewCDate(e[b], _calendarInstance);
            break
        }
        b += 1
    }
    return (c == null) ? f : c
}

function GetCalendarSelectedDates(b, d) {
    var c = [];
    var a = NewCDate(b, _calendarInstance);
    while (a.compareTo(d) != 1) {
        c.push(NewCDate(a, _calendarInstance));
        a = a.add(1, "d")
    }
    return c
}

function UpdateNumberOfNightsDropdownControl(b, h) {
    var a = 1;
    try {
        var e = null;
        var g = null;
        if (b == null || typeof (b) == "undefined") {
            if (typeof (_arrivalDatePickerId) != "undefined") {
                e = jQuery(_arrivalDatePickerId).calendarsPicker("getDate")[0]
            }
        } else {
            e = b
        }
        if (h == null || typeof (h) == "undefined") {
            if (typeof (_departureDatePickerId) != "undefined") {
                g = jQuery(_departureDatePickerId).calendarsPicker("getDate")[0]
            } else {
                return
            }
        } else {
            g = h
        }
        a = GetNumberOfNights(e, g);
        if (typeof (_nightsDropDownId) != "undefined") {
            var f = jQuery(jQuery.format("#{0}", _nightsDropDownId));
            var d = false;
            jQuery(jQuery.format("#{0} option", _nightsDropDownId)).each(function (i, j) {
                if (parseInt(j.value) == a) {
                    d = true
                }
            });
            if (d) {
                f.val(a)
            }
        }
    } catch (c) {
        LogError(c, "UpdateNumberOfNightsDropdownControl", "Calendar")
    }
    UpdateLegendText(a)
}

function CriteriaSetControls(b, c, a) {
    jQuery(jQuery.format("#{0}", _invalidArrivalDateId)).css({
        display: "none"
    });
    jQuery(jQuery.format("#{0}", _invalidDepartureDateId)).css({
        display: "none"
    });
    _ignoreDateChange = true;
    jQuery(_arrivalDatePickerId).calendarsPicker("setDate", b);
    jQuery(_departureDatePickerId).calendarsPicker("setDate", c);
    _ignoreDateChange = false;
    if (_totalPriceLabelClientId != "") {
        UpdateTotalPriceLabel(b, c)
    }
    if (!a) {
        UpdateNumberOfNightsDropdownControl()
    }
}

function UpdateTotalPriceLabel(h, k) {
    try {
        var l = 0;
        var n = GetNumberOfNights(h, k);
        var m = h._day;
        var f = h._month;
        var d = 0;
        for (var b = 0; b < _datesWithPrices.length; b++) {
            if ((_datesWithPrices[b][0] == f) && (_datesWithPrices[b][1] == m)) {
                d = b;
                break
            }
        }
        for (var a = d; a < (d + n) ; a++) {
            l += parseFloat(_datesWithPrices[a][2])
        }
        var g = JQControl(null, _CriteriaControlIds.RoomsDropdownId).val();
        var c = "";
        if (parseInt(g) > 1) {
            c = jQuery.format("({0} {1})", g, _roomsText)
        }
        jQuery(_totalPriceLabelClientId).text(l);
        jQuery(_totalPriceNumberRoomsLabelClientId).text(c)
    } catch (e) {
        LogError(e, "UpdateTotalPriceLabel", "Calendar")
    }
}

function GetNumberOfNights(d, f) {
    if (typeof (d) == "undefined" || typeof (f) == "undefined") {
        return 1
    }
    var e = NewCDate(d, _calendarArrivalInstance);
    var b = 0;
    while (e.compareTo(f) == -1) {
        b++;
        e.add(1, "d")
    }
    var c = 1;
    if (typeof (_calendarMaxNights) == "undefined") {
        c = _maxLOS
    } else {
        c = _calendarMaxNights
    }
    var a = (c - 1);
    return (b > a) ? a : b
}

function UpdateLegendText(a) {
    var c = 1;
    try {
        if (typeof (_availabilityCalendarId) != "undefined") {
            if (XbeState.losUsedByCalendar == c) {
                a = c
            }
        }
        if (_calendarLosLegendControlId != "" && _calendarLosLegendText != "") {
            jQuery(jQuery.format("#{0}", _calendarLosLegendControlId)).text(jQuery.format(_calendarLosLegendText, a))
        }
    } catch (b) {
        LogError(b, "UpdateLegendText", "Calendar")
    }
}

function OnChangeNumberOfNights(g) {
    var b = jQuery(_arrivalDatePickerId).data("calendarsPicker");
    var a = jQuery(_arrivalDatePickerId).calendarsPicker("getDate")[0];
    var h = (_departureDatePickerId != null) ? jQuery(_departureDatePickerId).calendarsPicker("getDate")[0] : null;
    var e = null;
    var f = (a.compareTo(h) == 0) ? NewCDate(jQuery(_arrivalDatePickerId).calendarsPicker("getDate")[0], _calendarArrivalInstance).add(-1, "d") : NewCDate(a, _calendarArrivalInstance);
    var d = NewCDate(f, _calendarArrivalInstance);
    if (f != null && _departureDatePickerId != null) {
        var c = g.value;
        UpdateLegendText(c);
        e = NewCDate(f.add((d.compareTo(h) == 0) ? (c - 1) : c, "d"), _calendarDepartureInstance)
    }
    if (e == null) {
        e = jQuery(_departureDatePickerId).calendarsPicker("getDate")[0]
    }
    _isOnChangeNummberOfNights = true;
    if (b.settings.isCalendarDisplayed) {
        SetAvailabilityCalendarDates(_availabilityCalendarId, d, ValidateDepartureDate(d, e));
        _isOnChangeNummberOfNights = false
    }
    CriteriaSetControls(d, ValidateDepartureDate(d, e), true)
}

function UpdateCalendarAvailability(c) {
    try {
        var f = jQuery(c).calendarsPicker("getDate");
        var a = f[0];
        var e = f[f.length - 1];
        var d;
        var h;
        if (a.compareTo(e) == -1) {
            d = a;
            h = e
        } else {
            d = e;
            h = a
        }
        var g = jQuery.format("arr={0}&dep={1}", Date.UTC(d.year(), d.month() - 1, d.day()), Date.UTC(h.year(), h.month() - 1, h.day()));
        __doPostBack("tsUpdateAvail", g)
    } catch (b) {
        LogError(b, "UpdateCalendarAvailability", c)
    }
}

function UpdateAvailability(c, f, d) {
    if (typeof (Page_ClientValidate) == "function" && Page_ClientValidate("ModalValidation") == false) {
        return false
    }
    var e = jQuery(_arrivalDatePickerId).calendarsPicker("getDate");
    var b = jQuery(_departureDatePickerId).calendarsPicker("getDate");
    if (e.length == 0 || b.length == 0) {
        return false
    }
    var j = e[0];
    var k = b[0];
    var a = jQuery(jQuery.format("#{0} option:selected", c)).value();
    var i = jQuery(jQuery.format("#{0} option:selected", f)).value();
    var g = jQuery(jQuery.format("#{0}", d));
    var h = "arr=" + Date.UTC(j.year(), j.month() - 1, j.day());
    h += "&dep=" + Date.UTC(k.year(), k.month() - 1, k.day());
    h += "&adt=" + a;
    h += "&chd=" + i;
    if (g.size() == 0) {
        h += "&rms=null"
    } else {
        h += "&rms=" + g.value()
    }
    __doPostBack("tsUpdateAvail", h)
}

function UpdateAvailabilityModification(l, c, f, i, g, a) {
    try {
        if (typeof (Page_ClientValidate) == "function" && Page_ClientValidate("ModalValidation") == false) {
            return false
        }
        var h = jQuery(jQuery.format("#{0}", l)).calendarsPicker("getDate");
        var e = jQuery(jQuery.format("#{0}", c)).calendarsPicker("getDate");
        if (h.length == 0 || e.length == 0) {
            return false
        }
        var o = h[0];
        var p = e[0];
        var d = jQuery(jQuery.format("#{0} option:selected", f)).val();
        var n = jQuery(jQuery.format("#{0} option:selected", i)).val();
        var k = jQuery(jQuery.format("#{0}", g));
        var b = jQuery(jQuery.format("#{0}", a)).val();
        var m = "arr=" + Date.UTC(o.year(), o.month() - 1, o.day());
        m += "&dep=" + Date.UTC(p.year(), p.month() - 1, p.day());
        m += "&adt=" + d;
        m += "&chd=" + n;
        if (k.size() == 0) {
            m += "&rms=null"
        } else {
            m += "&rms=" + k.val()
        }
        m += "&filt=" + b;
        __doPostBack("tsUpdateAvail", m)
    } catch (j) {
        LogError(j, "UpdateAvailabilityModification")
    }
}

function BuildLink(J) {
    try {
        var n = jQuery(_arrivalDatePickerId).calendarsPicker("getDate");
        var M = null;
        if (typeof (_departureDatePickerId) != "undefined") {
            M = jQuery(_departureDatePickerId).calendarsPicker("getDate")
        }
        if (J) {
            if (n.length == 0) {
                return
            }
        } else {
            if (n.length == 0 || M.length == 0) {
                return
            }
        }
        var Q = "#{0}";
        var g = jQuery(jQuery.format(Q, _checkAvailHLid));
        var t = null;
        var w = jQuery(jQuery.format("{0}_HiddenSelectedDate", _arrivalDatePickerId)).val();
        if (!J && (typeof (w) != "undefined" && w != "")) {
            var a = _calendarArrivalInstance.newDate(w.split("|")[2], w.split("|")[0], w.split("|")[1]);
            if (M[0].compareTo(n[0]) == 0 && a.compareTo(n[0]) == -1) {
                t = new Date(a.year(), a.month() - 1, a.day())
            } else {
                t = new Date(n[0].year(), n[0].month() - 1, n[0].day())
            }
        } else {
            t = new Date(n[0].year(), n[0].month() - 1, n[0].day())
        }
        if (typeof (w) != "undefined" && w) {
            var l = NewCDate()
        }
        var D = jQuery.format("&arrive={0}", t.localeFormat("d"));
        var G = "";
        var R = "0";
        var b = jQuery(jQuery.format(Q, _hotelDDLid));
        if (typeof (b) != "undefined") {
            if (b.val() != "00000000-0000-0000-0000-000000000000") {
                R = b.val()
            }
        }
        if (typeof (R) == "undefined" || R == "0") {
            R = jQuery(jQuery.format(Q, _hotelHFid)).val()
        }
        if (parseInt(R) > 0) {
            G = jQuery.format("hotel={0}", R)
        }
        var U = "";
        var S = parseInt(jQuery(jQuery.format(Q, _hotelGroupHFid)).val());
        if (S > 0 && parseInt(R) >= 0) {
            U = jQuery.format("&chain={0}", S.toString())
        }
        var N = "";
        var q = "1";
        var P = jQuery(jQuery.format(Q, _roomsDDLid));
        if (typeof (P) != "undefined" && typeof (P.val()) != "undefined" && P.val() != "") {
            q = P.val()
        }
        N = jQuery.format("&rooms={0}", q);
        var j = "";
        var i = "1";
        var p = jQuery(jQuery.format(Q, _adultsDDLid));
        if (typeof (p) != "undefined") {
            i = p.val()
        }
        j = jQuery.format("&adult={0}", i);
        var s = "";
        var k = "0";
        var L = jQuery(jQuery.format(Q, _childDDLid));
        if (typeof (L) != "undefined") {
            k = L.val()
        }
        if (parseInt(k) > 0) {
            s = jQuery.format("&child={0}", k)
        }
        var v = "";
        var E = jQuery(jQuery.format(Q, _groupTBid));
        if (typeof (E) != "undefined" && (typeof (E.val()) != "undefined" && E.val() != "")) {
            v = jQuery.format("&group={0}", E.val())
        }
        var F = "";
        var C = jQuery(jQuery.format(Q, _promoTBid));
        if (typeof (C) != "undefined" && (typeof (C.val()) != "undefined" && C.val() != "")) {
            F = jQuery.format("&promo={0}", C.val())
        }
        var z = jQuery(jQuery.format(Q, _iataTBid));
        var Y = "";
        if (typeof (z) != "undefined" && (typeof (z.val()) != "undefined" && z.val() != "")) {
            Y = jQuery.format("&iata={0}", z.val())
        }
        var K = "";
        var d = jQuery(jQuery.format(Q, _rateCodeHFid));
        if (typeof (d) != "undefined" && (typeof (d.val()) != "undefined" && d.val() != "")) {
            K = jQuery.format("&rate={0}", d.val())
        }
        var H = "";
        var r = jQuery(jQuery.format(Q, _roomCodeHFid));
        if (typeof (r) != "undefined" && (typeof (r.val()) != "undefined" && r.val() != "")) {
            H = jQuery.format("&room={0}", r.val())
        }
        var f = "";
        var I = jQuery(jQuery.format(Q, _templateCodeHFid));
        if (typeof (I) != "undefined" && (typeof (I.val()) != "undefined" && I.val() != "")) {
            f = jQuery.format("&template={0}", I.val())
        }
        var h = "";
        var o = jQuery(jQuery.format(Q, _shellCodeHFid));
        if (typeof (o) != "undefined" && (typeof (o.val()) != "undefined" && o.val() != "")) {
            h = jQuery.format("&shell={0}", o.val())
        }
        var e = "";
        var X = jQuery(jQuery.format(Q, _langHFid));
        e = jQuery.format("&lang={0}", X.val());
        var u = "";
        var B = jQuery(jQuery.format(Q, _productSortingHFid));
        if (typeof (B) != "undefined" && (typeof (B.val()) != "undefined" && B.val() != "")) {
            u = jQuery.format("&SortProductsBy={0}", B.val())
        }
        var A = "&start=availresults";
        var c = "{0}rez.aspx?{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}";
        if (J) {
            var m = "";
            var V = "1";
            var W = jQuery(jQuery.format(Q, _nightsDropDownId));
            if (typeof (W) != "undefined" && typeof (_nightsDropDownId) != "undefined") {
                V = jQuery(jQuery.format("#{0} option:selected", _nightsDropDownId)).val()
            }
            m = jQuery.format("&nights={0}", V);
            c = jQuery.format(c, getAbsolutePath(), G, U, D, m, N, j, s, K, H, v, F, Y, f, h, A, e, u)
        } else {
            var T = false;
            if (M[0].month() - 1 == t.getMonth() && M[0].day() == t.getDay()) {
                T = true
            }
            var x = new Date(M[0].year(), M[0].month() - 1, M[0].day());
            var y = jQuery.format("&depart={0}", (T) ? x.setDate(x.getDate() + 1).localeFormat("d") : x.localeFormat("d"));
            c = jQuery.format(c, getAbsolutePath(), G, U, D, y, N, j, s, K, H, v, F, Y, f, h, A, e, u)
        }
        g.attr("href", c)
    } catch (O) {
        LogError(O, "BuildLink", "TeaserControl")
    }
}

function GetCalendarLanguage(a, c) {
    var b = jQuery.calendars.instance();
    if (c != "en") {
        if (typeof (_languages[a][c]) != "undefined") {
            b = jQuery.calendars.instance(a, c)
        }
    }
    return b
}

function tryParseInt(a) {
    if (isNaN(parseInt(a))) {
        return 0
    } else {
        return parseInt(a)
    }
}

function SetArrivalDatePickerValue(c, d) {
    try {
        var b = (d != null && typeof (d) != "undefined" && d != "");
        if (b) {
            jQuery(d).calendarsPicker("setDate", c)
        } else {
            jQuery(_arrivalDatePickerId).calendarsPicker("setDate", c)
        }
    } catch (a) {
        LogError(a, "SetArrivalDatePickerValue", "DatePickerControl")
    }
}

function SetDepartureDatePickerValue(d, c) {
    try {
        var b = (c != null && typeof (c) != "undefined" && c != "");
        if (b) {
            jQuery(c).calendarsPicker("setDate", d)
        } else {
            jQuery(_departureDatePickerId).calendarsPicker("setDate", d)
        }
    } catch (a) {
        LogError(a, "SetDepartureDatePickerValue", "DatePickerControl")
    }
};