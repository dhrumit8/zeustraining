export interface PersonalData{
    firstName?: string;
    lastName?: string;
    email?: string;
    phoneCode?: number;
    phoneNumber?: string;
    resume?: string;
    portfolio?: string;
    referral?: string;
    industrialDesigner?: boolean;
    softwareEngineer?: boolean;
    softwareQualityEngineer?: boolean;
    jobRelatedEmail?: boolean;
    password?: string;
}

export interface QualificationData {
    percentage?: number;
    yearOfPassing?: number;
    qualification?: string;
    stream?: string;
    college?: string;
    otherCollege?: string;
    location?: string;
    fresher?: boolean;
    experienced?: boolean;
}

export interface JobRoles {
    id: number,
    title: string | null,
    expires?: number | null,
    startDate: string | null,
    endDate: string | null,
    location: string | null,
    industrialDesigner: boolean,
    softwareEngineer: boolean,
    softwareQualityEngineer: boolean,
    opportunity: string | null,
}