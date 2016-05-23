﻿var SearchAndShortlist = SearchAndShortlist || {};
(function(cookieHelper) {

    cookieHelper.GetCookie = function (name) {
        var cookie = new cookieHelper.Cookie(name);

        var cookieString = Cookies.get(name);

        if (cookieString && cookieString.length !== 0) {
            cookie.PopulateFromString(cookieString);
        }

        return cookie;
    };

    cookieHelper.SaveCookie = function(cookie) 
    {
        Cookies.set(cookie.Name,
            cookie.ToString(),
            {
                expires: 365,
                domain: SearchAndShortlist.appsettings.cookieDomain,
                HttpOnly: SearchAndShortlist.appsettings.cookieSecure,
                path: '/'
            });
    }

    cookieHelper.Cookie = function (name)
    {
        this.Name = name;
        this.SubKeys = new Array();

        this.PopulateFromString = function (cookieString)
        {
            this.SubKeys = new Array();

            var subKeyStrings = cookieString.split("&");

            for (var i = 0; i < subKeyStrings.length; i++)
            {
                var subkey = new SubKey(subKeyStrings[i]);
                this.SubKeys.push(subkey);
            }
        };

        this.AddSubKey = function(keyName) {
            var key = new SubKey(keyName);
            this.SubKeys.push(key);
            return key;
        };

        this.AddSubKeyValue = function(key, value) {
            var subKey = this.SubKeys.find(function (element, index, array)
            {
                console.log(element.Key);
                return element.Key === key;
            });

            if (!subKey) {
                subKey = this.AddSubKey(key);
            }

            subKey.AddValue(value);
        }

        this.RemoveSubKey = function (keyName)
        {
            var index = this.SubKeys.findIndex(function (element, index, array)
            {
                return element.Name === keyName;
            });

            if (index > -1) {
                this.SubKeys.splice(index, 1);
            }
        };

        this.RemoveSubKeyValue = function (key, value)
        {
            var subKey = this.SubKeys.find(function (element, index, array)
            {
                return element.Key === key;
            });

            if (subKey)
            {
                subKey.RemoveValue(value);
            }
        }

        this.ToString = function ()
        {
            var subKeyStrings = new Array();

            for (var i = 0; i < this.SubKeys.length; i++) {
                subKeyStrings.push(this.SubKeys[i].ToString());
            }

            return subKeyStrings.join("&");
        }

        function SubKey(key)
        {
            this.Key = key;
            this.Values = new Array();

            this.PopulateFromString = function (keyString)
            {
                if (keyString && keyString.length !== 0) {
                    var keypair = keyString.split("=");

                    this.Key = keypair[0];

                    if (keypair[1]) {
                        this.Values = keypair[1].split("|");
                    }
                }
            }

            this.AddValue = function(value) {
                this.Values.push(value);
            };

            this.AddValues = function(values) {
                this.Values.push.apply(this.Values, values);
            };

            this.RemoveValue = function(value) {
                var index = this.Values.indexOf(value);

                if (index > -1) {
                    this.Values.splice(index, 1);
                }
            };

            this.ToString = function() {
                var objString = this.Key ? this.Key + "=" : "";

                objString += this.Values ? this.Values.join("|") : "";

                return objString;
            }
        }
    }

}(SearchAndShortlist.CookieHelper = {}));
