/// <reference path="vendor/require/require.js" />
/// <reference path="vendor/jquery/jquery-3.1.1.min.js" />
/// <reference path="vendor/require/text.js" />
/// <reference path="vendor/require/domReady.js" />
/// <reference path="vendor/avalon/avalon.js" />

require.config({
    baseUrl: '',
    paths: {
        jquery: 'vendor/jquery/jquery-3.1.1.min',
        avalon: 'vendor/avalon/avalon',
        text: 'vendor/require/text',
        domReady: 'vendor/require/domReady'
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

require(['avalon', "domReady!"], function () {
    avalon.log("加载avalon完毕，开始构建根vm与加载其他模块");

    avalon.define({
        $id: "root",
        header: "这是根模块，用于放置其他模块都共用的东西，比如<b>用户名</b>什么的",
        footer: "页脚消息",
        page: "empty"
    });

    avalon.scan(document.body);

    require(['./vendor/modules/aaa'], function () {
        avalon.log("加载其他完毕");
    });
});