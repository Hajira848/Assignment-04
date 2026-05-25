window.themeInterop = {
    setThemeAttribute: function (theme) {

        document.documentElement.setAttribute('data-theme', theme);
      
        localStorage.setItem('selected-theme', theme);
    },
    getThemeAttribute: function () {
        return localStorage.getItem('selected-theme') || 'light';
    }
};

