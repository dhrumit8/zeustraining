import { DashboardData } from "./interfaces";

let coursesContainer: HTMLElement | null = document.querySelector(".courses-container");
const hamburger: HTMLElement | null = document.getElementById("hamburger-menu-logo");
const menubar: HTMLElement | null = document.querySelector(".vertical-menu");
const alertLogo: HTMLElement | null = document.getElementById("alert-logo");
const alertContainer: HTMLElement | null = document.querySelector(".alert-container");
const announcementLogo: HTMLElement | null = document.getElementById("announcement-logo");
const announcementContainer: HTMLElement | null = document.querySelector(".announcement-container");

hoverEvents();

fetch('./json/dashboard.json')
    .then(response => response.json())
    .then(json => {
        // const new1 = json;
        console.log(json.courses[0].title);
        // console.log(new1.courses[0].units);
        addCourses(json);
        addAlerts(json);
        addAnnouncements(json);
    })
function addCourses(json: DashboardData): void {
    console.log(json);
    let markup = "";
    let i = 0;

    
    for (let course of json.courses) {
        markup += `<div class="courses">

        ${course.isExpired ?
                `<div class="expired">EXPIRED</div>
            <div class="details-courses with-expired">`
                : `<div class="details-courses">`}

        <div class="course-image-info">
        <img class="course-img" src="${course.image}" alt="image${i}">
        <div class="information">
        <div class="title">
        <div>${course.title}</div>
        ${course.isFavourite ? `<img class="favourite-icon" src="./quantum screen assets/icons/favourite.svg" alt="">` : ""}
        </div>
        <div class="sub-title">
        <span class="vertical-line">${course.subject}</span>
        <span class="grade">Grade ${course.grade}</span>
        <span class="green">${course.addGrade}</span>
        </div>
        <div class="sub-title2">
        ${course.units !== null ? `
        <span class="number">${course.units}</span>
        <span class="text">Units</span>` : ''}
        ${course.lessons !== null ? `
        <span class="number">${course.lessons}</span>
        <span class="text">Lessons</span>` : ''}
        ${course.topics !== null ? `
        <span class="number">${course.topics}</span>
        <span class="text">Topics</span>` : ''}
        
        </div>
        <div class="dropdown">
        <select class="dropdown-classes
        ${course.professorClasses.length == 0 ? ` no-classes` : ''}
        " name="classes" id="course${i}">
        ${generateDropdownOptions(course.professorClasses)}
        
        </select>
        </div>
        <div class="line-dropdown"></div>
        <div class="sub-title3">

        ${course.students !== null ? `
        <span>${course.students} Students</span>` : ''}

        ${course.date !== null ? `
        <span class="vertical-line"></span>
        <span class="date">${course.date}</span>` : ''}

        </div>
        </div>
        </div>
        <div class="line-in-course"></div>
        <div class="icons-container">
        <img src="./quantum screen assets/icons/preview.svg" alt="preview icon"
        ${course.isPreview ? "" : `class="icon-blur"`}
        >
        <img src="./quantum screen assets/icons/manage course.svg" alt="manage course icon"
        ${course.isManageCourse ? "" : `class="icon-blur"`}
        >
        <img src="./quantum screen assets/icons/grade submissions.svg" alt="grade submission icon"
        ${course.isGradeSubmission ? "" : `class="icon-blur"`}
        >
        <img src="./quantum screen assets/icons/reports.svg" alt="reports icon"
        ${course.isReports ? "" : `class="icon-blur"`}
        >
        </div>
        </div>
        </div>`;
        i++;
    }
    if (coursesContainer) {
        coursesContainer.innerHTML = markup;
    }
}

function generateDropdownOptions(classes: string[]): string {
    let options = "";
    if (classes.length > 0) {
        for (let professorClass of classes) {
            options += `<option value="${professorClass}">${professorClass}</option>`;
        }
    } else {
        options = '<option class="no-classes" value="">No Classes</option>';
    }
    return options;
}

