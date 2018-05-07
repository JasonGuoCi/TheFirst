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
});

$(function () {
    //为tab选项卡绑定右键菜单
    $(". tabs li").live('contextmenu', function (e) {
        //选中当前触发事件的选项卡
        var subTitle = $(this).text();
        $("#mainTab").tabs('select', subTitle);

        //显示快捷菜单
        $('#tab_menu').menu('show', {
            left: e.pageX,
            top: e.pageY
        });
        return false;
    });
});
//添加标签
function addTab(subTitle, url, icon) {
    if (!$("#mainTab").tabs('exists', subTitle)) {
        $("#mainTab").tabs('add', {
            title: subTitle,
            context: createFrame(url),
            closable: true,
            icon: icon
        });
    } else {
        $("#mainTab").tabs('select', subTitle);
        $("#tab_menu-tabrefresh").trigger("click");
    }
    $(".layout-button-left").trigger("click");
}

function createFrame(url) {
    var s = '<iframe frameborder="0" src="' + url + '" scrolling="auto" style="width:100%;height:99%"></iframe>';
    return s;
}

//系统皮肤切换
$(function () {
    $(".ui-skin-nav .li-skinitem span").click(function () {
        var theme = $(this).attr("rel");
        $.messager.confirm('提示', '切换皮肤将重新加载!', function (r) {
            if (r) {
                $.post("../../Home/SetThemes", { value: theme }, function (data) {
                    window.location.reload();
                }, "json");
            }
        });
    });
});