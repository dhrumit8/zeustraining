export interface Course {
    title: string;
    subject: string;
    image: string;
    grade: number;
    addGrade: string;
    units: number | null;
    lessons: number | null;
    topics: number | null;
    professorClasses: string[];
    students: number | null;
    date: string | null;
    isFavourite: boolean;
    isPreview: boolean;
    isManageCourse: boolean;
    isGradeSubmission: boolean;
    isReports: boolean;
    isExpired: boolean;
}

export interface Alert {
    description: string;
    course: string | null;
    class: string | null;
    datetime: string;
    isViewed: boolean;
}

export interface Announcement {
    pa: string;
    description: string;
    attachment: string | null;
    course: string | null;
    datetime: string;
    isViewed: boolean;
}

export interface DashboardData {
    courses: Course[];
    alerts: Alert[];
    announcements: Announcement[];
}

export default DashboardData;