function hoverEvents(): void {
    if (hamburger && menubar && alertLogo && alertContainer && announcementLogo && announcementContainer) {
        hamburger.addEventListener("mouseover", function () {
            menubar.style.display = "block";
            announcementContainer.style.display = "none";
            alertContainer.style.display = "none";
        });

        menubar.addEventListener("mouseleave", function () {
            menubar.style.display = "none";
        });

        alertLogo.addEventListener("mouseenter", () => {
            alertContainer.style.display = "block";
            menubar.style.display = "none";
            announcementContainer.style.display = "none";
        });

        alertContainer.addEventListener("mouseleave", () => {
            alertContainer.style.display = "none";
        });

        announcementLogo.addEventListener("mouseenter", () => {
            announcementContainer.style.display = "block";
            alertContainer.style.display = "none";
            menubar.style.display = "none";
        });

        announcementContainer.addEventListener("mouseleave", () => {
            announcementContainer.style.display = "none";
        });
    }
}


function addAlerts(json: DashboardData): void {
    console.log(json);
    let markup = "";
    let i = 0;
    for (let alert of json.alerts) {
        markup += `<div class="alerts 
        ${alert.isViewed ? " viewed" : " not-viewed"}
        ">
        <div class="alert-desc-with-icon">
            <div class="alert-description">
                ${alert.description}
            </div>
            ${alert.isViewed ?
                "<img class='viewed-icon' src='./icons/correct.png' alt='viewed icon'>"
                : "<img class='notViewed-icon' src='./icons/dnd.png' alt='Not viewed icon'>"}
        </div>
        ${alert.course !== null ? "<div class='alert-course-container'><span class='alert-course'>Course: </span><span class='alert-course-name'>"
                : ''}
        ${alert.course !== null ? alert.course : ''}
        ${alert.course !== null ? "</span></div>" : ''}
        ${alert.class !== null ? "<div class='alert-class-container'><span class='alert-class'>Class: </span><span class='alert-class-name'>"
                : ''}
        ${alert.class !== null ? alert.class : ''}
        ${alert.class !== null ? "</span></div>" : ''}
        
        <div class="alert-date-time">${alert.datetime}</div>
    </div>`;
    }
    markup += `<button class="alert-show-all-btn">SHOW ALL</button>`;
    if (alertContainer) {
        alertContainer.innerHTML = markup;
    }
}

function addAnnouncements(json: DashboardData): void {
    console.log(json);
    let markup = "";
    let i = 0;
    for (let announcement of json.announcements) {
        markup += `<div class="announcements 
        ${announcement.isViewed ? " viewed" : " not-viewed"}
        ">
        <div class="announcement-desc-with-icon">
        
            <div class="pa-desc-conatainer">
                <div class="pa-container">
                    <span class="pa">PA: </span>
                    <span class="pa-name">${announcement.pa}</span>
                </div>
                <div class="announcement-description">
                    ${announcement.description}
                </div>
            </div>
            ${announcement.isViewed ?
                "<img class='viewed-icon' src='./icons/correct.png' alt='viewed icon'>"
                : "<img class='notViewed-icon' src='./icons/dnd.png' alt='Not viewed icon'>"}
        </div>

        ${announcement.course !== null ? "<div class='announcement-course-container'><span class='announcement-course'>Course: </span><span class='announcement-course-name'>"
                : ''}
        ${announcement.course !== null ? announcement.course : ''}
        ${announcement.course !== null ? "</span></div>" : ''}
        
        <div class="attachment-date-container">
        
            <div class="attachment">${announcement.attachment !== null ? announcement.attachment : ""}</div>
            <div class="announcement-date-time">${announcement.datetime}</div>
        </div>
    </div>`;
    }

    markup += `<div class="announcement-btns">

    <button class="announcement-show-all-btn">SHOW ALL</button>
    <button class="announcement-create-new-btn">CREATE NEW</button>
    </div>`;
    if (announcementContainer) {
        announcementContainer.innerHTML = markup;
    }
}
