import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    constructor (private http: HttpClient) {

    }

    baseServerUrl = "https://localhost:7035/api/";

    registerUser(user: Array<String>,
        industrialDesigner: boolean,
        softwareEngineer: boolean,
        softwareQualityEngineer: boolean,
        password: string,
        educationalQualification: Array<String>,
        professionalQualification: string,
        fresherQualification: Array<String>,
        javascriptFresher: string,
        angularJSFresher: string,
        reactFresher: string,
        nodeJSFresher: string,
        experiencedQualification: Array<String>,
        javascriptExpFam: string,
        angularJSExpFam: string,
        reactExpFam: string,
        nodeJSExpFam: string,
        javascriptExpExpert: string,
        angularJSExpExpert: string,
        reactExpExpert: string,
        nodeJSExpExpert: string,
    ) {
        if (educationalQualification[4] == 'other') {
            educationalQualification[4] = educationalQualification[5]; //check this
        }
        console.log("hello");
        console.log(educationalQualification);
        return this.http.post(this.baseServerUrl + "User/CreateUser", {
            user: {
                FirstName: user[0],
                LastName: user[1],
                Email: user[2],
                CountryCode: user[3],
                PhoneNumber: user[4],
                Resume: user[5],
                ProfileImage: user[6],
                PortfolioUrl: user[7],
                Referal: user[8],
                JobRelatedEmail: user[9]
            },
            industrialDesigner: industrialDesigner,
            softwareEngineer: softwareEngineer,
            softwareQualityEngineer: softwareQualityEngineer,
            password: password,
            educationalQualification: {
                Percentage: educationalQualification[0],
                YearOfPassing: educationalQualification[1],
                Qualification: educationalQualification[2],
                StreamBranch: educationalQualification[3],
                College: educationalQualification[4],
                CollegeLocation: educationalQualification[6],
            },
            professionalQualification: professionalQualification,
            fresherQualification: {
                AppearedForZeusTest: fresherQualification[0],
                RoleAppliedForZeusTest: fresherQualification[1],
                OtherTechnologiesFamiliar: fresherQualification[2],
            },
            JavascriptFresher: javascriptFresher,
            AngularJSFresher: angularJSFresher,
            ReactFresher: reactFresher,
            NodeJSFresher: nodeJSFresher,
            experiencedQualification: {
                YearsOfExperience: experiencedQualification[0],
                CurrentCtc: experiencedQualification[1],
                ExpectedCtc: experiencedQualification[2],
                OnNoticePeriod: experiencedQualification[3],
                NoticePeriodEnd: experiencedQualification[4],
                NoticePeriodLength: experiencedQualification[5],
                ApperedForZeusTest: experiencedQualification[6],
                RoleApplied: experiencedQualification[7],
                OtherTechnologiesFamiliar: experiencedQualification[8],
                OtherTechnologiesExpertise: experiencedQualification[9],
            },
            JavascriptExpFam: javascriptExpFam,
            AngularJSExpFam: angularJSExpFam,
            ReactExpFam: reactExpFam,
            NodeJSExpFam: nodeJSExpFam,
            JavascriptExpExpert: javascriptExpExpert,
            AngularJSExpExpert: angularJSExpExpert,
            ReactExpExpert: reactExpExpert,
            NodeJSExpExpert: nodeJSExpExpert,
        },
        {responseType: 'text'});
    }
    getJobDetails() {
        return this.http.get(this.baseServerUrl + "User/GetJobDetails",
        {responseType: 'text'});
    }
    getJobRoles() {
        return this.http.get(this.baseServerUrl + "User/GetJobRoles",
        {responseType: 'text'});
    }
}