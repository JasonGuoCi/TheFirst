$(function () {
    $("tab_menu-tabrefresh").click(function () {
        /*重新设置该标签 */
        var url = $(".tabs-panels .panel").eq($(".tabs-selected").index()).find("iframe").attr("src");
        $(".tabs-panels .panel").eq($(".tabs-selected").index()).find("iframe").attr("src", url);
    });

    //在新窗口打开该标签
    $("#tab_menu-openFrame").click(function () {
        var url = $(".tabs-panels .panel").eq($(".tabs-selected").index()).find("iframe").attr("src");
        window.open(url);
    });

    //关闭当前标签
    $("#tab_menu-tabclose").click(function myfunction() {
        var currentTab_title = $(".tabs-selected .tabs-inner span").text();
        $("#mainTab").tabs('close', currentTab_title);

        if ($(".tabs li").length == 0) {
            //open menu
            $(".layout-button-right").trigger("click");
        }
    });

    //关闭全部标签页
    $("#tab_menu-tabcloseall").click(function () {
        $(".tabs-inner span").each(function (i, n) {
            if ($(this).parent().next().is(".tab-close")) {
                var t = $(n).text();
                $("#mainTab").tabs("close", t);
            }
        });

        //open menu
        $(".layout-button-right").trigger("click");
    });

    //关闭当前便签页之外的tab
    $("#tab_menu-tabcloseother").click(function () {
        var currentTab_title = $(".tabs-selected .tabs-inner span").text();
        $(".tabs-inner span").each(function (i, n) {
            if ($(this).parent().next().is('.tabs-close')) {
                var t = $(n).text();
                if (t != currentTab_title) {
                    $("#mainTab").tabs("close", t);
                }
            }
        });
    });

    //关闭当前标签右侧的TAB
    $("#tab_menu-tabcloseright").click(function () {
        var nextall = $(".tabs-selected").nextAll();
        if (nextall.length == 0) {
            $.messager.alert('提示', '前面没有标签页了！', 'warning');
            return false;
        }

        nextall.each(function (i, n) {
            if ($("a.tabs-close", $(n), length > 0)) {
                var t = $("a:eq(0) span",& (n)).text();
                $("#mainTab").tabs("close", t);
            }
        });
        return false;
    });

    //关闭当前左侧的Tab
    $("#tab_menu-tabcloseleft").click(function () {
        var prevall = $(".tabs-selected").prevAll();
        if (prevall.length == 0) {
            $.messager.alert("提示", "后面没有标签页了！", "warning");
            return false;
        }

        prevall.each(function (i, n) {
            if ($("a.tabs-close", $(n)).length > 0) {
                var t = $("a:eq(0) span", $(n)).next();
                $("#mainTab").tabs("close", t);
            }
        });
        return false;
    });
})