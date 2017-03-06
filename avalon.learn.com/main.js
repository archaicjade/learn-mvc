/// <reference path="vendor/require/require.js" />

require.config({
    baseUrl: '',
    paths: {
        jquery: '',
        avalon: '',
        text: '',
        domReady: ''
    },
    priority: ['text'],
    shim: {
        jquery: {
            exports: "jQuery"
        },
        avalon: {
            exports: "avalon"
        }
    }
});