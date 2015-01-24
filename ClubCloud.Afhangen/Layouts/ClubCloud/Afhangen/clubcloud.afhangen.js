function MakeReadOnly(b) {
    var a = document.getElementById(b);
    a.checked = true
}

function TogglePanel(a) {
    var b = document.getElementById(a);
    b.style.display = (b.style.display == "none" || b.style.display == "" ? "block" : "none");
    return false
}

function GetDateString(a) {
    return jQuery.format("{0}{1}{2}", a[1], a[2], a[0])
}

function GetDateFromDateArray(a) {
    return new Date(a[0], a[1] - 1, a[2])
}

function GetDateArray(a) {
    return new Array(a.getFullYear(), a.getMonth() + 1, a.getDate())
}

function GetNextDate(a) {
    return GetDateByOffset(a, 1)
}

function GetPreviousDate(a) {
    return GetDateByOffset(a, -1)
}

function GetDateByOffset(a, c) {
    var b = new Date();
    b.setTime(a.valueOf());
    b.setDate(b.getDate() + c);
    return b
}

function ValueInArray(b, c) {
    for (var a = 0; a < c.length; a++) {
        if (b == c[a]) {
            return true
        }
    }
    return false
}

function OnDayChange(F, M, l, a, w, b, k, x, P, c, B, N, g, G, E, D, f, s, u, d, A, z) {
    try {
        var J = jQuery("#" + a);
        var C = jQuery("#" + w);
        var o = jQuery("#" + b);
        var q = JQControl(null, B);
        var H = JQControl(null, g);
        var y = JQControl(null, G);
        var m = JQControl(null, E);
        var v = JQControl(null, d);
        var O = JQControl(null, d).length != 0;
        var t = new Date(J.val(), C.val(), o.val());
        var K = new Date(H.val(), y.val(), m.val());
        if (F) {
            t.setDate(t.getDate() + (1 * M))
        } else {
            K.setDate(K.getDate() + (1 * M))
        }
        if ((t.getFullYear() * 1000 + t.getMonth() * 50 + t.getDate()) < q.val()) {
            return
        }
        if ((K.getFullYear() * 1000 + K.getMonth() * 50 + K.getDate()) < (parseInt(q.val()) + 1)) {
            return
        }
        if (F) {
            if (O) {
                K.setDate(K.getDate() + (1 * M))
            } else {
                if (dates.compare(t, K) == 0) {
                    K.setDate(K.getDate() + 1)
                }
            }
        } else {
            if (O) {
                t.setDate(t.getDate() + (1 * M))
            } else {
                if (dates.compare(t, K) == 0) {
                    t.setDate(K.getDate() - 1)
                }
            }
        }
        J.val(t.getFullYear());
        C.val(t.getMonth());
        o.val(t.getDate());
        H.val(K.getFullYear());
        y.val(K.getMonth());
        m.val(K.getDate());
        JQControl(null, k).text(J.val());
        JQControl(null, x).text(t.getMonthShortName());
        JQControl(null, P).text(o.val());
        JQControl(null, c).text(t.getDayShortName());
        if (JQControl(null, D).length != 0) {
            JQControl(null, D).text(H.val());
            JQControl(null, f).text(K.getMonthShortName());
            JQControl(null, s).text(m.val());
            JQControl(null, u).text(K.getDayShortName())
        }
        if (O == true) {
            var r = GetStayNumberOfNights(t, K);
            var h = false;
            jQuery(jQuery.format("#{0} option", d)).each(function (e, Q) {
                if (parseInt(Q.value) == r) {
                    h = true
                }
            });
            if (h) {
                v.val(r)
            }
        } else {
            var r = GetStayNumberOfNights(t, K);
            JQControl(null, A).text(r);
            if (r == 1) {
                JQControl(null, z).text(nightTranslation)
            } else {
                if (r > 1) {
                    JQControl(null, z).text(nightsTranslation)
                }
            }
        }
        var I = true;
        if ((t.getFullYear() + t.getMonth() * 100 + t.getDate()) == q.val()) {
            I = false
        }
        var p = JQControl(null, l);
        if (I == false) {
            if (p.hasClass("activeLink")) {
                p.removeClass("activeLink")
            }
            if (!p.hasClass("nonactiveLink")) {
                p.addClass("nonactiveLink")
            }
        } else {
            if (p.hasClass("nonactiveLink")) {
                p.removeClass("nonactiveLink")
            }
            if (!p.hasClass("activeLink")) {
                p.addClass("activeLink")
            }
        }
        if (JQControl(null, N).length != 0) {
            var n = JQControl(null, N);
            var j = true;
            if ((K.getFullYear() + K.getMonth() * 100 + K.getDate()) == (parseInt(q.val()) + 1)) {
                j = false
            }
            if (j == false) {
                if (n.hasClass("activeLink")) {
                    n.removeClass("activeLink")
                }
                if (!n.hasClass("nonactiveLink")) {
                    n.addClass("nonactiveLink")
                }
            } else {
                if (n.hasClass("nonactiveLink")) {
                    n.removeClass("nonactiveLink")
                }
                if (!p.hasClass("activeLink")) {
                    n.addClass("activeLink")
                }
            }
        }
    } catch (L) {
        alert(L.Message)
    }
    bInDelay++;
    setTimeout(function () {
        ProcessDateChange()
    }, 1000)
}