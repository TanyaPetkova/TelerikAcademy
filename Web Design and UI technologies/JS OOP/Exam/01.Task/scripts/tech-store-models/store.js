define(['tech-store-models/item'],function (Item) {
    'use strict';
    var Store;
    Store = (function () {
        function predicatBy(prop) {
            return function (a, b) {
                if (a[prop].toLowerCase() > b[prop].toLowerCase()) {
                    return 1;
                } else if (a[prop].toLowerCase() < b[prop].toLowerCase()) {
                    return -1;
                }
                return 0;
            }
        }

        function Store(name) {
            if (name.length < 6 || name.length > 40) {
                throw {
                    message: 'Trying to create an object with invalid name length'
                }
            }

            this._name = name;
            this._items = [];
        }

        Store.prototype = {
            addItem: function (item) {
                if (!(item instanceof Item)) {
                    throw {
                        message: 'Trying to add an object that is not an instance of Item'
                    };
                }

                this._items.push(item);
                return this;
            },

            getAll: function () {
                this._items.sort(predicatBy("_name"));
                var copiedItems = this._items.slice();
                return copiedItems;
            },

            getSmartPhones: function () {
                var smartPhones = [];
                var copiedItems = this.getAll();

                copiedItems.forEach(function (item) {
                    if (item._type === 'smart-phone') {
                        smartPhones.push(item);
                    }
                });

                return smartPhones;
            },

            getMobiles: function () {
                var mobiles = [];

                var copiedItems = this.getAll();

                copiedItems.forEach(function (item) {
                    if (item._type === 'smart-phone' || item._type === 'tablet') {
                        mobiles.push(item);
                    }
                });

                return mobiles;
            },

            getComputers: function () {
                var computers = [];

                var copiedItems = this.getAll();

                copiedItems.forEach(function (item) {
                    if (item._type === 'pc' || item._type === 'notebook') {
                        computers.push(item);
                    }
                });

                return computers;
            },

            filterItemsByType: function (filterType) {
                var filteredItems = [];

                var copiedItems = this.getAll();

                copiedItems.forEach(function (item) {
                    if (item._type === filterType ) {
                        filteredItems.push(item);
                    }
                });

                return filteredItems;
            },

            filterItemsByPrice: function (options) {
                var min,
                    max;

                    min = options.min || 0;
                    max = options.max || Number.POSITIVE_INFINITY;

                this._items.sort(function (first, second) {
                    return first._price - second._price;
                });

                var filteredItemdByPrice = [];

                this._items.forEach(function (item) {
                    if (item._price >= min && item._price <= max) {
                        filteredItemdByPrice.push(item);
                    }
                });

                return filteredItemdByPrice;
            },

            countItemsByType: function () {
                var assocArray = {};
                var type = {};

                for(var i in this._items){
                    type = this._items[i]._type;
                    if (assocArray[type]) {
                        assocArray[type]++;
                    }
                    else {
                        assocArray[type] = 1;
                    }
                }

                return assocArray;
            },

            filterItemsByName: function (partOfName) {
                var filteredItemsByName = [];

                this._items.forEach(function (item) {
                    if (item._name.toLowerCase().indexOf(partOfName) !== -1) {
                        filteredItemsByName.push(item);
                    }
                });

                return filteredItemsByName;
            }
        };

        return Store;
    })();

    return Store;
});