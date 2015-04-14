/// <reference path="libs/jquery-2.0.2.js" />
/// <reference path="libs/sammy-0.7.5.min.js" />
/// <reference path="libs/underscore.js" />
/// <reference path="libs/q.js" />
/// <reference path="libs/mocha.js" />
/// <reference path="libs/chai.js" />

(function () {
    'use strict';
    require.config({
        paths: {
            'criptojs': 'libs/cryptojs-sha1',
            'jquery': 'libs/jquery-2.1.1.min',
            'underscore': 'libs/underscore',
            'sammy': 'libs/sammy',
            'q': 'libs/q',
            'mocha': 'libs/mocha',
            'chai': 'libs/chai',
            'http-requester': 'logic/http-requester'
        }, shim: {
            underscore: {
                exports: '_'
            }
        }
    });

    require(['jquery', 'underscore', 'sammy', 'q', 'mocha', 'chai', 'http-requester', 'criptojs'],
        function ($, _, sammy, q, mocha, chai, requester, crypto) {
            //Registration endpoint
            $('#registration #submit-post-button').on('click', function () {
                var name, pass, url, jsonObj;
                name = $('#registration #name-input').val();
                pass = $('#registration #text-input').val();
                url = 'http://localhost:3000/user';
                jsonObj = {
                    username: name,
                    authCode: CryptoJS.SHA1(name + pass).toString(),
                };
                requester.postJson(url, jsonObj)
                .then(function () {
                    console.log('Successfully registered!');
                }, function () {
                    console.log('Error by registration');
                })
            });

            //Login endpoint
            $('#log-in #log-in-button').on('click', function () {
                var name, pass, url, jsonObj;
                name = $('#log-in #name-input').val();
                pass = $('#log-in #text-input').val();
                url = 'http://localhost:3000/auth';
                jsonObj = {
                    username: name,
                    authCode: CryptoJS.SHA1(name + pass).toString(),
                };
                requester.postJson(url, jsonObj)
                .then(function (obj) {
                    var sessionKey = obj.sessionKey;
                    sessionStorage.setItem("sessionKey", sessionKey);
                    console.log('Successfully logged in!');
                }, function (code) {
                    console.log('Error by login');
                })
            });

            //Logout endpoint
            $('#log-in #log-out-button').on('click', function () {
                var url = 'http://localhost:3000/user';
                var sessionKey = sessionStorage.getItem('sessionKey');
                requester.putJson(url, sessionKey)
                .then(function () {
                    sessionStorage.removeItem("sessionKey");
                    console.log('Successfully logged out!');
                }, function (code) {
                    console.log('Error by loggin out');
                })
            });

            //Get posts
            $('#get-posts-button').on('click', function () {
                var url = 'http://localhost:3000/post';
                var filter = $('#filter-input').val();

                requester.getJson(url)
                .then(function (data) {
                    if (filter !== '') {
                        var data = _.filter(data, function (item) {
                            return item.user.username === filter;
                        });
                    }
              
                    var post, $postsList, i, len;
                    $postsList = $('<div/>').addClass('post-list');
                    for (i = 0, len = data.length; i < len; i++) {
                        post = data[i];
                        $('<p />')
                          .addClass('post-item')
                          .append($('<strong /> ')
                            .html("title: " + post.title))
                          .append($('<span />')
                            .html(" content: " + post.body))
                          .append($('<span />')
                            .html(" post-date: " + post.postDate))
                          .append($('<span />')
                            .html(" by: " + post.user.username))
                          .appendTo($postsList);
                    }

                    $('#post-list-container').html($postsList);
                    console.log('Successfully getted posts!');

                }, function () {
                    console.log('Error by getting posts');
                })
            });

            //Create post
            $('#create-post-button').on('click', function () {
                var title, content, url, jsonObj;
                title = $('#title-input').val();
                content = $('#content-input').val();
                url = 'http://localhost:3000/post';
                jsonObj = {
                    title: title,
                    body: content
                };
                var sessionKey = sessionStorage.getItem('sessionKey');
                requester.postJson(url, jsonObj, sessionKey)
                .then(function () {
                    console.log('Successfully posted!');
                }, function () {
                    console.log('Error by posting');
                })
            });
        });
}());