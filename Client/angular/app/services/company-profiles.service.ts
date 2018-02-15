import { Injectable } from '@angular/core';
import { ClientApiService } from './clientapi.service'; 
import { ClientApiSettings } from './clientapi.settings'; 
import { CompanyProfiles } from '../entities/aba-entities';
@Injectable()
export class CompanyProfilesService {

  constructor(private api:ClientApiService) {
    api.authorizedHeader();
    api.apiUrl=ClientApiSettings.GETAPIURL("CompanyProfiles")
  }

  getCompanyProfiles(){
    return this.api.getAll();
  }

  getCompanyProfile(companyProfileID:string){
    return this.api.getOne(companyProfileID);
  }

  postCompanyProfiles(companyProfile:CompanyProfiles){
    var body = JSON.stringify(companyProfile);
    return this.api.postData(body);  
  }

  putCompanyProfiles(companyProfile:CompanyProfiles){
    var body = JSON.stringify(companyProfile);
    return this.api.putData(body,companyProfile.CompanyProfileID.toString());  
  }
}
