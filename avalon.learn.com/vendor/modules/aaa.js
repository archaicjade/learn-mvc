/// <reference path="../vendor/require/require.js" />


define(['avalon', "text!./aaa.html"], function () {
    avalon.define({
        $id: "aaa",
        username: "嘉靖皇帝"
    });
    avalon.vmodels.root.page = "aaa";
});