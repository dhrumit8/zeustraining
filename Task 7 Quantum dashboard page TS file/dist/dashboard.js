var coursesContainer = document.querySelector(".courses-container");
var hamburger = document.getElementById("hamburger-menu-logo");
var menubar = document.querySelector(".vertical-menu");
var alertLogo = document.getElementById("alert-logo");
var alertContainer = document.querySelector(".alert-container");
var announcementLogo = document.getElementById("announcement-logo");
var announcementContainer = document.querySelector(".announcement-container");
hoverEvents();
fetch('./json/dashboard.json')
    .then(function (response) { return response.json(); })
    .then(function (json) {
    // const new1 = json;
    console.log(json.courses[0].title);
    // console.log(new1.courses[0].units);
    addCourses(json);
    addAlerts(json);
    addAnnouncements(json);
});
function addCourses(json) {
    console.log(json);
    var markup = "";
    var i = 0;
    for (var _i = 0, _a = json.courses; _i < _a.length; _i++) {
        var course = _a[_i];
        markup += "<div class=\"courses\">\n\n        ".concat(course.isExpired ?
            "<div class=\"expired\">EXPIRED</div>\n            <div class=\"details-courses with-expired\">"
            : "<div class=\"details-courses\">", "\n\n        <div class=\"course-image-info\">\n        <img class=\"course-img\" src=\"").concat(course.image, "\" alt=\"image").concat(i, "\">\n        <div class=\"information\">\n        <div class=\"title\">\n        <div>").concat(course.title, "</div>\n        ").concat(course.isFavourite ? "<img class=\"favourite-icon\" src=\"./quantum screen assets/icons/favourite.svg\" alt=\"\">" : "", "\n        </div>\n        <div class=\"sub-title\">\n        <span class=\"vertical-line\">").concat(course.subject, "</span>\n        <span class=\"grade\">Grade ").concat(course.grade, "</span>\n        <span class=\"green\">").concat(course.addGrade, "</span>\n        </div>\n        <div class=\"sub-title2\">\n        ").concat(course.units !== null ? "\n        <span class=\"number\">".concat(course.units, "</span>\n        <span class=\"text\">Units</span>") : '', "\n        ").concat(course.lessons !== null ? "\n        <span class=\"number\">".concat(course.lessons, "</span>\n        <span class=\"text\">Lessons</span>") : '', "\n        ").concat(course.topics !== null ? "\n        <span class=\"number\">".concat(course.topics, "</span>\n        <span class=\"text\">Topics</span>") : '', "\n        \n        </div>\n        <div class=\"dropdown\">\n        <select class=\"dropdown-classes\n        ").concat(course.professorClasses.length == 0 ? " no-classes" : '', "\n        \" name=\"classes\" id=\"course").concat(i, "\">\n        ").concat(generateDropdownOptions(course.professorClasses), "\n        \n        </select>\n        </div>\n        <div class=\"line-dropdown\"></div>\n        <div class=\"sub-title3\">\n\n        ").concat(course.students !== null ? "\n        <span>".concat(course.students, " Students</span>") : '', "\n\n        ").concat(course.date !== null ? "\n        <span class=\"vertical-line\"></span>\n        <span class=\"date\">".concat(course.date, "</span>") : '', "\n\n        </div>\n        </div>\n        </div>\n        <div class=\"line-in-course\"></div>\n        <div class=\"icons-container\">\n        <img src=\"./quantum screen assets/icons/preview.svg\" alt=\"preview icon\"\n        ").concat(course.isPreview ? "" : "class=\"icon-blur\"", "\n        >\n        <img src=\"./quantum screen assets/icons/manage course.svg\" alt=\"manage course icon\"\n        ").concat(course.isManageCourse ? "" : "class=\"icon-blur\"", "\n        >\n        <img src=\"./quantum screen assets/icons/grade submissions.svg\" alt=\"grade submission icon\"\n        ").concat(course.isGradeSubmission ? "" : "class=\"icon-blur\"", "\n        >\n        <img src=\"./quantum screen assets/icons/reports.svg\" alt=\"reports icon\"\n        ").concat(course.isReports ? "" : "class=\"icon-blur\"", "\n        >\n        </div>\n        </div>\n        </div>");
        i++;
    }
    if (coursesContainer) {
        coursesContainer.innerHTML = markup;
    }
}
function generateDropdownOptions(classes) {
    var options = "";
    if (classes.length > 0) {
        for (var _i = 0, classes_1 = classes; _i < classes_1.length; _i++) {
            var professorClass = classes_1[_i];
            options += "<option value=\"".concat(professorClass, "\">").concat(professorClass, "</option>");
        }
    }
    else {
        options = '<option class="no-classes" value="">No Classes</option>';
    }
    return options;
}
function hoverEvents() {
    if (hamburger && menubar && alertLogo && alertContainer && announcementLogo && announcementContainer) {
        hamburger.addEventListener("mouseover", function () {
            menubar.style.display = "block";
            announcementContainer.style.display = "none";
            alertContainer.style.display = "none";
        });
        menubar.addEventListener("mouseleave", function () {
            menubar.style.display = "none";
        });
        alertLogo.addEventListener("mouseenter", function () {
            alertContainer.style.display = "block";
            menubar.style.display = "none";
            announcementContainer.style.display = "none";
        });
        alertContainer.addEventListener("mouseleave", function () {
            alertContainer.style.display = "none";
        });
        announcementLogo.addEventListener("mouseenter", function () {
            announcementContainer.style.display = "block";
            alertContainer.style.display = "none";
            menubar.style.display = "none";
        });
        announcementContainer.addEventListener("mouseleave", function () {
            announcementContainer.style.display = "none";
        });
    }
}
function addAlerts(json) {
    console.log(json);
    var markup = "";
    var i = 0;
    for (var _i = 0, _a = json.alerts; _i < _a.length; _i++) {
        var alert_1 = _a[_i];
        markup += "<div class=\"alerts \n        ".concat(alert_1.isViewed ? " viewed" : " not-viewed", "\n        \">\n        <div class=\"alert-desc-with-icon\">\n            <div class=\"alert-description\">\n                ").concat(alert_1.description, "\n            </div>\n            ").concat(alert_1.isViewed ?
            "<img class='viewed-icon' src='./icons/correct.png' alt='viewed icon'>"
            : "<img class='notViewed-icon' src='./icons/dnd.png' alt='Not viewed icon'>", "\n        </div>\n        ").concat(alert_1.course !== null ? "<div class='alert-course-container'><span class='alert-course'>Course: </span><span class='alert-course-name'>"
            : '', "\n        ").concat(alert_1.course !== null ? alert_1.course : '', "\n        ").concat(alert_1.course !== null ? "</span></div>" : '', "\n        ").concat(alert_1.class !== null ? "<div class='alert-class-container'><span class='alert-class'>Class: </span><span class='alert-class-name'>"
            : '', "\n        ").concat(alert_1.class !== null ? alert_1.class : '', "\n        ").concat(alert_1.class !== null ? "</span></div>" : '', "\n        \n        <div class=\"alert-date-time\">").concat(alert_1.datetime, "</div>\n    </div>");
    }
    markup += "<button class=\"alert-show-all-btn\">SHOW ALL</button>";
    if (alertContainer) {
        alertContainer.innerHTML = markup;
    }
}
function addAnnouncements(json) {
    console.log(json);
    var markup = "";
    var i = 0;
    for (var _i = 0, _a = json.announcements; _i < _a.length; _i++) {
        var announcement = _a[_i];
        markup += "<div class=\"announcements \n        ".concat(announcement.isViewed ? " viewed" : " not-viewed", "\n        \">\n        <div class=\"announcement-desc-with-icon\">\n        \n            <div class=\"pa-desc-conatainer\">\n                <div class=\"pa-container\">\n                    <span class=\"pa\">PA: </span>\n                    <span class=\"pa-name\">").concat(announcement.pa, "</span>\n                </div>\n                <div class=\"announcement-description\">\n                    ").concat(announcement.description, "\n                </div>\n            </div>\n            ").concat(announcement.isViewed ?
            "<img class='viewed-icon' src='./icons/correct.png' alt='viewed icon'>"
            : "<img class='notViewed-icon' src='./icons/dnd.png' alt='Not viewed icon'>", "\n        </div>\n\n        ").concat(announcement.course !== null ? "<div class='announcement-course-container'><span class='announcement-course'>Course: </span><span class='announcement-course-name'>"
            : '', "\n        ").concat(announcement.course !== null ? announcement.course : '', "\n        ").concat(announcement.course !== null ? "</span></div>" : '', "\n        \n        <div class=\"attachment-date-container\">\n        \n            <div class=\"attachment\">").concat(announcement.attachment !== null ? announcement.attachment : "", "</div>\n            <div class=\"announcement-date-time\">").concat(announcement.datetime, "</div>\n        </div>\n    </div>");
    }
    markup += "<div class=\"announcement-btns\">\n\n    <button class=\"announcement-show-all-btn\">SHOW ALL</button>\n    <button class=\"announcement-create-new-btn\">CREATE NEW</button>\n    </div>";
    if (announcementContainer) {
        announcementContainer.innerHTML = markup;
    }
}
// export {};
