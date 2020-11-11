using Serenity.Navigation;
using Administration = MovieTutorial.Administration.Pages;

[assembly: NavigationMenu(90000, "Administration", icon: "fa-desktop")]
[assembly: NavigationLink(90000, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(90000, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(90000, "Administration/Sergen", typeof(Administration.SergenController), icon: "fa-magic")]
[assembly: NavigationLink(90000, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(90000, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]