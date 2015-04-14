define(function () {
    'use strict';
    var Item;
    Item = (function () {
        var types = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];

        Array.prototype.contains = function (elem) {
            var self = this;
            for (var i in self) {
                if (self[i] === elem)
                    return true;
            }
            return false;
        }

        function isFloat(value) {
            return !!(value % 1);
        }

        function Item(type, name, price) {
            if (!types.contains(type)) {
                throw {
                    message: 'Trying to create an object with invalid type'
                }
            }

            this._type = type;

            if (name.length < 6 || name.length > 40) {
                throw {
                    message: 'Trying to create an object with invalid name length'
                }
            }

            this._name = name;

            if (!isFloat(price)) {
                throw {
                    message: 'Trying to create an object with invalid price type'
                }
            }

            this._price = price;
        }

        return Item;
    })();

    return Item;
});