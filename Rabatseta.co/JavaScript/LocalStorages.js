function initPage() {
    var lastOpenPage = localStorage.LastOpenPage;
    if (lastOpenPage == null || lastOpenPage == '') {
        lastOpenPage = '../Views/Home/Home';
        navigateToString(lastOpenPage);
    }
}

function saveLastOpenPage(lastOpenPage) {
    localStorage.LastOpenPage = lastOpenPage;
}